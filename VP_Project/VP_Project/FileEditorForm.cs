

using Microsoft.VisualBasic.Devices;

namespace VP_Project
{
    public partial class FileEditorForm : Form
    {
        bool ClickedONPanel;

        Registration reg;

        bool IsFileEdited;

        string StartingKMValue = "0";

        int i = 0;

        Point mouse;
        public FileEditorForm(Registration reg)
        {
            InitializeComponent();
            this.reg = new Registration(reg);
            ClickedONPanel = false;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(IsFileEdited)
            {
                UtilityClass.Serialize<Registration>(reg, reg.Name);
                UtilityClass.Regs[UtilityClass.Regs.IndexOf(UtilityClass.GetRegistration(reg.Name))] = reg;
            }            
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FileEditorForm_Load(object sender, EventArgs e)
        {
            IsFileEdited = false;
            RegName.Text = reg.Name;
            ownerNameEdit.Text = reg.Owner.Name;
            modelEdit.Text = reg.CarModel;
            kilometersEdit.Value = reg.Info[0].Kilometers;
            TextEditBox.Text = reg.Info[0].Text;
            StartingKMValue = kilometersEdit.Value.ToString();
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (i < reg.Info.Count - 1)
            {
                i++;
                kilometersEdit.Value = reg.Info[i].Kilometers;
                TextEditBox.Text = reg.Info[i].Text;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                kilometersEdit.Value = reg.Info[i].Kilometers;
                TextEditBox.Text = reg.Info[i].Text;
            }
        }

        //BUTTONS

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


        //FORM BORDER

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ClickedONPanel = true;
            mouse = new Point(-e.X + 8, -e.Y);
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
            mouse = new Point(-e.X - 24, -e.Y - 2);
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

        private void FileEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsFileEdited)
            {
                if (e.CloseReason == CloseReason.UserClosing && DialogResult != DialogResult.OK)
                    e.Cancel = MessageBox.Show("Имате незачувани податоци. Дали сакате да откажете?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No;
            }
        }

        //TEXTCHANGED & FILE EDIT EVENTS
        private void kilometersEdit_Validated(object sender, EventArgs e)
        {
            if (kilometersEdit.Text == "")
            {
                kilometersEdit.Text = "0";
                kilometersEdit.Value = 0;
            }
            if (kilometersEdit.Value != reg.Info[i].Kilometers)
            {
                reg.Info[i] = new InfoText(reg.Info[i].Text, reg.Info[i].Datetime, (int)kilometersEdit.Value);
                IsFileEdited = true;
            }
        }

        private void TextEditBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (TextEditBox.Text != reg.Info[i].Text)
            {
                reg.Info[i] = new InfoText(TextEditBox.Text, reg.Info[i].Datetime, reg.Info[i].Kilometers);
                IsFileEdited = true;
            }
        }

        private void modelEdit_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (modelEdit.Text != reg.CarModel)
            {
                IsFileEdited = true;
            }
        }

        private void ownerNameEdit_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ownerNameEdit.Text != reg.Owner.Name)
            {
                IsFileEdited = true;
            }
        }
    }
}
