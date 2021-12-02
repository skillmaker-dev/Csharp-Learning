using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_Basics
{
    class Stack
    {
        private List<object> _list = new List<object>();
        public void Push(object obj)
        {
            if (obj != null)
                this._list.Add(obj);
            else 
                throw new InvalidCastException("null object");
        
                    
        }

        public object Pop()
        {
            object RemovedItem; 
            if (this._list.Count != 0)
            {
                RemovedItem = this._list[this._list.Count - 1];
                this._list.RemoveAt(_list.Count - 1);
            }
            else throw new InvalidOperationException("Stack is empty");

            return RemovedItem;
        }

        public void Clear()
        {
            this._list.Clear();
        }
    }
}
