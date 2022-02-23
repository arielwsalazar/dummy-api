using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace dummyApi.Controllers
{
    [ApiController]
    [Route("calculator")]
    public class CalculatorController:ControllerBase 
    {
        [Route("Add")]
        [HttpGet]
        public JsonResult Add([FromQuery(Name ="Value1")] int val1, [FromQuery(Name = "Value2")] int val2)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            result.Add("result", val1 + val2);
            return new JsonResult(result);
        }
    }
}
