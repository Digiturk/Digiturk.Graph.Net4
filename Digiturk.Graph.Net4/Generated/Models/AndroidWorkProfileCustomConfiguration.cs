// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// Android Work Profile custom configuration
    /// </summary>
    public class AndroidWorkProfileCustomConfiguration : DeviceConfiguration, IParsable 
    {
        /// <summary>OMA settings. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OmaSetting>? OmaSettings {
            get { return BackingStore?.Get<List<OmaSetting>?>("omaSettings"); }
            set { BackingStore?.Set("omaSettings", value); }
        }
#nullable restore
#else
        public List<OmaSetting> OmaSettings {
            get { return BackingStore?.Get<List<OmaSetting>>("omaSettings"); }
            set { BackingStore?.Set("omaSettings", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AndroidWorkProfileCustomConfiguration"/> and sets the default values.
        /// </summary>
        public AndroidWorkProfileCustomConfiguration() : base()
        {
            OdataType = "#microsoft.graph.androidWorkProfileCustomConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AndroidWorkProfileCustomConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidWorkProfileCustomConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidWorkProfileCustomConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"omaSettings", n => { OmaSettings = n.GetCollectionOfObjectValues<OmaSetting>(OmaSetting.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<OmaSetting>("omaSettings", OmaSettings);
        }
    }
}