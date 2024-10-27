namespace FinalCPE142LProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pnlAdminMenu = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            btnMyAccount = new Button();
            btnCart = new Button();
            btnShop = new Button();
            btnSignout = new Button();
            btnExit = new Button();
            btnHome = new Button();
            pnlContainerMain = new Panel();
            pnlAdminMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAdminMenu
            // 
            pnlAdminMenu.BackColor = Color.FromArgb(53, 59, 72);
            pnlAdminMenu.Controls.Add(label1);
            pnlAdminMenu.Controls.Add(panel1);
            pnlAdminMenu.Controls.Add(btnMyAccount);
            pnlAdminMenu.Controls.Add(btnCart);
            pnlAdminMenu.Controls.Add(btnShop);
            pnlAdminMenu.Controls.Add(btnSignout);
            pnlAdminMenu.Controls.Add(btnExit);
            pnlAdminMenu.Controls.Add(btnHome);
            pnlAdminMenu.Dock = DockStyle.Left;
            pnlAdminMenu.Location = new Point(0, 0);
            pnlAdminMenu.Name = "pnlAdminMenu";
            pnlAdminMenu.Size = new Size(190, 625);
            pnlAdminMenu.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Square721 Cn BT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(64, 147);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 6;
            label1.Text = "[NAME]";
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
            // btnMyAccount
            // 
            btnMyAccount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnMyAccount.FlatAppearance.BorderSize = 0;
            btnMyAccount.FlatStyle = FlatStyle.Flat;
            btnMyAccount.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMyAccount.ForeColor = SystemColors.ControlLightLight;
            btnMyAccount.Image = (Image)resources.GetObject("btnMyAccount.Image");
            btnMyAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnMyAccount.Location = new Point(0, 358);
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
            btnCart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCart.FlatAppearance.BorderSize = 0;
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCart.ForeColor = SystemColors.ControlLightLight;
            btnCart.Image = (Image)resources.GetObject("btnCart.Image");
            btnCart.ImageAlign = ContentAlignment.MiddleLeft;
            btnCart.Location = new Point(0, 307);
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
            btnShop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnShop.FlatAppearance.BorderSize = 0;
            btnShop.FlatStyle = FlatStyle.Flat;
            btnShop.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShop.ForeColor = SystemColors.ControlLightLight;
            btnShop.Image = (Image)resources.GetObject("btnShop.Image");
            btnShop.ImageAlign = ContentAlignment.MiddleLeft;
            btnShop.Location = new Point(0, 256);
            btnShop.Name = "btnShop";
            btnShop.Size = new Size(190, 45);
            btnShop.TabIndex = 7;
            btnShop.Text = "   SHOP   ";
            btnShop.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnShop.UseVisualStyleBackColor = true;
            btnShop.Click += btnShop_Click;
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
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = SystemColors.ControlLightLight;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 205);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(200, 45);
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
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 625);
            Controls.Add(pnlContainerMain);
            Controls.Add(pnlAdminMenu);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            IsMdiContainer = true;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            pnlAdminMenu.ResumeLayout(false);
            pnlAdminMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAdminMenu;
        private Label label1;
        private Panel panel1;
        private Button btnMyAccount;
        private Button btnCart;
        private Button btnShop;
        private Button btnSignout;
        private Button btnExit;
        private Button btnHome;
        private Panel pnlContainerMain;
    }
}