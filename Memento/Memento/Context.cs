using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento
{
    public class Context
    {

        TextCareTaker careTake = new TextCareTaker();

        public void Save(RichTextBox richTex)
        {
            careTake.AddMemento(new TextMemento(richTex.Text));
        }

        public void Load(RichTextBox richText)
        {
            TextMemento textM = careTake.GetPrev();
            if (textM != null && textM.savedText != null)
            {
                richText.Text = textM.savedText;
                //careTake.RemoveMemento(careTake.GetNext());
            }
                
        }

        public void Redo(RichTextBox richText)
        {
            TextMemento textM = careTake.GetNext();
            if (textM != null && textM.savedText != null)
            {
                richText.Text = textM.savedText;
                //careTake.RemoveMemento(careTake.GetNext());
            }

        }
    }
}
