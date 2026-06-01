using mediatek86.model;
using Mysqlx.Crud;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediatek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les absences
    /// </summary>
    public class AbsenceAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public AbsenceAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne la liste des absences
        /// </summary>
        /// <returns>liste du absence</returns>
        public List<Absence> GetLesAbsences()
        {
            List<Absence> LesAbsences = new List<Absence>();
            if (access.Manager != null)
            {
                string req = "select ab.idpersonnel as idpersonnel, ps.nom as nom, ps.prenom as prenom, ps.tel as tel, ps.mail as mail, ab.idmotif as idmotif, mf.libelle as libelle, ab.datedebut as datedebut, ab.datefin as datefin, ps.idservice as idservice, sv.nom as service ";
                req += "FROM absence ab, motif mf, personnel ps, service sv ";
                req += "where ab.idmotif = mf.idmotif ";
                req += "and ab.idpersonnel = ps.idpersonnel ";
                req += "and ps.idservice = sv.idservice ";
                req += "order by nom, prenom ";

                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        Log.Debug("AbsenceAccess.GetLesAbsences nb records = {0}", records.Count);
                        foreach (Object[] record in records)
                        {
                            Log.Debug("AbsenceAccess.GetLesAbsences Personnel : id={0} nom={1} prenom={2} tel={3} mail={4} ", record[0], record[1], record[2], record[3], record[4]);
                            Log.Debug("AbsenceAccess.GetLesAbsences Motif : id={0} nom={1}", record[5], record[6]);
                            Log.Debug("AbsenceAccess.GetLesAbsences Absence : datedebut={1} daatefin={2} ", record[7], record[8]);
                            Motif motif = new Motif((int)record[5], (string)record[6]);
                            Service service = new Service((int)record[9], (string)record[10]);
                            Personnel personnel = new Personnel((int)record[0], (string)record[1], (string)record[2], (string)record[3], (string)record[4], service);
                            Absence absence = new Absence(personnel, (DateTime)record[7], (DateTime)record[8], motif);
                            LesAbsences.Add(absence);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("AbsenceAccess.GetLesAbsences catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return LesAbsences;
        }

        /// <summary>
        /// Demande de suppression d'un absence
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        public void DelAbsence(Absence absence)
        {

            string req = "delete from absence where idpersonnel = @idpersonnel and datedebut = @datedebut; ";
            Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@idpersonnel", absence.Personnel.IdPersonnel },
                    { "@datedebut", absence.Datedebut },
                };
            try
            {
                access.Manager.ReqUpdate(req, parameters);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Log.Error("AbsenceAccess.DelAbsence catch req={0} erreur={1}", req, e.Message);
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Demande d'ajout un absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "insert into absence( idpersonnel, idmotif, datedebut, datefin ) ";
                req += "values (@idpersonnel, @idmotif, @datedebut, @datefin);";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@idpersonnel", absence.Personnel.IdPersonnel },
                    { "@idmotif", absence.Motif.IdMotif },
                    { "@datedebut", absence.Datedebut },
                    { "@datefin", absence.Datefin },
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("AbsenceAccess.AddAbsence catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande de modification d'un absence
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
        public void UpdateAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "update absence set idpersonnel = @idpersonnel, idmotif = @idmotif, datedebut = @datedebut, datefin = @datefin ";
                req += "where idpersonnel = @idpersonnel and datedebut = @datedebut;";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@idpersonnel", absence.Personnel.IdPersonnel },
                    { "@datedebut", absence.Datedebut },
                    { "@idmotif", absence.Motif.IdMotif },
                    { "@datefin", absence.Datefin },
                }
            ;
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("AbsenceAccess.UpdateAbsence catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
