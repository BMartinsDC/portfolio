namespace TP5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.animalbutton = new System.Windows.Forms.Button();
            this.animaltext2 = new System.Windows.Forms.TextBox();
            this.animallabel2 = new System.Windows.Forms.Label();
            this.animaltext1 = new System.Windows.Forms.TextBox();
            this.animallabel1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.oiseaubutton = new System.Windows.Forms.Button();
            this.oiseautext1 = new System.Windows.Forms.TextBox();
            this.oiseaulabel1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.felintext1 = new System.Windows.Forms.TextBox();
            this.felinlabel1 = new System.Windows.Forms.Label();
            this.felinbutton = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chatbutton = new System.Windows.Forms.Button();
            this.chatlabel1 = new System.Windows.Forms.Label();
            this.chattext1 = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.archenum3 = new System.Windows.Forms.Label();
            this.archenum2 = new System.Windows.Forms.Label();
            this.archenum1 = new System.Windows.Forms.Label();
            this.archelabel3 = new System.Windows.Forms.Label();
            this.archelabel2 = new System.Windows.Forms.Label();
            this.archelabel1 = new System.Windows.Forms.Label();
            this.buttonquit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(481, 273);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.animalbutton);
            this.tabPage1.Controls.Add(this.animaltext2);
            this.tabPage1.Controls.Add(this.animallabel2);
            this.tabPage1.Controls.Add(this.animaltext1);
            this.tabPage1.Controls.Add(this.animallabel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(473, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Créer un Animal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // animalbutton
            // 
            this.animalbutton.Location = new System.Drawing.Point(167, 165);
            this.animalbutton.Name = "animalbutton";
            this.animalbutton.Size = new System.Drawing.Size(133, 28);
            this.animalbutton.TabIndex = 4;
            this.animalbutton.Text = "Ajouter l\'animal";
            this.animalbutton.UseVisualStyleBackColor = true;
            this.animalbutton.Click += new System.EventHandler(this.animalbutton_Click);
            // 
            // animaltext2
            // 
            this.animaltext2.Location = new System.Drawing.Point(235, 97);
            this.animaltext2.Name = "animaltext2";
            this.animaltext2.Size = new System.Drawing.Size(173, 23);
            this.animaltext2.TabIndex = 3;
            // 
            // animallabel2
            // 
            this.animallabel2.AutoSize = true;
            this.animallabel2.Location = new System.Drawing.Point(72, 100);
            this.animallabel2.Name = "animallabel2";
            this.animallabel2.Size = new System.Drawing.Size(108, 15);
            this.animallabel2.TabIndex = 2;
            this.animallabel2.Text = "Nombre de pattes :";
            // 
            // animaltext1
            // 
            this.animaltext1.Location = new System.Drawing.Point(235, 37);
            this.animaltext1.Name = "animaltext1";
            this.animaltext1.Size = new System.Drawing.Size(173, 23);
            this.animaltext1.TabIndex = 1;
            // 
            // animallabel1
            // 
            this.animallabel1.AutoSize = true;
            this.animallabel1.Location = new System.Drawing.Point(72, 40);
            this.animallabel1.Name = "animallabel1";
            this.animallabel1.Size = new System.Drawing.Size(49, 15);
            this.animallabel1.TabIndex = 0;
            this.animallabel1.Text = "Espèce :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.oiseaubutton);
            this.tabPage2.Controls.Add(this.oiseautext1);
            this.tabPage2.Controls.Add(this.oiseaulabel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(473, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Créer un Oiseau";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // oiseaubutton
            // 
            this.oiseaubutton.Location = new System.Drawing.Point(167, 165);
            this.oiseaubutton.Name = "oiseaubutton";
            this.oiseaubutton.Size = new System.Drawing.Size(133, 28);
            this.oiseaubutton.TabIndex = 2;
            this.oiseaubutton.Text = "Ajouter l\'oiseau";
            this.oiseaubutton.UseVisualStyleBackColor = true;
            this.oiseaubutton.Click += new System.EventHandler(this.oiseaubutton_Click);
            // 
            // oiseautext1
            // 
            this.oiseautext1.Location = new System.Drawing.Point(235, 37);
            this.oiseautext1.Name = "oiseautext1";
            this.oiseautext1.Size = new System.Drawing.Size(173, 23);
            this.oiseautext1.TabIndex = 1;
            // 
            // oiseaulabel1
            // 
            this.oiseaulabel1.AutoSize = true;
            this.oiseaulabel1.Location = new System.Drawing.Point(72, 40);
            this.oiseaulabel1.Name = "oiseaulabel1";
            this.oiseaulabel1.Size = new System.Drawing.Size(118, 15);
            this.oiseaulabel1.TabIndex = 0;
            this.oiseaulabel1.Text = "Couleur des plumes :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.felintext1);
            this.tabPage3.Controls.Add(this.felinlabel1);
            this.tabPage3.Controls.Add(this.felinbutton);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(473, 245);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Créer un Félin";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // felintext1
            // 
            this.felintext1.Location = new System.Drawing.Point(214, 37);
            this.felintext1.Name = "felintext1";
            this.felintext1.Size = new System.Drawing.Size(173, 23);
            this.felintext1.TabIndex = 2;
            // 
            // felinlabel1
            // 
            this.felinlabel1.AutoSize = true;
            this.felinlabel1.Location = new System.Drawing.Point(72, 40);
            this.felinlabel1.Name = "felinlabel1";
            this.felinlabel1.Size = new System.Drawing.Size(49, 15);
            this.felinlabel1.TabIndex = 1;
            this.felinlabel1.Text = "Espèce :";
            // 
            // felinbutton
            // 
            this.felinbutton.Location = new System.Drawing.Point(167, 165);
            this.felinbutton.Name = "felinbutton";
            this.felinbutton.Size = new System.Drawing.Size(133, 28);
            this.felinbutton.TabIndex = 0;
            this.felinbutton.Text = "Ajouter le félin";
            this.felinbutton.UseVisualStyleBackColor = true;
            this.felinbutton.Click += new System.EventHandler(this.felinbutton_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chatbutton);
            this.tabPage4.Controls.Add(this.chatlabel1);
            this.tabPage4.Controls.Add(this.chattext1);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(473, 245);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Créer un Chat";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chatbutton
            // 
            this.chatbutton.Location = new System.Drawing.Point(167, 165);
            this.chatbutton.Name = "chatbutton";
            this.chatbutton.Size = new System.Drawing.Size(133, 28);
            this.chatbutton.TabIndex = 5;
            this.chatbutton.Text = "Ajouter le chat";
            this.chatbutton.UseVisualStyleBackColor = true;
            this.chatbutton.Click += new System.EventHandler(this.chatbutton_Click);
            // 
            // chatlabel1
            // 
            this.chatlabel1.AutoSize = true;
            this.chatlabel1.Location = new System.Drawing.Point(72, 40);
            this.chatlabel1.Name = "chatlabel1";
            this.chatlabel1.Size = new System.Drawing.Size(40, 15);
            this.chatlabel1.TabIndex = 4;
            this.chatlabel1.Text = "Nom :";
            // 
            // chattext1
            // 
            this.chattext1.Location = new System.Drawing.Point(214, 37);
            this.chattext1.Name = "chattext1";
            this.chattext1.Size = new System.Drawing.Size(173, 23);
            this.chattext1.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.archenum3);
            this.tabPage5.Controls.Add(this.archenum2);
            this.tabPage5.Controls.Add(this.archenum1);
            this.tabPage5.Controls.Add(this.archelabel3);
            this.tabPage5.Controls.Add(this.archelabel2);
            this.tabPage5.Controls.Add(this.archelabel1);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(473, 245);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Contenu de l\'Arche";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // archenum3
            // 
            this.archenum3.AutoSize = true;
            this.archenum3.Location = new System.Drawing.Point(300, 160);
            this.archenum3.Name = "archenum3";
            this.archenum3.Size = new System.Drawing.Size(13, 15);
            this.archenum3.TabIndex = 5;
            this.archenum3.Text = "0";
            // 
            // archenum2
            // 
            this.archenum2.AutoSize = true;
            this.archenum2.Location = new System.Drawing.Point(300, 100);
            this.archenum2.Name = "archenum2";
            this.archenum2.Size = new System.Drawing.Size(13, 15);
            this.archenum2.TabIndex = 4;
            this.archenum2.Text = "0";
            // 
            // archenum1
            // 
            this.archenum1.AutoSize = true;
            this.archenum1.Location = new System.Drawing.Point(300, 40);
            this.archenum1.Name = "archenum1";
            this.archenum1.Size = new System.Drawing.Size(13, 15);
            this.archenum1.TabIndex = 3;
            this.archenum1.Text = "0";
            // 
            // archelabel3
            // 
            this.archelabel3.AutoSize = true;
            this.archelabel3.Location = new System.Drawing.Point(72, 160);
            this.archelabel3.Name = "archelabel3";
            this.archelabel3.Size = new System.Drawing.Size(170, 15);
            this.archelabel3.TabIndex = 2;
            this.archelabel3.Text = "Nombre de chats dans l\'arche :";
            // 
            // archelabel2
            // 
            this.archelabel2.AutoSize = true;
            this.archelabel2.Location = new System.Drawing.Point(72, 100);
            this.archelabel2.Name = "archelabel2";
            this.archelabel2.Size = new System.Drawing.Size(176, 30);
            this.archelabel2.TabIndex = 1;
            this.archelabel2.Text = "Nombre d\'oiseaux dans l\'arche :\r\n\r\n";
            // 
            // archelabel1
            // 
            this.archelabel1.AutoSize = true;
            this.archelabel1.Location = new System.Drawing.Point(72, 40);
            this.archelabel1.Name = "archelabel1";
            this.archelabel1.Size = new System.Drawing.Size(182, 15);
            this.archelabel1.TabIndex = 0;
            this.archelabel1.Text = "Nombre d\'animaux dans l\'arche :\r\n";
            // 
            // buttonquit
            // 
            this.buttonquit.Location = new System.Drawing.Point(414, 291);
            this.buttonquit.Name = "buttonquit";
            this.buttonquit.Size = new System.Drawing.Size(75, 23);
            this.buttonquit.TabIndex = 0;
            this.buttonquit.Text = "Quitter";
            this.buttonquit.UseVisualStyleBackColor = true;
            this.buttonquit.Click += new System.EventHandler(this.buttonquit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 324);
            this.Controls.Add(this.buttonquit);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Arche de Noe";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button buttonquit;
        private Label animallabel2;
        private TextBox animaltext1;
        private Label animallabel1;
        private Button animalbutton;
        private TextBox animaltext2;
        private TextBox oiseautext1;
        private Label oiseaulabel1;
        private Button oiseaubutton;
        private Button felinbutton;
        private TextBox felintext1;
        private Label felinlabel1;
        private Button chatbutton;
        private Label chatlabel1;
        private TextBox chattext1;
        private Label archelabel3;
        private Label archelabel2;
        private Label archelabel1;
        private Label archenum1;
        private Label archenum3;
        private Label archenum2;
    }
}