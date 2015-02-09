using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evil_Operator
{
    class MBox
    {
        public int type = 0;
        public int numofBox = 0;
        public bool inf = false;
        public string msg;

        public void Launch()
        {
            while (numofBox != 0)
            {
                switch (type)
                {
                    case 1://info
                        MessageBox.Show(msg.ToString(), "Info", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                        break;
                    case 2://warning
                        MessageBox.Show(msg.ToString(), "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        break;
                    case 3://error
                        MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        break;
                }
                numofBox--;
            }
            while (inf)
            {
                switch (type)
                {
                    case 1://info
                        MessageBox.Show(msg.ToString(), "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        break;
                    case 2://warning
                        MessageBox.Show(msg.ToString(), "Warning", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                        break;
                    case 3://error
                        MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                        break;
                }
            }
        }
    }
}
