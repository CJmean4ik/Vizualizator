using System.IO.Ports;

namespace Vizualizator.COM
{
    public class ComPortWorker
    {
        public SerialPort ComPort { get; set; }

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
                return false;
            }

            for (int i = 0; i < portNames.Length; i++)
            {
                if (portNames[i] == comparedPort)
                    return true;
            }
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
        public bool TryReceiveMessage(out string message)
        {
            if (!ComPort.IsOpen)
            {
                MessageBox.Show("Port not open or close");
                message = "";
                return false;
            }


            try
            {
                message = ComPort.ReadExisting();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                message = "";
                return false;
            }        
        }

        public bool TryConnectToPort()
        {
            if (ComPort.IsOpen) return true;

            try
            {
                ComPort.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + $"\nНе удалось подключиться к порту {ComPort.PortName}");
                return false;
            }         

        }
        public bool TryDisconnectFromPort()
        {
            if (!ComPort.IsOpen) return true;
            try
            {
                ComPort.Close();
                return true;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
