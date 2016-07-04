using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using UIComponents.Dialogs;

namespace ColorDropDownTest
{
    public class ColorDropDownTest
    {
        public ColorDropDownTest()
        {
            var dialog = new SimpleColorPickDialog();
            dialog.ShowDialog();
            MessageBox.Show("SelectedColor: " + dialog.SelectedColor.ToString());

        }
    }
}
