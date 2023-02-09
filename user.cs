using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Optional & default parameter//

    public class User
        {
            private int userid;
            private string username;
            private bool isAdmin;

            // isAdmin is a default paramter
            public User(int userid, string username, bool isAdmin = false)
            {
                this.userid = userid;
                this.username = username;
                this.isAdmin = isAdmin;
            }
            public override string ToString()
            {
                return $"userid ={userid} , username ={username} admin={isAdmin}";
            }
        }

    
}
