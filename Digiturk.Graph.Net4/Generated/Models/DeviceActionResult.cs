// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// Device action result
    /// </summary>
    public class DeviceActionResult : IAdditionalDataHolder, IBackedModel, IParsable 
    {
        /// <summary>Action name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActionName {
            get { return BackingStore?.Get<string?>("actionName"); }
            set { BackingStore?.Set("actionName", value); }
        }
#nullable restore
#else
        public string ActionName {
            get { return BackingStore?.Get<string>("actionName"); }
            set { BackingStore?.Set("actionName", value); }
        }
#endif
        /// <summary>State of the action on the device</summary>
        public Microsoft.Graph.Models.ActionState? ActionState {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ActionState?>("actionState"); }
            set { BackingStore?.Set("actionState", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Time the action state was last updated</summary>
        public DateTimeOffset? LastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Time the action was initiated</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="DeviceActionResult"/> and sets the default values.
        /// </summary>
        public DeviceActionResult()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeviceActionResult"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceActionResult CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            DeviceActionResult result;
switch (mappingValue)
{
    case "#microsoft.graph.deleteUserFromSharedAppleDeviceActionResult":
        result = new DeleteUserFromSharedAppleDeviceActionResult();
        break;
    case "#microsoft.graph.locateDeviceActionResult":
        result = new LocateDeviceActionResult();
        break;
    case "#microsoft.graph.remoteLockActionResult":
        result = new RemoteLockActionResult();
        break;
    case "#microsoft.graph.resetPasscodeActionResult":
        result = new ResetPasscodeActionResult();
        break;
    case "#microsoft.graph.rotateBitLockerKeysDeviceActionResult":
        result = new RotateBitLockerKeysDeviceActionResult();
        break;
    case "#microsoft.graph.windowsDefenderScanActionResult":
        result = new WindowsDefenderScanActionResult();
        break;
    default:
        result = new DeviceActionResult();
        break;
}
return result;

// Original C# 8.0 code:
// return mappingValue switch
// {
//     "#microsoft.graph.deleteUserFromSharedAppleDeviceActionResult" => new DeleteUserFromSharedAppleDeviceActionResult(),
//     "#microsoft.graph.locateDeviceActionResult" => new LocateDeviceActionResult(),
//     "#microsoft.graph.remoteLockActionResult" => new RemoteLockActionResult(),
//     "#microsoft.graph.resetPasscodeActionResult" => new ResetPasscodeActionResult(),
//     "#microsoft.graph.rotateBitLockerKeysDeviceActionResult" => new RotateBitLockerKeysDeviceActionResult(),
//     "#microsoft.graph.windowsDefenderScanActionResult" => new WindowsDefenderScanActionResult(),
//     _ => new DeviceActionResult(),
// };<
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"actionName", n => { ActionName = n.GetStringValue(); } },
                {"actionState", n => { ActionState = n.GetEnumValue<ActionState>(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("actionName", ActionName);
            writer.WriteEnumValue<ActionState>("actionState", ActionState);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}