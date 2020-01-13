using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomForms
{
    public static class MsgControl
    {
        public static void show(string msg)
        {
            msg1 uc = new msg1();
            uc.tb1.Text = msg;
            uc.ShowDialog();
        }
    }
}
