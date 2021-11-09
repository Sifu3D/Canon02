using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using CameraControl.Devices;

namespace CameraControl.Core.Classes
{
    public static class CameraHelper
    {
        /// <summary>
        /// Captures the specified camera device.
        /// </summary>
        /// <param name="o">ICameraDevice</param>
        public static void Capture(object o)
        {
            if (o != null)
            {
                var camera = o as ICameraDevice;
                if (camera != null)
                {
                    CameraProperty property = ServiceProvider.Settings.CameraProperties.Get(camera);
                    if (property.UseExternalShutter && property.SelectedConfig!=null)
                    {
                        ServiceProvider.ExternalDeviceManager.AssertFocus(property.SelectedConfig);
                        Thread.Sleep(2000);
                        ServiceProvider.ExternalDeviceManager.OpenShutter(property.SelectedConfig);
                        Thread.Sleep(1000);
                        ServiceProvider.ExternalDeviceManager.CloseShutter(property.SelectedConfig);
                        return;
                    }
                    camera.CapturePhoto();
                }
            }
        }

        public static void Capture()
        {
            try
            {
                Capture(ServiceProvider.DeviceManager.SelectedCameraDevice);
            }
            catch (Exception e)
            {
                Log.Debug("Error capture", e);
                StaticHelper.Instance.SystemMessage = e.Message;
            }
        }

        public static void CaptureNoAf(object o)
        {
            if (o != null)
            {
                var camera = o as ICameraDevice;
                if (camera != null)
                {
                    CameraProperty property = ServiceProvider.Settings.CameraProperties.Get(camera);
                    if (property.UseExternalShutter && property.SelectedConfig != null)
                    {
                        ServiceProvider.ExternalDeviceManager.OpenShutter(property.SelectedConfig);
                        Thread.Sleep(200);
                        ServiceProvider.ExternalDeviceManager.CloseShutter(property.SelectedConfig);
                        return;
                    }
                    camera.CapturePhotoNoAf();
                }
            }
        }

        /// <summary>
        /// Waits for a camera to be ready.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="timeout">The timeout in milliseconds.</param>
        public static void WaitForCamera(this ICameraDevice device, int timeout)
        {
            DateTime startTime = DateTime.Now;
            while (device.IsBusy)
            {
                if ((DateTime.Now - startTime).TotalMilliseconds > timeout)
                    break;
            }
        }
    }
}
