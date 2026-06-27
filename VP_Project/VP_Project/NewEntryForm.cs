using Microsoft.VisualBasic.Devices;
using Org.BouncyCastle.Ocsp;
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
        }

        private void SaveFile()
        {
            Registration reg = new Registration();
            if (!UtilityClass.DoesRegExist(WriteReg.Text))
            {
                reg = new Registration(WriteReg.Text, Model.Text, OwnerNameBox.Text);
            }
            else
            {
                reg = UtilityClass.GetRegistration(WriteReg.Text);
            }
            reg.AddComment(new InfoText(WriteInfo.Text, DateTime.Now, (int)Kilometers.Value));
            UtilityClass.Serialize(reg);
        }

        private void WriteReg_TextChanged(object sender, EventArgs e)
        {
            AllowAlphabetLettersOnly(WriteReg);            
        }
        private void AllowAlphabetLettersOnly(TextBox TB)
        {
            int caretpos = TB.SelectionStart;
            if (!String.IsNullOrWhiteSpace(TB.Text))
            {
                foreach (char c in TB.Text.ToCharArray())
                {
                    if (!System.Text.RegularExpressions.Regex.IsMatch(c.ToString(), @"^[a-zA-Z0-9 ]+$"))
                    {
                        TB.Text = TB.Text.Replace(c.ToString(), "");
                        TB.SelectionStart = caretpos - 1;
                    }
                }
            }
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
                && String.IsNullOrWhiteSpace(OwnerNameBox.Text)))
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
                OwnerNameBox.Text = reg.Owner;
                Model.Enabled = false;
                OwnerNameBox.Enabled = false;
            }
            else
            {
                Model.Clear();
                OwnerNameBox.Clear();
                Model.Enabled = true;
                OwnerNameBox.Enabled = true;
            }
        }
    }
}
