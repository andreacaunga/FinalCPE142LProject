namespace FinalCPE142LProject
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            pnlAdminMenu = new Panel();
            btnMenu = new PictureBox();
            btnTransactions = new Button();
            btnInventory = new Button();
            btnAccounts = new Button();
            btnSignout = new Button();
            btnExit = new Button();
            btnDashboard = new Button();
            pnlContainerAdmin = new Panel();
            menuTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            pnlAdminMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            SuspendLayout();
            // 
            // pnlAdminMenu
            // 
            pnlAdminMenu.BackColor = Color.FromArgb(53, 59, 72);
            pnlAdminMenu.Controls.Add(label1);
            pnlAdminMenu.Controls.Add(btnMenu);
            pnlAdminMenu.Controls.Add(btnTransactions);
            pnlAdminMenu.Controls.Add(btnInventory);
            pnlAdminMenu.Controls.Add(btnAccounts);
            pnlAdminMenu.Controls.Add(btnSignout);
            pnlAdminMenu.Controls.Add(btnExit);
            pnlAdminMenu.Controls.Add(btnDashboard);
            pnlAdminMenu.Dock = DockStyle.Left;
            pnlAdminMenu.Location = new Point(0, 0);
            pnlAdminMenu.MaximumSize = new Size(190, 625);
            pnlAdminMenu.MinimumSize = new Size(50, 625);
            pnlAdminMenu.Name = "pnlAdminMenu";
            pnlAdminMenu.Size = new Size(190, 625);
            pnlAdminMenu.TabIndex = 0;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(3, 69);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(40, 40);
            btnMenu.SizeMode = PictureBoxSizeMode.AutoSize;
            btnMenu.TabIndex = 11;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
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
            btnTransactions.Size = new Size(190, 45);
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
            btnInventory.Size = new Size(190, 45);
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
            btnAccounts.Size = new Size(190, 45);
            btnAccounts.TabIndex = 7;
            btnAccounts.Text = "   USER ACCOUNTS   ";
            btnAccounts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAccounts.UseVisualStyleBackColor = true;
            btnAccounts.Click += btnAccounts_Click;
            // 
            // btnSignout
            // 
            btnSignout.FlatAppearance.BorderSize = 0;
            btnSignout.FlatStyle = FlatStyle.Flat;
            btnSignout.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignout.ForeColor = SystemColors.ControlLightLight;
            btnSignout.Image = (Image)resources.GetObject("btnSignout.Image");
            btnSignout.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignout.Location = new Point(0, 523);
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
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ControlLightLight;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 568);
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
            btnDashboard.Size = new Size(190, 45);
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
            // menuTimer
            // 
            menuTimer.Interval = 10;
            menuTimer.Tick += menuTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Square721 BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(74, 79);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 12;
            label1.Text = "ADMIN";
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 54, 64);
            ClientSize = new Size(970, 625);
            Controls.Add(pnlContainerAdmin);
            Controls.Add(pnlAdminMenu);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "AdminPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            pnlAdminMenu.ResumeLayout(false);
            pnlAdminMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAdminMenu;
        private Button btnDashboard;
        private Button btnSignout;
        private Button btnExit;
        private Button btnTransactions;
        private Button btnInventory;
        private Button btnAccounts;
        private Panel pnlContainerAdmin;
        private System.Windows.Forms.Timer menuTimer;
        private PictureBox btnMenu;
        private Label label1;
    }
}