using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLoginWithWPF.Models
{
    public class UserModel
    {
        private String name;
        private String password;
        private List<String> hobbies;

        public List<String> Hobbies
        {
            get { return hobbies; }
            set { hobbies = value; }
        }


        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public UserModel()
        {

        }

        public UserModel(String name, String password)
        {
            this.name = name;
            this.password = password;
            this.hobbies = new List<string>();
        }
    }
}
