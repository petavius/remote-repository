using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GitManual.App02.Helpers
{
    internal class TextHelpers
    {
        public static void WriteSomething(string something)
        {
            MessageBox.Show($"Text to write: {something}");
        }
    }
}
