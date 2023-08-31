using Microsoft.AspNetCore.Mvc;
using API.Data;

[ApiController]
[Route("api/[controller]")] 

public class UserController : ControllerBase
{
    private readonly DataContext _context;
    public UserController()
    {

    }
}