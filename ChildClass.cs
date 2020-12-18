using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VSC_Folder
{
// class ChildClass : ParentClass
class ChildClass : AbstractClass

    {

        public void sayHello()
        {
            Console.WriteLine("Hello from Child");
        }
        public void sayGoodBye()
        {
            Console.WriteLine("Say Good Bye");
        }
    }
}        