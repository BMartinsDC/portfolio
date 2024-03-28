namespace ASG
{
    partial class Accueil
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
            dgvMesFormations = new DataGridView();
            centreDeFormation = new DataGridViewTextBoxColumn();
            nbDeJours = new DataGridViewTextBoxColumn();
            prerequis = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvMesFormations).BeginInit();
            SuspendLayout();
            // 
            // dgvMesFormations
            // 
            dgvMesFormations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMesFormations.Columns.AddRange(new DataGridViewColumn[] { centreDeFormation, nbDeJours, prerequis });
            dgvMesFormations.Location = new Point(1, 0);
            dgvMesFormations.Name = "dgvMesFormations";
            dgvMesFormations.RowTemplate.Height = 25;
            dgvMesFormations.Size = new Size(360, 139);
            dgvMesFormations.TabIndex = 0;
            dgvMesFormations.CellContentClick += dgvMesFormations_CellContentClick;
            // 
            // centreDeFormation
            // 
            centreDeFormation.HeaderText = "Centre de Formation";
            centreDeFormation.Name = "centreDeFormation";
            // 
            // nbDeJours
            // 
            nbDeJours.HeaderText = "Nombre de jours";
            nbDeJours.Name = "nbDeJours";
            // 
            // prerequis
            // 
            prerequis.HeaderText = "Prérequis";
            prerequis.Name = "prerequis";
            // 
            // Accueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 139);
            Controls.Add(dgvMesFormations);
            Name = "Accueil";
            Text = "Accueil";
            Load += Accueil_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMesFormations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMesFormations;
        private DataGridViewTextBoxColumn centreDeFormation;
        private DataGridViewTextBoxColumn nbDeJours;
        private DataGridViewTextBoxColumn prerequis;
    }
}