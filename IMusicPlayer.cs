using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAbstraction.Serivce
{
    public interface IMusicPlayer
    {
        // public interface for music player functionality
        void PlayMusic(string trackName);
        void StopMusic();
    }
}
