using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo
{
    class Element<T>
    {
        private T _Value;
        private Element<T> _Prev;
        private Element<T> _Next;

        public Element(T value)
        {
            _Value = value;
            _Next = null;
            _Prev = null;
        }

        public Element(T value, Element<T> next)
        {
            _Value = value;
            _Next = next;
        }

        public T getValue()
        {
            return _Value;
        }

        public Element<T> getPrev()
        {
            return _Prev;
        }

        public Element<T> getNext()
        {
            return _Next;
        }

        public void setPrev(Element<T> prev)
        {
            _Prev = prev;
        }

        public void deleteNext()
        {
            _Next = null;
        }
    }
}
