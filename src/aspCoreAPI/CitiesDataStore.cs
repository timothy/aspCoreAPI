using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspCoreAPI.Models;

namespace aspCoreAPI
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();//Auto property syntax// property is immutable
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Phoenix",
                    Description = "Hot all day... Need to swim to stay cool!"
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Seattle",
                    Description = "Best place for rain!"
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Chicago",
                    Description = "Good place to ride the train!"
                }
            };
        }
    }
}
