using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace CSAc4ySDTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var ctx = new Context())
            {
                List<Ac4ySDCommunication> ac4YSDCommunications = new List<Ac4ySDCommunication>();
                ac4YSDCommunications.Add(new Ac4ySDCommunication() { Message = new Ac4ySDMessage() { Message = "Teszt" } });
                ac4YSDCommunications.Add(new Ac4ySDCommunication()
                {
                    Sender = new Ac4ySDParticipant() { Name = "Jack" }
                    ,
                    Receiver = new Ac4ySDParticipant() { Name = "Flora" }
                });

                Ac4ySDSequence ac4YSDSequence = new Ac4ySDSequence()
                {
                    Communications = ac4YSDCommunications
                };

                //ctx.ac4ySDSequences.Add(ac4YSDSequence);
                //ctx.SaveChanges();
                
                int id = 1;
                List<int> messageID = new List<int>();

                List<Ac4ySDSequence> s = ctx.ac4ySDSequences.Include(ss => ss.Communications.Select(mm => mm.Message)).ToList();
                ICollection<Ac4ySDCommunication> ac4YSD = s[0].Communications;
                foreach (Ac4ySDCommunication a in ac4YSD)
                {
                    Console.WriteLine(a.Message.Message);
                }
                /*
                foreach(var ac4ySDCommunication in x)
                {
                    messageID.Add(ac4ySDCommunication.MessageID);
                }

                int id2 = messageID[0];

                List<Ac4ySDMessage> y = ctx.ac4ySDMessages.ToList();*/
                //Console.WriteLine(y.Message);
            }
        }
    }
}
