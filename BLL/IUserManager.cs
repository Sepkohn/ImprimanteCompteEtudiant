using DTO;

namespace BLL
{
    public interface IUserManager
    {
        User GetUserById(int uid);

        User GetUserByCardId(int cardId);

        User GetUserByUsername(string username);

        int UpdateBalance(User user);

        decimal GetBalance(User user);

    }
}