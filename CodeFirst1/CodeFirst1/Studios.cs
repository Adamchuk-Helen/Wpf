using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst1
{
   public class Studios
    {
        public int Id { get; set; }
        public string StudioName { get; set; }
        public List<Games> games { get; set; }

    }
}
