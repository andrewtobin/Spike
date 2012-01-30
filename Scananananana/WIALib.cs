using Caliburn.Micro;

namespace Scananananana
{
    public class WIALib: WIA.ICommonDialog
    {
        public WIALib(WindowManager wm)
        {
            _wm = wm;
        }

        private WindowManager _wm;

        public WIA.ImageFile ShowAcquireImage(WIA.WiaDeviceType DeviceType = WIA.WiaDeviceType.UnspecifiedDeviceType, WIA.WiaImageIntent Intent = WIA.WiaImageIntent.UnspecifiedIntent, WIA.WiaImageBias Bias = WIA.WiaImageBias.MaximizeQuality, string FormatID = "{00000000-0000-0000-0000-000000000000}", bool AlwaysSelectDevice = false, bool UseCommonUI = true, bool CancelError = false)
        {
            throw new System.NotImplementedException();
        }

        public dynamic ShowAcquisitionWizard(WIA.Device Device)
        {
            throw new System.NotImplementedException();
        }

        public void ShowDeviceProperties(WIA.Device Device, bool CancelError = false)
        {
            throw new System.NotImplementedException();
        }

        public void ShowItemProperties(WIA.Item Item, bool CancelError = false)
        {
            throw new System.NotImplementedException();
        }

        public void ShowPhotoPrintingWizard(ref object Files)
        {
            throw new System.NotImplementedException();
        }

        public WIA.Device ShowSelectDevice(WIA.WiaDeviceType DeviceType = WIA.WiaDeviceType.UnspecifiedDeviceType, bool AlwaysSelectDevice = false, bool CancelError = false)
        {
            var vm = new DeviceDialogViewModel();
            _wm.ShowWindow(vm);

            if (vm.Device == null) return null;

            return vm.Connect();

        }

        public WIA.Items ShowSelectItems(WIA.Device Device, WIA.WiaImageIntent Intent = WIA.WiaImageIntent.UnspecifiedIntent, WIA.WiaImageBias Bias = WIA.WiaImageBias.MaximizeQuality, bool SingleSelect = true, bool UseCommonUI = true, bool CancelError = false)
        {
            throw new System.NotImplementedException();
        }

        public dynamic ShowTransfer(WIA.Item Item, string FormatID = "{00000000-0000-0000-0000-000000000000}", bool CancelError = false)
        {
            throw new System.NotImplementedException();
        }
    }
}