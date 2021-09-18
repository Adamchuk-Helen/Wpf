using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst2
{
    public class Mode
    {
        public int Id { get; set; }
        public string ModeName { get; set; }

        public virtual List<Game> Games { get; set; }

    }
}
