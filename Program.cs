using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIMP2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        
    }
    interface IStrategy
    {
        GraphI Move(GraphI head);
    }
    class dfs : IStrategy
    {
        public GraphI Move(GraphI head)
        {
            head.Visited = true;
            foreach (GraphI element in head)
            {

            }

        }
    }
}
