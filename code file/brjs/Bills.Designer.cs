namespace brjs
{
    partial class Bills
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
            Label label4;
            Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bills));
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            calcButn = new Button();
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            logout = new Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            AddItemBtn = new Button();
            button1 = new Button();
            orderFormBtn = new Button();
            ResetPass = new Button();
            logoutP = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            fromDateTxt = new TextBox();
            toDateTxt = new TextBox();
            amountTxt = new TextBox();
            label3 = new Label();
            dataBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            logoutP.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 14.25F);
            label4.Location = new Point(421, 79);
            label4.Name = "label4";
            label4.Size = new Size(81, 22);
            label4.TabIndex = 31;
            label4.Text = "Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 14.25F);
            label5.Location = new Point(614, 77);
            label5.Name = "label5";
            label5.Size = new Size(33, 22);
            label5.TabIndex = 32;
            label5.Text = "To";
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.BorderRadius = 15;
            guna2Elipse4.TargetControl = calcButn;
            // 
            // calcButn
            // 
            calcButn.BackColor = Color.Blue;
            calcButn.FlatStyle = FlatStyle.Flat;
            calcButn.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calcButn.ForeColor = Color.White;
            calcButn.Location = new Point(396, 157);
            calcButn.Name = "calcButn";
            calcButn.Size = new Size(136, 50);
            calcButn.TabIndex = 23;
            calcButn.Text = "Calculation";
            calcButn.UseVisualStyleBackColor = false;
            calcButn.Click += calcButn_Click;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 12;
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
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(163, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(610, 46);
            panel2.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.file;
            pictureBox1.Location = new Point(-2, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.TargetControl = logout;
            // 
            // logout
            // 
            logout.BackColor = Color.Transparent;
            logout.BackgroundImageLayout = ImageLayout.Center;
            logout.FlatAppearance.BorderSize = 0;
            logout.FlatStyle = FlatStyle.Flat;
            logout.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout.ForeColor = Color.White;
            logout.Location = new Point(20, 10);
            logout.Name = "logout";
            logout.Size = new Size(127, 42);
            logout.TabIndex = 4;
            logout.Text = "logout";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 20;
            guna2Elipse1.TargetControl = this;
            // 
            // AddItemBtn
            // 
            AddItemBtn.BackColor = Color.Transparent;
            AddItemBtn.BackgroundImageLayout = ImageLayout.Center;
            AddItemBtn.FlatAppearance.BorderSize = 0;
            AddItemBtn.FlatStyle = FlatStyle.Flat;
            AddItemBtn.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddItemBtn.ForeColor = Color.WhiteSmoke;
            AddItemBtn.Image = Properties.Resources.Box;
            AddItemBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AddItemBtn.Location = new Point(-7, 64);
            AddItemBtn.Name = "AddItemBtn";
            AddItemBtn.RightToLeft = RightToLeft.No;
            AddItemBtn.Size = new Size(160, 41);
            AddItemBtn.TabIndex = 9;
            AddItemBtn.Text = "          ORDER";
            AddItemBtn.UseVisualStyleBackColor = false;
            AddItemBtn.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Image = Properties.Resources.Settings1;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-7, 209);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(160, 41);
            button1.TabIndex = 8;
            button1.Text = "           SETTING";
            button1.UseVisualStyleBackColor = false;
            // 
            // orderFormBtn
            // 
            orderFormBtn.BackColor = Color.Transparent;
            orderFormBtn.BackgroundImageLayout = ImageLayout.Center;
            orderFormBtn.FlatAppearance.BorderSize = 0;
            orderFormBtn.FlatStyle = FlatStyle.Flat;
            orderFormBtn.Font = new Font("Cooper Black", 13F);
            orderFormBtn.ForeColor = Color.WhiteSmoke;
            orderFormBtn.Image = Properties.Resources.Bills;
            orderFormBtn.ImageAlign = ContentAlignment.MiddleLeft;
            orderFormBtn.Location = new Point(-7, 135);
            orderFormBtn.Name = "orderFormBtn";
            orderFormBtn.RightToLeft = RightToLeft.No;
            orderFormBtn.Size = new Size(160, 41);
            orderFormBtn.TabIndex = 7;
            orderFormBtn.Text = "          BILLS";
            orderFormBtn.UseVisualStyleBackColor = false;
            // 
            // ResetPass
            // 
            ResetPass.BackColor = Color.Transparent;
            ResetPass.BackgroundImageLayout = ImageLayout.Center;
            ResetPass.FlatAppearance.BorderSize = 0;
            ResetPass.FlatStyle = FlatStyle.Flat;
            ResetPass.Font = new Font("Cooper Black", 7.75F);
            ResetPass.ForeColor = Color.White;
            ResetPass.Image = Properties.Resources.Restart;
            ResetPass.ImageAlign = ContentAlignment.MiddleLeft;
            ResetPass.Location = new Point(-7, 279);
            ResetPass.Name = "ResetPass";
            ResetPass.RightToLeft = RightToLeft.No;
            ResetPass.Size = new Size(173, 41);
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
            logoutP.Name = "logoutP";
            logoutP.Size = new Size(163, 57);
            logoutP.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 25);
            label2.Name = "label2";
            label2.Size = new Size(135, 22);
            label2.TabIndex = 6;
            label2.Text = "BLACK HOLE";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(label2);
            panel3.ForeColor = Color.Navy;
            panel3.Location = new Point(0, -10);
            panel3.Name = "panel3";
            panel3.Size = new Size(196, 56);
            panel3.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(AddItemBtn);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(orderFormBtn);
            panel1.Controls.Add(ResetPass);
            panel1.Controls.Add(logoutP);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 414);
            panel1.TabIndex = 19;
            // 
            // fromDateTxt
            // 
            fromDateTxt.Location = new Point(225, 102);
            fromDateTxt.Name = "fromDateTxt";
            fromDateTxt.Size = new Size(137, 29);
            fromDateTxt.TabIndex = 27;
            fromDateTxt.MouseEnter += fromDateTxt_MouseEnter;
            // 
            // toDateTxt
            // 
            toDateTxt.Location = new Point(565, 102);
            toDateTxt.Name = "toDateTxt";
            toDateTxt.Size = new Size(137, 29);
            toDateTxt.TabIndex = 28;
            toDateTxt.MouseEnter += toDateTxt_MouseEnter;
            // 
            // amountTxt
            // 
            amountTxt.Location = new Point(393, 102);
            amountTxt.Name = "amountTxt";
            amountTxt.Size = new Size(137, 29);
            amountTxt.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 14.25F);
            label3.Location = new Point(263, 77);
            label3.Name = "label3";
            label3.Size = new Size(57, 22);
            label3.TabIndex = 30;
            label3.Text = "From";
            // 
            // dataBox
            // 
            dataBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataBox.Location = new Point(168, 220);
            dataBox.Multiline = true;
            dataBox.Name = "dataBox";
            dataBox.ReadOnly = true;
            dataBox.ScrollBars = ScrollBars.Vertical;
            dataBox.Size = new Size(599, 185);
            dataBox.TabIndex = 33;
            // 
            // Bills
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 414);
            Controls.Add(dataBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(amountTxt);
            Controls.Add(toDateTxt);
            Controls.Add(fromDateTxt);
            Controls.Add(calcButn);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Arial Narrow", 14.25F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Bills";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bills";
            Load += Bills_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            logoutP.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Button logout;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button AddItemBtn;
        private Button button1;
        private Button orderFormBtn;
        private Button ResetPass;
        private Panel logoutP;
        private Label label2;
        private Panel panel3;
        private Panel panel1;
        private TextBox fromDateTxt;
        private Button calcButn;
        private TextBox amountTxt;
        private TextBox toDateTxt;
        private Label label3;
        private TextBox dataBox;
    }
}