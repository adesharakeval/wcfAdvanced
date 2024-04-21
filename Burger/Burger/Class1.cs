using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Windows.Forms;
namespace Burger
{
    public class Burger
    {
        int count;

        public int eat()
        {
            //string y = OperationContext.Current.SessionId.ToString();
            //MessageBox.Show(count+" "+y);
            count++;

            return count;
        }
    }
}
