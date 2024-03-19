using AssignmentSWD.Core.EnumCore;
using AssignmentSWD.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSWD.API.Service.Models.Trend
{
    public class FilterModel
    {
        public string? RegionName { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate {  get; set; } 
        public string? FieldName { get; set; }
        public string? PlatformName { get; set; }
    }
}
