using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate
{
    public class CustomStack
    {
        private class CustomStackElement
        {
            public object Data { get; set; }
            public CustomStackElement NextElement { get; set; }
        }

        private CustomStackElement FirstElement { get; set; }

        public void Push(object data)
        {
            if(IsEmpty())
            {
                FirstElement = new CustomStackElement();
                FirstElement.Data = data;
            }
            else
            {
                var newElement = new CustomStackElement();
                newElement.Data = data;

                var currentElement = FirstElement;

                while (currentElement.NextElement != null)
                    currentElement = currentElement.NextElement;

                currentElement.NextElement = newElement;
            }
        }

        public object Pop()
        {
            var currentElement = FirstElement;
            object returnVal;

            if (currentElement.NextElement != null)
            {
                while (currentElement.NextElement.NextElement != null)
                    currentElement = currentElement.NextElement;

                returnVal = currentElement.NextElement.Data;
                currentElement.NextElement = null;
            }
            else
            {
                returnVal = currentElement.Data;
                FirstElement = null;
            }

            return returnVal;
        }

        public object Top()
        {
            if (!IsEmpty())
            {
                var currentElement = FirstElement;

                while (currentElement.NextElement != null)
                    currentElement = currentElement.NextElement;

                return currentElement.Data;
            }
            else
                return null;
        }

        public void Clear()
        {
            var currentElement = FirstElement;
            FirstElement = null;
            CustomStackElement nextElement;

            while (currentElement.NextElement != null)
            {
                nextElement = currentElement.NextElement;
                currentElement.NextElement = null;
                currentElement = nextElement;
            }
        }

        private bool IsEmpty() => FirstElement == null ? true : false;
    }
}
