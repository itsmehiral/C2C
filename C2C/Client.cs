using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2C
{
    class Client
    {
        static void Main(string[] args)
        {
            ICamera cam = new CameraV1(); //Instatiate the Camera object
            IComm channel = new CameraComChannel(cam); //pass the Camera to Communication Channel
            channel.ZoomIn();
            channel.ZoomOut();
            Console.ReadLine();
        }
    }
}
