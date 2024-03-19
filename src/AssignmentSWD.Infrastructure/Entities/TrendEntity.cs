using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentSWD.Infrastructure.Entities
{
    [Table("Trend")]
    public class TrendEntity : Entity
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? PlatformId { get; set; }
        public string? FieldId { get; set; }
        public string? RegionId { get; set; }
        [ForeignKey(nameof(PlatformId))]
        public PlatformEntity? Platform { get; set; }

        [ForeignKey(nameof(FieldId))]
        public FieldEntity? Field { get; set; }
        [ForeignKey(nameof(RegionId))]
        public RegionEntity? Region { get; set; }
    }
}
