// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class SolutionsRoot : IAdditionalDataHolder, IBackedModel, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The bookingBusinesses property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BookingBusiness>? BookingBusinesses {
            get { return BackingStore?.Get<List<BookingBusiness>?>("bookingBusinesses"); }
            set { BackingStore?.Set("bookingBusinesses", value); }
        }
#nullable restore
#else
        public List<BookingBusiness> BookingBusinesses {
            get { return BackingStore?.Get<List<BookingBusiness>>("bookingBusinesses"); }
            set { BackingStore?.Set("bookingBusinesses", value); }
        }
#endif
        /// <summary>The bookingCurrencies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BookingCurrency>? BookingCurrencies {
            get { return BackingStore?.Get<List<BookingCurrency>?>("bookingCurrencies"); }
            set { BackingStore?.Set("bookingCurrencies", value); }
        }
#nullable restore
#else
        public List<BookingCurrency> BookingCurrencies {
            get { return BackingStore?.Get<List<BookingCurrency>>("bookingCurrencies"); }
            set { BackingStore?.Set("bookingCurrencies", value); }
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
        /// <summary>The virtualEvents property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public VirtualEventsRoot? VirtualEvents {
            get { return BackingStore?.Get<VirtualEventsRoot?>("virtualEvents"); }
            set { BackingStore?.Set("virtualEvents", value); }
        }
#nullable restore
#else
        public VirtualEventsRoot VirtualEvents {
            get { return BackingStore?.Get<VirtualEventsRoot>("virtualEvents"); }
            set { BackingStore?.Set("virtualEvents", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="SolutionsRoot"/> and sets the default values.
        /// </summary>
        public SolutionsRoot()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SolutionsRoot"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SolutionsRoot CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SolutionsRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"bookingBusinesses", n => { BookingBusinesses = n.GetCollectionOfObjectValues<BookingBusiness>(BookingBusiness.CreateFromDiscriminatorValue)?.ToList(); } },
                {"bookingCurrencies", n => { BookingCurrencies = n.GetCollectionOfObjectValues<BookingCurrency>(BookingCurrency.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"virtualEvents", n => { VirtualEvents = n.GetObjectValue<VirtualEventsRoot>(VirtualEventsRoot.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<BookingBusiness>("bookingBusinesses", BookingBusinesses);
            writer.WriteCollectionOfObjectValues<BookingCurrency>("bookingCurrencies", BookingCurrencies);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<VirtualEventsRoot>("virtualEvents", VirtualEvents);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}