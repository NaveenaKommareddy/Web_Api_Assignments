using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using JWT_Token.Models;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class EmployeeController : ControllerBase
{
    [HttpGet]
    [Route("GetData")]
    public string GetData()
    {
        return "Authenticated with JWT";
    }
    [HttpGet]
    [Route("Details")]
    public string Details()
    {
        return "Authenticated with JWT";
    }

    [HttpPost]
    public string AddUser(Users user)
    {
        return "User added with username: " + user.Username;
    }
}
