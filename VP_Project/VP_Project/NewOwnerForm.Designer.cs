namespace VP_Project
{
    partial class NewOwnerForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOwnerForm));
            btnCancel = new Button();
            btnSave = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            PanelText = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            nameBox = new TextBox();
            numBox = new TextBox();
            mailBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            addressBox = new TextBox();
            EMBGBox = new TextBox();
            label5 = new Label();
            EP = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EP).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(44, 280);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(89, 30);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Откажи";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(150, 280);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(89, 30);
            btnSave.TabIndex = 1;
            btnSave.Text = "Зачувај";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(26, 30, 41);
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 59, 59);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(26, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(41, 41);
            btnClose.TabIndex = 14;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 30, 41);
            panel1.Controls.Add(PanelText);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 19);
            panel1.TabIndex = 20;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // PanelText
            // 
            PanelText.AutoSize = true;
            PanelText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PanelText.ForeColor = Color.White;
            PanelText.Location = new Point(27, 2);
            PanelText.Name = "PanelText";
            PanelText.Size = new Size(101, 15);
            PanelText.TabIndex = 29;
            PanelText.Text = "Нов Сопственик";
            PanelText.MouseDown += PanelText_MouseDown;
            PanelText.MouseMove += PanelText_MouseMove;
            PanelText.MouseUp += PanelText_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(207, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 21);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 30, 41);
            panel2.Controls.Add(btnClose);
            panel2.Location = new Point(228, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(67, 40);
            panel2.TabIndex = 18;
            // 
            // nameBox
            // 
            nameBox.BackColor = Color.FromArgb(59, 66, 87);
            nameBox.BorderStyle = BorderStyle.None;
            nameBox.ForeColor = Color.White;
            nameBox.Location = new Point(44, 65);
            nameBox.Name = "nameBox";
            nameBox.ShortcutsEnabled = false;
            nameBox.Size = new Size(195, 16);
            nameBox.TabIndex = 22;
            nameBox.TextChanged += nameBox_TextChanged;
            // 
            // numBox
            // 
            numBox.BackColor = Color.FromArgb(59, 66, 87);
            numBox.BorderStyle = BorderStyle.None;
            numBox.ForeColor = Color.White;
            numBox.Location = new Point(44, 156);
            numBox.Name = "numBox";
            numBox.ShortcutsEnabled = false;
            numBox.Size = new Size(195, 16);
            numBox.TabIndex = 23;
            numBox.KeyPress += numBox_KeyPress;
            // 
            // mailBox
            // 
            mailBox.BackColor = Color.FromArgb(59, 66, 87);
            mailBox.BorderStyle = BorderStyle.None;
            mailBox.ForeColor = Color.White;
            mailBox.Location = new Point(44, 203);
            mailBox.Name = "mailBox";
            mailBox.Size = new Size(195, 16);
            mailBox.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(44, 47);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 26;
            label1.Text = "Име на сопственикот:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(44, 138);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 27;
            label2.Text = "Контакт број:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(44, 185);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 28;
            label3.Text = "Е-Пошта:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(44, 233);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 30;
            label4.Text = "Адреса:";
            // 
            // addressBox
            // 
            addressBox.BackColor = Color.FromArgb(59, 66, 87);
            addressBox.BorderStyle = BorderStyle.None;
            addressBox.ForeColor = Color.White;
            addressBox.Location = new Point(44, 251);
            addressBox.Name = "addressBox";
            addressBox.ShortcutsEnabled = false;
            addressBox.Size = new Size(195, 16);
            addressBox.TabIndex = 29;
            // 
            // EMBGBox
            // 
            EMBGBox.BackColor = Color.FromArgb(59, 66, 87);
            EMBGBox.BorderStyle = BorderStyle.None;
            EMBGBox.ForeColor = Color.White;
            EMBGBox.Location = new Point(44, 110);
            EMBGBox.Name = "EMBGBox";
            EMBGBox.ShortcutsEnabled = false;
            EMBGBox.Size = new Size(195, 16);
            EMBGBox.TabIndex = 31;
            EMBGBox.TextChanged += EMBGBox_TextChanged;
            EMBGBox.KeyPress += numBox_KeyPress;
            EMBGBox.Validating += EMBGBox_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(44, 90);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 32;
            label5.Text = "ЕМБГ:";
            // 
            // EP
            // 
            EP.ContainerControl = this;
            // 
            // NewOwnerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 40, 54);
            ClientSize = new Size(294, 322);
            Controls.Add(label5);
            Controls.Add(EMBGBox);
            Controls.Add(label4);
            Controls.Add(addressBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mailBox);
            Controls.Add(numBox);
            Controls.Add(nameBox);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewOwnerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Нов Сопственик";
            FormClosing += NewOwnerForm_FormClosing;
            Load += NewOwnerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EP).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private Button btnClose;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private TextBox nameBox;
        private TextBox numBox;
        private TextBox mailBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label PanelText;
        private Label label4;
        private TextBox addressBox;
        private TextBox EMBGBox;
        private Label label5;
        private ErrorProvider EP;
    }
}