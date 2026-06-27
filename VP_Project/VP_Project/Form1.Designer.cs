namespace VP_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            RegList = new ListBox();
            InfoBox = new TextBox();
            btnAddNew = new Button();
            SearchBox = new TextBox();
            btnRefresh = new Button();
            label1 = new Label();
            btnEditFile = new Button();
            btnDelete = new Button();
            PanelText = new Label();
            pictureBox1 = new PictureBox();
            btnFullScreen = new Button();
            panel1 = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            RegNameBox = new Label();
            btnInvoice = new Button();
            embglabel = new Label();
            displayMode = new FlatComboExample.Net.FlatComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // RegList
            // 
            RegList.BackColor = Color.FromArgb(59, 66, 87);
            RegList.BorderStyle = BorderStyle.None;
            RegList.DrawMode = DrawMode.OwnerDrawFixed;
            RegList.ForeColor = Color.White;
            RegList.FormattingEnabled = true;
            RegList.ItemHeight = 15;
            RegList.Location = new Point(12, 134);
            RegList.Name = "RegList";
            RegList.Size = new Size(163, 300);
            RegList.TabIndex = 0;
            RegList.DrawItem += RegList_DrawItem;
            RegList.DoubleClick += RegList_DoubleClick;
            RegList.KeyDown += RegList_KeyDown;
            // 
            // InfoBox
            // 
            InfoBox.BackColor = Color.FromArgb(59, 66, 87);
            InfoBox.BorderStyle = BorderStyle.None;
            InfoBox.ForeColor = Color.White;
            InfoBox.Location = new Point(201, 108);
            InfoBox.Multiline = true;
            InfoBox.Name = "InfoBox";
            InfoBox.ReadOnly = true;
            InfoBox.ScrollBars = ScrollBars.Vertical;
            InfoBox.Size = new Size(587, 268);
            InfoBox.TabIndex = 1;
            // 
            // btnAddNew
            // 
            btnAddNew.FlatAppearance.BorderSize = 0;
            btnAddNew.FlatStyle = FlatStyle.Flat;
            btnAddNew.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAddNew.ForeColor = Color.White;
            btnAddNew.Image = (Image)resources.GetObject("btnAddNew.Image");
            btnAddNew.ImageAlign = ContentAlignment.MiddleRight;
            btnAddNew.Location = new Point(507, 414);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(281, 33);
            btnAddNew.TabIndex = 2;
            btnAddNew.Text = "Нова Регистрација";
            btnAddNew.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // SearchBox
            // 
            SearchBox.BackColor = Color.FromArgb(59, 66, 87);
            SearchBox.BorderStyle = BorderStyle.None;
            SearchBox.ForeColor = Color.White;
            SearchBox.Location = new Point(12, 108);
            SearchBox.Name = "SearchBox";
            SearchBox.PlaceholderText = "Барај...";
            SearchBox.Size = new Size(163, 16);
            SearchBox.TabIndex = 3;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackgroundImage = (Image)resources.GetObject("btnRefresh.BackgroundImage");
            btnRefresh.BackgroundImageLayout = ImageLayout.Center;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(152, 76);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(23, 23);
            btnRefresh.TabIndex = 4;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 6;
            label1.Text = "Барај според:";
            // 
            // btnEditFile
            // 
            btnEditFile.FlatAppearance.BorderSize = 0;
            btnEditFile.FlatStyle = FlatStyle.Flat;
            btnEditFile.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEditFile.ForeColor = Color.White;
            btnEditFile.Image = (Image)resources.GetObject("btnEditFile.Image");
            btnEditFile.ImageAlign = ContentAlignment.MiddleRight;
            btnEditFile.Location = new Point(201, 382);
            btnEditFile.Name = "btnEditFile";
            btnEditFile.Size = new Size(195, 26);
            btnEditFile.TabIndex = 7;
            btnEditFile.Text = "Измени Податоци";
            btnEditFile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditFile.UseVisualStyleBackColor = true;
            btnEditFile.Click += btnEditFile_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleRight;
            btnDelete.Location = new Point(598, 381);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(190, 26);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Избриши Регистрација";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // PanelText
            // 
            PanelText.AutoSize = true;
            PanelText.Font = new Font("Agency FB", 14.75F, FontStyle.Bold);
            PanelText.ForeColor = Color.White;
            PanelText.Location = new Point(41, 7);
            PanelText.Name = "PanelText";
            PanelText.Size = new Size(195, 24);
            PanelText.TabIndex = 10;
            PanelText.Text = "Сервисни Податоци";
            PanelText.TextAlign = ContentAlignment.MiddleCenter;
            PanelText.MouseDown += PanelText_MouseDown;
            PanelText.MouseMove += PanelText_MouseMove;
            PanelText.MouseUp += PanelText_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnFullScreen
            // 
            btnFullScreen.FlatAppearance.BorderSize = 0;
            btnFullScreen.FlatStyle = FlatStyle.Flat;
            btnFullScreen.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnFullScreen.ForeColor = Color.White;
            btnFullScreen.Image = (Image)resources.GetObject("btnFullScreen.Image");
            btnFullScreen.ImageAlign = ContentAlignment.MiddleRight;
            btnFullScreen.Location = new Point(402, 382);
            btnFullScreen.Name = "btnFullScreen";
            btnFullScreen.Size = new Size(190, 25);
            btnFullScreen.TabIndex = 12;
            btnFullScreen.Text = "Цел Екран";
            btnFullScreen.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFullScreen.UseVisualStyleBackColor = true;
            btnFullScreen.Click += btnFullScreen_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 30, 41);
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(PanelText);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 40);
            panel1.TabIndex = 13;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // btnMinimize
            // 
            btnMinimize.BackgroundImage = (Image)resources.GetObject("btnMinimize.BackgroundImage");
            btnMinimize.BackgroundImageLayout = ImageLayout.Center;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Location = new Point(721, -1);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(41, 41);
            btnMinimize.TabIndex = 13;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 59, 59);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(760, -1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(41, 41);
            btnClose.TabIndex = 12;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // RegNameBox
            // 
            RegNameBox.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            RegNameBox.ForeColor = Color.White;
            RegNameBox.Location = new Point(201, 79);
            RegNameBox.Name = "RegNameBox";
            RegNameBox.Size = new Size(587, 20);
            RegNameBox.TabIndex = 16;
            RegNameBox.Text = " ";
            RegNameBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnInvoice
            // 
            btnInvoice.FlatAppearance.BorderSize = 0;
            btnInvoice.FlatStyle = FlatStyle.Flat;
            btnInvoice.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnInvoice.ForeColor = Color.White;
            btnInvoice.Image = (Image)resources.GetObject("btnInvoice.Image");
            btnInvoice.ImageAlign = ContentAlignment.MiddleRight;
            btnInvoice.Location = new Point(201, 414);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(286, 33);
            btnInvoice.TabIndex = 18;
            btnInvoice.Text = "Креирај Фактура";
            btnInvoice.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInvoice.UseVisualStyleBackColor = true;
            btnInvoice.Click += btnInvoice_Click;
            // 
            // embglabel
            // 
            embglabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            embglabel.ForeColor = Color.White;
            embglabel.Location = new Point(636, 49);
            embglabel.Name = "embglabel";
            embglabel.Size = new Size(165, 20);
            embglabel.TabIndex = 19;
            embglabel.Text = " ";
            embglabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // displayMode
            // 
            displayMode.BackColor = Color.FromArgb(59, 66, 87);
            displayMode.BorderColor = Color.FromArgb(59, 66, 87);
            displayMode.ButtonColor = Color.Silver;
            displayMode.DrawMode = DrawMode.OwnerDrawFixed;
            displayMode.DropDownStyle = ComboBoxStyle.DropDownList;
            displayMode.ForeColor = Color.White;
            displayMode.Location = new Point(12, 76);
            displayMode.Name = "displayMode";
            displayMode.Size = new Size(134, 24);
            displayMode.TabIndex = 20;
            displayMode.DrawItem += displayMode_DrawItem;
            displayMode.SelectedIndexChanged += displayMode_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 40, 54);
            ClientSize = new Size(800, 450);
            Controls.Add(displayMode);
            Controls.Add(embglabel);
            Controls.Add(btnInvoice);
            Controls.Add(RegNameBox);
            Controls.Add(panel1);
            Controls.Add(btnFullScreen);
            Controls.Add(btnDelete);
            Controls.Add(btnEditFile);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(SearchBox);
            Controls.Add(btnAddNew);
            Controls.Add(InfoBox);
            Controls.Add(RegList);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Сервисни Податоци";
            Activated += Form1_Activated;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private ListBox RegList;
        private TextBox InfoBox;
        private Button btnAddNew;
        private TextBox SearchBox;
        private Button btnRefresh;
        private Label label1;
        private Button btnEditFile;
        private Button btnDelete;
        private Label PanelText;
        private PictureBox pictureBox1;
        private Button btnFullScreen;
        private Panel panel1;
        private Button btnClose;
        private Button btnMinimize;
        private Label RegNameBox;
        private Button btnInvoice;
        private Label label2;
        private Label embglabel;
        private FlatComboExample.Net.FlatComboBox displayMode;
    }
}