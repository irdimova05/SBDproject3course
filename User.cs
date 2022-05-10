using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBDproject
{
    internal class User
    {
        int id;
        static User instance = null;

        public static User getInstance()
        {
            if (instance == null)
            {
                instance = new User();
            }
            return instance;
        }

        //create a constructor

        public User() { 
        }
        public User(int id)
        {
            this.id = id;
        }

        //get
        public int getId()
        {
            return id;
        }

        //set
        public void setId(int id)
        {
            this.id = id;
        }
    }
}
