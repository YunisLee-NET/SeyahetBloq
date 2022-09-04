using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seyahet_Bloq_Proyekt.Models.Sinifler
{
    public class BloqYorum
    {
        public IEnumerable<Bloq> Melumat1 { get; set; }
        public IEnumerable<Yorumlar> Melumat2 { get; set; }
        public IEnumerable<Bloq> Melumat3 { get; set; }
    }
}