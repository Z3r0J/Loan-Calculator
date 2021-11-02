using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ComboBoxItem
{
    public class ComboBoxItem
    {

        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
