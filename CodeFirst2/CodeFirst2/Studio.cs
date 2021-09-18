using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst2
{
    public class Studio
    {
        public int Id { get; set; }
        [Index(IsUnique = true)]
        [MaxLength(30)]
        public string StudiosName { get; set; }

        public virtual List<Game> Games { get; set; }
    }
}
