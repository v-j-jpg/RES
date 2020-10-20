using RES.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RES.Writter
{
    public class Writter
    {
        public static  Random random = new Random();

        public Writter()
        {
            Thread thread = new Thread(Writte);
            thread.Start();
            Logger.Logger.LoggToFile(Component.SYSTEM, DateTime.Now, "Thread is started");

        }
        public void WritteToReplicatorSender(Codes codes,double value)
        {
            ReplicatorSender.ReplicatorSender replicatorSender=new ReplicatorSender.ReplicatorSender(value,codes);
            //Upis u logger
            Logger.Logger.LoggToFile(Component.WRITTER,DateTime.Now,"Data is send to ReplicatorSender.");
        }
        public void Writte()
        {
            //Generise random ime iz enum klase
            Codes code = (Codes)random.Next(Enum.GetNames(typeof(Codes)).Length);

             //Generise rnd float vrednosti
            // 80.69833684  40.06479342  81.77382056  49.13457648  34.14766599  99.87410768
            double value = random.NextDouble() * 100.0;
           

            Logger.Logger.LoggToFile(Common.Component.WRITTER, DateTime.Now, "Data is written automatically.");

            Thread.Sleep(2000);//Upisuje na svake dve sekunde
        }
    }
}
