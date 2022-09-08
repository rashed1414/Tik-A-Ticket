using Microsoft.AspNetCore.Mvc;
using Tik_A_Ticket.DTO.FanDTO;
using Tik_A_Ticket.Repositories.AuthRepository;

namespace Tik_A_Ticket.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthRepository _authRepository;
    
    public AuthController(IAuthRepository authRepository)
    {
        _authRepository = authRepository;
    }
    
    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterFanDto registerDto)
    {
        var response = await _authRepository.Register(
            new Fan
            {
              Username  = registerDto.Username,
                Email = registerDto.Email,
                FanId = registerDto.FanId,
                Name = registerDto.Name,
               
            }, registerDto.Password
            );
        if (!response.Success)
        {
            return BadRequest(response);
        }
        return Ok(response);
    }
    
    [HttpPost("loginViaEmail")]
    public async Task<IActionResult> LoginViaEmail(LoginFanDto loginDto)
    {
        var response = await _authRepository.EmailLogIn(loginDto.Email, loginDto.Password);
        if (response.Success)
        {
            return Ok(response);
        }
        return BadRequest(response);
    }
    
    [HttpPost("loginViaUsername")]
    public async Task<IActionResult> LoginViaUsername(LoginFanDto loginDto)
    {
        var response = await _authRepository.UserNameLogIn(loginDto.Username, loginDto.Password);
        if (response.Success)
        {
            return Ok(response);
        }
        return BadRequest(response);
    }
}