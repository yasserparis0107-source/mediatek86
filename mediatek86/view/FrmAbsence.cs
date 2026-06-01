using mediatek86.controller;
using mediatek86.model;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediatek86.view
{
    /// <summary>
    /// Fenêtre d'affichage et de gestion des absences
    /// </summary>
    public partial class FrmAbsence : Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursModifAbsence = false;
        /// <summary>
        /// Objet pour gérer la liste des développeurs
        /// </summary>
        private readonly BindingSource bdgPersonnel = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des motifs
        /// </summary>
        private readonly BindingSource bdgMotifs = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des motifs
        /// </summary>
        private readonly BindingSource bdgAbsences = new BindingSource();
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmAbsenceController controller;
        /// <summary>
        /// Titre des fenêtres d'information
        /// </summary>
        private readonly String titreFenetreInformation = "Information";


        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmAbsence()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmAbsenceController();
            RemplirListeAbsences();
            RemplirListeMotifs();
            EnCoursDeModifAbsence(false);
        }

        /// <summary>
        /// Affiche les Absences
        /// </summary>
        private void RemplirListeAbsences()
        {
            List<Absence> lesAbsences = controller.GetLesAbsences();
            bdgAbsences.DataSource = lesAbsences;
            dgvAbsences.DataSource = bdgAbsences;

            foreach (DataGridViewColumn col in dgvAbsences.Columns)
            {
                Debug.WriteLine($"Column name: '{col.Name}' | DataPropertyName: '{col.DataPropertyName}'");
            }
            dgvAbsences.Columns["Personnel"].HeaderText = "Nom & Prénom";
            dgvAbsences.Columns["Datedebut"].HeaderText = "Date Début";
            dgvAbsences.Columns["Datefin"].HeaderText = "Date Fin";
            dgvAbsences.Columns["Motif"].HeaderText = "Motif";
            //dgvAbsences.Columns["Datedebut"].DefaultCellStyle.Format = "dd/MM/yyyy";
            //dgvAbsences.Columns["Datefin"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAbsences.ColumnHeadersDefaultCellStyle.Font = new Font(dgvAbsences.Font, FontStyle.Bold);
        }

        /// <summary>
        /// Affiche les Motifs
        /// </summary>
        private void RemplirListeMotifs()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            cboMotif.DataSource = bdgMotifs;
        }

        /// <summary>
        ///  Demande de modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDemandeModifAbs_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                EnCoursDeModifAbsence(true);
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                txtNom.Text = absence.Personnel.Nom;
                txtPrenom.Text = absence.Personnel.Prenom;
                txtNom.Enabled = false;
                txtPrenom.Enabled = false;
                datedebutAbs.Value = absence.Datedebut;
                datefinAbs.Value = absence.Datefin;
                cboMotif.SelectedIndex = cboMotif.FindStringExact(absence.Motif.Libelle);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDemandeSupprAbs_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer l'absence de " + absence.Personnel.Nom + " " + absence.Personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    RemplirListeAbsences();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEnregAbs_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && cboMotif.SelectedIndex != -1 && !datedebutAbs.Equals("") && !datefinAbs.Text.Equals(""))
            {
                Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];
                if (enCoursModifAbsence)
                {
                    Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                    absence.Datedebut = datedebutAbs.Value;
                    absence.Datefin = datefinAbs.Value;
                    absence.Motif = motif;
                    controller.UpdateAbsence(absence);
                    //Personnel n'est pas modifiable
                }
                else  
                {
                    Log.Debug("FrmAbsence.BtnEnregAbs_Click : nom={0} , prenom={1} ", txtNom.Text, txtPrenom.Text);
                    Personnel personnel = controller.GetPersonnelByNomPrenom(txtNom.Text, txtPrenom.Text);
                    Absence absence = new Absence(personnel, datedebutAbs.Value, datefinAbs.Value, motif);
                    controller.AddAbsence(absence);
                }
                RemplirListeAbsences();
                EnCoursDeModifAbsence(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Annule la demande d'ajout ou de modification d'un développeur
        /// Vide les zones de saisie du développeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnulAbs_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursDeModifAbsence(false);
            }
        }

        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout d'un developpeur
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursDeModifAbsence(Boolean modif)
        {
            enCoursModifAbsence = modif;
            grbListeAbsence.Enabled = !modif;
            if (modif)
            {
                grbAbsence.Text = "modifier une Absence";
            }
            else
            {
                grbAbsence.Text = "ajouter une Absence";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtNom.Enabled = true;
                txtPrenom.Enabled = true;
             }
        }


               
        private void personnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPersonnel frm = new FrmPersonnel();
            frm = new FrmPersonnel();
            frm.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous quitter l'application ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (form != this)
                        form.Close();
                }
            }
        }
    }
}
