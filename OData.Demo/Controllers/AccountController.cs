using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OData.Demo.Data;

namespace OData.Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public AccountController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [EnableQuery(PageSize = 5)]
        public IActionResult Get()
        {
            return Ok(_dbContext.Accounts.AsQueryable());
        }
    }


}
