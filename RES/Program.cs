using RES.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RES
{
   public class Program
    {

   

        private static Writter.Writter writter ;
        public static RES.Reader.Reader reader  = new Reader.Reader();
        public static RES.ReplicatorReceiver.ReplicatorReciever rr;
        public static RES.ReplicatorSender.ReplicatorSender rs;
        public static Program instanca;
        public static object syncLock = new object();
      
        public Program()
        {
           
           

            //rr = new ReplicatorReceiver.ReplicatorReciever();
           // rs = new ReplicatorSender.ReplicatorSender();

          //  RES.Common.LoadBalancer.Instanciranje(syncLock,instanca);

        }
        ~Program()
        {

        }
      public  static void Main(string[] args)
        {
            Logger.Logger.LoggToFile(Component.SYSTEM, DateTime.Now, "System is starting...");

            while (true)
            {
                Console.WriteLine("\nEnter one number for:");
                Console.WriteLine("\t1 - Write in database ");
                Console.WriteLine("\t2 - Read values in database");
                Console.WriteLine("\t0 - Exit");


                int meni= Int32.Parse(Console.ReadKey().KeyChar.ToString());


                if (meni.Equals(0))
                {
                    Console.WriteLine("System is shuting down.");
                    Logger.Logger.LoggToFile(Component.SYSTEM, DateTime.Now, "System is shuting down.");
                    break;
                    
                }
                else if (meni.Equals(1))
                {
                  WritteInDataBase();

                }
                else if (meni.Equals(2))
                {

                }else
                {
                    Console.WriteLine("Try again");
                }

                

            }
            
        }

        private static void WritteInDataBase()
        {
            writter = new Writter.Writter();

            Codes code = InputCode();
            double value = InputValue();

            writter.WritteToReplicatorSender(code, value);
        
            
        }

        private static double InputValue()
        {
            Console.WriteLine("Enter value: ");
            double value = double.Parse(Console.ReadLine());

            //if (code.Equals(Codes.CODE_DIGITAL))
            //{
            //    Console.WriteLine("Value must 0 or 1:");

            //    if (!value.Equals("1") || !value.Equals("0"))
            //    {
            //        Console.WriteLine("Enter value 0 or 1!");
            //        return 0;
            //    }
            //}

            return value;
        }

        private static Codes InputCode()
        {
          
            Console.WriteLine("Enter code: ");
            Console.WriteLine("\t1 - CODE_ANALOG");
            Console.WriteLine("\t2 - CODE_DIGITAL");
            Console.WriteLine("\t3 - CODE_CUSTOM");
            Console.WriteLine("\t4 - CODE_LIMITSET");
            Console.WriteLine("\t5 - CODE_SINGLENODE");
            Console.WriteLine("\t6 - CODE_MULTIPLENODE");
            Console.WriteLine("\t7 - CODE_CONSUMER");
            Console.WriteLine("\t8 - CODE_SOURCE");
            char option = Console.ReadKey().KeyChar;
            
            if (option < '1' || option > '8')
            {
                Console.WriteLine("Try again to enter a number between 1 and 8");
                return 0;

            }

            return (Codes)(int.Parse(option.ToString()) - 1);
            //-1 jer enum ide od 0
           
        }
    }
}
