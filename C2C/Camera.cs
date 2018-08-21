using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2C
{
    //Interface
    public interface ICamera
    {
        void ZoomIn();
        void ZoomOut();
    }
    //Receiver
    public class CameraV1 : ICamera
    {
        public void ZoomIn()
        {
            Console.WriteLine("Camera V1 ZoomIn Called!!!");
        }

        public void ZoomOut()
        {
            Console.WriteLine("Camera V1 ZoomOut Called!!!");
        }
    }
}
