
using System.IdentityModel.Tokens.Jwt;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Tik_A_Ticket.Data;

namespace Tik_A_Ticket.Repositories.AuthRepository;

public class AuthRepository : IAuthRepository
{
    private readonly DataContext _context;
    private readonly  IConfiguration _config;
    
    public AuthRepository(DataContext context,IConfiguration config)
    {
        _context = context;
        _config = config;
    }


    public async Task<ServiceResponse<long>> Register(Fan user, string password)
    {
        var response = new ServiceResponse<long>();
        if (await FanIdExists(user.FanId))
        {
            response.Success = false;
            response.Message = "FanId already exists.";
            return response;
        }
        if(!await ValidFanId(user.FanId))
        {
            response.Success = false;
            response.Message = "FanId is not valid. It Must be 14 digits.";
            return response;
        }
        
        if(await UserExists(user.Username)){
            response.Success = false;
            response.Message = "User already exists";
            return response;
        }

        if (await EmailExists(user.Email))
        {
            response.Success = false;
            response.Message = "Email already exists";
            return response;
        }

        if (!await ValidEmail(user.Email))
        {
            response.Success = false;
            response.Message = "Email is not valid";
            return response;
        }

        CreatePasswordHash(password,out byte[] passwordHash,out byte[] passwordSalt);
        user.PasswordHash = passwordHash;
        user.PasswordSalt = passwordSalt;


        _context.Fans.Add(user);
        await _context.SaveChangesAsync();
        response.Data = (long)user.FanId;
        return response;
    }

    public async Task<ServiceResponse<string>> EmailLogIn(string email, string password)
    {
        ServiceResponse<string> response = new ServiceResponse<string>();
        var user = await _context.Fans.FirstOrDefaultAsync(u => u.Email.ToLower().Equals(email.ToLower()));
        if(user == null){
            response.Success = false;
            response.Message = "User not found.";
        }
        else if(!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt)){
            response.Success = false;
            response.Message = "Wrong password.";
        }
        else{
            response.Data = CreateToken(user);
        }
        return response;
    }

    public async Task<ServiceResponse<string>> UserNameLogIn(string userName, string password)
    {
        ServiceResponse<string> response = new ServiceResponse<string>();
        var user = await _context.Fans.FirstOrDefaultAsync(u => u.Username.ToLower().Equals(userName.ToLower()));
        if(user == null){
            response.Success = false;
            response.Message = "User not found.";
        }
        else if(!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt)){
            response.Success = false;
            response.Message = "Wrong password.";
        }
        else{
            response.Data = CreateToken(user);
        }
        return response;
    }

    public async Task<bool> UserExists(string username)
    {
        if(await _context.Fans.AnyAsync(x => x.Username.ToLower().Equals(username.ToLower()))){
            return true;
        }
        return false;
    }

    public async Task<bool> EmailExists(string email)
    {
        if(await _context.Fans.AnyAsync(x => x.Email.ToLower().Equals(email.ToLower()))){
            return true;
        }
        return false;
    }

   

    public async Task<bool> FanIdExists(long fanId)
    {
        if(await _context.Fans.AnyAsync(x => x.FanId == fanId)){
            return true;
        }
        return false;
    }

    private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using (var hmac = new System.Security.Cryptography.HMACSHA512())
        {
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }
    }

    private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
    {
        using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
        {
            var computeHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            return computeHash.SequenceEqual(passwordHash);
        }
    }
    
    private string CreateToken(Fan user)
    {
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.FanId.ToString()),
            new Claim(ClaimTypes.Name, user.Email)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value));

        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.Now.AddDays(1),
            SigningCredentials = creds
        };

        var tokenHandler = new JwtSecurityTokenHandler();

        var token = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(token);
    }
    
    public async Task<bool> ValidFanId(long fanId)
    {
        if (Math.Floor(Math.Log10(fanId) + 1) == 14)
        {
            return true;
        }
        return false;
    }

    public async Task<bool> ValidEmail(string email)
    {
        try
        {
            MailAddress m = new MailAddress(email);

            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }
}