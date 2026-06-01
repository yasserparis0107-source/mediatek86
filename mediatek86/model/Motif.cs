using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.model
{
    public class Motif
    {     
        public int IdMotif { get; }
        public string Libelle { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle)
        {
            this.IdMotif = idmotif;
            this.Libelle = libelle;
        }

        /// <summary>
        /// Définit l'information à afficher (juste le libellé)
        /// </summary>
        /// <returns>nom du motif</returns>
        public override string ToString()
        {
            return this.Libelle;
        }
    }
}

