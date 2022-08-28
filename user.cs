using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoprite_Management_System
{
    public class user
    {
        public string usrName;
        public int id;
        string dob;
        string phone;
        string pass;
        public user(string usrName, int id, string dob, string phone, string pass)
        {
            this.usrName = usrName;
            this.id = id;
            this.dob = dob;
            this.phone = phone;
            this.pass = pass;
        }
        

    }
}
