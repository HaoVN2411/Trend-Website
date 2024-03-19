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
        public PeriodEnum Period { get; set; } = PeriodEnum.All;
        public string? Category { get; set; }
        public string? Platform { get; set; }
    }
}
