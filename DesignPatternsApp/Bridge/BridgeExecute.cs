using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class BridgeExecute
    {
        public static void BridgeCommand()
        {

            bool repeat = true;
            while (repeat)
            {
                IMessageSender email = new EmailSender();
                IMessageSender queue = new MSMQSender();
                IMessageSender web = new WebServiceSender();

                Message message = new SystemMessage();
                message.Subject = "Test Message";
                message.Body = "Hi, This is a Test Message";

                message.MessageSender = email;
                message.Send();

                message.MessageSender = queue;
                message.Send();

                message.MessageSender = web;
                message.Send();

                UserMessage usermsg = new UserMessage();
                usermsg.Subject = "Test Message";
                usermsg.Body = "Hi, This is a Test Message";
                usermsg.UserComments = "I hope you are well";

                usermsg.MessageSender = email;
                usermsg.Send();

                Console.Write("Go again? Y/N: ");
                string go = Console.ReadLine();
                if (go == "Y" || go == "y")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }
            }

        }
    }
}