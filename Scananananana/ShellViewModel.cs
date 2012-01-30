using Caliburn.Micro;

namespace Scananananana {
    using System.ComponentModel.Composition;

    [Export(typeof(IShell))]
    public class ShellViewModel : IShell
    {
        public WindowManager wm = new WindowManager();
        
        public void GetDevice()
        {
            var wia = new WIALib(wm);
            var device = wia.ShowSelectDevice();


        }
    }
}
