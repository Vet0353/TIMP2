using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIMP2
{
    class GraphI : IteratorAggregate
    {
        List<GraphI> elements;
        bool visited;
        public GraphI(IStrategy method)
        {
            elements = new List<GraphI>();
            Method = method;
            visited = false;
        }

        public List<GraphI> Elements { get => elements; }
        public bool Visited { get => visited; set => visited = value; }
        IStrategy Method { get; set; }
        //ssss
        public override IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();
        public abstract object Current();
        public abstract bool MoveNext();
        public abstract void Reset();
    }

    class GraphIterator : Iterator
    {
        private GraphI head;
        private GraphI curr;

        public GraphIterator(GraphI element)
        {
            head = element;
            curr = element;
        }

        public override object Current()
        {
            return head;
        }

        public override bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public override void Reset()
        {
            curr = head;
        }

        public IStrategy Method { private get; set; }
    }
    abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}
