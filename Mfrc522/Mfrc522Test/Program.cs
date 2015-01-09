using Mfrc522Lib;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware.NetduinoPlus;

namespace Mfrc522Test
{
    public class Program
    {
        public static void Main()
        {
            var led = new OutputPort(Pins.ONBOARD_LED, false);
            var mfrc = new Mfrc522(SPI.SPI_module.SPI1, Pins.GPIO_PIN_D8, Pins.GPIO_PIN_D7);

            // Request
            while (true)
            {
                led.Write(mfrc.IsTagPresent());
                
                mfrc.HaltTag();
            }
        }
    }
}
