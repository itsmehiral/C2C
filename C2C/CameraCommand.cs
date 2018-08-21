using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2C
{
    //Command
    public abstract class Command
    {
        public abstract void ExecuteCommand();
        public abstract bool CanExecute();
    }

    //ConcreteCommand
    public class ZoomInCommand : Command
    {
        private ICamera _cam;

        public ZoomInCommand(ICamera cam)
        {
            _cam = cam;
            if (!CanExecute())
            {
                throw new Exception("Error turning on the camera!!!");
            }
        }

        public override void ExecuteCommand()
        {
            _cam.ZoomIn();
        }
        public override bool CanExecute()
        {
            return (_cam != null);
        }
    }

    //ConcreteCommand
    public class ZoomOutCommand : Command
    {
        private ICamera _cam;

        public ZoomOutCommand(ICamera cam)
        {
            _cam = cam;
            if (!CanExecute())
            {
                throw new Exception("Error turning on the camera!!!");
            }
        }

        public override void ExecuteCommand()
        {
            _cam.ZoomOut();
        }
        public override bool CanExecute()
        {
            return (_cam != null);
        }
    }

  
}
