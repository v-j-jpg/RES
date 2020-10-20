using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RES.Common
{
    public class DataSet
    {


        public static int GetDataSet(Codes codes)
        {

            int dataSetNum = -1;

            switch (codes)
            {
                case Codes.CODE_ANALOG:
                case Codes.CODE_DIGITAL:
                    dataSetNum = 1;
                    break;
                case Codes.CODE_CUSTOM:
                case Codes.CODE_LIMITSET:
                    dataSetNum = 2;
                    break;
                case Codes.CODE_SINGLENODE:
                case Codes.CODE_MULTIPLENODE:
                    dataSetNum = 3;
                    break;
                case Codes.CODE_CONSUMER:
                case Codes.CODE_SOURCE:
                    dataSetNum = 4;
                    break;
            }

            return dataSetNum;
        }
    }
}
       

          
    

