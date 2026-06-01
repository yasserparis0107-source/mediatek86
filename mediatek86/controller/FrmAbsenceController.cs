using mediatek86.dal;
using mediatek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace mediatek86.controller
{
    /// <summary>
    /// Contrôleur de FrmPersonnel
    /// </summary>
    public class FrmAbsenceController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Personnel
        /// </summary>
        private readonly PersonnelAccess personnelAccess;
        /// <summary>
        /// objet d'accès aux opérations possible sur Service
        /// </summary>
        private readonly ServiceAccess serviceAccess;
        /// <summary>
        /// objet d'accès aux opérations possibles sur Absence
        /// </summary>
        private readonly AbsenceAccess absenceAccess;
        /// <summary>
        /// objet d'accès aux opérations possible sur motif
        /// </summary>
        private readonly MotifAccess motifAccess;

        /// <summary>
        /// Récupère les acces aux données
        /// </summary>
        public FrmAbsenceController()
        {
            ///personnelAccess = new PersonnelAccess();
            ///serviceAccess = new ServiceAccess();
            absenceAccess = new AbsenceAccess();
            motifAccess = new MotifAccess();
            personnelAccess = new PersonnelAccess();
        }

        /// <summary>
        /// Récupère et retourne la liste des absences
        /// </summary>
        /// <returns>liste du personnel
        public List<Absence> GetLesAbsences()
        {
            return absenceAccess.GetLesAbsences();
        }

        /// <summary>
        /// Récupère et retourne les infos des motifs
        /// </summary>
        /// <returns>liste des services
        public List<Motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }

        /// <summary>
        /// Supprime une absence
        /// </summary>
        /// /// <param name="absence">objet personnel à supprimer</param>
        public void DelAbsence(Absence absence)
        {
            absenceAccess.DelAbsence(absence);
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet developpeur à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            absenceAccess.AddAbsence(absence);
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet developpeur à modifier</param>
        public void UpdateAbsence(Absence absence)
        {
            absenceAccess.UpdateAbsence(absence);
        }

        public Personnel GetPersonnelByNomPrenom(string nom, string prenom)
        {
            return personnelAccess.GetPersonnelByNomPrenom(nom, prenom);
        }
    }
}
