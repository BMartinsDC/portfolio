namespace ASG
{
    partial class frmConnexion
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
            labelBienvenue = new Label();
            labelLogin = new Label();
            labelPassword = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // labelBienvenue
            // 
            labelBienvenue.AutoSize = true;
            labelBienvenue.Location = new Point(138, 9);
            labelBienvenue.Name = "labelBienvenue";
            labelBienvenue.Size = new Size(68, 15);
            labelBienvenue.TabIndex = 0;
            labelBienvenue.Text = "Bienvenue !";
            labelBienvenue.Click += labelBienvenue_Click;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(51, 42);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(37, 15);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Login";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(51, 71);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(179, 39);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(137, 23);
            textBoxLogin.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(179, 68);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(137, 23);
            textBoxPassword.TabIndex = 4;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(129, 104);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(88, 23);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Se connecter";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // frmConnexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 139);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(labelBienvenue);
            Name = "frmConnexion";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBienvenue;
        private Label labelLogin;
        private Label labelPassword;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button buttonLogin;
    }
}