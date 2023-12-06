using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MatrixSpace;

namespace ControlWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ВАРИАНТ 1 
            string file = "D:\\VisualStudio\\Study\\ControlWork2\\input.txt";
            Matrix m = new Matrix(file);
            m.Print();
            m.Changer();
            m.Print();
        }
    }
}
