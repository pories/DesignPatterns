using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPassed
{
    public class Facebook : ISocialNetworking
    {
        //linked list to keep track of subscribers
        private LinkedList<string> Users;
        public Facebook()
        {
            //Sing up for FaceBook account.
            Users = new LinkedList<string>();
            Users.AddLast("Mike");
            Users.AddLast("Jason");
            Users.AddLast("Paul");
            Users.AddLast("Mark");
            Users.AddLast("Luke");
            Users.AddLast("John");

        }

        public IIterator CreateIterator()
        {
            return new FacebookIterator(Users);
        }
    }
}
