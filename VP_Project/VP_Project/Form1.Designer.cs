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
            this.RegList = new System.Windows.Forms.ListBox();
            this.InfoBox = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditFile = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.PanelText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.RegNameBox = new System.Windows.Forms.Label();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.embglabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            // 
            // RegList
            // 
            this.RegList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(87)))));
            this.RegList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RegList.ForeColor = System.Drawing.Color.White;
            this.RegList.FormattingEnabled = true;
            this.RegList.ItemHeight = 15;
            this.RegList.Location = new System.Drawing.Point(12, 134);
            this.RegList.Name = "RegList";
            this.RegList.Size = new System.Drawing.Size(163, 300);
            this.RegList.TabIndex = 0;
            this.RegList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.RegList_DrawItem);
            this.RegList.DoubleClick += new System.EventHandler(this.RegList_DoubleClick);
            this.RegList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegList_KeyDown);
            // 
            // InfoBox
            // 
            this.InfoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(87)))));
            this.InfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoBox.ForeColor = System.Drawing.Color.White;
            this.InfoBox.Location = new System.Drawing.Point(201, 108);
            this.InfoBox.Multiline = true;
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.ReadOnly = true;
            this.InfoBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InfoBox.Size = new System.Drawing.Size(587, 268);
            this.InfoBox.TabIndex = 1;
            // 
            // btnAddNew
            // 
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNew.Location = new System.Drawing.Point(507, 414);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(281, 33);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Нова Регистрација";
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(87)))));
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.ForeColor = System.Drawing.Color.White;
            this.SearchBox.Location = new System.Drawing.Point(12, 108);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PlaceholderText = "Барај...";
            this.SearchBox.Size = new System.Drawing.Size(163, 16);
            this.SearchBox.TabIndex = 3;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(152, 76);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Барај според:";
            // 
            // btnEditFile
            // 
            this.btnEditFile.FlatAppearance.BorderSize = 0;
            this.btnEditFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFile.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditFile.ForeColor = System.Drawing.Color.White;
            this.btnEditFile.Image = ((System.Drawing.Image)(resources.GetObject("btnEditFile.Image")));
            this.btnEditFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditFile.Location = new System.Drawing.Point(201, 382);
            this.btnEditFile.Name = "btnEditFile";
            this.btnEditFile.Size = new System.Drawing.Size(195, 26);
            this.btnEditFile.TabIndex = 7;
            this.btnEditFile.Text = "Измени Податоци";
            this.btnEditFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditFile.UseVisualStyleBackColor = true;
            this.btnEditFile.Click += new System.EventHandler(this.btnEditFile_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(598, 381);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(190, 26);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Избриши Регистрација";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // PanelText
            // 
            this.PanelText.AutoSize = true;
            this.PanelText.Font = new System.Drawing.Font("Agency FB", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PanelText.ForeColor = System.Drawing.Color.White;
            this.PanelText.Location = new System.Drawing.Point(41, 7);
            this.PanelText.Name = "PanelText";
            this.PanelText.Size = new System.Drawing.Size(195, 24);
            this.PanelText.TabIndex = 10;
            this.PanelText.Text = "Сервисни Податоци";
            this.PanelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PanelText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelText_MouseDown);
            this.PanelText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelText_MouseMove);
            this.PanelText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelText_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.FlatAppearance.BorderSize = 0;
            this.btnFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullScreen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFullScreen.ForeColor = System.Drawing.Color.White;
            this.btnFullScreen.Image = ((System.Drawing.Image)(resources.GetObject("btnFullScreen.Image")));
            this.btnFullScreen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFullScreen.Location = new System.Drawing.Point(402, 382);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(190, 25);
            this.btnFullScreen.TabIndex = 12;
            this.btnFullScreen.Text = "Цел Екран";
            this.btnFullScreen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFullScreen.UseVisualStyleBackColor = true;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.PanelText);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 13;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(721, -1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(41, 41);
            this.btnMinimize.TabIndex = 13;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(760, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 41);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RegNameBox
            // 
            this.RegNameBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegNameBox.ForeColor = System.Drawing.Color.White;
            this.RegNameBox.Location = new System.Drawing.Point(201, 79);
            this.RegNameBox.Name = "RegNameBox";
            this.RegNameBox.Size = new System.Drawing.Size(587, 20);
            this.RegNameBox.TabIndex = 16;
            this.RegNameBox.Text = " ";
            this.RegNameBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInvoice
            // 
            this.btnInvoice.FlatAppearance.BorderSize = 0;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInvoice.ForeColor = System.Drawing.Color.White;
            this.btnInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnInvoice.Image")));
            this.btnInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvoice.Location = new System.Drawing.Point(201, 414);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(286, 33);
            this.btnInvoice.TabIndex = 18;
            this.btnInvoice.Text = "Креирај Фактура";
            this.btnInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // embglabel
            // 
            this.embglabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.embglabel.ForeColor = System.Drawing.Color.White;
            this.embglabel.Location = new System.Drawing.Point(636, 49);
            this.embglabel.Name = "embglabel";
            this.embglabel.Size = new System.Drawing.Size(165, 20);
            this.embglabel.TabIndex = 19;
            this.embglabel.Text = " ";
            this.embglabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.embglabel);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.RegNameBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFullScreen);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.RegList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Сервисни Податоци";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}