using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.NetduinoPlus;
using Mfrc522Lib;
using System.Diagnostics;

namespace Mfrc522Test
{
    public class Program
    {
        public static void Main()
        {
            var led = new OutputPort(Pins.ONBOARD_LED, false);
            var mfrc = new Mfrc522(SPI.SPI_module.SPI1, Pins.GPIO_PIN_D8, Pins.GPIO_PIN_D7);
            var defaultKey = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };

            var dummyData = new byte[]
            {
                0x01, 0x02, 0x03, 0x04,
                0x11, 0x12, 0x13, 0x14,
                0x81, 0x82, 0x83, 0x84,
                0xA1, 0xA2, 0xA3, 0xA4
            };

            // Request
            while (true)
            {
                if (mfrc.IsNewTagPresent())
                    Debug.Print(mfrc.Uid.ToString());
            }
        }
    }
}
