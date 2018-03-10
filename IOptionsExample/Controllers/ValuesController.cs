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
        public IOptions<MyConfigSettings> MyConfigSettings { get; }

        public ValuesController(IOptions<MyConfigSettings> myConfigSettings)
        {
            MyConfigSettings = myConfigSettings;
        }

       
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string firstSetting = MyConfigSettings.Value.FirstSetting;
            string secondSetting = MyConfigSettings.Value.SecondSetting;
            return new string[] { firstSetting, secondSetting };
        }        
    }
}
