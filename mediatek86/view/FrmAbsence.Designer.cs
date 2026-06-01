namespace mediatek86.view
{
    partial class FrmAbsence
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
            this.btnAnnulAbs = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.grbAbsence = new System.Windows.Forms.GroupBox();
            this.Motif = new System.Windows.Forms.Label();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.datefinAbs = new System.Windows.Forms.DateTimePicker();
            this.datedebutAbs = new System.Windows.Forms.DateTimePicker();
            this.btnEnregAbs = new System.Windows.Forms.Button();
            this.btnDemandeSupprAbs = new System.Windows.Forms.Button();
            this.btnDemandeModifAbs = new System.Windows.Forms.Button();
            this.grbListeAbsence = new System.Windows.Forms.GroupBox();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbAbsence.SuspendLayout();
            this.grbListeAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnnulAbs
            // 
            this.btnAnnulAbs.Location = new System.Drawing.Point(103, 98);
            this.btnAnnulAbs.Name = "btnAnnulAbs";
            this.btnAnnulAbs.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulAbs.TabIndex = 10;
            this.btnAnnulAbs.Text = "annuler";
            this.btnAnnulAbs.UseVisualStyleBackColor = true;
            this.btnAnnulAbs.Click += new System.EventHandler(this.BtnAnnulAbs_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date de debut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date de fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "prenom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(54, 45);
            this.txtPrenom.MaxLength = 20;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(245, 20);
            this.txtPrenom.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(54, 19);
            this.txtNom.MaxLength = 20;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(245, 20);
            this.txtNom.TabIndex = 3;
            // 
            // grbAbsence
            // 
            this.grbAbsence.Controls.Add(this.Motif);
            this.grbAbsence.Controls.Add(this.cboMotif);
            this.grbAbsence.Controls.Add(this.datefinAbs);
            this.grbAbsence.Controls.Add(this.datedebutAbs);
            this.grbAbsence.Controls.Add(this.btnAnnulAbs);
            this.grbAbsence.Controls.Add(this.btnEnregAbs);
            this.grbAbsence.Controls.Add(this.label4);
            this.grbAbsence.Controls.Add(this.label3);
            this.grbAbsence.Controls.Add(this.label2);
            this.grbAbsence.Controls.Add(this.txtPrenom);
            this.grbAbsence.Controls.Add(this.label1);
            this.grbAbsence.Controls.Add(this.txtNom);
            this.grbAbsence.Location = new System.Drawing.Point(11, 331);
            this.grbAbsence.Name = "grbAbsence";
            this.grbAbsence.Size = new System.Drawing.Size(605, 129);
            this.grbAbsence.TabIndex = 5;
            this.grbAbsence.TabStop = false;
            this.grbAbsence.Text = "ajouter une absence";
            // 
            // Motif
            // 
            this.Motif.AutoSize = true;
            this.Motif.Location = new System.Drawing.Point(6, 74);
            this.Motif.Name = "Motif";
            this.Motif.Size = new System.Drawing.Size(30, 13);
            this.Motif.TabIndex = 17;
            this.Motif.Text = "Motif";
            // 
            // cboMotif
            // 
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Location = new System.Drawing.Point(54, 71);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(245, 21);
            this.cboMotif.TabIndex = 16;
            // 
            // datefinAbs
            // 
            this.datefinAbs.Location = new System.Drawing.Point(399, 48);
            this.datefinAbs.Name = "datefinAbs";
            this.datefinAbs.Size = new System.Drawing.Size(171, 20);
            this.datefinAbs.TabIndex = 15;
            // 
            // datedebutAbs
            // 
            this.datedebutAbs.Location = new System.Drawing.Point(399, 19);
            this.datedebutAbs.Name = "datedebutAbs";
            this.datedebutAbs.Size = new System.Drawing.Size(171, 20);
            this.datedebutAbs.TabIndex = 14;
            // 
            // btnEnregAbs
            // 
            this.btnEnregAbs.Location = new System.Drawing.Point(6, 98);
            this.btnEnregAbs.Name = "btnEnregAbs";
            this.btnEnregAbs.Size = new System.Drawing.Size(75, 23);
            this.btnEnregAbs.TabIndex = 9;
            this.btnEnregAbs.Text = "enregistrer";
            this.btnEnregAbs.UseVisualStyleBackColor = true;
            this.btnEnregAbs.Click += new System.EventHandler(this.BtnEnregAbs_Click);
            // 
            // btnDemandeSupprAbs
            // 
            this.btnDemandeSupprAbs.Location = new System.Drawing.Point(87, 231);
            this.btnDemandeSupprAbs.Name = "btnDemandeSupprAbs";
            this.btnDemandeSupprAbs.Size = new System.Drawing.Size(75, 23);
            this.btnDemandeSupprAbs.TabIndex = 2;
            this.btnDemandeSupprAbs.Text = "supprimer";
            this.btnDemandeSupprAbs.UseVisualStyleBackColor = true;
            this.btnDemandeSupprAbs.Click += new System.EventHandler(this.BtnDemandeSupprAbs_Click);
            // 
            // btnDemandeModifAbs
            // 
            this.btnDemandeModifAbs.Location = new System.Drawing.Point(6, 231);
            this.btnDemandeModifAbs.Name = "btnDemandeModifAbs";
            this.btnDemandeModifAbs.Size = new System.Drawing.Size(75, 23);
            this.btnDemandeModifAbs.TabIndex = 1;
            this.btnDemandeModifAbs.Text = "modifier";
            this.btnDemandeModifAbs.UseVisualStyleBackColor = true;
            this.btnDemandeModifAbs.Click += new System.EventHandler(this.BtnDemandeModifAbs_Click);
            // 
            // grbListeAbsence
            // 
            this.grbListeAbsence.Controls.Add(this.btnDemandeSupprAbs);
            this.grbListeAbsence.Controls.Add(this.btnDemandeModifAbs);
            this.grbListeAbsence.Controls.Add(this.dgvAbsences);
            this.grbListeAbsence.Location = new System.Drawing.Point(11, 53);
            this.grbListeAbsence.Name = "grbListeAbsence";
            this.grbListeAbsence.Size = new System.Drawing.Size(605, 264);
            this.grbListeAbsence.TabIndex = 4;
            this.grbListeAbsence.TabStop = false;
            this.grbListeAbsence.Text = "Gestion des absences";
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.AllowUserToAddRows = false;
            this.dgvAbsences.AllowUserToDeleteRows = false;
            this.dgvAbsences.AllowUserToResizeRows = false;
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(6, 19);
            this.dgvAbsences.MultiSelect = false;
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.ReadOnly = true;
            this.dgvAbsences.RowHeadersVisible = false;
            this.dgvAbsences.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAbsences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsences.Size = new System.Drawing.Size(581, 206);
            this.dgvAbsences.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personnelToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personnelToolStripMenuItem
            // 
            this.personnelToolStripMenuItem.Name = "personnelToolStripMenuItem";
            this.personnelToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.personnelToolStripMenuItem.Text = "Personnel";
            this.personnelToolStripMenuItem.Click += new System.EventHandler(this.personnelToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // FrmAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 498);
            this.Controls.Add(this.grbAbsence);
            this.Controls.Add(this.grbListeAbsence);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAbsence";
            this.Text = "Mediatek86";
            this.grbAbsence.ResumeLayout(false);
            this.grbAbsence.PerformLayout();
            this.grbListeAbsence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAnnulAbs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.GroupBox grbAbsence;
        private System.Windows.Forms.Button btnDemandeSupprAbs;
        private System.Windows.Forms.Button btnDemandeModifAbs;
        private System.Windows.Forms.GroupBox grbListeAbsence;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.DateTimePicker datedebutAbs;
        private System.Windows.Forms.DateTimePicker datefinAbs;
        private System.Windows.Forms.ComboBox cboMotif;
        private System.Windows.Forms.Label Motif;
        private System.Windows.Forms.Button btnEnregAbs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personnelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}

