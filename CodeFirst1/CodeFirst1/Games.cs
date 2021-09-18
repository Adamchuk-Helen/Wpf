using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst1
{
   public class Games
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string Studio { get; set; }

        public string Style { get; set; }

        public DateTime Relise { get; set; }
        public Studios Studios { get; set; }

        public Styles Styles { get; set; }

    }
}
