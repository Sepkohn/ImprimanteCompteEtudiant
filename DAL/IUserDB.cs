using DTO;

namespace DAL
{
    public interface IUserDB
    {
        User GetUserById(int id);
    }
}