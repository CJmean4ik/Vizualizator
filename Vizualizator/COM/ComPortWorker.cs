using System.IO.Ports;

namespace Vizualizator.COM
{
    /// <summary>
    /// Класс для работы с COM-порт'ами 
    /// </summary>
    public class ComPortWorker
    {
        public SerialPort ComPort { get; set; }
        public static bool isInitialize { get; set; }
        public ComPortWorker(string portName, int transferRate, int dataBit, Parity parity = Parity.None, StopBits stopBits = StopBits.One)
        {
            ComPort = new SerialPort();

            if (CheckExistPort(SerialPort.GetPortNames(), portName))
                ComPort.PortName = portName;

            ComPort.BaudRate = transferRate;
            ComPort.DataBits = dataBit;
            ComPort.Parity = parity;
            ComPort.StopBits = stopBits;
        }
        /// <summary>
        /// Проверяет, существует ли порт считаный с текстового поля
        /// </summary>
        /// <param name="portNames"></param>
        /// <param name="comparedPort"></param>
        /// <returns></returns>
        private static bool CheckExistPort(string[] portNames, string comparedPort)
        {
            if (portNames.Length == 0 || comparedPort == "")
            {
                MessageBox.Show("Value cannot be empty ");
                isInitialize = false;
                return false;
            }

            for (int i = 0; i < portNames.Length; i++)
            {
                if (portNames[i] == comparedPort)
                    isInitialize = true;
                return true;
            }
            isInitialize = false;
            return false;
        }

        /// <summary>
        /// Метод который пробует отправить сообщение по COM-порт'у
        /// </summary>
        /// <param name="message">Отправляемое сообщение</param>
        /// <returns>Значение, указывающие, удалось ли отправить сообщение</returns>
        /// <exception cref="NullReferenceException"></exception>
        public bool TrySendMessage(string message)
        {
            if (message == null) throw new NullReferenceException("Sending a message that contains NULL is not possible");


            if (!ComPort.IsOpen) return true;

            try
            {
                ComPort.Write(message);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Метод, который принимает сообщение через COM-порт 
        /// </summary>
        /// <param name="isSuccessful">Значение, указывающее, удалось ли получить ответ</param>
        /// <returns>Полученное сообщение</returns>
        public string ReceiveMessage(out bool isSuccessful)
        {
            if (!ComPort.IsOpen)
            {
                MessageBox.Show("Port not open or close");
                isSuccessful = false;
                return "";
            }

            try
            {
                string message = ComPort.ReadExisting();
                isSuccessful = true;
                return message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                isSuccessful = false;
                return "";
            }
        }

        /// <summary>
        /// Метод который подлючается к указаному COM-порт'у
        /// </summary>
        /// <param name="isSuccessful">Параметр, указывающий, является ли подключени успешным</param>
        public void ConnectToPort(out bool isSuccessful)
        {
            if (ComPort.IsOpen)
            {
                isSuccessful = true;
                return;
            }

            try
            {
                ComPort.Open();
                isSuccessful = true;
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + $"\nНе удалось подключиться к порту {ComPort.PortName}");
                isSuccessful = true;
                return;
            }

        }

        /// <summary>
        /// Метод который отключается от заранее подключенного COM-порт'а
        /// </summary>
        /// <param name="isSuccessful"></param>
        public void DisconnectFromPort(out bool isSuccessful)
        {
            if (!ComPort.IsOpen)
            {
                isSuccessful = true;
                return;
            }

            try
            {
                ComPort.Close();
                isSuccessful = true;
                return;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
                isSuccessful = false;
                return;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
                isSuccessful = false;
                return;
            }
        }
    }
}
