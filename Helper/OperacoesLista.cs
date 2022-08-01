using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_LINQ_Fundamentals_DIO.Helper
{
    internal class OperacoesLista
    {
        public void PrintStringList(List<string> Lista) 
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                Console.WriteLine($" Index -> [{i}] Value -> [{Lista[i]}]");
            }
        }
    }
}
