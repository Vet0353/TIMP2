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
        GraphElement head;
        public GraphI(IStrategy method)
        {
            Method = method;
        }

        internal GraphElement Head { get { return head; } }
        public IStrategy Method { get; set; }
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
        GraphI graph;
        GraphElement current;
        public GraphIterator(GraphI graph)
        {
            this.graph = graph;
            current = this.graph.Head;
        }

        public override object Current()
        {
            return current;
        }

        public override bool MoveNext()
        {
            
        }

        public override void Reset()
        {
            
        }
    }
    abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}
