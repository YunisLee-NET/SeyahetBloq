using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seyahet_Bloq_Proyekt.Models.Sinifler
{
    public class Elaqe
    {
        [Key]
        public int ElaqeID { get; set; }
        public string AdSoyad { get; set; }
        public string Mail { get; set; }
        public string Movzu { get; set; }
        public string Mesaj { get; set; }
    }
}