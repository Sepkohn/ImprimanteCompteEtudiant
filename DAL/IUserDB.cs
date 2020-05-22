using DTO;

namespace DAL
{
    public interface IUserDB
    {
        User GetUserById(int id);
        User GetUserByCardId(int id);

        User GetUserByUsername(string username);

        int UpdateBalance(User user);
    }
}