using System.Collections.Generic;

namespace TD1cli
{
    public class Sorting
    {
        private List<int> _list;

        public Sorting()
        {
            this._list = new List<int>();
        }

        public void add_list(int a)
        {
            this._list.Add(a);
        }

        public int get_lower()
        {
            int res = this._list[0];
            foreach (int element in this._list)
            {
                if (element < res)
                {
                    res = element;
                }
            }

            this._list.RemoveAt(this._list.IndexOf(res));
            return res;
        }

    }
}