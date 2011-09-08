using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace RepetierHost.model
{
    // https://connect.microsoft.com/VisualStudio/feedback/details/140018/serialport-crashes-after-disconnect-of-usb-com-port
    public class ProtectedSerialPort : SerialPort
    {
        public new void Open()
        {
            try
            {
                base.Open();

                /*
                ** because of the issue with the FTDI USB serial device,
                ** the call to the stream's finalize is suppressed
                **
                ** it will be un-suppressed in Dispose if the stream
                ** is still good
                */
                GC.SuppressFinalize(BaseStream);
            }
            catch
            {
            }
        }
        public new void Dispose()
        {
            Dispose(true);
        }

        protected override void Dispose(bool disposing)
        {

        try
            {
            /*
            ** because of the issue with the FTDI USB serial device,
            ** the call to the stream's finalize is suppressed
            **
            ** an attempt to un-suppress the stream's finalize is made
            ** here, but if it fails, the exception is caught and
            ** ignored
            */
            GC.ReRegisterForFinalize(BaseStream);
            }
        catch
            {
            }
                
        base.Dispose(disposing);
        }
    }    
}
