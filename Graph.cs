using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIMP2
{
    public class Graph
    {
        private int[,] m_matrixS;
        public int n;
        public Graph(int n)
        {
            this.n = n;
            m_matrixS = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    m_matrixS[i, j] = 0;
        }

        public int FIRST(int v)
        {
            for (int i = 0; i < n; i++)
                if (m_matrixS[v, i] == 1)
                    return i;
            return -1;
        }

        public int NEXT(int v, int i)
        {
            for (int j = i + 1; j < n; j++)
                if (m_matrixS[v, j] == 1)
                    return j;
            return -1;
        }
        public int VERTEX(int v, int i)
        { return i; }

        public List<int> GetL(int v)
        {
            List<int> tmp = new List<int>();
            int w, i = FIRST(v);
            while (i != -1)
            {
                w = VERTEX(v, i);
                tmp.Add(w);
                i = NEXT(v, i);
            }
            return tmp;
        }
        public int[,] MatrixS { get { return m_matrixS; } set { m_matrixS = value; } }
    }
}
