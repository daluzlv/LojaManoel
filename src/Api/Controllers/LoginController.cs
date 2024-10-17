using Domain.Dto;
using Domain.Repositories.Users;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("/v1/login")]
public class LoginController : ControllerBase
{
    private readonly ITokenService _tokenService;
    private readonly IUserRepository _userRepository;
    public LoginController(ITokenService tokenService, IUserRepository userRepository)
    {
        _tokenService = tokenService;
        _userRepository = userRepository;
    }

    [HttpPost]
    public async Task<IActionResult> Authenticate(UserDto dto)
    {
        var user = _userRepository.Get(dto.Username, dto.Password);
        if (user == null) return NotFound(new { message = "Usuário ou senha inválidos" });

        user.Password = "";
        var token = _tokenService.GenerateToken(user);
        return Ok(new
        {
            user = user,
            token = token
        });
    }
}
