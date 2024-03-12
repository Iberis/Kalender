using System.Drawing;
using System.Windows.Forms;

namespace Kalender
{
    class ButtonDay : Button
    {
        public readonly int index;
        public ButtonDay(int i)
        {
            index = i;
            Name = "Day" + i.ToString();
            Text = i.ToString();

            FlatStyle = FlatStyle.Standard;
            UseVisualStyleBackColor = true;
            Size = new Size(50, 50);
            FontHeight = 14;
        }

        
    }
}
