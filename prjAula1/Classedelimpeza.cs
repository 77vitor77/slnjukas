using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace prjAula1
{
    public static class Classedelimpeza
    {
        private static object parent;

        public static void LimpaForm(Form form)
        {

            foreach (Control controle in form.Controls)
            {

                if (controle is TextBox || controle is ComboBox)
                {
                    controle.Text = string.Empty;
                }
                else if (controle is DateTime) 
                {
                    controle.Text = DateTime.Now.ToString();
                }


            }
        }
    }



}


 





