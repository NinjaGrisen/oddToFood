using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    //Explicit route for AboutController
    //if [Route("[controller]")] then use about as name and if you want to call it something else [Route("Somethingelse")]
    //Literals can also be uses company/["controller"]
    //If the actions dont have to be setup it can be writen like [Route("company/[controller]/[action]")]
    [Route("company/[controller]")]
    public class AboutController
    {
        //Will be the default action no need for /about/phone just /about

        [Route("[action]")]
        public string Phone()
        {
            return "555-555 5555";
        }
        [Route("")]
        public string Country()
        {
            return "Denmark";
        }

        [Route("age")]
        public string Age()
        {
            return "98";
        }
    }
}
