namespace FinalCPE142LProject.AdminUserControl
{
    partial class UserAccounts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccounts));
            dgvUser = new DataGridView();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            btnAddUser = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // dgvUser
            // 
            dgvUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUser.BackgroundColor = Color.FromArgb(53, 59, 72);
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.GridColor = SystemColors.Desktop;
            dgvUser.Location = new Point(40, 205);
            dgvUser.MultiSelect = false;
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersVisible = false;
            dgvUser.RowHeadersWidth = 51;
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.Size = new Size(701, 338);
            dgvUser.TabIndex = 22;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(47, 54, 64);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Square721 Cn BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ControlLightLight;
            textBox1.Location = new Point(528, 163);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 21);
            textBox1.TabIndex = 21;
            textBox1.Text = "Search...";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Square721 Cn BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(334, 159);
            button2.Name = "button2";
            button2.Size = new Size(128, 29);
            button2.TabIndex = 20;
            button2.Text = "Delete User";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Square721 Cn BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(201, 159);
            button1.Name = "button1";
            button1.Size = new Size(84, 29);
            button1.TabIndex = 19;
            button1.Text = "Edit";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Square721 Cn BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = SystemColors.ControlLightLight;
            btnAddUser.Image = (Image)resources.GetObject("btnAddUser.Image");
            btnAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddUser.Location = new Point(40, 159);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(111, 29);
            btnAddUser.TabIndex = 18;
            btnAddUser.Text = "Add User";
            btnAddUser.TextAlign = ContentAlignment.MiddleRight;
            btnAddUser.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Square721 BT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(40, 81);
            label6.Name = "label6";
            label6.Size = new Size(219, 35);
            label6.TabIndex = 17;
            label6.Text = "User Accounts";
            // 
            // UserAccounts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 54, 64);
            Controls.Add(dgvUser);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAddUser);
            Controls.Add(label6);
            Name = "UserAccounts";
            Size = new Size(780, 625);
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUser;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Button btnAddUser;
        private Label label6;
    }
}
