namespace WebApiIntroduction.Services
{
    public class IoCService
    {
        private readonly AddService _addService;

        public IoCService(AddService addService)
        {
            _addService = addService;
        }

        public int Add(int x, int y)
        {
            return _addService.Add(x, y);
        }
    }
}