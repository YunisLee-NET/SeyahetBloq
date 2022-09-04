using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seyahet_Bloq_Proyekt.Models.Sinifler
{
    public class Yorumlar
    {
        [Key]
        public int YorumID { get; set; }
        public string IstifadeciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int BloqID { get; set; }
        public virtual Bloq Bloq { get; set; }
    }
}