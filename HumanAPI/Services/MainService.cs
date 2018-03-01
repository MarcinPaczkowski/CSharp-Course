using System;
using HumanAPI.Enums;
using HumanAPI.Models;

namespace HumanAPI.Services
{
    public class MainService
    {
        public void Start()
        {
            var femaleService = new FemaleService();

            var woman = new Female
            {
                BreastSize = SizeType.XXL,
                IsPreagnant = false,
                DateOfBirth = DateTime.Today,
                FirtName = "Anna",
                LastName = "Lewandowska",
                Id = 1,
                RaceType = RaceType.Black
            };
            

            var result = femaleService.Urinate(woman);
            
        }
    }
}