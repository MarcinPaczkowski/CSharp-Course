namespace WebApiIntroduction.Models
{
    public class Response<T>
    {
        public T Data { get; set; }
        public bool IsError { get; set; }
        public Error Error { get; set; }

        public Response()
        {
            IsError = false;
        }
    }
}