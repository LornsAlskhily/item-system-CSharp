using brjs.Properties;
using System.Drawing.Imaging;

namespace brjs
{
    partial class AddItem
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            panel1 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            orderFormBtn = new Button();
            settingFormBtn = new Button();
            billsFormBtn = new Button();
            ResetPass = new Button();
            logoutP = new Panel();
            logout = new Button();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel2 = new Panel();
            label1 = new Label();
            typeTxt = new ComboBox();
            phoneNumTxt = new TextBox();
            priceTxt = new ComboBox();
            locationTxt = new ComboBox();
            groupTxt = new ComboBox();
            otherTxt = new ComboBox();
            addButn = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            dateTxt = new TextBox();
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            logoutP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(orderFormBtn);
            panel1.Controls.Add(settingFormBtn);
            panel1.Controls.Add(billsFormBtn);
            panel1.Controls.Add(ResetPass);
            panel1.Controls.Add(logoutP);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 414);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(label2);
            panel3.ForeColor = Color.Navy;
            panel3.Location = new Point(0, -11);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(195, 57);
            panel3.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 25);
            label2.Name = "label2";
            label2.Size = new Size(135, 22);
            label2.TabIndex = 6;
            label2.Text = "BLACK HOLE";
            // 
            // orderFormBtn
            // 
            orderFormBtn.BackColor = Color.Transparent;
            orderFormBtn.BackgroundImageLayout = ImageLayout.Center;
            orderFormBtn.FlatAppearance.BorderSize = 0;
            orderFormBtn.FlatStyle = FlatStyle.Flat;
            orderFormBtn.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderFormBtn.ForeColor = Color.WhiteSmoke;
            orderFormBtn.Image = Resources.Box;
            orderFormBtn.ImageAlign = ContentAlignment.MiddleLeft;
            orderFormBtn.Location = new Point(-6, 64);
            orderFormBtn.Margin = new Padding(3, 2, 3, 2);
            orderFormBtn.Name = "orderFormBtn";
            orderFormBtn.RightToLeft = RightToLeft.No;
            orderFormBtn.Size = new Size(159, 41);
            orderFormBtn.TabIndex = 9;
            orderFormBtn.Text = "          ORDER";
            orderFormBtn.UseVisualStyleBackColor = false;
            // 
            // settingFormBtn
            // 
            settingFormBtn.BackColor = Color.Transparent;
            settingFormBtn.BackgroundImageLayout = ImageLayout.None;
            settingFormBtn.FlatAppearance.BorderSize = 0;
            settingFormBtn.FlatStyle = FlatStyle.Flat;
            settingFormBtn.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            settingFormBtn.ForeColor = Color.WhiteSmoke;
            settingFormBtn.Image = Resources.Settings1;
            settingFormBtn.ImageAlign = ContentAlignment.MiddleLeft;
            settingFormBtn.Location = new Point(-6, 209);
            settingFormBtn.Margin = new Padding(3, 2, 3, 2);
            settingFormBtn.Name = "settingFormBtn";
            settingFormBtn.RightToLeft = RightToLeft.No;
            settingFormBtn.Size = new Size(159, 41);
            settingFormBtn.TabIndex = 8;
            settingFormBtn.Text = "           SETTING";
            settingFormBtn.UseVisualStyleBackColor = false;
            // 
            // billsFormBtn
            // 
            billsFormBtn.BackColor = Color.Transparent;
            billsFormBtn.BackgroundImageLayout = ImageLayout.Center;
            billsFormBtn.FlatAppearance.BorderSize = 0;
            billsFormBtn.FlatStyle = FlatStyle.Flat;
            billsFormBtn.Font = new Font("Cooper Black", 13F);
            billsFormBtn.ForeColor = Color.WhiteSmoke;
            billsFormBtn.Image = Resources.Bills;
            billsFormBtn.ImageAlign = ContentAlignment.MiddleLeft;
            billsFormBtn.Location = new Point(-6, 136);
            billsFormBtn.Margin = new Padding(3, 2, 3, 2);
            billsFormBtn.Name = "billsFormBtn";
            billsFormBtn.RightToLeft = RightToLeft.No;
            billsFormBtn.Size = new Size(159, 41);
            billsFormBtn.TabIndex = 7;
            billsFormBtn.Text = "          BILLS";
            billsFormBtn.UseVisualStyleBackColor = false;
            billsFormBtn.Click += billsFormBtn_Click;
            // 
            // ResetPass
            // 
            ResetPass.BackColor = Color.Transparent;
            ResetPass.BackgroundImageLayout = ImageLayout.Center;
            ResetPass.FlatAppearance.BorderSize = 0;
            ResetPass.FlatStyle = FlatStyle.Flat;
            ResetPass.Font = new Font("Cooper Black", 7.75F);
            ResetPass.ForeColor = Color.White;
            ResetPass.Image = Resources.Restart;
            ResetPass.ImageAlign = ContentAlignment.MiddleLeft;
            ResetPass.Location = new Point(-6, 278);
            ResetPass.Margin = new Padding(3, 2, 3, 2);
            ResetPass.Name = "ResetPass";
            ResetPass.RightToLeft = RightToLeft.No;
            ResetPass.Size = new Size(174, 41);
            ResetPass.TabIndex = 4;
            ResetPass.Text = " RESET PASSWORD";
            ResetPass.TextAlign = ContentAlignment.MiddleRight;
            ResetPass.UseVisualStyleBackColor = false;
            ResetPass.Click += ResetPass_Click;
            // 
            // logoutP
            // 
            logoutP.BackColor = Color.MediumBlue;
            logoutP.Controls.Add(logout);
            logoutP.Location = new Point(0, 357);
            logoutP.Margin = new Padding(3, 2, 3, 2);
            logoutP.Name = "logoutP";
            logoutP.Size = new Size(163, 57);
            logoutP.TabIndex = 4;
            // 
            // logout
            // 
            logout.BackColor = Color.Transparent;
            logout.BackgroundImageLayout = ImageLayout.Center;
            logout.FlatAppearance.BorderSize = 0;
            logout.FlatStyle = FlatStyle.Flat;
            logout.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout.ForeColor = Color.White;
            logout.Location = new Point(21, 11);
            logout.Margin = new Padding(3, 2, 3, 2);
            logout.Name = "logout";
            logout.Size = new Size(127, 41);
            logout.TabIndex = 4;
            logout.Text = "logout";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.file;
            pictureBox1.Location = new Point(-3, -11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 20;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.TargetControl = logout;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(163, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(610, 46);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(58, 12);
            label1.Name = "label1";
            label1.Size = new Size(259, 22);
            label1.TabIndex = 0;
            label1.Text = "CNC Mangment System 1.0";
            // 
            // typeTxt
            // 
            typeTxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            typeTxt.AutoCompleteSource = AutoCompleteSource.ListItems;
            typeTxt.FormattingEnabled = true;
            typeTxt.Items.AddRange(new object[] { "stander stand", "logo", "table lamb" });
            typeTxt.Location = new Point(168, 107);
            typeTxt.Margin = new Padding(3, 2, 3, 2);
            typeTxt.Name = "typeTxt";
            typeTxt.Size = new Size(136, 23);
            typeTxt.TabIndex = 2;
            // 
            // phoneNumTxt
            // 
            phoneNumTxt.Location = new Point(323, 107);
            phoneNumTxt.Margin = new Padding(3, 2, 3, 2);
            phoneNumTxt.Name = "phoneNumTxt";
            phoneNumTxt.Size = new Size(136, 23);
            phoneNumTxt.TabIndex = 3;
            // 
            // priceTxt
            // 
            priceTxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            priceTxt.AutoCompleteSource = AutoCompleteSource.ListItems;
            priceTxt.FormattingEnabled = true;
            priceTxt.Location = new Point(624, 104);
            priceTxt.Margin = new Padding(3, 2, 3, 2);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(136, 23);
            priceTxt.TabIndex = 5;
            // 
            // locationTxt
            // 
            locationTxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            locationTxt.AutoCompleteSource = AutoCompleteSource.ListItems;
            locationTxt.FormattingEnabled = true;
            locationTxt.Items.AddRange(new object[] { "Ajloun", "Al Karak", "Amman", "Aqaba", "Irbid", "Jerash", "Ma'an", "Madaba", "Mafraq", "Salt", "Tafilah", "Zarqa" });
            locationTxt.Location = new Point(168, 209);
            locationTxt.Margin = new Padding(3, 2, 3, 2);
            locationTxt.Name = "locationTxt";
            locationTxt.Size = new Size(121, 23);
            locationTxt.TabIndex = 6;
            // 
            // groupTxt
            // 
            groupTxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            groupTxt.AutoCompleteSource = AutoCompleteSource.ListItems;
            groupTxt.FormattingEnabled = true;
            groupTxt.Items.AddRange(new object[] { "Eva Shop", "Black Hole" });
            groupTxt.Location = new Point(323, 209);
            groupTxt.Margin = new Padding(3, 2, 3, 2);
            groupTxt.Name = "groupTxt";
            groupTxt.Size = new Size(121, 23);
            groupTxt.TabIndex = 7;
            // 
            // otherTxt
            // 
            otherTxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            otherTxt.AutoCompleteSource = AutoCompleteSource.ListItems;
            otherTxt.FormattingEnabled = true;
            otherTxt.Location = new Point(480, 209);
            otherTxt.Margin = new Padding(3, 2, 3, 2);
            otherTxt.Name = "otherTxt";
            otherTxt.Size = new Size(121, 23);
            otherTxt.TabIndex = 8;
            // 
            // addButn
            // 
            addButn.BackColor = Color.Blue;
            addButn.FlatStyle = FlatStyle.Flat;
            addButn.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addButn.ForeColor = Color.White;
            addButn.Location = new Point(624, 199);
            addButn.Margin = new Padding(3, 2, 3, 2);
            addButn.Name = "addButn";
            addButn.Size = new Size(136, 51);
            addButn.TabIndex = 9;
            addButn.Text = "ADD";
            addButn.UseVisualStyleBackColor = false;
            addButn.Click += addButn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(318, 81);
            label3.Name = "label3";
            label3.Size = new Size(142, 22);
            label3.TabIndex = 10;
            label3.Text = "Phone number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(204, 80);
            label4.Name = "label4";
            label4.Size = new Size(55, 22);
            label4.TabIndex = 11;
            label4.Text = "Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(510, 81);
            label5.Name = "label5";
            label5.Size = new Size(53, 22);
            label5.TabIndex = 12;
            label5.Text = "Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(663, 81);
            label6.Name = "label6";
            label6.Size = new Size(58, 22);
            label6.TabIndex = 13;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(186, 179);
            label7.Name = "label7";
            label7.Size = new Size(88, 22);
            label7.TabIndex = 14;
            label7.Text = "Location";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(351, 179);
            label8.Name = "label8";
            label8.Size = new Size(67, 22);
            label8.TabIndex = 15;
            label8.Text = "Group";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(508, 182);
            label9.Name = "label9";
            label9.Size = new Size(62, 22);
            label9.TabIndex = 16;
            label9.Text = "Other";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Navy;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.Window;
            dataGridView1.Location = new Point(172, 281);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersWidth = 20;
            dataGridView1.Size = new Size(590, 92);
            dataGridView1.TabIndex = 17;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 12;
            guna2Elipse3.TargetControl = dataGridView1;
            // 
            // dateTxt
            // 
            dateTxt.Location = new Point(465, 107);
            dateTxt.Margin = new Padding(3, 2, 3, 2);
            dateTxt.Name = "dateTxt";
            dateTxt.Size = new Size(136, 23);
            dateTxt.TabIndex = 18;
            dateTxt.MouseEnter += dateTxt_MouseEnter;
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.BorderRadius = 15;
            guna2Elipse4.TargetControl = addButn;
            // 
            // AddItem
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(773, 414);
            Controls.Add(dateTxt);
            Controls.Add(dataGridView1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(addButn);
            Controls.Add(otherTxt);
            Controls.Add(groupTxt);
            Controls.Add(locationTxt);
            Controls.Add(priceTxt);
            Controls.Add(phoneNumTxt);
            Controls.Add(typeTxt);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            logoutP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Panel logoutP;
        private Button logout;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Button ResetPass;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Button addButn;
        private ComboBox otherTxt;
        private ComboBox groupTxt;
        private ComboBox locationTxt;
        private ComboBox priceTxt;
        private TextBox phoneNumTxt;
        private ComboBox typeTxt;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private TextBox dateTxt;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Button billsFormBtn;
        private Panel panel3;
        private Button orderFormBtn;
        private Button settingFormBtn;
    }
}
