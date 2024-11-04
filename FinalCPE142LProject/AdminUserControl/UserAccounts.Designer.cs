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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            txtSearch = new TextBox();
            btnDeleteUser = new Button();
            btnEdit = new Button();
            btnAddUser = new Button();
            label6 = new Label();
            dgvUser = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(47, 54, 64);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Square721 Cn BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = SystemColors.ControlLightLight;
            txtSearch.Location = new Point(557, 163);
            txtSearch.MaxLength = 11;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(154, 21);
            txtSearch.TabIndex = 21;
            txtSearch.Text = "Search by ID...";
            txtSearch.Click += txtSearch_Click;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.FlatAppearance.BorderSize = 0;
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.Font = new Font("Square721 Cn BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteUser.ForeColor = SystemColors.ControlLightLight;
            btnDeleteUser.Image = (Image)resources.GetObject("btnDeleteUser.Image");
            btnDeleteUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteUser.Location = new Point(334, 159);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(128, 29);
            btnDeleteUser.TabIndex = 20;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.TextAlign = ContentAlignment.MiddleRight;
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnEdit
            // 
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Square721 Cn BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = SystemColors.ControlLightLight;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(201, 159);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(84, 29);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Edit";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
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
            btnAddUser.Click += btnAddUser_Click;
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
            // dgvUser
            // 
            dgvUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle5.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(223, 228, 234);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvUser.BackgroundColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(30, 39, 46);
            dataGridViewCellStyle6.Font = new Font("Square721 Cn BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(30, 39, 46);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvUser.ColumnHeadersHeight = 30;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle7.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(223, 228, 234);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvUser.DefaultCellStyle = dataGridViewCellStyle7;
            dgvUser.GridColor = Color.FromArgb(231, 229, 255);
            dgvUser.Location = new Point(47, 203);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvUser.RowHeadersVisible = false;
            dgvUser.RowHeadersWidth = 51;
            dgvUser.Size = new Size(687, 370);
            dgvUser.TabIndex = 23;
            dgvUser.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvUser.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvUser.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvUser.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvUser.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvUser.ThemeStyle.BackColor = Color.FromArgb(47, 54, 64);
            dgvUser.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvUser.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvUser.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUser.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvUser.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvUser.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvUser.ThemeStyle.HeaderStyle.Height = 30;
            dgvUser.ThemeStyle.ReadOnly = true;
            dgvUser.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvUser.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUser.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvUser.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvUser.ThemeStyle.RowsStyle.Height = 29;
            dgvUser.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvUser.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(515, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(40, 40);
            panel1.TabIndex = 24;
            // 
            // UserAccounts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 54, 64);
            Controls.Add(panel1);
            Controls.Add(dgvUser);
            Controls.Add(txtSearch);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnEdit);
            Controls.Add(btnAddUser);
            Controls.Add(label6);
            Name = "UserAccounts";
            Size = new Size(780, 625);
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSearch;
        private Button btnDeleteUser;
        private Button btnEdit;
        private Button btnAddUser;
        private Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUser;
        private Panel panel1;
    }
}
