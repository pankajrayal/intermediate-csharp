﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExercise
{
    public class Stack
    {
        private readonly List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("You can not add a null object to the stack.");

            _list.Add(obj);
        }

        public object Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("There are no elements in the stack yet.");

            var index = _list.Count - 1;
            
            var toReturn = _list[index];

            _list.RemoveAt(index);

            return (toReturn);
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}
