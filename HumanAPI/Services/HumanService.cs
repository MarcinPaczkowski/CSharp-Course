using HumanAPI.Models;

namespace HumanAPI.Services
{
    public abstract class HumanService : IHumanService
    {
        public abstract string  Urinate(Human human);
        public string Eat(Human human)
        {
            return "I'm eating";
        }

        public string Defecate(Human human)
        {
            return "I'm defecating";
        }

        public string GoWork(Human human)
        {
            return "I'm going to work";
        }

        public string GoHome(Human human)
        {
            return "I'm going home";
        }
    }
}
