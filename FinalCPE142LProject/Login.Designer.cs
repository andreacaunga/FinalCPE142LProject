namespace FinalCPE142LProject
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            label4 = new Label();
            lblSignup = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(143, 41);
            label1.Name = "label1";
            label1.Size = new Size(127, 54);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 115);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(75, 209);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(81, 150);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(267, 34);
            txtUser.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(81, 244);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(267, 34);
            txtPass.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Peru;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(163, 314);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 34);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(111, 367);
            label4.Name = "label4";
            label4.Size = new Size(143, 17);
            label4.TabIndex = 6;
            label4.Text = "Don't have an account?";
            label4.Click += lblSignup_Click;
            // 
            // lblSignup
            // 
            lblSignup.AutoSize = true;
            lblSignup.Cursor = Cursors.Hand;
            lblSignup.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignup.Location = new Point(252, 367);
            lblSignup.Name = "lblSignup";
            lblSignup.Size = new Size(55, 17);
            lblSignup.TabIndex = 7;
            lblSignup.Text = "Sign up";
            lblSignup.Click += lblSignup_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(431, 427);
            Controls.Add(lblSignup);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;
        private Label label4;
        private Label lblSignup;
    }
}
