using RES.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RES.ReplicatorReceiver
{
    public class ReceiverProperty
    {
		private double values;

		public double Value
		{
			get { return values; }
			set { values = value; }
		}

		private Codes code;

		public Codes Code
		{
			get { return code; }
			set { code = value; }
		}

		public ReceiverProperty(double values, Codes code)
		{
			this.values = values;
			this.code = code;
		}
	}
}
