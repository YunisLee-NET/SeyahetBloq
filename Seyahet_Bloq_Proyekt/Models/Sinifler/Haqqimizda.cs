using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seyahet_Bloq_Proyekt.Models.Sinifler
{
    public class Haqqimizda
    {
        [Key]
        public int HaqqimizdaID { get; set; }
        public string FotoURL { get; set; }
        public string Aciqlama { get; set; }
    }
}