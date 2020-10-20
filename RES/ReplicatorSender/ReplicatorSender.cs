using RES.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RES.ReplicatorSender
{
   public  class ReplicatorSender
    {
        Dictionary<Codes, double> baffer  = new Dictionary<Codes, double>();

        public void SendToReplicatorReciever()
        {
            foreach (var item in baffer)
            {
               // ReplicatorReceiver();
            }
        }

        public ReplicatorSender(double value,Codes codes)
        {
            baffer.Add(codes, value);

            //logger
            Logger.Logger.LoggToFile(Component.REPLICATOR_SENDER, DateTime.Now, "ReplicatorSender has recevied data.");
        }
    }
}
