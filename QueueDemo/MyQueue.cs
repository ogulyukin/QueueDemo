using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo
{
    class MyQueue<T>
    {
        private Element<T> _Head;
        private Element<T> _Tail;
        private int _Size;
        
        public MyQueue()
        {
            _Head = null;
            _Tail = null;
            _Size = 0;
        }

        public int Count()
        {
            return _Size;
        }

        public void Push(T value)
        {
            if(_Size == 0)
            {
                _Head = _Tail = new Element<T>(value);
            }else
            {
                Element<T> temp = new Element<T>(value, _Head.getNext());
                _Head.setPrev(temp);
                _Head = temp;
            }
            _Size++;
        }

        public T Pop()
        {
            if (_Size == 0 )
                throw new Exception("Error: Queue is empty. Nothing to Pop");
            T result = _Tail.getValue();
            _Tail = _Tail.getPrev();
            if (_Size == 1)
            {
                _Head = null;
                _Tail = null;
            }else
            {
                _Tail.deleteNext();
            }

            _Size--;
            return result;
        }
    }
}
