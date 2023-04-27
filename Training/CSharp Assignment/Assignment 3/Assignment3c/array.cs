using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3c
{
   
        public class StackException : Exception
        {
            public StackException(string message) : base(message) { }
        }

        public class stack
        {
        public int[] arr = new int[5];
        public int top = -1;
        public int size;
        public stack()
        {
            this.arr = arr;
            this.top = top;
            this.size = size;
        }

        public int size
        {
            get
            {
                return size;
            }
        }

         }
}
