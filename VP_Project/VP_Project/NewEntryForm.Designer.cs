namespace VP_Project
{
    partial class NewEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEntryForm));
            WriteReg = new TextBox();
            WriteInfo = new TextBox();
            btnCancel = new Button();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            PanelText = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            Model = new TextBox();
            label5 = new Label();
            Kilometers = new NumericUpDown();
            OwnerNameBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Kilometers).BeginInit();
            SuspendLayout();
            // 
            // WriteReg
            // 
            WriteReg.BackColor = Color.FromArgb(59, 66, 87);
            WriteReg.BorderStyle = BorderStyle.None;
            WriteReg.ForeColor = Color.White;
            WriteReg.Location = new Point(352, 76);
            WriteReg.Name = "WriteReg";
            WriteReg.ShortcutsEnabled = false;
            WriteReg.Size = new Size(195, 16);
            WriteReg.TabIndex = 0;
            WriteReg.TextChanged += WriteReg_TextChanged;
            WriteReg.Validating += WriteReg_Validating;
            // 
            // WriteInfo
            // 
            WriteInfo.BackColor = Color.FromArgb(59, 66, 87);
            WriteInfo.BorderStyle = BorderStyle.None;
            WriteInfo.ForeColor = Color.White;
            WriteInfo.Location = new Point(12, 77);
            WriteInfo.Multiline = true;
            WriteInfo.Name = "WriteInfo";
            WriteInfo.ScrollBars = ScrollBars.Vertical;
            WriteInfo.Size = new Size(325, 202);
            WriteInfo.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(121, 294);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(132, 27);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Откажи";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnClose_Click;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(310, 294);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 27);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Зачувај";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(352, 58);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 4;
            label1.Text = "Регистрација:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 59);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 5;
            label2.Text = "Коментар:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(352, 179);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 7;
            label3.Text = "Километри:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 30, 41);
            panel1.Controls.Add(PanelText);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-11, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 19);
            panel1.TabIndex = 8;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // PanelText
            // 
            PanelText.AutoSize = true;
            PanelText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PanelText.ForeColor = Color.White;
            PanelText.Location = new Point(36, 2);
            PanelText.Name = "PanelText";
            PanelText.Size = new Size(115, 15);
            PanelText.TabIndex = 29;
            PanelText.Text = "Нова Регистрација";
            PanelText.MouseDown += PanelText_MouseDown;
            PanelText.MouseMove += PanelText_MouseMove;
            PanelText.MouseUp += PanelText_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 59, 59);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(47, -1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(41, 41);
            btnClose.TabIndex = 13;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 30, 41);
            panel2.Controls.Add(btnClose);
            panel2.Location = new Point(474, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(86, 40);
            panel2.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(453, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 21);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(350, 117);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 22;
            label4.Text = "Сопственик:";
            // 
            // Model
            // 
            Model.BackColor = Color.FromArgb(59, 66, 87);
            Model.BorderStyle = BorderStyle.None;
            Model.ForeColor = Color.White;
            Model.Location = new Point(352, 262);
            Model.Name = "Model";
            Model.Size = new Size(195, 16);
            Model.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(352, 244);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 24;
            label5.Text = "Модел:";
            // 
            // Kilometers
            // 
            Kilometers.BackColor = Color.FromArgb(59, 66, 87);
            Kilometers.BorderStyle = BorderStyle.None;
            Kilometers.ForeColor = Color.White;
            Kilometers.Location = new Point(352, 197);
            Kilometers.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            Kilometers.Name = "Kilometers";
            Kilometers.Size = new Size(195, 19);
            Kilometers.TabIndex = 37;
            Kilometers.Validated += Kilometers_Validated;
            // 
            // OwnerNameBox
            // 
            OwnerNameBox.BackColor = Color.FromArgb(59, 66, 87);
            OwnerNameBox.BorderStyle = BorderStyle.None;
            OwnerNameBox.ForeColor = Color.White;
            OwnerNameBox.Location = new Point(352, 135);
            OwnerNameBox.Name = "OwnerNameBox";
            OwnerNameBox.ShortcutsEnabled = false;
            OwnerNameBox.Size = new Size(195, 16);
            OwnerNameBox.TabIndex = 38;
            // 
            // NewEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 40, 54);
            ClientSize = new Size(559, 333);
            Controls.Add(OwnerNameBox);
            Controls.Add(Kilometers);
            Controls.Add(label5);
            Controls.Add(Model);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(WriteInfo);
            Controls.Add(WriteReg);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "NewEntryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Нова Регистрација";
            FormClosing += NewEntryForm_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Kilometers).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox WriteReg;
        private TextBox WriteInfo;
        private Button btnCancel;
        private Button btnAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnClose;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label4;
        private TextBox Model;
        private Label label5;
        private Label PanelText;
        private NumericUpDown Kilometers;
        private TextBox OwnerNameBox;
    }
}