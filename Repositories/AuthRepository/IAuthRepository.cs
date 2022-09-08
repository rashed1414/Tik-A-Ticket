namespace Tik_A_Ticket.Repositories.AuthRepository;

public interface IAuthRepository
{
    Task<ServiceResponse<long>> Register(Fan user, string password);
    Task<ServiceResponse<string>> EmailLogIn (string email,string password);
    Task<ServiceResponse<string>> UserNameLogIn (string userName,string password);
    Task<bool> UserExists(string username);
    Task<bool> EmailExists(string email);
    Task<bool> FanIdExists(long fanId);
    Task<bool> ValidFanId(long fanId);
    Task<bool> ValidEmail(string email);

}