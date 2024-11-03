namespace FinalCPE142LProject
{
    partial class Login
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lblSignup = new Label();
            label1 = new Label();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            chkboxShowPass = new CheckBox();
            btnCLose = new Label();
            SuspendLayout();
            // 
            // lblSignup
            // 
            lblSignup.AutoSize = true;
            lblSignup.BackColor = Color.FromArgb(47, 54, 64);
            lblSignup.Cursor = Cursors.Hand;
            lblSignup.Font = new Font("Square721 Cn BT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignup.ForeColor = SystemColors.ControlLightLight;
            lblSignup.Location = new Point(223, 471);
            lblSignup.Name = "lblSignup";
            lblSignup.Size = new Size(51, 18);
            lblSignup.TabIndex = 23;
            lblSignup.Text = "Sign up";
            lblSignup.Click += lblSignup_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(47, 54, 64);
            label1.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(94, 471);
            label1.Name = "label1";
            label1.Size = new Size(131, 18);
            label1.TabIndex = 22;
            label1.Text = "Don't have an account?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(47, 54, 64);
            btnLogin.BorderRadius = 18;
            btnLogin.CustomizableEdges = customizableEdges7;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.FromArgb(41, 45, 53);
            btnLogin.Font = new Font("Square721 Cn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(94, 403);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnLogin.Size = new Size(100, 37);
            btnLogin.TabIndex = 21;
            btnLogin.Text = "LOGIN";
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(47, 54, 64);
            txtPass.BorderColor = Color.WhiteSmoke;
            txtPass.BorderRadius = 6;
            txtPass.CustomizableEdges = customizableEdges9;
            txtPass.DefaultText = "";
            txtPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPass.FillColor = Color.FromArgb(47, 54, 64);
            txtPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPass.Font = new Font("Square721 Cn BT", 10.2F);
            txtPass.ForeColor = Color.White;
            txtPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPass.Location = new Point(94, 323);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '•';
            txtPass.PlaceholderText = "";
            txtPass.SelectedText = "";
            txtPass.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtPass.Size = new Size(243, 32);
            txtPass.TabIndex = 20;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(47, 54, 64);
            txtUser.BorderColor = Color.WhiteSmoke;
            txtUser.BorderRadius = 6;
            txtUser.CustomizableEdges = customizableEdges11;
            txtUser.DefaultText = "";
            txtUser.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUser.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUser.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUser.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUser.FillColor = Color.FromArgb(47, 54, 64);
            txtUser.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUser.Font = new Font("Square721 Cn BT", 10.2F);
            txtUser.ForeColor = Color.White;
            txtUser.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUser.Location = new Point(94, 238);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.PasswordChar = '\0';
            txtUser.PlaceholderText = "";
            txtUser.SelectedText = "";
            txtUser.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtUser.Size = new Size(243, 32);
            txtUser.TabIndex = 19;
            // 
            // chkboxShowPass
            // 
            chkboxShowPass.AutoSize = true;
            chkboxShowPass.BackColor = Color.Transparent;
            chkboxShowPass.Font = new Font("Square721 Cn BT", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkboxShowPass.ForeColor = Color.White;
            chkboxShowPass.Location = new Point(233, 359);
            chkboxShowPass.Name = "chkboxShowPass";
            chkboxShowPass.Size = new Size(104, 20);
            chkboxShowPass.TabIndex = 24;
            chkboxShowPass.Text = "Show password";
            chkboxShowPass.UseVisualStyleBackColor = false;
            chkboxShowPass.CheckedChanged += chkboxShowPass_CheckedChanged;
            // 
            // btnCLose
            // 
            btnCLose.AutoSize = true;
            btnCLose.Cursor = Cursors.Hand;
            btnCLose.Image = (Image)resources.GetObject("btnCLose.Image");
            btnCLose.Location = new Point(934, 20);
            btnCLose.Name = "btnCLose";
            btnCLose.Size = new Size(13, 20);
            btnCLose.TabIndex = 25;
            btnCLose.Text = " ";
            btnCLose.Click += btnCLose_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(970, 625);
            Controls.Add(btnCLose);
            Controls.Add(chkboxShowPass);
            Controls.Add(lblSignup);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSignup;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private CheckBox chkboxShowPass;
        private Label btnCLose;
    }
}