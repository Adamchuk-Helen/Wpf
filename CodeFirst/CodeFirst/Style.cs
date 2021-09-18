using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Style
    {
        public int Id { get; set; }
        public string StylesName { get; set; }

        public virtual List<Game> Games { get; set; }
    }
}
