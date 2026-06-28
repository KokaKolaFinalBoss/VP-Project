namespace VP_Project
{
    partial class FileEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileEditorForm));
            btnCancel = new Button();
            btnConfirm = new Button();
            TextEditBox = new TextBox();
            RegName = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnClose = new Button();
            panel1 = new Panel();
            PanelText = new Label();
            pictureBox1 = new PictureBox();
            modelEdit = new TextBox();
            btnPrevious = new Button();
            btnNext = new Button();
            Owner = new Label();
            Model = new Label();
            Kilometers = new Label();
            kilometersEdit = new NumericUpDown();
            ownerSelect = new FlatComboExample.Net.FlatComboBox();
            panel4 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kilometersEdit).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancel.Location = new Point(135, 293);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 31);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Откажи";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnClose_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnConfirm.Location = new Point(297, 293);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(116, 31);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Зачувај";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // TextEditBox
            // 
            TextEditBox.BackColor = Color.FromArgb(59, 66, 87);
            TextEditBox.BorderStyle = BorderStyle.None;
            TextEditBox.ForeColor = Color.White;
            TextEditBox.Location = new Point(268, 61);
            TextEditBox.Multiline = true;
            TextEditBox.Name = "TextEditBox";
            TextEditBox.ScrollBars = ScrollBars.Vertical;
            TextEditBox.Size = new Size(267, 223);
            TextEditBox.TabIndex = 2;
            TextEditBox.Validating += TextEditBox_Validating;
            // 
            // RegName
            // 
            RegName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            RegName.Location = new Point(125, 30);
            RegName.Name = "RegName";
            RegName.Size = new Size(283, 20);
            RegName.TabIndex = 3;
            RegName.Text = "label1";
            RegName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(414, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 21);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 30, 41);
            panel2.Controls.Add(btnClose);
            panel2.Location = new Point(435, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(112, 40);
            panel2.TabIndex = 15;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 59, 59);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(71, -1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(41, 41);
            btnClose.TabIndex = 13;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 30, 41);
            panel1.Controls.Add(PanelText);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-7, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 19);
            panel1.TabIndex = 17;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // PanelText
            // 
            PanelText.AutoSize = true;
            PanelText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PanelText.Location = new Point(30, 2);
            PanelText.Name = "PanelText";
            PanelText.Size = new Size(113, 15);
            PanelText.TabIndex = 28;
            PanelText.Text = "Измени Податоци";
            PanelText.MouseDown += PanelText_MouseDown;
            PanelText.MouseMove += PanelText_MouseMove;
            PanelText.MouseUp += PanelText_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // modelEdit
            // 
            modelEdit.BackColor = Color.FromArgb(59, 66, 87);
            modelEdit.BorderStyle = BorderStyle.None;
            modelEdit.ForeColor = Color.White;
            modelEdit.Location = new Point(23, 141);
            modelEdit.Name = "modelEdit";
            modelEdit.Size = new Size(218, 16);
            modelEdit.TabIndex = 18;
            modelEdit.Validating += modelEdit_Validating;
            // 
            // btnPrevious
            // 
            btnPrevious.BackgroundImage = (Image)resources.GetObject("btnPrevious.BackgroundImage");
            btnPrevious.BackgroundImageLayout = ImageLayout.Center;
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.ForeColor = Color.Black;
            btnPrevious.Location = new Point(76, 234);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(35, 35);
            btnPrevious.TabIndex = 21;
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.BackgroundImage = (Image)resources.GetObject("btnNext.BackgroundImage");
            btnNext.BackgroundImageLayout = ImageLayout.Center;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.ForeColor = Color.Black;
            btnNext.Location = new Point(145, 234);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(35, 35);
            btnNext.TabIndex = 22;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // Owner
            // 
            Owner.AutoSize = true;
            Owner.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Owner.Location = new Point(23, 69);
            Owner.Name = "Owner";
            Owner.Size = new Size(78, 15);
            Owner.TabIndex = 23;
            Owner.Text = "Сопственик:";
            // 
            // Model
            // 
            Model.AutoSize = true;
            Model.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Model.Location = new Point(23, 123);
            Model.Name = "Model";
            Model.Size = new Size(131, 15);
            Model.TabIndex = 24;
            Model.Text = "Модел на автомобил:";
            // 
            // Kilometers
            // 
            Kilometers.AutoSize = true;
            Kilometers.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Kilometers.Location = new Point(11, 110);
            Kilometers.Name = "Kilometers";
            Kilometers.Size = new Size(136, 15);
            Kilometers.TabIndex = 25;
            Kilometers.Text = "Изминати километри:";
            // 
            // kilometersEdit
            // 
            kilometersEdit.BackColor = Color.FromArgb(59, 66, 87);
            kilometersEdit.BorderStyle = BorderStyle.None;
            kilometersEdit.ForeColor = Color.White;
            kilometersEdit.Location = new Point(11, 128);
            kilometersEdit.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            kilometersEdit.Name = "kilometersEdit";
            kilometersEdit.Size = new Size(218, 19);
            kilometersEdit.TabIndex = 36;
            kilometersEdit.Validated += kilometersEdit_Validated;
            // 
            // ownerSelect
            // 
            ownerSelect.BackColor = Color.FromArgb(59, 66, 87);
            ownerSelect.BorderColor = Color.FromArgb(59, 66, 87);
            ownerSelect.ButtonColor = Color.Silver;
            ownerSelect.DrawMode = DrawMode.OwnerDrawFixed;
            ownerSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            ownerSelect.ForeColor = Color.White;
            ownerSelect.Location = new Point(23, 87);
            ownerSelect.Name = "ownerSelect";
            ownerSelect.Size = new Size(218, 24);
            ownerSelect.TabIndex = 39;
            ownerSelect.DrawItem += ownerSelect_DrawItem;
            ownerSelect.SelectedIndexChanged += ownerSelect_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 40, 54);
            panel4.Controls.Add(Kilometers);
            panel4.Controls.Add(kilometersEdit);
            panel4.Location = new Point(12, 62);
            panel4.Name = "panel4";
            panel4.Size = new Size(239, 163);
            panel4.TabIndex = 54;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(59, 66, 87);
            panel3.Location = new Point(11, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(241, 165);
            panel3.TabIndex = 53;
            // 
            // FileEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 40, 54);
            ClientSize = new Size(547, 333);
            Controls.Add(ownerSelect);
            Controls.Add(Model);
            Controls.Add(Owner);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(modelEdit);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(RegName);
            Controls.Add(TextEditBox);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Controls.Add(panel4);
            Controls.Add(panel3);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FileEditorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Измени Податоци";
            FormClosing += FileEditorForm_FormClosing;
            Load += FileEditorForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kilometersEdit).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button btnConfirm;
        private TextBox TextEditBox;
        private Label RegName;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Button btnClose;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox modelEdit;
        private Button btnPrevious;
        private Button btnNext;
        private Label Owner;
        private Label Model;
        private Label Kilometers;
        private Label PanelText;
        private NumericUpDown kilometersEdit;
        private FlatComboExample.Net.FlatComboBox ownerSelect;
        private Panel panel4;
        private Panel panel3;
    }
}