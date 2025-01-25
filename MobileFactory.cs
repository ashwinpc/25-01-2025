using ConsoleAppAbstraction.Model;

namespace ConsoleAppAbstraction
{
    internal class MobileFactory
    {
        static void Main(string[] args)
        {
            //Create a basic  instance
            BasicPhone basicPhone = new BasicPhone();
            basicPhone.Brand = "Nokia";
            basicPhone.Model = "3310";
            basicPhone.Price = 5000;
            BasicPhone basicPhone2 = new BasicPhone
            {
                Brand = "Nokia",
                Model = "3312",
                Price=4500



            };
            basicPhone.DisplayDetails();
            basicPhone.MakeCall("923345456");
            basicPhone.SendMessage("923345456", "hello from basicc phone !");
            // create a smarthphone instance
            SmartPhone smartPhone = new SmartPhone();
            smartPhone.Brand = "samsung";
            smartPhone.Model = "S23";
            smartPhone.Price = 1000;
            smartPhone.DisplayDetails();
            smartPhone.MakeCall("1023345456");
            smartPhone.SendMessage("1233345456", "hello from smartphone phone !");
            smartPhone.TakePhoto();
            smartPhone.RecordVideo();
            smartPhone.PlayMusic("Faviortes song");
            smartPhone.StopMusic();


            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
