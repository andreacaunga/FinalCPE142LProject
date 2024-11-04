namespace FinalCPE142LProject.AdminUserControl
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnRemove = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label4 = new Label();
            dgvInventory = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // btnRemove
            // 
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Square721 Cn BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = SystemColors.ControlLightLight;
            btnRemove.Image = (Image)resources.GetObject("btnRemove.Image");
            btnRemove.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemove.Location = new Point(378, 150);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(103, 29);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Remove";
            btnRemove.TextAlign = ContentAlignment.MiddleRight;
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Square721 Cn BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(215, 150);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(99, 29);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Square721 Cn BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(41, 150);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add Product";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Square721 BT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(41, 85);
            label4.Name = "label4";
            label4.Size = new Size(140, 35);
            label4.TabIndex = 7;
            label4.Text = "Inventory";
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle1.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(223, 228, 234);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvInventory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvInventory.BackgroundColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 39, 46);
            dataGridViewCellStyle2.Font = new Font("Square721 Cn BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 39, 46);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvInventory.ColumnHeadersHeight = 30;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle3.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(223, 228, 234);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvInventory.DefaultCellStyle = dataGridViewCellStyle3;
            dgvInventory.GridColor = Color.FromArgb(231, 229, 255);
            dgvInventory.Location = new Point(47, 194);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.Size = new Size(687, 370);
            dgvInventory.TabIndex = 24;
            dgvInventory.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvInventory.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvInventory.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvInventory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvInventory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvInventory.ThemeStyle.BackColor = Color.FromArgb(47, 54, 64);
            dgvInventory.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvInventory.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvInventory.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvInventory.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvInventory.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvInventory.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvInventory.ThemeStyle.HeaderStyle.Height = 30;
            dgvInventory.ThemeStyle.ReadOnly = true;
            dgvInventory.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvInventory.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInventory.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvInventory.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvInventory.ThemeStyle.RowsStyle.Height = 29;
            dgvInventory.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvInventory.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 54, 64);
            Controls.Add(dgvInventory);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Name = "Inventory";
            Size = new Size(780, 625);
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRemove;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView dgvInventory;
    }
}
