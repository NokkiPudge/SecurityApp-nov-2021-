using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SECURITYapp
{
    class ProgressBar1 : ProgressBar // объявление класса индикатора выполнения
    {
        protected override CreateParams CreateParams // объявление класса параметров
        {
            get
            {
                CreateParams orientation = base.CreateParams; // обьявление класса параметра-ориентации
                orientation.Style |= 0x04;// установка вертикального положения
                return orientation; // возвращение положения
            }
        }

    }
}
