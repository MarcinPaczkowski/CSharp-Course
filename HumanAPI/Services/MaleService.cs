using HumanAPI.Models;

namespace HumanAPI.Services
{
    public class MaleService : HumanService, IMaleService
    {

        public string Ejaculate(Male male)
        {
            return default(string);
        }

        public override string Urinate(Human human)
        {
            return "I'm urinating like a man";
        }
    }
}