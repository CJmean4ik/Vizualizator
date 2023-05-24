using System.IO.Ports;

namespace Vizualizator.COM
{
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
