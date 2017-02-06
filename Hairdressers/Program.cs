using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Hairdressers
{
    class Program
    {
        Thread l = new Thread(thread);

       
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            throw new NotImplementedException();
        }

         private static void thread()
        {
            Thread hairdresser1 = new Thread(thread);
            Thread hairdresser2 = new Thread(thread);
            Thread hairdresser3 = new Thread(thread);
            Thread hairdresser4 = new Thread(thread);
            Thread hairdresser5 = new Thread(thread);
            Thread hairdresser6 = new Thread(thread);

        }

        private static void objects()
        { 
            object customer1 = new object();
            object customer2 = new object();
            object customer3 = new object();
            object customer4 = new object();
            object customer5 = new object();
            object customer6 = new object();
        }

        private static void scissors()
        {

        }
        
    }
}
