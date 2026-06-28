using iText;
using iText.Forms.Form.Element;
using iText.IO.Font;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Events;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Pdf.Colorspace;
using iText.Kernel.Pdf.Xobject;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Layout;
using iText.Layout.Properties;
using iText.Layout.Renderer;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VP_Project
{
    public partial class InvoiceForm : Form
    {
        Owner selectedOwner;
        int TotalPrice { get; set; }

        System.Drawing.Point mouse;

        Random IDGenerator;

        bool ClickedONPanel;

        int alpha = 255;

        int R = 0, G = 0, B = 0;

        int TicksElapsed = 0;

        public InvoiceForm()
        {
            InitializeComponent();
            IDGenerator = new Random();
            selectedOwner = new Owner();
            foreach (Owner o in UtilityClass.Owners) ownerSelect.Items.Add(o.Name);
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            FeedbackLabel.ForeColor = System.Drawing.Color.FromArgb(0, R, G, B);
        }

        //BUTTONS

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            DGVadd(IName.Text, (int)ICount.Value, (int)IPrice.Value);
            IName.Clear();
            ICount.Value = 1;
            IPrice.Value = 0;
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in DataGrid.SelectedCells)
            {
                DataGrid.Rows.RemoveAt(cell.RowIndex);
            }
            for (int i = 0; i < DataGrid.RowCount; i++)
            {
                DataGrid.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(selectedOwner.ID == "0" || ownerSelect.SelectedIndex == -1)
            {
                MessageBox.Show("Немате одбрано примач на фактурата!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DataGrid.Rows.Count == 0)
            {
                MessageBox.Show("Немате внесено податоци за фактурата!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CreateInvoice();
                TimerFadeOut.Enabled = true;
                TimerFadeOut.Start();
            }
        }

        //FORM BORDER

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ClickedONPanel = true;
            mouse = new System.Drawing.Point(-e.X + 1, -e.Y + 1);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && ClickedONPanel)
            {
                System.Drawing.Point mp = Control.MousePosition;
                mp.Offset(mouse.X, mouse.Y);
                this.Location = mp;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            ClickedONPanel = false;
        }

        private void PanelText_MouseDown(object sender, MouseEventArgs e)
        {
            ClickedONPanel = true;
            mouse = new System.Drawing.Point(-e.X - 30, -e.Y - 1);
        }

        private void PanelText_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && ClickedONPanel)
            {
                System.Drawing.Point mp = Control.MousePosition;
                mp.Offset(mouse.X, mouse.Y);
                this.Location = mp;
            }
        }

        private void PanelText_MouseUp(object sender, MouseEventArgs e)
        {
            ClickedONPanel = false;
        }

        //OTHERS

        private void CreateInvoice()
        {
            //FILENAME & ID
            string getRandomID = IDGenerator.Next(10000, 100000).ToString();
            string filename = selectedOwner.Name + "_" + getRandomID + ".pdf";
            string newFile = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), filename);

            //FONT & COLORS
            PdfFont normalFont = PdfFontFactory.CreateFont("C:/Windows/Fonts/arial.ttf", "Identity-H");
            iText.Kernel.Colors.Color customcolor = new DeviceRgb(5, 96, 146);

            //TABLE
            Table grid = new Table(new float[] { 35, 380, 50, 75 });
            for (int i = 0; i < 4; i++)
            {
                Cell headercell = new Cell();
                if (i == 3)
                    headercell.Add(new Paragraph(DataGrid.Columns[i].HeaderText + "(МКД)").SetBold());
                else
                    headercell.Add(new Paragraph(DataGrid.Columns[i].HeaderText).SetBold());
                headercell.SetBorderLeft(Border.NO_BORDER);
                headercell.SetBorderRight(Border.NO_BORDER);
                headercell.SetBorderBottom(new SolidBorder(customcolor, 2));
                headercell.SetBorderTop(new SolidBorder(customcolor, 2));
                headercell.SetFont(normalFont);
                grid.AddCell(headercell);
            }
            for (int i = 0; i < DataGrid.RowCount; i++)
            {
                if (i >= 10) break;
                else
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Cell cells = new Cell();
                        if (j == 1)
                        {
                            if (DataGrid.Rows[i].Cells[j].Value.ToString().Length > 56)
                                cells.Add(new Paragraph(DataGrid.Rows[i].Cells[j].Value.ToString()).SetFontSize(8));
                            else
                                cells.Add(new Paragraph(DataGrid.Rows[i].Cells[j].Value.ToString()).SetFontSize(12));
                        }
                        else if (j == 3)
                            cells.Add(new Paragraph(DataGrid.Rows[i].Cells[j].Value.ToString() + ",00").SetFontSize(12));
                        else
                            cells.Add(new Paragraph(DataGrid.Rows[i].Cells[j].Value.ToString()).SetFontSize(12));

                        cells.SetBorder(Border.NO_BORDER);
                        cells.SetFont(normalFont);
                        grid.AddCell(cells);
                    }
                }
            }
            Cell sumtext = new Cell(1, 3);
            sumtext.Add(new Paragraph("Вкупен износ:").SetBold().SetFontColor(customcolor));
            sumtext.SetBorder(Border.NO_BORDER);
            sumtext.SetFont(normalFont);
            sumtext.SetTextAlignment(TextAlignment.RIGHT);
            grid.AddCell(sumtext);
            int CValue, PValue;
            for (int i = 0; i < DataGrid.RowCount; i++)
            {
                CValue = System.Convert.ToInt32(DataGrid.Rows[i].Cells[2].Value);
                PValue = System.Convert.ToInt32(DataGrid.Rows[i].Cells[3].Value);
                TotalPrice += CValue * PValue;
            }
            Cell pricetotal = new Cell();
            pricetotal.Add(new Paragraph(TotalPrice.ToString() + ",00").SetBold().SetFontColor(customcolor));
            pricetotal.SetBorder(Border.NO_BORDER);
            pricetotal.SetFont(normalFont);
            grid.AddCell(pricetotal);

            //LOGO
            ImageData data = ImageDataFactory.Create(@"icons/icon2.png");
            iText.Layout.Element.Image logo = new iText.Layout.Element.Image(data);

            //LINE
            ImageData data2 = ImageDataFactory.Create(@"icons/decor.png");
            iText.Layout.Element.Image decor = new iText.Layout.Element.Image(data2);

            //TITLE
            Paragraph Title = new Paragraph();
            Title.SetFont(normalFont);
            Title.Add(new Text("Авто Сервис АутоМК").SetBold().SetFont(normalFont).SetFontColor(customcolor).SetFontSize(28));
            Title.Add(new Text(Environment.NewLine + "Ул. 1234 Бр. 56, Општина Гази Баба").SetFont(normalFont).SetFontSize(12));
            Title.Add(new Text(Environment.NewLine + "Тел. +389 2 12 34 567").SetFont(normalFont).SetFontSize(12));
            Title.SetFixedLeading(23);

            //CUSTOMER
            Paragraph CInfo = new Paragraph();
            CInfo.SetFont(normalFont);
            CInfo.Add(new Text("ФАКТУРА ДО:" + Environment.NewLine).SetBold().SetFont(normalFont).SetFontSize(18));
            CInfo.Add(new Text(Environment.NewLine + selectedOwner.Name + " (" + selectedOwner.ID + ")").SetBold().SetFont(normalFont).SetFontSize(12));
            CInfo.Add(new Text(
                Environment.NewLine + "Контакт број: " + selectedOwner.Number
                + Environment.NewLine + "Е-Пошта: " + selectedOwner.Email
                + Environment.NewLine + selectedOwner.Address).SetFont(normalFont).SetFontSize(12));
            CInfo.SetFixedLeading(15);

            //INVOICE
            Paragraph IInfo = new Paragraph();
            IInfo.SetFont(normalFont);
            IInfo.Add(new Text(
                Environment.NewLine + "Број на сметка:   " + getRandomID
                + Environment.NewLine + "Датум на издавање: " + DateTime.Now.ToString("dd/MM/yyyy")
                + Environment.NewLine + "Рок на исплата: " + DateTime.Now.AddDays((double)DaysNum.Value).ToString("dd/MM/yyyy")).SetFont(normalFont).SetFontSize(12));
            IInfo.SetFixedLeading(15);
            IInfo.SetTextAlignment(TextAlignment.RIGHT);

            //SIGNATURES
            Table sig = new Table(new float[] { 170, 190, 170 });
            sig.AddCell(new Cell().Add(new Paragraph("Изготвил").SetFont(normalFont)).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER));
            sig.AddCell(new Cell().Add(new Paragraph("Овластено лице").SetFont(normalFont)).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER));
            sig.AddCell(new Cell().Add(new Paragraph("Примил").SetFont(normalFont)).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER));
            for (int i = 0; i < 3; i++)
            {
                sig.AddCell(new Cell().Add(new Paragraph("__________________").SetFont(normalFont)).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER));
            }
            for (int i = 0; i < 3; i++)
            {
                sig.AddCell(new Cell().Add(new Paragraph("Потпис").SetFont(normalFont)).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(9));
            }
            sig.AddCell(new Cell(1, 3).Add(new Paragraph(Environment.NewLine + Environment.NewLine + Environment.NewLine
                + "За ненавремено плаќање пресметуваме затезна камата и еднократен надомест согласност Законот за финансиска дисциплина")
                .SetFont(normalFont))
                .SetBorder(Border.NO_BORDER)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(9));

            //CREATE PDF
            PdfWriter writer = new PdfWriter(newFile);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            decor.ScaleAbsolute(550, 15);
            decor.SetFixedPosition(20, 655);
            document.Add(decor);

            grid.SetFixedPosition(30, 470 - (22 * DataGrid.RowCount), 180);
            grid.SetFixedLayout();
            document.Add(grid);

            sig.SetFixedPosition(30, 60, 210);
            sig.SetFixedLayout();
            document.Add(sig);

            Title.SetFixedPosition(170, 680, 300);
            document.Add(Title);

            CInfo.SetFixedPosition(30, 540, 400);
            document.Add(CInfo);

            IInfo.SetFixedPosition(370, 540, 200);
            document.Add(IInfo);

            logo.ScaleAbsolute(128, 128);
            logo.SetFixedPosition(30, 670);
            document.Add(logo);

            document.Close();

            //CHECK FOR FILE
            if (File.Exists(newFile))
            {
                R = 5;
                G = 135;
                B = 0;
                alpha = 255;
                FeedbackLabel.Text = "Фактурата е успешно креирана";
            }
            else
            {
                R = 161;
                G = 24;
                B = 14;
                alpha = 255;
                FeedbackLabel.Text = "Грешка при креирање фактура";
            }
            TicksElapsed = 0;
            FeedbackLabel.ForeColor = System.Drawing.Color.FromArgb(alpha, R, G, B);
            TotalPrice = 0;
        }

        private void DGVadd(string item, int count, int price)
        {
            bool newRow = true;
            int CValue;
            foreach (DataGridViewRow row in DataGrid.Rows)
            {
                if (row.Cells[1].Value.Equals(item))
                {
                    CValue = System.Convert.ToInt32(row.Cells[2].Value);
                    row.Cells[2].Value = CValue + ICount.Value;
                    row.Cells[3].Value = IPrice.Value;
                    newRow = false;
                }
            }
            if (newRow == true)
            {
                if (String.IsNullOrWhiteSpace(IName.Text))
                    return;
                else
                {
                    var index = this.DataGrid.Rows.Add();
                    DataGrid.Rows[index].Cells[0].Value = index + 1;
                    DataGrid.Rows[index].Cells[1].Value = item;
                    DataGrid.Rows[index].Cells[2].Value = count;
                    DataGrid.Rows[index].Cells[3].Value = price;
                }
            }
            DataGrid.Update();
        }

        private void IName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrWhiteSpace(IName.Text))
                {
                    DGVadd(IName.Text, (int)ICount.Value, (int)IPrice.Value);
                    IName.Clear();
                    ICount.Value = 1;
                    IPrice.Value = 0;
                }
            }
        }

        private async void TimerFadeOut_Tick(object sender, EventArgs e)
        {
            TicksElapsed++;
            if (TicksElapsed > 20)
            {
                alpha -= 5;
                FeedbackLabel.ForeColor = System.Drawing.Color.FromArgb(alpha, R, G, B);
                if (alpha < 10)
                {
                    FeedbackLabel.ForeColor = System.Drawing.Color.FromArgb(0, R, G, B);
                    TimerFadeOut.Stop();
                    TicksElapsed = 0;
                    alpha = 255;
                }
                else return;
            }
            else return;
        }

        private void ownerSelect_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State ^ DrawItemState.Selected, e.ForeColor, System.Drawing.Color.FromArgb(255, 79, 88, 117));
            e.DrawBackground();
            e.Graphics.DrawString(ownerSelect.Items[e.Index].ToString(), e.Font, Brushes.White, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void ownerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ownerSelect.SelectedIndex != -1)
            {
                selectedOwner = UtilityClass.GetOwner(ownerSelect.Text);
            }
        }
    }
}
