// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class StringKeyLongValuePair : IAdditionalDataHolder, IBackedModel, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The mapping of the user type from the source system to the target system. For example:User to User - For Microsoft Entra ID to Microsoft Entra ID synchronization worker to user - For Workday to Microsoft Entra synchronization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Key {
            get { return BackingStore?.Get<string?>("key"); }
            set { BackingStore?.Set("key", value); }
        }
#nullable restore
#else
        public string Key {
            get { return BackingStore?.Get<string>("key"); }
            set { BackingStore?.Set("key", value); }
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
        /// <summary>Total number of synchronized objects.</summary>
        public long? Value {
            get { return BackingStore?.Get<long?>("value"); }
            set { BackingStore?.Set("value", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="StringKeyLongValuePair"/> and sets the default values.
        /// </summary>
        public StringKeyLongValuePair()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="StringKeyLongValuePair"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static StringKeyLongValuePair CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new StringKeyLongValuePair();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"key", n => { Key = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"value", n => { Value = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("key", Key);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteLongValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}