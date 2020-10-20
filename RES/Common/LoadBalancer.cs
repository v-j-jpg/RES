using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RES.Common
{
    public class LoadBalancer
    {

        public static Program Instanciranje(object syncLock, Program instanca)
        {
            lock(syncLock)
            {

                if (instanca == null)
                {
                    instanca = new Program();
                }

            }
            return instanca;

        }

        
    }
}
