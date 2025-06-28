namespace brjs
{
    partial class Main
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
            password = new TextBox();
            hide = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            login = new Button();
            username = new TextBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            closeBtn = new Button();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.None;
            password.Location = new Point(47, 108);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(184, 16);
            password.TabIndex = 1;
            password.KeyPress += password_KeyPress;
            // 
            // hide
            // 
            hide.BackColor = Color.White;
            hide.BackgroundImage = Properties.Resources.Asset_2;
            hide.BackgroundImageLayout = ImageLayout.Zoom;
            hide.FlatAppearance.BorderSize = 0;
            hide.FlatAppearance.MouseDownBackColor = Color.Transparent;
            hide.FlatStyle = FlatStyle.Flat;
            hide.ForeColor = Color.White;
            hide.Location = new Point(203, 108);
            hide.Name = "hide";
            hide.Size = new Size(28, 16);
            hide.TabIndex = 5;
            hide.UseVisualStyleBackColor = false;
            hide.Click += hide_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 16);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 81);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(hide);
            panel1.Controls.Add(login);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(password);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(username);
            panel1.Cursor = Cursors.Help;
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(558, 142);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 228);
            panel1.TabIndex = 3;
            // 
            // login
            // 
            login.BackColor = Color.Teal;
            login.BackgroundImageLayout = ImageLayout.Center;
            login.FlatAppearance.BorderSize = 0;
            login.FlatStyle = FlatStyle.Flat;
            login.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login.ForeColor = Color.White;
            login.Location = new Point(27, 166);
            login.Name = "login";
            login.Size = new Size(226, 34);
            login.TabIndex = 3;
            login.Text = "login";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // username
            // 
            username.BackColor = SystemColors.Window;
            username.BorderStyle = BorderStyle.None;
            username.Location = new Point(47, 36);
            username.Name = "username";
            username.Size = new Size(184, 16);
            username.TabIndex = 0;
            username.TextChanged += username_TextChanged;
            username.KeyPress += username_KeyPress;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.Transparent;
            closeBtn.BackgroundImage = Properties.Resources.qutIcon;
            closeBtn.BackgroundImageLayout = ImageLayout.Zoom;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Location = new Point(852, 12);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(41, 44);
            closeBtn.TabIndex = 4;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 8;
            guna2Elipse2.TargetControl = login;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bgLogin;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(905, 493);
            Controls.Add(closeBtn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox password;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button login;
        private TextBox username;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Button closeBtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Button hide;
    }
}