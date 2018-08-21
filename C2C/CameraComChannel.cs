using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2C
{
    //Invoker Interface
    public interface IComm
    {
        void ZoomIn();
        void ZoomOut();
    }
    //Invoker Class
    public class CameraComChannel : IComm
    {
        ICamera _cam;

        public CameraComChannel(ICamera cam)
        {
            this._cam = cam;
        }

        public void ZoomIn()
        {
            ZoomInCommand obj = new ZoomInCommand(_cam);
            obj.ExecuteCommand();
        }

        public void ZoomOut()
        {
            ZoomOutCommand obj = new ZoomOutCommand(_cam);
            obj.ExecuteCommand();
        }

       
    }
}

//ExceptionHandling
//comm channel
//a summary of your work (concept, UML diagram(s), design, thoughts, things still under TBD, etc.).
