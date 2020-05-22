using DTO;

namespace BLL
{
    public interface IUserManager
    {
        User GetUserById(int id);

        User GetUserByCardId(int id);

        User GetUserByUsername(string username);

        int UpdateBalance(User user);

        string GetBalance(User user);

    }
}