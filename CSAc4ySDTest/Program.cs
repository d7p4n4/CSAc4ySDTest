using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAc4ySDTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var ctx = new Context())
            {/*
                List<Ac4ySDCommunication> ac4YSDCommunications = new List<Ac4ySDCommunication>();
                ac4YSDCommunications.Add(new Ac4ySDCommunication() { Message = new Ac4ySDMessage() { Message = "Teszt" } });
                ac4YSDCommunications.Add(new Ac4ySDCommunication() { Sender = new Ac4ySDParticipant() { Name = "Jack" } });

                Ac4ySDSequence ac4YSDSequence = new Ac4ySDSequence()
                {
                    Communication = ac4YSDCommunications
                };

                ctx.ac4ySDSequences.Add(ac4YSDSequence);
                ctx.SaveChanges();*/

                var s = ctx.ac4ySDSequences.Where(ss => ss.ID == 1).FirstOrDefault();

                Console.WriteLine(s.Communication.Count);
            }
        }
    }
}
