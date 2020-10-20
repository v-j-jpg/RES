using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RES.ReplicatorReceiver
{
   public class HistoricalCollection
    {
        List<ReceiverProperty> receiverProperties;

        public List<ReceiverProperty> ReceiverProperties { get => receiverProperties; set => receiverProperties = value; }

        public HistoricalCollection()
        {
            receiverProperties = new List<ReceiverProperty>();
        }
    }
}
