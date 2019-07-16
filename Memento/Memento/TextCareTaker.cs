using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class TextCareTaker
    {
        int index = -1;
        List<TextMemento> mementoList = new List<TextMemento>();

        public void AddMemento(TextMemento memento)
        {
            mementoList.Add(memento);
            index++;
            mementoList.RemoveRange(index, (mementoList.Count - index - 1));
        }

        public void RemoveMemento(TextMemento memento)
        {
            mementoList.Remove(memento);
        }
        public TextMemento GetPrev()
        {
            if ((index != -1) && (index <  mementoList.Count))
            {
                index--;
                return mementoList[index+1]; 

            }
            index = 0;
            return null;

        }
        public TextMemento GetNext()
        {
            if ((index != -1) && ((index+1) < mementoList.Count))
            {
                index++;
                return mementoList[index];
            }
            else if (index == -1)
            {
                index = 0;
            }
            return null; 
        }
    }
}
