using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditorMemento
{
    internal class Memento
    {
        public string Data { get; private set; }
        public Memento(string data)
        {
            Data = data;
        }

        public bool Remember(string text)
        {
            if (Data != null)
            {
                Data = text;
                return true;
            }
            return false;
        }
        public void Undo(ref RichTextBox rtb)
        {
            if (Data != null)
            {
                rtb.Text = Data;
            }
        }
    }
}
