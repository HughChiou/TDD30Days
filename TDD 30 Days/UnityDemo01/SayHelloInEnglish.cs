using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDemo01
{
   class SayHelloInEnglish: ISayHello
   {
      public SayHelloInEnglish() {
      }

      public SayHelloInEnglish(User aUser) {
         Console.WriteLine("SayHelloInEnglish(User aUser) is called");
      }

      public void Run() {
         Console.WriteLine("Hello, Unity!");
      }
   }
}
