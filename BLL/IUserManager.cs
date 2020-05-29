<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
=======
﻿using DTO;
>>>>>>> master

namespace BLL
{
    public interface IUserManager
    {
<<<<<<< HEAD
        User GetUserById(int id);
    }
}
=======
        User GetUserById(int uid);

        User GetUserByCardId(int cardId);

        User GetUserByUsername(string username);

        int UpdateBalance(User user);

        string GetBalance(User user);

    }
}
>>>>>>> master
