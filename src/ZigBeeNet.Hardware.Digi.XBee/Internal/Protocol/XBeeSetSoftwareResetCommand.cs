//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZigBeeNet.Hardware.Digi.XBee.Internal.Protocol
{
    
    
    /// <summary>
    /// Class to implement the XBee command " Set Software Reset ".
    /// AT Command <b>FR</b></p>Resets the device. The device responds immediately with an OK and
    /// performs a reset 100 ms later. If you issue FR while the device is in Command Mode, the reset
    /// effectively exits Command mode. 
    ///This class provides methods for processing XBee API commands.
    ///
    /// </summary>
    public class XBeeSetSoftwareResetCommand : XBeeFrame, IXBeeCommand 
    {
        
        /// <summary>
        /// 
        /// </summary>
        private int _frameId;
        
        /// <summary>
        /// The frameId to set as <see cref="uint8"/>
        /// </summary>
        public void SetFrameId(int frameId)
        {
            this._frameId = frameId;
        }
    }
}
