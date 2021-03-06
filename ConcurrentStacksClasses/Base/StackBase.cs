﻿namespace ConcurrentStacksClasses
{
    public abstract class StackBase<T>
    {
        protected Item _head = null;

        protected class Item
        {
            private readonly T _data;
            private readonly Item _next;            

            public Item(T data, Item next)
            {
                _data = data;
                _next = next;
            }

            public T Data
            {
                get { return _data; }
            }

            public Item Next
            {
                get { return _next; }
            }
        }

        public bool IsEmpty
        {
            get { return _head == null; }
        }

        public abstract void Push(T data);

        public abstract bool TryPop(out T data);
    }
}
