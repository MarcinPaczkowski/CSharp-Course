using System;
using System.Web.Http;
using WebApiIntroduction.Models;
using WebApiIntroduction.Services;
using WebApiIntroduction.ViewModels;

namespace WebApiIntroduction.Controllers
{
    public class TestController : ApiController
    {
        private readonly AddService _addService;
        private readonly IoCService _ioCService;

        public TestController(AddService addService, IoCService ioCService)
        {
            _addService = addService;
            _ioCService = ioCService;
        }

        [HttpGet]
        [Route("api/test")]
        public string GetTestValue()
        {
            return "test value";
        }

        [HttpGet]
        [Route("api/test/{id}")]
        public int GetTestValue(int id)
        {
            _addService.Add(1, 2);
            return id;
        }

        [HttpPost]
        [Route("api/test")]
        public Test SetTestValue([FromBody] Test myObject)
        {
            _addService.Add(1, 2);
            return myObject;
        }

        [HttpGet]
        [Route("api/newTest")]
        public TestViewModel GeTestViewModel()
        {
            _addService.Add(1, 2);

            return new TestViewModel
            {
                Test = new Test
                {
                    TestInt = 1,
                    TestString = "1"
                },
                NewTest = new NewTest
                {
                    Field1 = "Field1",
                    Field2 = 2
                }
            };
        }

        [HttpGet]
        [Route("api/template")]
        public Response<int> TemplateExample()
        {
            var response = new Response<int>();

            try
            {
                response.Data = _addService.Add(1, 2);
            }
            catch (Exception ex)
            {
                response.IsError = true;
                response.Error = new Error
                {
                    Message = ex.Message,
                    Code = 1
                };
            }

            return response;
        }
    }
}
