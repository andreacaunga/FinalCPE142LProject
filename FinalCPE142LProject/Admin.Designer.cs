namespace FinalCPE142LProject
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            pnlAdminMenu = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            btnTransactions = new Button();
            btnInventory = new Button();
            btnAccounts = new Button();
            btnSignout = new Button();
            btnExit = new Button();
            btnDashboard = new Button();
            pnlContainerAdmin = new Panel();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            pnlAdminMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAdminMenu
            // 
            pnlAdminMenu.BackColor = Color.FromArgb(53, 59, 72);
            pnlAdminMenu.Controls.Add(label1);
            pnlAdminMenu.Controls.Add(panel1);
            pnlAdminMenu.Controls.Add(btnTransactions);
            pnlAdminMenu.Controls.Add(btnInventory);
            pnlAdminMenu.Controls.Add(btnAccounts);
            pnlAdminMenu.Controls.Add(btnSignout);
            pnlAdminMenu.Controls.Add(btnExit);
            pnlAdminMenu.Controls.Add(btnDashboard);
            pnlAdminMenu.Dock = DockStyle.Left;
            pnlAdminMenu.Location = new Point(0, 0);
            pnlAdminMenu.Name = "pnlAdminMenu";
            pnlAdminMenu.Size = new Size(190, 625);
            pnlAdminMenu.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Square721 Cn BT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(70, 147);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 6;
            label1.Text = "Admin";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(10, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 125);
            panel1.TabIndex = 10;
            // 
            // btnTransactions
            // 
            btnTransactions.FlatAppearance.BorderSize = 0;
            btnTransactions.FlatStyle = FlatStyle.Flat;
            btnTransactions.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransactions.ForeColor = SystemColors.ControlLightLight;
            btnTransactions.Image = (Image)resources.GetObject("btnTransactions.Image");
            btnTransactions.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransactions.Location = new Point(0, 358);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(200, 45);
            btnTransactions.TabIndex = 9;
            btnTransactions.Text = "   TRANSACTIONS   ";
            btnTransactions.TextAlign = ContentAlignment.MiddleRight;
            btnTransactions.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransactions.UseVisualStyleBackColor = true;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // btnInventory
            // 
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventory.ForeColor = SystemColors.ControlLightLight;
            btnInventory.Image = (Image)resources.GetObject("btnInventory.Image");
            btnInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventory.Location = new Point(0, 307);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(200, 45);
            btnInventory.TabIndex = 8;
            btnInventory.Text = "   INVENTORY   ";
            btnInventory.TextAlign = ContentAlignment.MiddleRight;
            btnInventory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnAccounts
            // 
            btnAccounts.FlatAppearance.BorderSize = 0;
            btnAccounts.FlatStyle = FlatStyle.Flat;
            btnAccounts.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAccounts.ForeColor = SystemColors.ControlLightLight;
            btnAccounts.Image = (Image)resources.GetObject("btnAccounts.Image");
            btnAccounts.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccounts.Location = new Point(0, 256);
            btnAccounts.Name = "btnAccounts";
            btnAccounts.Size = new Size(200, 45);
            btnAccounts.TabIndex = 7;
            btnAccounts.Text = "   USER ACCOUNTS   ";
            btnAccounts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAccounts.UseVisualStyleBackColor = true;
            btnAccounts.Click += btnAccounts_Click;
            // 
            // btnSignout
            // 
            btnSignout.Dock = DockStyle.Bottom;
            btnSignout.FlatAppearance.BorderSize = 0;
            btnSignout.FlatStyle = FlatStyle.Flat;
            btnSignout.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignout.ForeColor = SystemColors.ControlLightLight;
            btnSignout.Image = (Image)resources.GetObject("btnSignout.Image");
            btnSignout.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignout.Location = new Point(0, 535);
            btnSignout.Name = "btnSignout";
            btnSignout.Size = new Size(190, 45);
            btnSignout.TabIndex = 5;
            btnSignout.Text = "   SIGN OUT   ";
            btnSignout.TextAlign = ContentAlignment.MiddleRight;
            btnSignout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSignout.UseVisualStyleBackColor = true;
            btnSignout.Click += btnSignout_Click;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ControlLightLight;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 580);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(190, 45);
            btnExit.TabIndex = 4;
            btnExit.Text = "   EXIT   ";
            btnExit.TextAlign = ContentAlignment.MiddleRight;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.ControlLightLight;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 205);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(200, 45);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "   HOME   ";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlContainerAdmin
            // 
            pnlContainerAdmin.Dock = DockStyle.Fill;
            pnlContainerAdmin.Location = new Point(190, 0);
            pnlContainerAdmin.Name = "pnlContainerAdmin";
            pnlContainerAdmin.Size = new Size(780, 625);
            pnlContainerAdmin.TabIndex = 1;
            // 
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.ImageScalingSize = new Size(20, 20);
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new Size(61, 4);
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 54, 64);
            ClientSize = new Size(970, 625);
            Controls.Add(pnlContainerAdmin);
            Controls.Add(pnlAdminMenu);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            pnlAdminMenu.ResumeLayout(false);
            pnlAdminMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAdminMenu;
        private Button btnDashboard;
        private Button btnSignout;
        private Button btnExit;
        private Label label1;
        private Button btnTransactions;
        private Button btnInventory;
        private Button btnAccounts;
        private Panel panel1;
        private Panel pnlContainerAdmin;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
    }
}