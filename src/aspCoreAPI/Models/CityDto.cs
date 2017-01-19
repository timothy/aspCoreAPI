using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspCoreAPI.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int NumberOfPointsOfInterest
        {
            get { return PointsOfInterest.Count; }
        }

        public ICollection<PointOfInterestDto> PointsOfInterest { get; set; } = new List<PointOfInterestDto>();// initialized to empty set to ovoid null reference issues// using C# 6 auto property initializer
    }
}
