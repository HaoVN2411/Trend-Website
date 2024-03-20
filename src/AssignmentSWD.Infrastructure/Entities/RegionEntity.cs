using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSWD.Infrastructure.Entities
{
    [Table("Region")]
    public class RegionEntity : Entity
    {
        public string? RegionName { get; set; }
        public virtual ICollection<TrendEntity>? TrendEntities { get; set; }

    }
}
