using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RES.Reader
{
   public class Reader
    {
		private DateTime timeStamp;

		public DateTime TimeStamp
		{
			get { return timeStamp; }
			set { timeStamp = value; }
		}

		public Reader()
		{
				//logger
		}
		public void isDeadBand()
		{
			//Deadband uslovi
			//Deadband predstavlja uslov da li je potrebno podatak upisati u bazu.
			//Deadband iznosi 2 % i to znači da ukoliko pristigli podatak, već postoji u bazi, ukoliko je 
			// njegova nova vrednost različita više od 2 % od stare vrednosti, tada će biti upisana nova vrednost.
			//Ukoliko nova vrednost ne izlazi iz okvira od 2 % od stare vrednosti tada nova vrednost
			//ne treba da bude upisana u bazu.
			//Jedini izuzetak iz Deadband-a je Code – CODE_DIGITAL, 
			//za ovaj Code se uvek upisuje prosleđena vrednost i ne proverava se Deadband. 


		}
		public void WritteInDatabase()
		{
			//Upis u bazu
			//Prilikom upisa podatka u bazu, Reader komponenta će generisati timestamp sa vremenom upisa tog podatka,
			//i timestamp takođe treba da bude upisan u bazu zajedno sa podatkom koji se upisuje.

		}

		public void ReadFromDatabase()
		{
			//Reader komponenta radi dobavljanje poslednjih vrednosti izabranih Code-ova.
			//Reader komponenta treba da iščita istorijske vrednosti po vremenskom intervalu za traženi Code.
			
		}

	}
}
