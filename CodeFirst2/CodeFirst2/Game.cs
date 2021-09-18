using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst2
{
    public class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string Studio { get; set; }

        public string Style { get; set; }

        public DateTime Relise { get; set; }

        public int Paid { get; set; }

        public string Mode { get; set; }

        public virtual Studio Studios { get; set; }

        public virtual Style Styles { get; set; }

        public virtual Mode Modes { get; set; }
    }
}
