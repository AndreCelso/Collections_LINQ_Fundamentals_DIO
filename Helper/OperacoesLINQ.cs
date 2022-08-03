using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_LINQ_Fundamentals_DIO.Helper
{
    internal class OperacoesLINQ
    {
        internal void PrintLINQuery(IOrderedEnumerable<int> OrderedArraybyLINQ)
        {
            var row = "[" + string.Join("]-[", OrderedArraybyLINQ) + "]";
            Console.WriteLine(row);
        }
    }
}
