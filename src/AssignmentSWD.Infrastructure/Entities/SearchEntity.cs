using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSWD.Infrastructure.Entities
{
    [Table("Search")]
    public class SearchEntity : Entity
    {
        public string? Keyword { get; set; }
        public int Count { get; set; }
    }
}
