using RES.Common;
using RES.ReplicatorReceiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RES.ReplicatorSender
{
   // CollectionDescription sadrži: ● ID ● Dataset ● HistoricalCollection
    public class CollectionDescription
    {


		private int id;

		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		private int data;

		public int Data
		{
			get { return data; }
			set { data = value; }
		}

		public HistoricalCollection Historical { get; set; }



		public CollectionDescription()
		{
			Historical = new HistoricalCollection();
		}
	}
}
