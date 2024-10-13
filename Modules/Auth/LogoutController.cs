using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GameLibraryApi.Modules.Auth;

[ApiController]
[Authorize]
public class LogoutController(SignInManager<IdentityUser> signInManager)
{
    [HttpPost("auth/logout")]
    public async Task Logout()
    {
        await signInManager.SignOutAsync();
    }
}