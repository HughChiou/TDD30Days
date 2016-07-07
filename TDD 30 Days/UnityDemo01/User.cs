using Microsoft.Practices.Unity;
using System;

namespace UnityDemo01
{
   class User
   {
      [InjectionConstructor]
      public User() {
         Console.WriteLine("No Name");
      }

      public User(string name) {
         Console.WriteLine(name);
      }
   }
}