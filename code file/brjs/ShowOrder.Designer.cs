namespace brjs
{
    partial class ShowOrder
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            close = new Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            removeBtn = new Button();
            editTxt = new TextBox();
            saveBtn = new Button();
            searchBtn = new Button();
            searchTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            dataGridViewCellStyle2.Font = new Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Navy;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Cambria Math", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.Window;
            dataGridView1.Location = new Point(8, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersWidth = 20;
            dataGridView1.Size = new Size(840, 427);
            dataGridView1.TabIndex = 18;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // close
            // 
            close.BackColor = Color.Blue;
            close.FlatAppearance.BorderSize = 0;
            close.FlatStyle = FlatStyle.Flat;
            close.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.ForeColor = Color.White;
            close.Location = new Point(759, 449);
            close.Name = "close";
            close.Size = new Size(76, 35);
            close.TabIndex = 19;
            close.Text = "Ok";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 8;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.TargetControl = close;
            // 
            // removeBtn
            // 
            removeBtn.BackColor = Color.Transparent;
            removeBtn.BackgroundImage = Properties.Resources.Remove;
            removeBtn.BackgroundImageLayout = ImageLayout.Zoom;
            removeBtn.Cursor = Cursors.Hand;
            removeBtn.FlatAppearance.BorderSize = 0;
            removeBtn.FlatStyle = FlatStyle.Flat;
            removeBtn.Location = new Point(28, 438);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(77, 50);
            removeBtn.TabIndex = 20;
            removeBtn.UseVisualStyleBackColor = false;
            removeBtn.Click += removeBtn_Click;
            // 
            // editTxt
            // 
            editTxt.BackColor = Color.White;
            editTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editTxt.ForeColor = Color.Black;
            editTxt.Location = new Point(241, 453);
            editTxt.Name = "editTxt";
            editTxt.Size = new Size(128, 29);
            editTxt.TabIndex = 23;
            editTxt.KeyPress += editTxt_KeyPress;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.Transparent;
            saveBtn.BackgroundImage = Properties.Resources.Save;
            saveBtn.BackgroundImageLayout = ImageLayout.Zoom;
            saveBtn.Cursor = Cursors.Hand;
            saveBtn.FlatAppearance.BorderSize = 0;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Location = new Point(192, 446);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(43, 40);
            saveBtn.TabIndex = 25;
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.Transparent;
            searchBtn.BackgroundImage = Properties.Resources.Search;
            searchBtn.BackgroundImageLayout = ImageLayout.Zoom;
            searchBtn.Cursor = Cursors.Hand;
            searchBtn.FlatAppearance.BorderSize = 0;
            searchBtn.FlatStyle = FlatStyle.Flat;
            searchBtn.Location = new Point(449, 445);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(43, 40);
            searchBtn.TabIndex = 26;
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // searchTxt
            // 
            searchTxt.BackColor = Color.White;
            searchTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTxt.ForeColor = Color.Gray;
            searchTxt.Location = new Point(503, 451);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(128, 29);
            searchTxt.TabIndex = 27;
            searchTxt.Text = "Search";
            searchTxt.TextChanged += searchTxt_TextChanged;
            searchTxt.Enter += searchTxt_Enter;
            searchTxt.Leave += searchTxt_Leave;
            // 
            // ShowOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(860, 496);
            ControlBox = false;
            Controls.Add(searchTxt);
            Controls.Add(searchBtn);
            Controls.Add(saveBtn);
            Controls.Add(editTxt);
            Controls.Add(removeBtn);
            Controls.Add(close);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "ShowOrder";
            Load += ShowOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button close;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private TextBox editTxt;
        private Button removeBtn;
        private Button searchBtn;
        private Button saveBtn;
        private TextBox searchTxt;
    }
}