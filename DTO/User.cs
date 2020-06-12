using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {
        public int Uid { get; set; }

        public int Id { get; set; }

        public string Username { get; set; }

        public decimal Balance { get; set; }

        public override string ToString()
        {
            return $"Uid : {Uid}, CardId : {Id},  Username : {Username}, Balance : {Balance}";
        }
    }
}
