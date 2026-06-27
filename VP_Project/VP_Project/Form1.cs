using Org.BouncyCastle.Ocsp;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VP_Project
{
    public partial class Form1 : Form
    {
        Point mouse;
        bool ClickedONPanel;
        bool ButtonsToggle;
        public enum Mode { RegMode, OwnerMode }
        public static Mode mod;
        public Form1()
        {
            InitializeComponent();
            ClickedONPanel = false;
            displayMode.Items.Add("Регистрација");
            displayMode.Items.Add("Сопственик");
            displayMode.SelectedIndex = 0;
            mod = Mode.RegMode;
        }

        public void TextReader()
        {
            if(mod == Mode.RegMode)
            {
                Registration reg = UtilityClass.GetRegistration(RegList.Text);
                InfoBox.Text = reg.ToString();
                RegNameBox.Text = reg.Name;
            }
            else if(mod == Mode.OwnerMode)
            {
                Owner o = UtilityClass.GetOwner(RegList.Text);
                InfoBox.Text = o.ToString();
                RegNameBox.Text = o.Name;
            }
            InfoBox.ScrollToCaret();
        }

        public void Refresher()
        {
            PopulateListBox();
            if (!String.IsNullOrWhiteSpace(RegNameBox.Text))
            {
                InfoBox.Clear();
                if (mod == Mode.RegMode)
                {
                    Registration reg = UtilityClass.GetRegistration(RegNameBox.Text);
                    if(reg != null) InfoBox.Text = reg.ToString();
                }
                else if (mod == Mode.OwnerMode)
                {
                    Owner o = UtilityClass.GetOwner(RegNameBox.Text);
                    if(o != null) InfoBox.Text = o.ToString();
                }
                InfoBox.ScrollToCaret();
            }
        }

        private void PopulateListBox()
        {
            RegList.Items.Clear();            
            if(mod == Mode.RegMode)
            {
                UtilityClass.Regs.Clear();
                DirectoryInfo dinfo = new DirectoryInfo(UtilityClass.BaseFolderRegs);
                FileInfo[] Files = dinfo.GetFiles("*.json");
                foreach (FileInfo file in Files)
                {
                    Registration reg = UtilityClass.Deserialize<Registration>(UtilityClass.BaseFolderRegs + file.Name);
                    UtilityClass.Regs.Add(reg);
                    RegList.Items.Add(reg.Name);
                }
            }
            else if(mod == Mode.OwnerMode)
            {
                UtilityClass.Owners.Clear();
                DirectoryInfo dinfo = new DirectoryInfo(UtilityClass.BaseFolderOwners);
                FileInfo[] Files = dinfo.GetFiles("*.json");
                foreach (FileInfo file in Files)
                {
                    Owner o = UtilityClass.Deserialize<Owner>(UtilityClass.BaseFolderOwners + file.Name);
                    UtilityClass.Owners.Add(o);
                    RegList.Items.Add(o.Name);
                }
            }
        }
        /*private void PopulateOwnerDict()
        {
            foreach (Registration reg in UtilityClass.Regs)
            {
                if (!String.IsNullOrEmpty(reg.Owner))
                {
                    if (UtilityClass.ownerRegs.ContainsKey(reg.Owner))
                    {
                        UtilityClass.ownerRegs.TryGetValue(reg.Owner, out List<Registration> value);
                        value.Add(reg);
                        UtilityClass.ownerRegs[reg.Owner] = value;
                    }
                    else
                    {
                        UtilityClass.ownerRegs[reg.Owner] = new List<Registration> { reg };
                    }
                }
            }
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo dinfo = new DirectoryInfo(UtilityClass.BaseFolderOwners);
            FileInfo[] Files = dinfo.GetFiles("*.json");
            foreach (FileInfo file in Files)
            {
                Owner o = UtilityClass.Deserialize<Owner>(UtilityClass.BaseFolderOwners + file.Name);
                UtilityClass.Owners.Add(o);
            }
            PopulateListBox();
            ButtonsDisable();
            //PopulateOwnerDict();
        }

        private void DeleteFile()
        {
            if(mod == Mode.RegMode)
            {
                DialogResult dr = MessageBox.Show("Дали сакате да ја избришете регистрацијата " + RegNameBox.Text + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    File.Delete(UtilityClass.BaseFolderRegs + RegNameBox.Text + ".json");
                    PopulateListBox();
                    ButtonsDisable();
                    RegNameBox.ResetText();
                    InfoBox.Clear();
                }
            }
            else if(mod == Mode.OwnerMode)
            {
                DialogResult dr = MessageBox.Show("Дали сакате да го избришете сопственикот " + RegNameBox.Text + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Owner o = UtilityClass.GetOwner(RegNameBox.Text);
                    File.Delete(UtilityClass.BaseFolderOwners + o.ID + ".json");
                    foreach(Registration reg in o.GetRegList())
                    {
                        reg.Owner = new Owner();
                        UtilityClass.Serialize<Registration>(reg, reg.Name);
                    }
                    PopulateListBox();
                    ButtonsDisable();
                    RegNameBox.ResetText();
                    InfoBox.Clear();
                }
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
            if(mod == Mode.RegMode)
            {
                NewEntryForm entryform = new NewEntryForm();
                entryform.ShowDialog();
            }
            else if(mod == Mode.OwnerMode)
            {
                NewOwnerForm ownerform = new NewOwnerForm();
                ownerform.ShowDialog();
            }
            
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
                if(mod == Mode.RegMode)
                {
                    FileEditorForm editform = new FileEditorForm(UtilityClass.GetRegistration(RegNameBox.Text));
                    editform.ShowDialog();
                }
                else if(mod == Mode.OwnerMode)
                {
                    OwnerEditForm ownerEditForm = new OwnerEditForm(UtilityClass.GetOwner(RegNameBox.Text));
                    ownerEditForm.ShowDialog();
                    if (ownerEditForm.DialogResult == DialogResult.OK)
                    {
                        RegNameBox.Text = ownerEditForm.NewName;
                        Refresher();
                    }
                }
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
            if (RegList.SelectedIndex != -1)
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

        private void displayMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (displayMode.SelectedIndex == 0) mod = Mode.RegMode;
            else if (displayMode.SelectedIndex == 1) mod = Mode.OwnerMode;
            InfoBox.Clear();
            RegNameBox.ResetText();
            ButtonsDisable();
            ChangeButtonsText();
            PopulateListBox();
        }

        private void ChangeButtonsText()
        {
            if(mod == Mode.RegMode)
            {
                btnAddNew.Text = "Нова Регистрација";
                btnDelete.Text = "Избриши Регистрација";
            }
            else if(mod == Mode.OwnerMode) 
            {
                btnAddNew.Text = "Нов Сопственик";
                btnDelete.Text = "Избриши Сопственик";
            }
        }

        private void displayMode_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State ^ DrawItemState.Selected, e.ForeColor, Color.FromArgb(255, 79, 88, 117));
            e.DrawBackground();
            e.Graphics.DrawString(displayMode.Items[e.Index].ToString(), e.Font, Brushes.White, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }
    }
}