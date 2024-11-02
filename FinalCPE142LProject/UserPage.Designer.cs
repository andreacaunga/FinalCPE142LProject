namespace FinalCPE142LProject
{
    partial class UserPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPage));
            pnlAdminMenu = new Panel();
            btnSignout = new Button();
            btnExit = new Button();
            btnMyAccount = new Button();
            btnCart = new Button();
            btnShop = new Button();
            btnHome = new Button();
            pnlContainerMain = new Panel();
            shopContainer = new Panel();
            btnMBoard = new Button();
            btnRAM = new Button();
            btnGPU = new Button();
            btnCPU = new Button();
            sidebar = new FlowLayoutPanel();
            panel2 = new Panel();
            label2 = new Label();
            btnMenu = new PictureBox();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            shopTimer = new System.Windows.Forms.Timer(components);
            pnlAdminMenu.SuspendLayout();
            shopContainer.SuspendLayout();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            SuspendLayout();
            // 
            // pnlAdminMenu
            // 
            pnlAdminMenu.BackColor = Color.FromArgb(53, 59, 72);
            pnlAdminMenu.Controls.Add(btnSignout);
            pnlAdminMenu.Controls.Add(btnExit);
            pnlAdminMenu.Dock = DockStyle.Bottom;
            pnlAdminMenu.Location = new Point(3, 432);
            pnlAdminMenu.Name = "pnlAdminMenu";
            pnlAdminMenu.Size = new Size(190, 298);
            pnlAdminMenu.TabIndex = 1;
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
            btnSignout.Location = new Point(0, 208);
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
            btnExit.Location = new Point(0, 253);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(190, 45);
            btnExit.TabIndex = 4;
            btnExit.Text = "   EXIT   ";
            btnExit.TextAlign = ContentAlignment.MiddleRight;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnMyAccount
            // 
            btnMyAccount.FlatAppearance.BorderSize = 0;
            btnMyAccount.FlatStyle = FlatStyle.Flat;
            btnMyAccount.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMyAccount.ForeColor = SystemColors.ControlLightLight;
            btnMyAccount.Image = (Image)resources.GetObject("btnMyAccount.Image");
            btnMyAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnMyAccount.Location = new Point(3, 381);
            btnMyAccount.Name = "btnMyAccount";
            btnMyAccount.Size = new Size(190, 45);
            btnMyAccount.TabIndex = 9;
            btnMyAccount.Text = "   MY ACCOUNT";
            btnMyAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMyAccount.UseVisualStyleBackColor = true;
            btnMyAccount.Click += btnMyAccount_Click;
            // 
            // btnCart
            // 
            btnCart.FlatAppearance.BorderSize = 0;
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCart.ForeColor = SystemColors.ControlLightLight;
            btnCart.Image = (Image)resources.GetObject("btnCart.Image");
            btnCart.ImageAlign = ContentAlignment.MiddleLeft;
            btnCart.Location = new Point(3, 330);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(190, 45);
            btnCart.TabIndex = 8;
            btnCart.Text = "   CART   ";
            btnCart.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCart.UseVisualStyleBackColor = true;
            btnCart.Click += btnCart_Click;
            // 
            // btnShop
            // 
            btnShop.BackColor = Color.FromArgb(53, 59, 72);
            btnShop.Dock = DockStyle.Top;
            btnShop.FlatAppearance.BorderSize = 0;
            btnShop.FlatStyle = FlatStyle.Flat;
            btnShop.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShop.ForeColor = SystemColors.ControlLightLight;
            btnShop.Image = (Image)resources.GetObject("btnShop.Image");
            btnShop.ImageAlign = ContentAlignment.MiddleLeft;
            btnShop.Location = new Point(0, 0);
            btnShop.Name = "btnShop";
            btnShop.Size = new Size(190, 45);
            btnShop.TabIndex = 7;
            btnShop.Text = "   SHOP   ";
            btnShop.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnShop.UseVisualStyleBackColor = false;
            btnShop.Click += btnShop_Click;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = SystemColors.ControlLightLight;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(3, 108);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(190, 45);
            btnHome.TabIndex = 0;
            btnHome.Text = "   HOME   ";
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // pnlContainerMain
            // 
            pnlContainerMain.BackColor = Color.FromArgb(47, 54, 64);
            pnlContainerMain.Dock = DockStyle.Fill;
            pnlContainerMain.Location = new Point(190, 0);
            pnlContainerMain.Name = "pnlContainerMain";
            pnlContainerMain.Size = new Size(780, 625);
            pnlContainerMain.TabIndex = 2;
            // 
            // shopContainer
            // 
            shopContainer.Controls.Add(btnMBoard);
            shopContainer.Controls.Add(btnRAM);
            shopContainer.Controls.Add(btnGPU);
            shopContainer.Controls.Add(btnCPU);
            shopContainer.Controls.Add(btnShop);
            shopContainer.Location = new Point(3, 159);
            shopContainer.MaximumSize = new Size(190, 165);
            shopContainer.MinimumSize = new Size(190, 45);
            shopContainer.Name = "shopContainer";
            shopContainer.Size = new Size(190, 165);
            shopContainer.TabIndex = 1;
            // 
            // btnMBoard
            // 
            btnMBoard.BackColor = Color.FromArgb(66, 73, 87);
            btnMBoard.Dock = DockStyle.Top;
            btnMBoard.FlatAppearance.BorderSize = 0;
            btnMBoard.FlatStyle = FlatStyle.Flat;
            btnMBoard.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMBoard.ForeColor = SystemColors.ControlLightLight;
            btnMBoard.ImageAlign = ContentAlignment.MiddleLeft;
            btnMBoard.Location = new Point(0, 135);
            btnMBoard.Name = "btnMBoard";
            btnMBoard.Size = new Size(190, 30);
            btnMBoard.TabIndex = 11;
            btnMBoard.Text = "             MOTHERBOARD";
            btnMBoard.TextAlign = ContentAlignment.MiddleLeft;
            btnMBoard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMBoard.UseVisualStyleBackColor = false;
            btnMBoard.Click += btnMBoard_Click;
            // 
            // btnRAM
            // 
            btnRAM.BackColor = Color.FromArgb(66, 73, 87);
            btnRAM.Dock = DockStyle.Top;
            btnRAM.FlatAppearance.BorderSize = 0;
            btnRAM.FlatStyle = FlatStyle.Flat;
            btnRAM.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRAM.ForeColor = SystemColors.ControlLightLight;
            btnRAM.ImageAlign = ContentAlignment.MiddleLeft;
            btnRAM.Location = new Point(0, 105);
            btnRAM.Name = "btnRAM";
            btnRAM.Size = new Size(190, 30);
            btnRAM.TabIndex = 10;
            btnRAM.Text = "             RAM";
            btnRAM.TextAlign = ContentAlignment.MiddleLeft;
            btnRAM.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRAM.UseVisualStyleBackColor = false;
            btnRAM.Click += btnRAM_Click;
            // 
            // btnGPU
            // 
            btnGPU.BackColor = Color.FromArgb(66, 73, 87);
            btnGPU.Dock = DockStyle.Top;
            btnGPU.FlatAppearance.BorderSize = 0;
            btnGPU.FlatStyle = FlatStyle.Flat;
            btnGPU.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGPU.ForeColor = SystemColors.ControlLightLight;
            btnGPU.ImageAlign = ContentAlignment.MiddleLeft;
            btnGPU.Location = new Point(0, 75);
            btnGPU.Name = "btnGPU";
            btnGPU.Size = new Size(190, 30);
            btnGPU.TabIndex = 9;
            btnGPU.Text = "             GPU";
            btnGPU.TextAlign = ContentAlignment.MiddleLeft;
            btnGPU.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGPU.UseVisualStyleBackColor = false;
            btnGPU.Click += btnGPU_Click;
            // 
            // btnCPU
            // 
            btnCPU.BackColor = Color.FromArgb(66, 73, 87);
            btnCPU.Dock = DockStyle.Top;
            btnCPU.FlatAppearance.BorderSize = 0;
            btnCPU.FlatStyle = FlatStyle.Flat;
            btnCPU.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCPU.ForeColor = SystemColors.ControlLightLight;
            btnCPU.ImageAlign = ContentAlignment.TopLeft;
            btnCPU.Location = new Point(0, 45);
            btnCPU.Name = "btnCPU";
            btnCPU.Size = new Size(190, 30);
            btnCPU.TabIndex = 8;
            btnCPU.Text = "             CPU";
            btnCPU.TextAlign = ContentAlignment.MiddleLeft;
            btnCPU.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCPU.UseVisualStyleBackColor = false;
            btnCPU.Click += btnCPU_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(53, 59, 72);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(btnHome);
            sidebar.Controls.Add(shopContainer);
            sidebar.Controls.Add(btnCart);
            sidebar.Controls.Add(btnMyAccount);
            sidebar.Controls.Add(pnlAdminMenu);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(190, 625);
            sidebar.MinimumSize = new Size(55, 625);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(190, 625);
            sidebar.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnMenu);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(187, 99);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Square721 Cn BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(56, 40);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 2;
            label2.Text = "MENU";
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(3, 29);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(40, 40);
            btnMenu.SizeMode = PictureBoxSizeMode.AutoSize;
            btnMenu.TabIndex = 1;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // shopTimer
            // 
            shopTimer.Interval = 10;
            shopTimer.Tick += shopTimer_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 625);
            Controls.Add(pnlContainerMain);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            IsMdiContainer = true;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            pnlAdminMenu.ResumeLayout(false);
            shopContainer.ResumeLayout(false);
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAdminMenu;
        private Button btnMyAccount;
        private Button btnCart;
        private Button btnShop;
        private Button btnSignout;
        private Button btnExit;
        private Button btnHome;
        private Panel pnlContainerMain;
        private FlowLayoutPanel sidebar;
        private Panel panel2;
        private Label label2;
        private PictureBox btnMenu;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel shopContainer;
        private Button btnMBoard;
        private Button btnRAM;
        private Button btnGPU;
        private Button btnCPU;
        private System.Windows.Forms.Timer shopTimer;
    }
}