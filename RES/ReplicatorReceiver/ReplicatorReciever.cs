using RES.Common;
using RES.ReplicatorSender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RES.ReplicatorReceiver
{
   public class ReplicatorReciever
    {
		int brojac = 0;

		private CollectionDescription CollectionDescription;

		public CollectionDescription GetCollectionDescription
		{
			get { return CollectionDescription; }
			set { CollectionDescription = value; }
		}

		public ReplicatorReciever(Dictionary<Codes,double> received)
		{
			CollectionDescription.ID = brojac++;
		
		}
	}
}
