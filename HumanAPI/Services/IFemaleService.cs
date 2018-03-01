using HumanAPI.Models;

namespace HumanAPI.Services
{
    public interface IFemaleService
    {
        string Period(Female female);
        string BornBaby(Female female);

    }
}