using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class TurnirModel
    {
        /// <summary>
        /// Ime koje ima turnir
        /// </summary>
        public string NazivTurnira { get; set; }
        /// <summary>
        /// Količina novca koje treba uplatiti za sudjelovanje u  turniru
        /// </summary>
        public decimal  Kotizacija { get; set; }
        /// <summary>
        /// Lista timova koji su prijavljeni na turnir
        /// </summary>
        public List<EkipaModel> PrijavljeniTimovi { get; set; } = new List<EkipaModel>();
        /// <summary>
        /// Nagrada koju osvajaju prva 3 mjesta
        /// </summary>
        public List<NagradaModel> Nagrada { get; set; } = new List<NagradaModel>();
        /// <summary>
        /// Lista rundi
        /// </summary>
        public List<List<UtakmicaModel>> Runde { get; set; }=new List<List<UtakmicaModel>>();

    }
}
