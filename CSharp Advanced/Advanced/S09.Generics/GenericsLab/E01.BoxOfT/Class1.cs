using System.Collections.Generic;
using System.Linq;

namespace BoxOfT
{
    internal class Box<T>
    {
        private List<T> boxList;

        public Box()
        {
            boxList = new List<T>();
        }

        public void Add(T item)
        {
            this.boxList.Add(item);
        }

        public T Remove()
        {
            var rem = this.boxList.Last();
            this.boxList.RemoveAt(boxList.Count - 1);
            return rem;
        }
    }
}
