using Microsoft.VisualBasic.Devices;
using Org.BouncyCastle.Ocsp;
using System.ComponentModel.Design;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace VP_Project
{
    public partial class NewEntryForm : Form
    {
        Point mouse;
        bool ClickedONPanel;
        public NewEntryForm()
        {
            InitializeComponent();
            ClickedONPanel = false;
            foreach (Owner o in UtilityClass.Owners) ownerSelect.Items.Add(o.Name);
        }

        private void SaveFile()
        {
            Registration reg = new Registration();
            if (!UtilityClass.DoesRegExist(WriteReg.Text))
            {
                if (ownerSelect.SelectedIndex != -1)
                {
                    Owner o = UtilityClass.GetOwner(ownerSelect.Text);
                    reg = new Registration(WriteReg.Text, Model.Text, o);
                }
                else reg = new Registration(WriteReg.Text, Model.Text, new Owner());
            }
            else
            {
                reg = UtilityClass.GetRegistration(WriteReg.Text);
            }
            reg.AddComment(new InfoText(WriteInfo.Text, DateTime.Now, (int)Kilometers.Value));
            UtilityClass.Serialize<Registration>(reg, reg.Name);
        }

        private void WriteReg_TextChanged(object sender, EventArgs e)
        {
            UtilityClass.AllowAlphabetLettersOnly(WriteReg);
        }


        //BUTTONS

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(WriteReg.Text))
            {
                MessageBox.Show("Регистрацијата не е внесена", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(WriteInfo.Text) || Kilometers.Value == 0 || (Model.Enabled == true && String.IsNullOrWhiteSpace(Model.Text)))
            {
                DialogResult dr = MessageBox.Show("Немате внесено податоци. Дали сакате да продолжите?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    SaveFile();
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                SaveFile();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //FORM BORDER

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ClickedONPanel = true;
            mouse = new Point(-e.X + 10, -e.Y);
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
            mouse = new Point(-e.X - 26, -e.Y - 2);
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

        private void NewEntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(String.IsNullOrWhiteSpace(WriteInfo.Text)
                && Kilometers.Value == 0
                && String.IsNullOrWhiteSpace(WriteReg.Text)
                && String.IsNullOrWhiteSpace(Model.Text)
                && ownerSelect.SelectedIndex == -1))
            {
                if (e.CloseReason == CloseReason.UserClosing && DialogResult != DialogResult.OK)
                    e.Cancel = MessageBox.Show("Имате незачувани податоци. Дали сакате да откажете?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No;
            }
        }

        private void Kilometers_Validated(object sender, EventArgs e)
        {
            if (Kilometers.Text == "")
            {
                Kilometers.Text = "0";
                Kilometers.Value = 0;
            }
            else return;
        }

        private void WriteReg_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            WriteReg.Text = UtilityClass.FormatRegName(WriteReg.Text);
            if (UtilityClass.DoesRegExist(WriteReg.Text))
            {
                Registration reg = UtilityClass.GetRegistration(WriteReg.Text);
                Model.Text = reg.CarModel;
                ownerSelect.Text = reg.Owner.Name;
                Model.Enabled = false;
                ownerSelect.Enabled = false;
            }
            else
            {
                Model.Clear();
                ownerSelect.SelectedIndex = -1;
                Model.Enabled = true;
                ownerSelect.Enabled = true;
            }
        }

        private void ownerSelect_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State ^ DrawItemState.Selected, e.ForeColor, Color.FromArgb(255, 79, 88, 117));
            e.DrawBackground();
            e.Graphics.DrawString(ownerSelect.Items[e.Index].ToString(), e.Font, Brushes.White, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }
    }
}
