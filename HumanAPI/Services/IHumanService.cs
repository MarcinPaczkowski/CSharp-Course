using HumanAPI.Models;

namespace HumanAPI.Services
{
    public interface IHumanService
    {
        string Eat(Human human);
        string Defecate(Human human);
        string GoWork(Human human);
        string GoHome(Human human);
    }
}
