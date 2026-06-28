using System.Linq.Expressions;

namespace VP_Project
{
    partial class InvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            FeedbackLabel = new fadinglabel.FadingLabel();
            btnClose = new Button();
            panel1 = new Panel();
            PanelText = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            IName = new TextBox();
            DaysNum = new NumericUpDown();
            ICount = new NumericUpDown();
            IPrice = new NumericUpDown();
            btnConfirm = new Button();
            Owner = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAddItem = new Button();
            btnRemoveItem = new Button();
            DataGrid = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            ItemDesc = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            TimerFadeOut = new System.Windows.Forms.Timer(components);
            ownerSelect = new FlatComboExample.Net.FlatComboBox();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DaysNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ICount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            SuspendLayout();
            // 
            // FeedbackLabel
            // 
            FeedbackLabel.AutoSize = true;
            FeedbackLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FeedbackLabel.Location = new Point(27, 285);
            FeedbackLabel.Name = "FeedbackLabel";
            FeedbackLabel.Size = new Size(57, 15);
            FeedbackLabel.TabIndex = 49;
            FeedbackLabel.Text = "SUCCESS";
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 59, 59);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(39, -1);
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
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(636, 19);
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
            PanelText.Location = new Point(30, 2);
            PanelText.Name = "PanelText";
            PanelText.Size = new Size(103, 15);
            PanelText.TabIndex = 28;
            PanelText.Text = "Креирај Фактура";
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
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(593, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 21);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 30, 41);
            panel2.Controls.Add(btnClose);
            panel2.Location = new Point(614, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(80, 40);
            panel2.TabIndex = 18;
            // 
            // IName
            // 
            IName.BackColor = Color.FromArgb(59, 66, 87);
            IName.BorderStyle = BorderStyle.None;
            IName.ForeColor = Color.White;
            IName.Location = new Point(27, 203);
            IName.Name = "IName";
            IName.Size = new Size(174, 16);
            IName.TabIndex = 33;
            IName.KeyDown += IName_KeyDown;
            // 
            // DaysNum
            // 
            DaysNum.BackColor = Color.FromArgb(59, 66, 87);
            DaysNum.BorderStyle = BorderStyle.None;
            DaysNum.ForeColor = Color.White;
            DaysNum.Location = new Point(29, 132);
            DaysNum.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            DaysNum.Name = "DaysNum";
            DaysNum.Size = new Size(172, 19);
            DaysNum.TabIndex = 35;
            // 
            // ICount
            // 
            ICount.BackColor = Color.FromArgb(59, 66, 87);
            ICount.BorderStyle = BorderStyle.None;
            ICount.ForeColor = Color.White;
            ICount.Location = new Point(160, 250);
            ICount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ICount.Name = "ICount";
            ICount.Size = new Size(45, 19);
            ICount.TabIndex = 36;
            ICount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            ICount.KeyDown += IName_KeyDown;
            // 
            // IPrice
            // 
            IPrice.BackColor = Color.FromArgb(59, 66, 87);
            IPrice.BorderStyle = BorderStyle.None;
            IPrice.ForeColor = Color.White;
            IPrice.Location = new Point(27, 250);
            IPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            IPrice.Name = "IPrice";
            IPrice.Size = new Size(127, 19);
            IPrice.TabIndex = 37;
            IPrice.ThousandsSeparator = true;
            IPrice.KeyDown += IName_KeyDown;
            // 
            // btnConfirm
            // 
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(27, 341);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(640, 31);
            btnConfirm.TabIndex = 39;
            btnConfirm.Text = "Креирај Фактура";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // Owner
            // 
            Owner.AutoSize = true;
            Owner.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Owner.ForeColor = Color.White;
            Owner.Location = new Point(27, 62);
            Owner.Name = "Owner";
            Owner.Size = new Size(68, 15);
            Owner.TabIndex = 41;
            Owner.Text = "Сметка до:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 114);
            label1.Name = "label1";
            label1.Size = new Size(163, 15);
            label1.TabIndex = 42;
            label1.Text = "Рок на исплата(во денови):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 185);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 43;
            label2.Text = "Име на производ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 232);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 44;
            label3.Text = "Цена(МКД):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(158, 232);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 45;
            label4.Text = "Кол.:";
            // 
            // btnAddItem
            // 
            btnAddItem.FlatAppearance.BorderSize = 0;
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAddItem.ForeColor = Color.White;
            btnAddItem.Location = new Point(376, 275);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(87, 25);
            btnAddItem.TabIndex = 47;
            btnAddItem.Text = "Додади";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.FlatAppearance.BorderSize = 0;
            btnRemoveItem.FlatStyle = FlatStyle.Flat;
            btnRemoveItem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRemoveItem.ForeColor = Color.White;
            btnRemoveItem.Location = new Point(485, 275);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(87, 25);
            btnRemoveItem.TabIndex = 46;
            btnRemoveItem.Text = "Отстрани";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToAddRows = false;
            DataGrid.AllowUserToDeleteRows = false;
            DataGrid.AllowUserToResizeColumns = false;
            DataGrid.AllowUserToResizeRows = false;
            DataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGrid.BackgroundColor = Color.FromArgb(59, 66, 87);
            DataGrid.BorderStyle = BorderStyle.None;
            DataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 40, 54);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(35, 40, 54);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Columns.AddRange(new DataGridViewColumn[] { ID, ItemDesc, Amount, Price });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(35, 40, 54);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(59, 66, 87);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            DataGrid.EnableHeadersVisualStyles = false;
            DataGrid.GridColor = Color.FromArgb(59, 66, 87);
            DataGrid.Location = new Point(271, 58);
            DataGrid.MultiSelect = false;
            DataGrid.Name = "DataGrid";
            DataGrid.ReadOnly = true;
            DataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(35, 40, 54);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(35, 40, 54);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DataGrid.RowHeadersVisible = false;
            DataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGrid.Size = new Size(396, 211);
            DataGrid.TabIndex = 48;
            // 
            // ID
            // 
            ID.HeaderText = "Р.бр";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 50;
            // 
            // ItemDesc
            // 
            ItemDesc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemDesc.HeaderText = "Производ";
            ItemDesc.Name = "ItemDesc";
            ItemDesc.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.HeaderText = "Кол.";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 50;
            // 
            // Price
            // 
            Price.HeaderText = "Цена";
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 65;
            // 
            // TimerFadeOut
            // 
            TimerFadeOut.Tick += TimerFadeOut_Tick;
            // 
            // ownerSelect
            // 
            ownerSelect.BackColor = Color.FromArgb(59, 66, 87);
            ownerSelect.BorderColor = Color.FromArgb(59, 66, 87);
            ownerSelect.ButtonColor = Color.Silver;
            ownerSelect.DrawMode = DrawMode.OwnerDrawFixed;
            ownerSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            ownerSelect.ForeColor = Color.White;
            ownerSelect.Location = new Point(27, 80);
            ownerSelect.Name = "ownerSelect";
            ownerSelect.Size = new Size(178, 24);
            ownerSelect.TabIndex = 50;
            ownerSelect.DrawItem += ownerSelect_DrawItem;
            ownerSelect.SelectedIndexChanged += ownerSelect_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(59, 66, 87);
            panel3.Location = new Point(15, 170);
            panel3.Name = "panel3";
            panel3.Size = new Size(205, 112);
            panel3.TabIndex = 51;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 40, 54);
            panel4.Location = new Point(16, 171);
            panel4.Name = "panel4";
            panel4.Size = new Size(203, 110);
            panel4.TabIndex = 52;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(35, 40, 54);
            panel5.Location = new Point(16, 59);
            panel5.Name = "panel5";
            panel5.Size = new Size(203, 105);
            panel5.TabIndex = 54;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(59, 66, 87);
            panel6.Location = new Point(15, 58);
            panel6.Name = "panel6";
            panel6.Size = new Size(205, 107);
            panel6.TabIndex = 53;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 40, 54);
            ClientSize = new Size(694, 383);
            Controls.Add(ownerSelect);
            Controls.Add(DataGrid);
            Controls.Add(FeedbackLabel);
            Controls.Add(btnAddItem);
            Controls.Add(btnRemoveItem);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Owner);
            Controls.Add(btnConfirm);
            Controls.Add(IPrice);
            Controls.Add(ICount);
            Controls.Add(DaysNum);
            Controls.Add(IName);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel6);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InvoiceForm";
            Text = "Креирај Сметка";
            Load += InvoiceForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DaysNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)ICount).EndInit();
            ((System.ComponentModel.ISupportInitialize)IPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button btnClose;
        private Panel panel1;
        private Label PanelText;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private TextBox IName;
        private NumericUpDown DaysNum;
        private NumericUpDown ICount;
        private NumericUpDown IPrice;
        private Button btnConfirm;
        private Label Owner;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private fadinglabel.FadingLabel FeedbackLabel;
        private Button btnAddItem;
        private Button btnRemoveItem;
        private DataGridView DataGrid;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ItemDesc;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Timer TimerFadeOut;
        private FlatComboExample.Net.FlatComboBox ownerSelect;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}