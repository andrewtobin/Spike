using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Caliburn.Micro;
using WIA;

namespace Scananananana
{
    public class DeviceDialogViewModel: PropertyChangedBase
    {
        public DeviceDialogViewModel()
        {
            DeviceManager dm = new DeviceManager();

            var infos = dm.DeviceInfos;

            foreach(DeviceInfo i in infos)
            {
                if (i.Type == WiaDeviceType.ScannerDeviceType)
                    Devices.Add(i);
            }
        }

        public DeviceInfo Device { get; set; }
        public ObservableCollection<DeviceInfo> Devices { get; set; }

        public Device Connect()
        {
            if (Device == null) return null;

            return Device.Connect();
        }
    }
}
