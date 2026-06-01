namespace mediatek86.view
{
    partial class FrmPersonnel
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDemandeSupprPers = new System.Windows.Forms.Button();
            this.btnDemandeModifPers = new System.Windows.Forms.Button();
            this.grbListePersonnel = new System.Windows.Forms.GroupBox();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnregPers = new System.Windows.Forms.Button();
            this.btnAnnulPers = new System.Windows.Forms.Button();
            this.grbPersonnel = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.menuMtk86 = new System.Windows.Forms.MenuStrip();
            this.absencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbListePersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.grbPersonnel.SuspendLayout();
            this.menuMtk86.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDemandeSupprPers
            // 
            this.btnDemandeSupprPers.Location = new System.Drawing.Point(87, 231);
            this.btnDemandeSupprPers.Name = "btnDemandeSupprPers";
            this.btnDemandeSupprPers.Size = new System.Drawing.Size(75, 23);
            this.btnDemandeSupprPers.TabIndex = 2;
            this.btnDemandeSupprPers.Text = "supprimer";
            this.btnDemandeSupprPers.UseVisualStyleBackColor = true;
            this.btnDemandeSupprPers.Click += new System.EventHandler(this.BtnDemandeSupprDev_Click);
            // 
            // btnDemandeModifPers
            // 
            this.btnDemandeModifPers.Location = new System.Drawing.Point(6, 231);
            this.btnDemandeModifPers.Name = "btnDemandeModifPers";
            this.btnDemandeModifPers.Size = new System.Drawing.Size(75, 23);
            this.btnDemandeModifPers.TabIndex = 1;
            this.btnDemandeModifPers.Text = "modifier";
            this.btnDemandeModifPers.UseVisualStyleBackColor = true;
            this.btnDemandeModifPers.Click += new System.EventHandler(this.BtnDemandeModifDev_Click);
            // 
            // grbListePersonnel
            // 
            this.grbListePersonnel.Controls.Add(this.btnDemandeSupprPers);
            this.grbListePersonnel.Controls.Add(this.btnDemandeModifPers);
            this.grbListePersonnel.Controls.Add(this.dgvPersonnel);
            this.grbListePersonnel.Location = new System.Drawing.Point(11, 32);
            this.grbListePersonnel.Name = "grbListePersonnel";
            this.grbListePersonnel.Size = new System.Drawing.Size(605, 264);
            this.grbListePersonnel.TabIndex = 4;
            this.grbListePersonnel.TabStop = false;
            this.grbListePersonnel.Text = "liste du personnel";
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.AllowUserToAddRows = false;
            this.dgvPersonnel.AllowUserToDeleteRows = false;
            this.dgvPersonnel.AllowUserToResizeRows = false;
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(6, 19);
            this.dgvPersonnel.MultiSelect = false;
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.ReadOnly = true;
            this.dgvPersonnel.RowHeadersVisible = false;
            this.dgvPersonnel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnel.Size = new System.Drawing.Size(593, 206);
            this.dgvPersonnel.TabIndex = 0;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(54, 19);
            this.txtNom.MaxLength = 20;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(245, 20);
            this.txtNom.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(54, 45);
            this.txtPrenom.MaxLength = 20;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(245, 20);
            this.txtPrenom.TabIndex = 4;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(354, 45);
            this.txtTel.MaxLength = 15;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(161, 20);
            this.txtTel.TabIndex = 7;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(354, 19);
            this.txtMail.MaxLength = 50;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(245, 20);
            this.txtMail.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mail";
            // 
            // btnEnregPers
            // 
            this.btnEnregPers.Location = new System.Drawing.Point(6, 98);
            this.btnEnregPers.Name = "btnEnregPers";
            this.btnEnregPers.Size = new System.Drawing.Size(75, 23);
            this.btnEnregPers.TabIndex = 9;
            this.btnEnregPers.Text = "enregistrer";
            this.btnEnregPers.UseVisualStyleBackColor = true;
            this.btnEnregPers.Click += new System.EventHandler(this.BtnEnregDev_Click);
            // 
            // btnAnnulPers
            // 
            this.btnAnnulPers.Location = new System.Drawing.Point(87, 98);
            this.btnAnnulPers.Name = "btnAnnulPers";
            this.btnAnnulPers.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulPers.TabIndex = 10;
            this.btnAnnulPers.Text = "annuler";
            this.btnAnnulPers.UseVisualStyleBackColor = true;
            this.btnAnnulPers.Click += new System.EventHandler(this.BtnAnnulDev_Click);
            // 
            // grbPersonnel
            // 
            this.grbPersonnel.Controls.Add(this.label6);
            this.grbPersonnel.Controls.Add(this.cboService);
            this.grbPersonnel.Controls.Add(this.btnAnnulPers);
            this.grbPersonnel.Controls.Add(this.btnEnregPers);
            this.grbPersonnel.Controls.Add(this.label4);
            this.grbPersonnel.Controls.Add(this.label3);
            this.grbPersonnel.Controls.Add(this.label2);
            this.grbPersonnel.Controls.Add(this.txtMail);
            this.grbPersonnel.Controls.Add(this.txtTel);
            this.grbPersonnel.Controls.Add(this.txtPrenom);
            this.grbPersonnel.Controls.Add(this.label1);
            this.grbPersonnel.Controls.Add(this.txtNom);
            this.grbPersonnel.Location = new System.Drawing.Point(11, 304);
            this.grbPersonnel.Name = "grbPersonnel";
            this.grbPersonnel.Size = new System.Drawing.Size(605, 129);
            this.grbPersonnel.TabIndex = 5;
            this.grbPersonnel.TabStop = false;
            this.grbPersonnel.Text = "Ajouter/modifier une personne";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Service";
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(54, 69);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(245, 21);
            this.cboService.TabIndex = 14;
            // 
            // menuMtk86
            // 
            this.menuMtk86.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.absencesToolStripMenuItem,
            this.quToolStripMenuItem});
            this.menuMtk86.Location = new System.Drawing.Point(0, 0);
            this.menuMtk86.Name = "menuMtk86";
            this.menuMtk86.Size = new System.Drawing.Size(707, 24);
            this.menuMtk86.TabIndex = 6;
            this.menuMtk86.Text = "menuStrip1";
            // 
            // absencesToolStripMenuItem
            // 
            this.absencesToolStripMenuItem.Name = "absencesToolStripMenuItem";
            this.absencesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.absencesToolStripMenuItem.Text = "Absences";
            this.absencesToolStripMenuItem.Click += new System.EventHandler(this.absencesToolStripMenuItem_Click);
            // 
            // quToolStripMenuItem
            // 
            this.quToolStripMenuItem.Name = "quToolStripMenuItem";
            this.quToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quToolStripMenuItem.Text = "Quitter";
            this.quToolStripMenuItem.Click += new System.EventHandler(this.quToolStripMenuItem_Click);
            // 
            // FrmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 443);
            this.Controls.Add(this.grbPersonnel);
            this.Controls.Add(this.grbListePersonnel);
            this.Controls.Add(this.menuMtk86);
            this.MainMenuStrip = this.menuMtk86;
            this.Name = "FrmPersonnel";
            this.Text = "Mediatek86";
            this.grbListePersonnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.grbPersonnel.ResumeLayout(false);
            this.grbPersonnel.PerformLayout();
            this.menuMtk86.ResumeLayout(false);
            this.menuMtk86.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDemandeSupprPers;
        private System.Windows.Forms.Button btnDemandeModifPers;
        private System.Windows.Forms.GroupBox grbListePersonnel;
        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnregPers;
        private System.Windows.Forms.Button btnAnnulPers;
        private System.Windows.Forms.GroupBox grbPersonnel;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuMtk86;
        private System.Windows.Forms.ToolStripMenuItem absencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quToolStripMenuItem;
    }
}

