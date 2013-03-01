using System;
using System.Linq;


public class GsmTest
{
    static void Main()
    {
        Gsm[] test = new Gsm[3];

        Display testDisplay = new Display(4, 16);
        Battery testBattery = new Battery(BatteryType.LiIon, 350, 100);

        Gsm firstPhone = new Gsm("Touch Pro2", "HTC", 350, "Bill", testBattery, testDisplay);
        test[0] = firstPhone;

        Gsm secondPhone = new Gsm("Lumia 720", "Nokia", 1020, "Sam", testBattery, testDisplay);
        test[1] = secondPhone;

        Gsm thirdPhone = new Gsm("8S", "HTC", 579, "Paul", testBattery, testDisplay);
        test[2] = thirdPhone;

        for (int i = 0; i < test.Length; i++)
        {
            Console.WriteLine(test[i]);
        }

        Console.WriteLine(Gsm.IPhone.Model);
        Console.WriteLine(Gsm.IPhone.Manufacturer);
    }
}