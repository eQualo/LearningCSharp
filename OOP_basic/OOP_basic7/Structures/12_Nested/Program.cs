using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Nested
{
    struct MyStruct
    {
        public class Nested
        {
			public struct NestedStuct
			{
				public void Method()
				{
					Console.WriteLine("2");
				}
			}
            public void Method()
            {
                Console.WriteLine("1");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
			MyStruct myStruct = new MyStruct();
			MyStruct.Nested.NestedStuct nestedStuct = new MyStruct.Nested.NestedStuct();
			nestedStuct.Method();
        }
    }
}
