using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seyahet_Bloq_Proyekt.Models.Sinifler
{
    public class Bloq
    {
        public int BloqID { get; set; }
        public string Basliq { get; set; }
        public DateTime Tarix { get; set; }
        public string FotoBloq { get; set; }
        public string Aciqlama { get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set; }
    }
}