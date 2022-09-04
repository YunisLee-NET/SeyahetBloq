using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seyahet_Bloq_Proyekt.Models.Sinifler
{
    public class Unvan
    {
        [Key]
        public int UnvanID { get; set; }
        public string Basliq { get; set; }
        public string UnvanAciqlama { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string GoogleMap { get; set; }
    }
}