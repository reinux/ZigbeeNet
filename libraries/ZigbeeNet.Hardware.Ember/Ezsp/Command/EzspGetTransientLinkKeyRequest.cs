//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:3.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZigBeeNet.Hardware.Ember.Ezsp.Command
{
    using ZigBeeNet.Hardware.Ember.Internal.Serializer;
    
    
    /// <summary>
    /// Class to implement the Ember EZSP command " getTransientLinkKey ".
    /// This is a function to get the transient link key structure in the transient key table. The EUI
    /// of the passed in key structure is searched and, if a match is found, the rest of the key
    /// structure is filled in.
    /// This class provides methods for processing EZSP commands.
    /// </summary>
    public class EzspGetTransientLinkKeyRequest : EzspFrameRequest
    {
        
        public const int FRAME_ID = 206;
        
        /// <summary>
        ///  The IEEE address to look up the transient key for.
        /// </summary>
        private IeeeAddress _eui;
        
        private EzspSerializer _serializer;
        
        public EzspGetTransientLinkKeyRequest()
        {
            _frameId = FRAME_ID;
            _serializer = new EzspSerializer();
        }
        
        /// <summary>
        /// The eui to set as <see cref="EmberEUI64"/> </summary>
        public void SetEui(IeeeAddress eui)
        {
            _eui = eui;
        }
        
        /// <summary>
        ///  The IEEE address to look up the transient key for.
        /// Return the eui as <see cref="IeeeAddress"/>
        /// </summary>
        public IeeeAddress GetEui()
        {
            return _eui;
        }
        
        /// <summary>
        /// Method for serializing the command fields </summary>
        public override int[] Serialize()
        {
            SerializeHeader(_serializer);
            _serializer.SerializeEmberEui64(_eui);
            return _serializer.GetPayload();
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("EzspGetTransientLinkKeyRequest [eui=");
            builder.Append(_eui);
            builder.Append(']');
            return builder.ToString();
        }
    }
}