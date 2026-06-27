using Org.BouncyCastle.Ocsp;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace VP_Project
{
    public partial class Form1 : Form
    {
        Point mouse;
        bool ClickedONPanel;

        public Form1()
        {
            InitializeComponent();
            ClickedONPanel = false;
        }

        private bool ButtonsToggle { get; set; }

        public void TextReader()
        {
            Registration reg = UtilityClass.Deserialize(UtilityClass.BaseFolder + RegList.Text + ".json");
            InfoBox.Text = reg.ToString();
            RegNameBox.Text = reg.Name;
            InfoBox.ScrollToCaret();
        }

        public void Refresher()
        {
            PopulateListBox();
            if (!String.IsNullOrWhiteSpace(RegNameBox.Text))
            {
                InfoBox.Clear();
                Registration reg = UtilityClass.GetRegistration(RegNameBox.Text);
                InfoBox.Text = reg.ToString();
                InfoBox.ScrollToCaret();
            }            
        }

        private void PopulateListBox()
        {
            RegList.Items.Clear();
            UtilityClass.Regs.Clear();
            DirectoryInfo dinfo = new DirectoryInfo(UtilityClass.BaseFolder);
            FileInfo[] Files = dinfo.GetFiles("*.json");
            foreach (FileInfo file in Files)
            {
                RegList.Items.Add(file.Name.Replace(".json", ""));
                Registration reg = UtilityClass.Deserialize(UtilityClass.BaseFolder + file.Name);
                UtilityClass.Regs.Add(reg);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {          
            PopulateListBox();
            ButtonsDisable();            
        }

        private void DeleteFile()
        {
            DialogResult dr = MessageBox.Show("Дали сакате да ја избришете регистрацијата " + RegNameBox.Text + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                File.Delete(UtilityClass.BaseFolder + RegNameBox.Text + ".json");
                PopulateListBox();
                ButtonsDisable();
                RegNameBox.ResetText();
                InfoBox.Clear();
            }
        }

//BUTTONS

        public void ButtonsEnable()
        {
            ButtonsToggle = true;
            btnDelete.ForeColor = System.Drawing.Color.Red;
            btnEditFile.ForeColor = System.Drawing.Color.White;
            btnFullScreen.ForeColor = System.Drawing.Color.White;
            btnFullScreen.Image = System.Drawing.Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "icons/fullscreen_enabled.png");
            btnEditFile.Image = System.Drawing.Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "icons/edit_enabled.png");
            btnDelete.Image = System.Drawing.Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "icons/delete_enabled.png");
            btnFullScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 42, 48, 64);
            btnFullScreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(255, 115, 126, 154);
            btnEditFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 42, 48, 64);
            btnEditFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(255, 115, 126, 154);
            btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 42, 48, 64);
            btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(255, 115, 126, 154);
        }

        public void ButtonsDisable()
        {
            ButtonsToggle = false;
            btnDelete.ForeColor = System.Drawing.Color.Gray;
            btnEditFile.ForeColor = System.Drawing.Color.Gray;
            btnFullScreen.ForeColor = System.Drawing.Color.Gray;
            btnFullScreen.Image = System.Drawing.Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "icons/fullscreen_disabled.png");
            btnEditFile.Image = System.Drawing.Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "icons/edit_disabled.png");
            btnDelete.Image = System.Drawing.Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "icons/delete_disabled.png");
            btnFullScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnFullScreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnEditFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnEditFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            NewEntryForm entryform = new NewEntryForm();
            entryform.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresher();
            SearchList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ButtonsToggle == false) return;
            else DeleteFile();
        }

        private void btnEditFile_Click(object sender, EventArgs e)
        {
            if (ButtonsToggle == false) return;
            else
            {
                FileEditorForm editform = new FileEditorForm(UtilityClass.GetRegistration(RegNameBox.Text));
                editform.ShowDialog();                        
            }
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if (ButtonsToggle == false) return;
            else
            {
                FullScreenText fsform = new FullScreenText(UtilityClass.GetRegistration(RegNameBox.Text));
                fsform.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            InvoiceForm invform = new InvoiceForm();
            invform.ShowDialog();
        }

//FORM BORDER

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ClickedONPanel = true;
            mouse = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && ClickedONPanel)
            {
                Point mp = Control.MousePosition;
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
            mouse = new Point(-e.X - 41, -e.Y - 7);
        }

        private void PanelText_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && ClickedONPanel)
            {
                Point mp = Control.MousePosition;
                mp.Offset(mouse.X, mouse.Y);
                this.Location = mp;
            }
        }

        private void PanelText_MouseUp(object sender, MouseEventArgs e)
        {
            ClickedONPanel = false;
        }

//OTHER
        public void SearchList()
        {            
            PopulateListBox();
            var itemList = RegList.Items.Cast<string>().ToList();
            if (itemList.Count > 0)
            {
                RegList.Items.Clear();
                RegList.Items.AddRange(itemList.Where(i => i.Contains(UtilityClass.FormatRegName(SearchBox.Text))).ToArray());                       
            }
        }

        private void RegList_DoubleClick(object sender, EventArgs e)
        {
            if(RegList.SelectedIndex != -1) 
            {
                TextReader();
                ButtonsEnable();
            }
        }

        private void RegList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (RegList.Text.Length > 0)
                {
                    TextReader();
                    ButtonsEnable();
                }
            }
            if (e.KeyCode == Keys.Delete)
            {
                if (btnDelete.Enabled == true && RegNameBox.Text.Length > 0)
                {
                    DeleteFile();
                }
                else return;
            }
            /*if(e.KeyCode == Keys.M)
            {
                if(!String.IsNullOrEmpty(RegNameBox.Text))
                {
                    MessageBox.Show(UtilityClass.GetRegistration(RegNameBox.Text).ToString());
                }
            }*/
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Refresher();
            SearchList();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchList();
        }

        private void RegList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State ^ DrawItemState.Selected, e.ForeColor, Color.FromArgb(255, 79, 88, 117));
            e.DrawBackground();
            e.Graphics.DrawString(RegList.Items[e.Index].ToString(), e.Font, Brushes.White, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }
    }
}