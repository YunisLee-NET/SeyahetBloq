using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seyahet_Bloq_Proyekt.Models.Sinifler
{
    public class AnaSehife
    {
        [Key]
        public int AnaID { get; set; }
        public string Basliq { get; set; }
        public string Aciqlama { get; set; }
    }
}