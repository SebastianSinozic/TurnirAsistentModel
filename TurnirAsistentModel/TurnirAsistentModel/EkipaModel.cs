using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class EkipaModel
    {
        /// <summary>
        /// Lista članova koji su u ekipi
        /// </summary>
        public List<OsobaModel> ClanoviEkipe { get; set; } = new List<OsobaModel>();
    public string ImeEkipe  { get; set; }
    }

}
