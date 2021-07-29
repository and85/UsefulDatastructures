using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulDatastructures
{
    // taken from coursera: https://www.coursera.org/learn/algorithms-part1/lecture/ZgecU/quick-union    
    public class QuickUnionUF
    {
        private int[] _parent;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">Number of unique elements</param>
        public QuickUnionUF(int n)
        {
            _parent = new int[n];
            Count = n;

            for (int i = 0; i < n; _parent[i] = i++)
            {
            }

        }

        public int Count { get; set; }

        // returns component number where p is located
        public int Find(int p)
        {
            Validate(p);

            while (p != _parent[p])
            {
                p = _parent[p];
            }

            return p;
        }

        private void Validate(int p)
        {
            int n = _parent.Length;
            if (p < 0 || p >= n)
            {
                throw new ArgumentException("index " + p + " is not between 0 and " + (n - 1));
            }
        }

        public void Uunion(int p, int q)
        {
            int rootP = Find(p);
            int rootQ = Find(q);
            if (rootP != rootQ)
            {
                _parent[rootP] = rootQ;
                Count--;
            }
        }
    }
}
