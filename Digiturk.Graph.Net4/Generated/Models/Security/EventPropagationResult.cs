// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security {
    public class EventPropagationResult : IAdditionalDataHolder, IBackedModel, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The name of the specific location in the workload associated with the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Location {
            get { return BackingStore?.Get<string?>("location"); }
            set { BackingStore?.Set("location", value); }
        }
#nullable restore
#else
        public string Location {
            get { return BackingStore?.Get<string>("location"); }
            set { BackingStore?.Set("location", value); }
        }
#endif
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
        /// <summary>The name of the workload associated with the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceName {
            get { return BackingStore?.Get<string?>("serviceName"); }
            set { BackingStore?.Set("serviceName", value); }
        }
#nullable restore
#else
        public string ServiceName {
            get { return BackingStore?.Get<string>("serviceName"); }
            set { BackingStore?.Set("serviceName", value); }
        }
#endif
        /// <summary>Indicates the status of the event creation request. The possible values are: none, inProcessing, failed, success, unknownFutureValue.</summary>
        public EventPropagationStatus? Status {
            get { return BackingStore?.Get<EventPropagationStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>Additional information about the status of the event creation request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatusInformation {
            get { return BackingStore?.Get<string?>("statusInformation"); }
            set { BackingStore?.Set("statusInformation", value); }
        }
#nullable restore
#else
        public string StatusInformation {
            get { return BackingStore?.Get<string>("statusInformation"); }
            set { BackingStore?.Set("statusInformation", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="EventPropagationResult"/> and sets the default values.
        /// </summary>
        public EventPropagationResult()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EventPropagationResult"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EventPropagationResult CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EventPropagationResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"location", n => { Location = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"serviceName", n => { ServiceName = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<EventPropagationStatus>(); } },
                {"statusInformation", n => { StatusInformation = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("location", Location);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("serviceName", ServiceName);
            writer.WriteEnumValue<EventPropagationStatus>("status", Status);
            writer.WriteStringValue("statusInformation", StatusInformation);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}