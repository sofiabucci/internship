using Herança.Models;
using Herança.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter the temperature value in Celsius: ");
            double temperatureValue = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the humidity value in Percent: ");
            double humidityValue = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the moviment value in Meters per Second: ");
            double movimentValue = Convert.ToDouble(Console.ReadLine());

            ISensor temperatureSensor = new Temperature(temperatureValue);
            ISensor humiditySensor = new Humidity(humidityValue);
            ISensor movimentSensor = new Moviment(movimentValue);

            double temperature = temperatureSensor.ReadValue();
            double humidity = humiditySensor.ReadValue();
            double moviment = movimentSensor.ReadValue();


            Console.WriteLine($"Temperature: {temperature} {temperatureSensor.GetUnit()}");
            Console.WriteLine($"Humidity: {humidity} {humiditySensor.GetUnit()}");
            Console.WriteLine($"Moviment: {moviment} {movimentSensor.GetUnit()}");

            Console.WriteLine("To exit press any key...");
            Console.ReadLine();
        }
    }
}
