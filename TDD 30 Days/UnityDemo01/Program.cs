using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDemo01
{
   class Program
   {
      static void Main(string[] args) {
         var container = new UnityContainer();
         ISayHello hello = container.Resolve<SayHelloInEnglish>();
         hello.Run();
         Console.ReadKey();
      }
   }
}
