using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using HumanAPI.Enums;

namespace HumanAPI.Models
{
    public class Female : Human
    {
        public bool IsPreagnant { get; set; }
        public SizeType BreastSize { get; set; }

    }
}
