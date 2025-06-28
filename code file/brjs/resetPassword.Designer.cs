namespace brjs
{
    partial class resetPassword
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
            newPassword = new TextBox();
            confirmPassword = new TextBox();
            lastPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Ok = new Button();
            cancel = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // newPassword
            // 
            newPassword.Location = new Point(48, 19);
            newPassword.Name = "newPassword";
            newPassword.Size = new Size(100, 23);
            newPassword.TabIndex = 0;
            // 
            // confirmPassword
            // 
            confirmPassword.Location = new Point(49, 68);
            confirmPassword.Name = "confirmPassword";
            confirmPassword.Size = new Size(100, 23);
            confirmPassword.TabIndex = 1;
            // 
            // lastPassword
            // 
            lastPassword.Location = new Point(48, 112);
            lastPassword.Name = "lastPassword";
            lastPassword.Size = new Size(100, 23);
            lastPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 3;
            label1.Text = "New Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 48);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 4;
            label2.Text = "Confirm Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 94);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 5;
            label3.Text = "Last Password";
            // 
            // Ok
            // 
            Ok.Location = new Point(3, 166);
            Ok.Name = "Ok";
            Ok.Size = new Size(75, 23);
            Ok.TabIndex = 6;
            Ok.Text = "Ok";
            Ok.UseVisualStyleBackColor = true;
            Ok.Click += Ok_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(125, 166);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 23);
            cancel.TabIndex = 7;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cancel);
            panel1.Controls.Add(newPassword);
            panel1.Controls.Add(Ok);
            panel1.Controls.Add(confirmPassword);
            panel1.Controls.Add(lastPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(133, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 189);
            panel1.TabIndex = 8;
            // 
            // resetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 299);
            ControlBox = false;
            Controls.Add(panel1);
            Name = "resetPassword";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "resetPassword";
            Load += resetPassword_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox newPassword;
        private TextBox confirmPassword;
        private TextBox lastPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Ok;
        private Button cancel;
        private Panel panel1;
    }
}