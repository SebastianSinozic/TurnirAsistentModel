using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class NagradaModel
    {
        /// <summary>
        /// pozicija koju je osvojila ekipa
        /// </summary>
        public int OsvojenoMjesto { get; set; }
        /// <summary>
        /// Naziv mjesta gdje se odigrala utakmica
        /// </summary>
        public string NazivMjesta { get; set; }
        /// <summary>
        /// Iznos koji osvaja pobjednik utakmice
        /// </summary>
        public decimal IznosNagrade { get; set; }
        /// <summary>
        /// Koliki postotak nagrade osvaja 1. mjesto
        /// </summary>
        public double PostotakNagrade { get; set; }

    }
}
