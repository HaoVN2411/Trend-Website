using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSWD.Infrastructure.Entities
{
    public class TrendImage : Entity
    {
        public string? TrendId {  get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageNote { get; set; }
        [ForeignKey(nameof(TrendId))]
        public TrendEntity Trend { get; set; }
    }
}
