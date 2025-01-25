using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAbstraction.Serivce
{
    // Interfcae for camera functionality
    public interface ICamera
    {
        void TakePhoto();
        void RecordVideo();
    }
}
