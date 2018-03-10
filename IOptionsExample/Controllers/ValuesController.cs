using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace IOptionsExample.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller    
    {
        public MyConfigSettings MyConfigSettings { get; }

        public ValuesController(IOptions<MyConfigSettings> myConfigSettings)
        {
            MyConfigSettings = myConfigSettings.Value;
        }

       
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string firstSetting = MyConfigSettings.FirstSetting;
            string secondSetting = MyConfigSettings.SecondSetting;
            return new string[] { firstSetting, secondSetting };
        }        
    }
}
