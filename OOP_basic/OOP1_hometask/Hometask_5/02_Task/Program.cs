using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix myMatrix = new MyMatrix(4, 5);

            myMatrix.Show();

            myMatrix.ChangeSize(3, 6);
            myMatrix.Show();
        }
    }
}
