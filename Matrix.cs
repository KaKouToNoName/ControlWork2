using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSpace
{
    // ВАРИАНТ 1 
    internal class Matrix
    {
        private int[,] matr;
        public string file = "D:\\VisualStudio\\Study\\ControlWork2\\input.txt";
        public int r;
        public int c;
        public Matrix(string file)
        {
            string info = File.ReadAllText(file);
            string[] rows = info.Split('\n');
            for (int i = 0; i < rows.Length; i++)
            {
                string[] columns = rows[i].Split(' ');
                //Console.WriteLine($"{columns[0]}, {columns[1]}");
                if (i == 0)
                {
                    r = int.Parse(columns[0]);
                    c = int.Parse(columns[1]);
                    matr = new int[r, c];
                }
                else
                {
                    for (int j = 0; j < columns.Length; j++)
                    {
                        matr[i - 1, j] = int.Parse(columns[j]);
                    }
                }
            }
        }
        public void Changer()
        {
            int buff;
            int maxRow = MaxSumRow();
            int minRow = MinSumRow();
            for (int j = 0;j < c; j++)
            {
                buff = matr[minRow, j];
                matr[minRow, j] = matr[maxRow, j];
                matr[maxRow, j] = buff;
            }
        }
        public int MaxSumRow()
        {
            int Max = int.MinValue;
            int MaxRow = 0;
            for (int i = 0; i < r; i++)
            {
                int sum = 0;
                for (int j = 0; j < c; j++) sum += matr[i, j];
                if (sum > Max)
                {
                    Max = sum;
                    MaxRow = i;
                }
            }
            return MaxRow;
        }
        public int MinSumRow()
        {
            int Min = int.MaxValue;
            int MinRow = 0;
            for (int i = 0; i < r; i++)
            {
                int sum = 0;
                for (int j = 0; j < c; j++) sum += matr[i, j];
                if (sum < Min)
                {
                    Min = sum;
                    MinRow = i;
                }
            }
            return MinRow;
        }
        public void Print()
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                    Console.Write($"{matr[i, j],3} ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
