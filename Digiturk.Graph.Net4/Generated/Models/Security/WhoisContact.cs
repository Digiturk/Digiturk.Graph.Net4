// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security {
    public class WhoisContact : IAdditionalDataHolder, IBackedModel, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>The physical address of the entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.PhysicalAddress? Address {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PhysicalAddress?>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.PhysicalAddress Address {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PhysicalAddress>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The email of this WHOIS contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email {
            get { return BackingStore?.Get<string?>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#nullable restore
#else
        public string Email {
            get { return BackingStore?.Get<string>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#endif
        /// <summary>The fax of this WHOIS contact. No format is guaranteed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Fax {
            get { return BackingStore?.Get<string?>("fax"); }
            set { BackingStore?.Set("fax", value); }
        }
#nullable restore
#else
        public string Fax {
            get { return BackingStore?.Get<string>("fax"); }
            set { BackingStore?.Set("fax", value); }
        }
#endif
        /// <summary>The name of this WHOIS contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
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
        /// <summary>The organization of this WHOIS contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Organization {
            get { return BackingStore?.Get<string?>("organization"); }
            set { BackingStore?.Set("organization", value); }
        }
#nullable restore
#else
        public string Organization {
            get { return BackingStore?.Get<string>("organization"); }
            set { BackingStore?.Set("organization", value); }
        }
#endif
        /// <summary>The telephone of this WHOIS contact. No format is guaranteed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Telephone {
            get { return BackingStore?.Get<string?>("telephone"); }
            set { BackingStore?.Set("telephone", value); }
        }
#nullable restore
#else
        public string Telephone {
            get { return BackingStore?.Get<string>("telephone"); }
            set { BackingStore?.Set("telephone", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="WhoisContact"/> and sets the default values.
        /// </summary>
        public WhoisContact()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WhoisContact"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WhoisContact CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WhoisContact();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"address", n => { Address = n.GetObjectValue<Microsoft.Graph.Models.PhysicalAddress>(Microsoft.Graph.Models.PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"fax", n => { Fax = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"organization", n => { Organization = n.GetStringValue(); } },
                {"telephone", n => { Telephone = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Models.PhysicalAddress>("address", Address);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("fax", Fax);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("organization", Organization);
            writer.WriteStringValue("telephone", Telephone);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
