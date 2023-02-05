using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericScale
{
    internal class EqualityScale<T>
    {
        private T left; private T right;

        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

       

    }
    public static bool AreEqual<T>(T left, T right)
    {
        return false;
    }
}

