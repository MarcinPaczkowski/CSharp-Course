using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanAPI.Enums;

namespace HumanAPI.Models
{
    public abstract class Human
    {
        public int Id { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public RaceType RaceType { get; set; }
    }
}
