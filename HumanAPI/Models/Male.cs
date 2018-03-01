using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanAPI.Enums;

namespace HumanAPI.Models
{
    public class Male : Human
    {
        public SizeType PenisSize { get; set; }
        public bool HasBeard { get; set; }

    }
}
