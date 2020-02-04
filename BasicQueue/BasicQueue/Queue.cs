using System;
using System.Collections.Generic;
using System.Text;

namespace BasicQueue
{
    class Queue<T>
    {
        private Node<T> first;

        private Node<T> last;
        //-----------------------------------
        public Queue()
        {
            this.first = null;

            this.last = null;
        }
        //-----------------------------------
        public bool IsEmpty()
        {
            return (this.first == null);
        }
        //-----------------------------------
        public void Insert(T x)
        {
            Node<T> temp = new Node<T>(x);

            if (this.first == null)

                this.first = temp;
            else

                this.last.SetNext(temp);

            this.last = temp;
        }
        //-------------------------------------
        public T Remove()
        {
            T x = this.first.GetValue();

            first = first.GetNext();

            if (this.first == null)

                this.last = null;

            return (x);
        }
        //-------------------------------------
        public T Head()
        {
            return (this.first.GetValue());
        }

        //-------------------------------------
        public Queue<T> CopyQ()
        {
            Queue<T> Temp = new Queue<T>();
            Node<T> pos = this.first;
            while (pos!=null)
            {
                Temp.Insert(pos.GetValue());
                pos = pos.GetNext();
            }
            return Temp;
        }

        //-------------------------------------
        public override string ToString()
        {
            string st = "[";

            Node<T> pos = this.first;

            while (pos != null)
            {
                st += pos.GetValue();

                if (pos.GetNext() != null)

                    st += ",";

                pos = pos.GetNext();
            }
            st += "]";
            return (st);
        }
    }
}
