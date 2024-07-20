using Ecommerce.Management.Application.Contracts.Exceptions;
using Ecommerce.Management.Application.Contracts.Identity;
using Ecommerce.Management.Domain.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Identity.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly JwtSettings _jwtSettings;

        public AuthService(UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager, IOptions<JwtSettings> jwtSettings)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtSettings = jwtSettings.Value;
        }
        public async Task<AuthResponse> Login(AuthRequest authRequest)
        {
            var user = await _userManager.FindByEmailAsync(authRequest.Email);
            if (user == null)
            {
                throw new NotFoundException($"User with {authRequest.Email} not found", authRequest.Email);
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, authRequest.Password, false);

            if (result.Succeeded == false)
            {
                throw new BadRequestException($"Credentials for '{authRequest.Email} aren't vaild'.");
            }

            JwtSecurityToken jwtSecurityToken = await GenerateToken(user);


        }

        private async Task<JwtSecurityToken> GenerateToken(IdentityUser user)
        {
            throw new NotImplementedException();
        }

        public Task<RegistrationResponse> Register(RegistrationRequest registerRequest)
        {
            throw new NotImplementedException();
        }
    }
}
