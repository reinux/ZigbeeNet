using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZigBeeNet.Security;
using ZigBeeNet.ZCL.Clusters.Price;
using ZigBeeNet.ZCL.Field;
using ZigBeeNet.ZCL.Protocol;


namespace ZigBeeNet.ZCL.Clusters.Price
{
    /// <summary>
    /// Cpp Event Response value object class.
    ///
    /// Cluster: Price. Command ID 0x0D is sent TO the server.
    /// This command is a specific command used for the Price cluster.
    ///
    /// The CPPEventResponse command is sent from a CLIENT (IHD) to the ESI to notify it of a
    /// Critical Peak Pricing event authorization.
    ///
    /// Code is auto-generated. Modifications may be overwritten!
    /// </summary>
    public class CppEventResponse : ZclCommand
    {
        /// <summary>
        /// The cluster ID to which this command belongs.
        /// </summary>
        public const ushort CLUSTER_ID = 0x0700;

        /// <summary>
        /// The command ID.
        /// </summary>
        public const byte COMMAND_ID = 0x0D;

        /// <summary>
        /// Issuer Event ID command message field.
        /// 
        /// Unique identifier generated by the commodity provider. When new information is
        /// provided that replaces older information for the same time period, this field
        /// allows devices to determine which information is newer. The value contained in
        /// this field is a unique number managed by upstream servers or a UTC based time stamp
        /// (UTCTime data type) identifying when the Publish command was issued. Thus, newer
        /// information will have a value in the Issuer Event ID field that is larger than older
        /// information.
        /// </summary>
        public uint IssuerEventId { get; set; }

        /// <summary>
        /// Cpp Auth command message field.
        /// 
        /// An 8-bit enumeration identifying the status of the CPP event. This field shall
        /// contain the ‘Accepted’ or ‘Rejected’ values.
        /// </summary>
        public byte CppAuth { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public CppEventResponse()
        {
            ClusterId = CLUSTER_ID;
            CommandId = COMMAND_ID;
            GenericCommand = false;
            CommandDirection = ZclCommandDirection.CLIENT_TO_SERVER;
        }

        internal override void Serialize(ZclFieldSerializer serializer)
        {
            serializer.Serialize(IssuerEventId, DataType.UNSIGNED_32_BIT_INTEGER);
            serializer.Serialize(CppAuth, DataType.ENUMERATION_8_BIT);
        }

        internal override void Deserialize(ZclFieldDeserializer deserializer)
        {
            IssuerEventId = deserializer.Deserialize<uint>(DataType.UNSIGNED_32_BIT_INTEGER);
            CppAuth = deserializer.Deserialize<byte>(DataType.ENUMERATION_8_BIT);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append("CppEventResponse [");
            builder.Append(base.ToString());
            builder.Append(", IssuerEventId=");
            builder.Append(IssuerEventId);
            builder.Append(", CppAuth=");
            builder.Append(CppAuth);
            builder.Append(']');

            return builder.ToString();
        }
    }
}
