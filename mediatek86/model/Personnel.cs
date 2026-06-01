using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace mediatek86.model
{
    public class Personnel
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="service"></param>
        /// 
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, Service service)
        {
            this.IdPersonnel = idpersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.Service = service;
        }

        public int IdPersonnel { get; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }     
        public string Mail { get; set; }
        public Service Service { get; set; }

        /// <summary>
        /// Définit l'information à afficher (juste le nom & prenom)
        /// </summary>
        /// <returns>nom du profil</returns>
        public override string ToString()
        {
            return $"{Nom} {Prenom}";
        }
    }
}

