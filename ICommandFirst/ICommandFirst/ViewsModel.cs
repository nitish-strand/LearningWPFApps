using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ICommandFirst
{
    class ViewsModel
    {
        public ICommand SomeCmd { get; set; }

        public ViewsModel()
        {
            SomeCmd = new GenCommand(action, boolant);
        }

        private bool boolant(object parm)
        {
            return true;
        }

        private void action(object parm)
        {
            MessageBox.Show("Some msgs...........");
        }
    }


}
