using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VP_Project
{
    public partial class OwnerEditForm : Form
    {
        Point mouse;
        bool ClickedONPanel;
        Owner owner;
        public string NewName = string.Empty;
        public OwnerEditForm(Owner o)
        {
            InitializeComponent();
            owner = o;
            ClickedONPanel = false;
        }        
        public void SaveFile()
        {
            owner = new Owner(nameBox.Text, mailBox.Text, owner.ID, numBox.Text, addressBox.Text);
            UtilityClass.Serialize<Owner>(owner, owner.ID);
            NewName = nameBox.Text;            
        }

        private void OwnerEditForm_Load(object sender, EventArgs e)
        {
            nameBox.Text = owner.Name;
            mailBox.Text = owner.Email;
            numBox.Text = owner.Number;
            addressBox.Text = owner.Address;
        }

        //BUTTON

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nameBox.Text))
            {
                MessageBox.Show("Немате внесено име на сопственикот!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(numBox.Text) || String.IsNullOrWhiteSpace(mailBox.Text) || String.IsNullOrWhiteSpace(addressBox.Text))
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
            mouse = new Point(-e.X - 28, -e.Y - 2);
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

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            UtilityClass.AllowAlphabetLettersOnly(nameBox);
        }

        private void numBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NewOwnerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(String.IsNullOrWhiteSpace(nameBox.Text)
                && String.IsNullOrWhiteSpace(numBox.Text)
                && String.IsNullOrWhiteSpace(mailBox.Text)
                && String.IsNullOrWhiteSpace(addressBox.Text)))
            {
                if (e.CloseReason == CloseReason.UserClosing && DialogResult != DialogResult.OK)
                    e.Cancel = MessageBox.Show("Имате незачувани податоци. Дали сакате да откажете?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No;
            }
        }       
    }
}
