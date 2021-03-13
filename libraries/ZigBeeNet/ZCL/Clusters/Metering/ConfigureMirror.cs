using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZigBeeNet.Security;
using ZigBeeNet.ZCL.Clusters.Metering;
using ZigBeeNet.ZCL.Field;
using ZigBeeNet.ZCL.Protocol;


namespace ZigBeeNet.ZCL.Clusters.Metering
{
    /// <summary>
    /// Configure Mirror value object class.
    ///
    /// Cluster: Metering. Command ID 0x08 is sent FROM the server.
    /// This command is a specific command used for the Metering cluster.
    ///
    /// FIXME: ConfigureMirror is sent to the mirror once the mirror has been created. The
    /// command deals with the operational configuration of the Mirror.
    ///
    /// Code is auto-generated. Modifications may be overwritten!
    /// </summary>
    public class ConfigureMirror : ZclCommand
    {
        /// <summary>
        /// The cluster ID to which this command belongs.
        /// </summary>
        public const ushort CLUSTER_ID = 0x0702;

        /// <summary>
        /// The command ID.
        /// </summary>
        public const byte COMMAND_ID = 0x08;

        /// <summary>
        /// Issuer Event ID command message field.
        /// 
        /// Unique identifier generated by the device being mirrored. When new information is
        /// provided that replaces older information, this field allows devices to determine
        /// which information is newer. It is recommended that the value contained in this
        /// field is a UTC based time stamp (UTCTime data type) identifying when the command was
        /// issued. Thus, newer information will have a value in the Issuer Event ID field that
        /// is larger than older information.
        /// </summary>
        public uint IssuerEventId { get; set; }

        /// <summary>
        /// Reporting Interval command message field.
        /// 
        /// An unsigned 24-bit integer to denote the interval, in seconds, at which a mirrored
        /// meter intends to use the ReportAttribute command.
        /// </summary>
        public uint ReportingInterval { get; set; }

        /// <summary>
        /// Mirror Notification Reporting command message field.
        /// 
        /// A Boolean used to advise a BOMD how the Notification flags should be acquired (see
        /// below).
        /// When Mirror Notification Reporting is set, the MirrorReportAttributeResponse
        /// command is enabled. In that case, the Metering client on the mirror endpoint shall
        /// respond to the last or only ReportAttribute command with the
        /// MirrorReportAttributeResponse.
        /// If Mirror Notification Reporting is set to FALSE, the
        /// MirrorReportAttributeResponse command shall not be enabled; the Metering
        /// server may poll the Notification flags by means of a normal ReadAttribute command.
        /// </summary>
        public bool MirrorNotificationReporting { get; set; }

        /// <summary>
        /// Notification Scheme command message field.
        /// 
        /// This unsigned 8-bit integer allows for the pre-loading of the Notification Flags
        /// bit mapping to ZCL or Smart Energy Standard commands.
        /// </summary>
        public byte NotificationScheme { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public ConfigureMirror()
        {
            ClusterId = CLUSTER_ID;
            CommandId = COMMAND_ID;
            GenericCommand = false;
            CommandDirection = ZclCommandDirection.SERVER_TO_CLIENT;
        }

        internal override void Serialize(ZclFieldSerializer serializer)
        {
            serializer.Serialize(IssuerEventId, DataType.UNSIGNED_32_BIT_INTEGER);
            serializer.Serialize(ReportingInterval, DataType.UNSIGNED_24_BIT_INTEGER);
            serializer.Serialize(MirrorNotificationReporting, DataType.BOOLEAN);
            serializer.Serialize(NotificationScheme, DataType.UNSIGNED_8_BIT_INTEGER);
        }

        internal override void Deserialize(ZclFieldDeserializer deserializer)
        {
            IssuerEventId = deserializer.Deserialize<uint>(DataType.UNSIGNED_32_BIT_INTEGER);
            ReportingInterval = deserializer.Deserialize<uint>(DataType.UNSIGNED_24_BIT_INTEGER);
            MirrorNotificationReporting = deserializer.Deserialize<bool>(DataType.BOOLEAN);
            NotificationScheme = deserializer.Deserialize<byte>(DataType.UNSIGNED_8_BIT_INTEGER);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append("ConfigureMirror [");
            builder.Append(base.ToString());
            builder.Append(", IssuerEventId=");
            builder.Append(IssuerEventId);
            builder.Append(", ReportingInterval=");
            builder.Append(ReportingInterval);
            builder.Append(", MirrorNotificationReporting=");
            builder.Append(MirrorNotificationReporting);
            builder.Append(", NotificationScheme=");
            builder.Append(NotificationScheme);
            builder.Append(']');

            return builder.ToString();
        }
    }
}
