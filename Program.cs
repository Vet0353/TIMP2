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
            GraphI graph = new GraphI(new dfs());
        }
        
    }
    interface IStrategy
    {
        GraphElement GetNext(GraphElement element);
    }
    class dfs : IStrategy
    {
        public Stack<GraphElement> stack = new Stack<GraphElement>();
        public GraphElement GetNext(GraphElement element)
        {
            GraphElement next;
            stack.Push(element);
            foreach (GraphElement child in element.ListElements)
            {
                if (!stack.Contains(child))
                {
                    next = child;
                    break;
                }
            }
        }
        GraphElement Faind(GraphElement element)
        {

        }
    }
}
