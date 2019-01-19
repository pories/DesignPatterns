using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPassed
{
    public class Twitter : ISocialNetworking
    {   //User should be an object instead, name, id, bla bla
        private string[] Users;

        public Twitter()
        {

            Users = new[] { "Kathy", "Lori", "Kristen", "Jamie" };
            //Below kills it. double declaring array, gives null value. 
            //string[] Users = new string[4];
            //this kills it too.
            //Users[0] = "Kathy";
            //Users[1] = "Lori";
            //Users[2] = "Kristen";
            //Users[3] = "Jamie";

        }

        public IIterator CreateIterator()
        {
            return new TwitterIterator(Users);
        }
    }
}
