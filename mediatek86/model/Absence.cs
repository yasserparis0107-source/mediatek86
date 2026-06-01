using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.model
{
    public class Absence
    {     
        public Personnel Personnel { get; set; }
        public DateTime Datedebut { get; set; }
        public DateTime Datefin { get; set; }
        public Motif Motif { get; set; }
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="Personnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="Motif"></param>
        /// 
        public Absence(Personnel Personnel, DateTime datedebut, DateTime datefin, Motif Motif)
        {
            this.Personnel = Personnel;
            this.Datedebut = datedebut;
            this.Datefin = datefin;
            this.Motif = Motif;
        }

        
    }
}

