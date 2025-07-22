using System;
using System.IO.Ports;


class Program
{
    static void Main(string[] args)
    {

        // Aygıt yöneticisinden arduino COM değerini kontrol et!!!
        string portName = "COM7";

        int baudRate = 9600;

        SerialPort serialPort = new SerialPort(portName, baudRate);

        serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);


        try
        {

            serialPort.Open();

            Console.WriteLine("Arduino bağlantısı başarılı.");
            Console.WriteLine("Kart okutulduğunda bilgiler bu ekranda görüntülenecektir.");

            Console.ReadLine();




        }

        catch (Exception ex)
        {
            Console.WriteLine("Lütfen arduino bağlantısı ve portunu kontrol ediniz.");
            Console.WriteLine("Hata:" + ex.Message);
            Console.ReadKey();
            
        }

        finally
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();

            }
            
        }

    }

    private static void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {

        try
        {

            SerialPort sp = (SerialPort)sender;

            string cardUID = sp.ReadLine();

            Console.WriteLine("Kart UID'si" + cardUID.Trim());

        }
        catch (Exception ex)
        {
            Console.WriteLine("Veri okuma hatası:" + ex.Message);

        }

    }



}
