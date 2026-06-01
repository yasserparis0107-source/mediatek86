using mediatek86.controller;
using mediatek86.model;
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
    /// Fenêtre d'affichage et de gestion des personnes
    /// </summary>
    public partial class FrmPersonnel : Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifPersonnel = false;
        /// <summary>
        /// Objet pour gérer la liste des développeurs
        /// </summary>
        private readonly BindingSource bdgPersonnel = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des services
        /// </summary>
        private readonly BindingSource bdgServices = new BindingSource();
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmPersonnelController controller;
        /// <summary>
        /// Titre des fenêtres d'information
        /// </summary>
        private readonly String titreFenetreInformation = "Information";


        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmPersonnel()
        {
            InitializeComponent();
            Init();
            //InitialiserMenu();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmPersonnelController();
            RemplirListePersonnel();
            RemplirListeServices();
            EnCourseModifPersonnel(false);
        //  EnCoursModifPwd(false);
        }

                /// <summary>
        /// Affiche les personnel
        /// </summary>
        private void RemplirListePersonnel()
        {
            List<Personnel> listepersonnel = controller.GetLePersonnel();
            bdgPersonnel.DataSource = listepersonnel;
            dgvPersonnel.DataSource = bdgPersonnel;
            
            foreach (DataGridViewColumn col in dgvPersonnel.Columns)
            {
                Debug.WriteLine($"Column name: '{col.Name}' | DataPropertyName: '{col.DataPropertyName}'");
            }

            dgvPersonnel.Columns["idpersonnel"].Visible = false;
            dgvPersonnel.Columns["tel"].Visible = false;
            dgvPersonnel.Columns["mail"].Visible = false;
            dgvPersonnel.Columns["Nom"].HeaderText = "Nom";
            dgvPersonnel.Columns["Prenom"].HeaderText = "Prénom";
            dgvPersonnel.Columns["Service"].HeaderText = "Service";
            

            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersonnel.ColumnHeadersDefaultCellStyle.Font = new Font(dgvPersonnel.Font, FontStyle.Bold);
        }

        /// <summary>
        /// Affiche les services
        /// </summary>
        private void RemplirListeServices()
        {
            List<Service> listeServices = controller.GetLesServices();
            bdgServices.DataSource = listeServices;
            cboService.DataSource = bdgServices;
        }

        /// <summary>
        ///  Demande de modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDemandeModifDev_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                EnCourseModifPersonnel(true);
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTel.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
                cboService.SelectedIndex = cboService.FindStringExact(personnel.Service.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDemandeSupprDev_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelPersonnel(personnel);
                    RemplirListePersonnel();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEnregDev_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cboService.SelectedIndex != -1)
            {
                Service service = (Service)bdgServices.List[bdgServices.Position];
                if (enCoursDeModifPersonnel)
                {
                    Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                    personnel.Nom = txtNom.Text;
                    personnel.Prenom = txtPrenom.Text;
                    personnel.Tel = txtTel.Text;
                    personnel.Mail = txtMail.Text;
                    personnel.Service = service;
                    controller.UpdatePersonnel(personnel);
                    MessageBox.Show("Mise à jour effectué avec succès.", titreFenetreInformation);
                }
                else
                {
                    Personnel personnel = new Personnel(0, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service);
                    controller.AddPersonnel(personnel);
                    MessageBox.Show("Ajout effectué avec succès.", titreFenetreInformation);
                }
                RemplirListePersonnel();
                EnCourseModifPersonnel(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Annule la demande d'ajout ou de modification d'un personnel
        /// Vide les zones de saisie du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnulDev_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCourseModifPersonnel(false);
            }
        }

        
        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout d'un developpeur
        /// </summary>
        /// <param name="modif"></param>
        private void EnCourseModifPersonnel(Boolean modif)
        {
            enCoursDeModifPersonnel = modif;
            //grbPersonnel.Enabled = !modif;
            if (modif)
            {
                grbPersonnel.Text = "Modifier un personnel";
            }
            else
            {
                grbPersonnel.Text = "Ajouter un personnel";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTel.Text = "";
                txtMail.Text = "";
            }
        }

        private void absencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAbsence frm = new FrmAbsence();
            frm = new FrmAbsence();
            frm.ShowDialog();
        }

        private void quToolStripMenuItem_Click(object sender, EventArgs e)
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
