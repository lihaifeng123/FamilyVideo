using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVideoApp.Models.UserModels
{
    public class LoginUser
    {
        private string Name { get; set; }

        private string Password
        {
            set;
            get;
        }

        public static bool operator ==(LoginUser user1,LoginUser user2)
        {
            return user1.Equals(user2);
        }
        public static bool operator !=(LoginUser user1, LoginUser user2)
        {
            return !user1.Equals(user2);
        }
        public override bool Equals(Object obj)
        {
            try
            {
                LoginUser login = (LoginUser)obj;
                if (login.Name == this.Name && login.Password == this.Password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception e)
            {
                return false;
            }
            
        }
    }
}
