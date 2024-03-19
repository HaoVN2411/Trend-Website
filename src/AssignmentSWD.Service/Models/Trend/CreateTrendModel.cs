using AssignmentSWD.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaoVN.Template_3_layers.Service.Models.Trend
{
    public class CreateTrendModel
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? PlatformId { get; set; }
        public string? TypeId { get; set; }
        public string? FieldId { get; set; }
        public string? RegionId { get; set; }
    }
}
