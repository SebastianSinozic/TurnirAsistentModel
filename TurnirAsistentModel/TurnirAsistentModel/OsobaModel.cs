using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class OsobaModel
    {
        /// <summary>
        /// Ime igrača
        /// </summary>
        public string Ime { get; set; }
        /// <summary>
        /// Prezime igrača
        /// </summary>
        public string Prezime { get; set; }
        /// <summary>
        /// Email račun igrača putem kojeg javljamo kad je sljedeća utakmica
        /// </summary>
        public string EmailAdresa { get; set; }
        /// <summary>
        /// Broj mobitela igrača kako bi mu javili kad se igra sljedeća utakmica
        /// </summary>
        public string BrojMobitela { get; set; }

    }
}
