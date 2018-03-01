using HumanAPI.Models;

namespace HumanAPI.Services
{
    public class FemaleService : HumanService, IFemaleService
    {
        public override string Urinate(Human human)
        {
            return "I'm urinating like a woman";
        }

        public string Period(Female female)
        {
            return "I'm having period";
        }

        public string BornBaby(Female female)
        {
            return "I'm borning baby";
        }
    }
}