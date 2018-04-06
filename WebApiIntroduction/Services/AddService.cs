using System;
using WebApiIntroduction.Controllers;

namespace WebApiIntroduction.Services
{
    public class AddService
    {
        public int Add(int a, int b)
        {
            var x = 0;
            try
            {
                throw new Exception("Test exception");
            }
            catch (Exception e)
            {
                throw new Exception("New exception", e);
            }
            finally
            {
                x = a + b;
            }

            return x;
        }
    }
}