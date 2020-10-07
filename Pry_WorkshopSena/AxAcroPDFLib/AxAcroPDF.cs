using System.Drawing;
using System.Windows.Forms;

namespace AxAcroPDFLib
{
    internal class AxAcroPDF
    {
        public AxAcroPDF()
        {
        }

        public bool Enabled { get; internal set; }
        public Point Location { get; internal set; }
        public string Name { get; internal set; }
        public AxHost.State OcxState { get; internal set; }
        public Size Size { get; internal set; }
        public int TabIndex { get; internal set; }
    }
}