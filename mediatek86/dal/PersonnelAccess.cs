using mediatek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace mediatek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les personnels
    /// </summary>
    public class PersonnelAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public PersonnelAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Controle si l'utillisateur a le droit de se connecter (nom, prénom, pwd et profil "admin")
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="pwd"></param>
        /// <returns>vrai si l'utilisateur a le profil "admin"</returns>
        ///
        ///public Boolean ControleAuthentification(Admin admin)
        ///{
        ///    if (access.Manager != null)
        ///    {
        ///string req = "select * from personnel d join profil p on d.idprofil=p.idprofil ";
        /// += "where d.nom=@nom and d.prenom=@prenom and pwd=SHA2(@pwd, 256) and p.nom='admin';";
        ///<string, object> parameters = new Dictionary<string, object> {
        ///            { "@nom", admin.Nom },
        ///            { "@prenom", admin.Prenom },
        ///            { "@pwd", admin.Pwd }
        ///};
        ///        try
        ///        {
        ///            List<Object[]> records = access.Manager.ReqSelect(req, parameters);
        ///            if (records != null)
        ///            {
        ///                return (records.Count > 0);
        ///            }
        ///        }
        ///        catch (Exception e)
        ///        {
        ///            Console.WriteLine(e.Message);
        ///            Log.Error("PersonnelAccess.ControleAuthentification catch req={0} erreur={1}", req, e.Message);
        ///            Environment.Exit(0);
        ///        }
        ///    }
        ///    return false;
        ///}
        ///

        /// <summary>
        /// Récupère et retourne la liste du personnel
        /// </summary>
        /// <returns>liste du personnel</returns>
        public List<Personnel> GetLePersonnel()
        {
            List<Personnel> LePersonnel = new List<Personnel>();
            if (access.Manager != null)
            {
                string req = "select ps.idpersonnel as idpersonnel, ps.nom as nom, ps.prenom as prenom, ps.tel as tel, ps.mail as mail, ps.idservice as idservice, sv.nom as service ";
                req += "FROM personnel ps join service sv on (ps.idservice = sv.idservice) ";
                req += "order by nom, prenom;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        Log.Debug("PersonnelAccess.GetLePersonnel nb records = {0}", records.Count);
                        foreach (Object[] record in records)
                        {
                            Log.Debug("PersonnelAccess.GetLePersonnel Service : id={0} nom={1}", record[5], record[6]);
                            Log.Debug("PersonnelAccess.GetLePersonnel Personnel : id={0} nom={1} prenom={2} tel={3} mail={4} ", record[0], record[1], record[2], record[3], record[4]);
                            Service service = new Service((int)record[5], (string)record[6]);
                            Personnel personnel = new Personnel((int)record[0], (string)record[1], (string)record[2],
                                (string)record[3], (string)record[4], service);
                            LePersonnel.Add(personnel);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("PersonnelAccess.GetLePersonnel catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return LePersonnel;
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {

                string req = "delete from personnel where idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    {"@idpersonnel", personnel.IdPersonnel }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("PersonnelAccess.DelPersonnel catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
        }

        /// <summary>
        /// Demande d'ajout un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "insert into personnel(nom, prenom, tel, mail, idservice ) ";
                req += "values (@nom, @prenom, @tel, @mail, @idservice);";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@nom", personnel.Nom },
                    { "@prenom", personnel.Prenom },
                    { "@tel", personnel.Tel },
                    { "@mail", personnel.Mail },
                    { "@idservice", personnel.Service.IdService }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("PersonnelAccess.AddPersonnel catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "update personnel set nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice ";
                req += "where idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@idPersonnel", personnel.IdPersonnel },
                    { "@nom", personnel.Nom },
                    { "@prenom", personnel.Prenom },
                    { "@tel", personnel.Tel },
                    { "@mail", personnel.Mail },
                    { "@idservice", personnel.Service.IdService }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("PersonnelAccess.UpdatePersonnel catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }

        public Personnel GetPersonnelByNomPrenom(string nom, string prenom)
        {
            Personnel lepersonnel = null;
            if (access.Manager != null)
            {
                string req = "select ps.idpersonnel as idpersonnel, ps.nom as nom, ps.prenom as prenom, ps.tel as tel, ps.mail as mail, ps.idservice as idservice, sv.nom as service ";
                req += "FROM personnel ps join service sv on (ps.idservice = sv.idservice) ";
                req += "where ps.nom = @nom ";
                req += "and ps.prenom = @prenom;";

                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@nom", nom },
                    { "@prenom", prenom },
                };

                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        Log.Debug("PersonnelAccess.GetPersonnelByNomPrenom nb records = {0}", records.Count);
                        foreach (Object[] record in records)
                        {
                            //on est sensé trouver une ligne
                            Log.Debug("PersonnelAccess.GetPersonnelByNomPrenom Personnel : id={0} nom={1} prenom={2} tel={3} mail={4} ", record[0], record[1], record[2], record[3], record[4]);
                            Service service = new Service((int)record[5], (string)record[6]);
                            Personnel personnel = new Personnel((int)record[0], (string)record[1], (string)record[2],
                                (string)record[3], (string)record[4], service);
                            lepersonnel = personnel;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("PersonnelAccess.GetPersonnelByNomPrenom catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }

            }
            return lepersonnel;
        }
    }
}
