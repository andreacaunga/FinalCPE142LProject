namespace FinalCPE142LProject
{
    partial class Signup
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
            txtPass = new TextBox();
            txtFname = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnSignup = new Button();
            label1 = new Label();
            txtLname = new TextBox();
            label4 = new Label();
            txtUser = new TextBox();
            label5 = new Label();
            txtConPass = new TextBox();
            label6 = new Label();
            lblLogin = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(291, 228);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(205, 34);
            txtPass.TabIndex = 8;
            // 
            // txtFname
            // 
            txtFname.BorderStyle = BorderStyle.FixedSingle;
            txtFname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFname.Location = new Point(53, 142);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(205, 34);
            txtFname.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(285, 193);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 107);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 5;
            label2.Text = "First name";
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.Peru;
            btnSignup.FlatAppearance.BorderSize = 0;
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup.Location = new Point(354, 322);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(94, 34);
            btnSignup.TabIndex = 9;
            btnSignup.Text = "Sign up";
            btnSignup.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 38);
            label1.Name = "label1";
            label1.Size = new Size(165, 54);
            label1.TabIndex = 10;
            label1.Text = "Sign up";
            // 
            // txtLname
            // 
            txtLname.BorderStyle = BorderStyle.FixedSingle;
            txtLname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLname.Location = new Point(291, 142);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(205, 34);
            txtLname.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(285, 107);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 11;
            label4.Text = "Last name";
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(53, 228);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(205, 34);
            txtUser.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(47, 193);
            label5.Name = "label5";
            label5.Size = new Size(99, 28);
            label5.TabIndex = 13;
            label5.Text = "Username";
            // 
            // txtConPass
            // 
            txtConPass.BorderStyle = BorderStyle.FixedSingle;
            txtConPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConPass.Location = new Point(53, 322);
            txtConPass.Name = "txtConPass";
            txtConPass.Size = new Size(205, 34);
            txtConPass.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(47, 287);
            label6.Name = "label6";
            label6.Size = new Size(170, 28);
            label6.TabIndex = 15;
            label6.Text = "Confirm password";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Cursor = Cursors.Hand;
            lblLogin.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(455, 377);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(43, 17);
            lblLogin.TabIndex = 18;
            lblLogin.Text = "Login";
            lblLogin.Click += lblLogin_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(302, 377);
            label7.Name = "label7";
            label7.Size = new Size(156, 17);
            label7.TabIndex = 17;
            label7.Text = "Already have an account?";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(569, 450);
            Controls.Add(lblLogin);
            Controls.Add(label7);
            Controls.Add(txtConPass);
            Controls.Add(label6);
            Controls.Add(txtUser);
            Controls.Add(label5);
            Controls.Add(txtLname);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnSignup);
            Controls.Add(txtPass);
            Controls.Add(txtFname);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPass;
        private TextBox txtFname;
        private Label label3;
        private Label label2;
        private Button btnSignup;
        private Label label1;
        private TextBox txtLname;
        private Label label4;
        private TextBox txtUser;
        private Label label5;
        private TextBox txtConPass;
        private Label label6;
        private Label lblLogin;
        private Label label7;
    }
}