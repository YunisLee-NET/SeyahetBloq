using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seyahet_Bloq_Proyekt.Models.Sinifler
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        public string Istifadeci { get; set; }
        public string Sifre { get; set; }
    }
}