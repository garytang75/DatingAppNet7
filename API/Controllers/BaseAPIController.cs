using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    //API automatically bind object within the parameters and
    //it will take care of the validation before it hits the api
    [ApiController]
    [Route("api/[controller]")]
    public class BaseAPIController:ControllerBase
    {
        
    }
}