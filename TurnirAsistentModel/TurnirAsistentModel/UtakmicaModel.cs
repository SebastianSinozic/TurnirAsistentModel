using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class UtakmicaModel
    {
        /// <summary>
        /// Lista natjecatelja 
        /// </summary>
        public List<SudionikModel> Natjecatelji { get; set; } = new List<SudionikModel>();
        /// <summary>
        /// Pobjednik u prošloj utakmici
        /// </summary>
        public EkipaModel Pobjednik { get; set; }
        /// <summary>
        /// Broj odigranih rundi
        /// </summary>
        public int BrojRunde { get; set; }
    }
}
