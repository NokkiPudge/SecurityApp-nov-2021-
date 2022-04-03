using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
namespace SECURITYapp
{
    public partial class Form1 : Form
    {
        bool Cp = false, pw=false; // ОБЪЯВЛЕНИЯ НУЖНЫХ ПУБЛИЧНЫХ ПЕРЕМЕННЫХ
        int counter = 0,delay=0; // ОБЪЯВЛЕНИЯ НУЖНЫХ ПУБЛИЧНЫХ ПЕРЕМЕННЫХ
        string password; // ОБЪЯВЛЕНИЯ НУЖНЫХ ПУБЛИЧНЫХ ПЕРЕМЕННЫХ
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames(); // ЗАПИСЬ В СТРИНГОВЫЙ МАССИВ СПИСКА ДОСТУПНЫХ КОМПОРТОВ
            COMbox.Items.AddRange(ports); // ОТОБРАЖЕНИЕБ ДОСТУПНЫХ ПОРТОВ В МЕТОДЕ COMbox
            COMbox.SelectedIndex = 0; // номер в списке портов-0 (стандартный)
            COMClose.Enabled = false; //Кнопка закрытия порта выключена, до первоначального включения порта
            richTextBox1.Hide(); // Скрывание метода richTextBox1 методом hide
            richTextBox2.Hide(); // Скрывание метода richTextBox2 методом hide
            label3.Hide();// Скрывание метода label3 методом hide
            label4.Hide();// Скрывание метода label4 методом hide
            button2.Hide();// Скрывание метода button2 методом hide
            progressBar11.Value = 0;//Состояние индикатора выполнения 
            COMbox.Enabled = false;//дизактвирование поля с последовательными портами
            COMOpen.Enabled = false;//дизактвирование кнопки подтверждения выбора порта
            PassClear.Enabled = false;//дизактвирование кнопки очистки поля ввода пароля
            StartButton.Enabled = false;//дизактвирование кноки Start
            StopButton.Enabled = false;//дизактвирование кнопки Stop
            PassText.Hide();//Скрывание метода  PassText методом hide
            StopButton.Hide();//Скрывание метода StopButton методом hide
            label5.Hide();//Скрывание метода label5 методом hide
            timer1.Interval = 3000;//интервал между опросами у устройства он 2.5 сек
            timer1.Enabled = false;//дизактивация таймера
            DelayBox.Enabled = false;//дизактивация поля для ввода задержки
     
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void COMOpen_Click(object sender, EventArgs e)
        {
            COMOpen.Enabled = false;//дизактивация кнопки Open 
            COMClose.Enabled = true;//активанция кнопки Close
            try
            {
                serialPort1.PortName = COMbox.Text;// запись имени порта
                serialPort1.Open();// вызов метода для открытия порта
                Cp = true;// bool переменная для проверки наличия порта
                serialPort1.BaudRate = 9600;// установка скорости передачи, битрейта
                progressBar11.Value = 100;// установка состояния индикатора выполнения
                StartButton.Enabled = true;//активация кнопки Start 
                StopButton.Enabled = true;//активация кнопки Stop
                DelayBox.Enabled = true;//активация поля задержки перед началом
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);// вывод ошибки при её возникновении 
            }
            
        }

        private void PassConfirm_Click(object sender, EventArgs e)
        {
           
            
            if (PassBox.Text != "") // проверка на то, что поле ввода не пустое
            {
                PassClear.Enabled = true;// активация кнопки Clear
                PassConfirm.Enabled = false;// дизактивация кнопки Confirm
                COMOpen.Enabled = true;// активирует кнопку подтверждения выбора компорта
                COMbox.Enabled = true;// открывает возможность выбора компорта 
                pw = true; // bool переменная для проверки наличия пароля
                password = PassBox.Text;// записывает пароль в переменную
                PassBox.Clear();// очищает поле с паролем
                MessageBox.Show(Convert.ToString("Your password is:" + password + "\nREMEMBER HIM!!!"));// просьба запомнить пароль
            }
            else
            {
                MessageBox.Show("INPUT FIELD IS EMPTY");// сообщение при возникновении ошибки
            }
        }

        private void PassClear_Click(object sender, EventArgs e)
        {
            pw = false; // устанавливает флажек на отсутствие пароля
            PassClear.Enabled = false; // дизактивация кнопки Clear
            COMOpen.Enabled = false; // дизактивирует кнопку подтверждения выбора компорта
            COMbox.Enabled = false; // закрывает возможность выбора компорта
            PassConfirm.Enabled = true; //активация кнопки confirm
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pw==true && Cp == true)
            {
                groupBox1.Hide();
                groupBox2.Hide();
                richTextBox1.Show();
                richTextBox2.Show();
                label3.Show();
                label4.Show();
                button2.Show();
                button1.Hide();
            }
            else
            {
                MessageBox.Show("Write the password and after select ComPort");
            }
        }

        private void PassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
      
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Hide();
            button1.Show();
            groupBox1.Show();
            groupBox2.Show();
            richTextBox1.Hide();
            richTextBox2.Hide();
            label3.Hide();
            label4.Hide();
            
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

        }

        private void StartButton_Click_1(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;//доступ к группе настройки пароля закрыт
            groupBox2.Enabled = false;//доступ к группе настройки коспорта закрыт
            StartButton.Hide();//скрывание кнопки Start 
            StopButton.Show();//включение кнопки  Stop
            PassText.Show();//включение поля для ввода пароля
            label5.Show();//включение подписи поля
            if (DelayBox.Text == "")//проверка на наличие введенных значений задержки
            {
                delay = 10000;//Если поле пусто, то ставиться стандартное значение в 10 секунд
            }else
            {
                delay = Convert.ToInt32(DelayBox.Text) * 1000;//Установка задержки пользователя
            }
            delaylabel.Hide();//скрывание подписи поля delay
            DelayBox.Hide();// скрывание поля delay
            timer1.Enabled = true;//включение таймера


        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            
            if (PassText.Text == password)//проверка на правильность/наличия пароля
            {
                timer1.Enabled = false;//выключение опрашевающего таймера
                groupBox1.Enabled = true;//Активация группы настройки пароля
                groupBox2.Enabled = true;//Активация группы настройки компорта
                StopButton.Hide();//скрывание кнопки Stop
                StartButton.Show();//включение кнопки Start
                PassText.Clear();//очистка поля для ввода паролей
                PassText.Hide();//скрывание поля для паролей
                delaylabel.Show();//включение пописи поля delay
                DelayBox.Show();//включение поля с задержкой
                label5.Hide();//скрывание подписи поля с паролем
                serialPort1.Write("4");//отправка команды на Arduino
                serialPort1.Write("2");//отправка команды на Arduino
                counter = 0;//сброс коунтера
            } else
            {
                PassText.Clear();//Очистка поля ввода
                MessageBox.Show("wrong password");//Сообщение при неправильном пароле
            }

        }

        private void PassText_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {if (counter == 0) // метод, которым я даю задержку в 10 сек, только при первом опросе
            {
                Thread.Sleep(delay);// задержка перед включением таймера
                try
                {


                    serialPort1.Write("1");// отправление в последовательный порт команды на Ардуино


                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);//сообщение об ошибке, при ее возникновении
                }
                counter++;// счетчик, позволяющий реализовать 1 задержку во время первого опроса
            }
            else // после первого опроса программа начинает опрашивать без задержки
            {
                try
                {


                    serialPort1.Write("1");// отправление в последовательный порт команды на Ардуино


                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);//сообщение об ошибке, при ее возникновении 
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void COMbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DelayBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void COMClose_Click(object sender, EventArgs e)
        {
            COMOpen.Enabled = true;// активирует кнопку Open 
            COMClose.Enabled = false;// дизактивирует кнопку Close
            try
            {
                progressBar11.Value = 0;// установка состояния индикатора выполнения
                serialPort1.Close();// вызов метода отключения потока серийного порта
                Cp = false;//bool переменная для проверки наличия порта
                StartButton.Enabled = false;//дизактивация кнопки Start 
                StopButton.Enabled = false;//дизактивация кнопки Stop
                DelayBox.Enabled = false;//дизактивация поля задержки перед началом
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);// вывод ошибки при её возникновении 
            }
        }
    }
}
