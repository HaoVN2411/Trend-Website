using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSWD.Infrastructure.Entities
{
    [Table("Trend")]
    public class TrendEntity : Entity
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? PlatformId { get; set; }
        public string? TypeId { get; set; }
        public string? FieldId { get; set; }
        [ForeignKey(nameof(PlatformId))]
        public PlatformEntity? Platform { get; set; }
        [ForeignKey(nameof(TypeId))]
        public TypeEntity? Type { get; set; }
        [ForeignKey(nameof(FieldId))]
        public FieldEntity? Field { get; set; }
    }
}
