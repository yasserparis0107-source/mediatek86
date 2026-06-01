using mediatek86.bddmanager;
using mediatek86.model;
using System;
using System.Collections.Generic;
using Serilog;
using System.Configuration;

namespace mediatek86.dal
{
    /// <summary>
    /// Singleton : classe d'accès à BddManager.
    /// </summary>
    public class Access
    {
        /// <summary>
        /// nom de connexion à la bdd
        /// </summary>
        private static readonly string connectionName = "mediatek86.Properties.Settings.mediatek86ConnectionString";
        /// <summary>
        /// instance unique de la classe.
        /// </summary>
        private static Access instance = null;
        /// <summary>
        /// Getter sur l'objet d'accès aux données.
        /// </summary>
        public BddManager Manager { get; }

        /// <summary>
        /// Création unique de l'objet de type BddManager
        /// Arrête le programme si l'accès à la BDD a échoué
        /// </summary>
        private Access()
        {
            String connectionString = null;
            try
            {
                Log.Logger = new LoggerConfiguration()
                    .MinimumLevel.Verbose()
                    .WriteTo.Console()
                    .WriteTo.File("logs/log.txt")
                    .CreateLogger();
                connectionString = GetConnectionStringByName(connectionName);
                Manager = BddManager.GetInstance(connectionString);
            }
            catch (Exception e)
            {
                Log.Fatal("Access.Access catch connectionString={0} erreur={1}", connectionString, e.Message);
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Création d'une seule instance de la classe
        /// </summary>
        /// <returns></returns>
        public static Access GetInstance()
        {
            if (instance == null)
            {
                instance = new Access();
            }
            return instance;
        }

        /// <summary>
        /// Récupération de la chaîne de connexion
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }

        /// <summary>
        /// Controle si l'utillisateur a le droit de se connecter (login , Pwd)
        /// </summary>
        /// <param name=login"></param>
        /// <param name="pwd"></param>
        /// <returns>vrai si l'utilisateur figure dans la table Responsable</returns>
        ///
        public Boolean ControleAuthentification(Responsable responsable)
        {
            string req = "select * from responsable rs ";
            req += "where rs.login=@login and rs.pwd=SHA2(@pwd, 256)";

            Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@LOGIN", responsable.Login },
                    { "@pwd", responsable.Pwd }
            };
                try
                {
                    List<Object[]> records = instance.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        return (records.Count > 0);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("Access.ControleAuthentification catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
                return false;
        }
        
    }
}
