using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppAbstraction.Serivce;

namespace ConsoleAppAbstraction.Model
{
    public class SmartPhone : MobilePhone, ICamera, IMusicPlayer
    {
        // Mobi,ePhone
        public override void MakeCall(string phoneNUmber)
        {
            Console.WriteLine($" Calling {phoneNUmber} from a smart phone ");
        }
        // Icamera
        public void TakePhoto()
        {
            Console.WriteLine(" Photo taken using smarthphone camera ");
        }

        public void RecordVideo()
        {
            Console.WriteLine(" recording vieo using smarthphone camera ");
        }

        // I MusicPlayers
        public void PlayMusic(string trackName)
        {
            Console.WriteLine($" Play Music :{trackName} ");
        }

        

        public void StopMusic()
        {
            Console.WriteLine(" Music stopped ");
        }

       
    }
}
