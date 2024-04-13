// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// Contains properties used when assigning a Windows Universal AppX mobile app to a group.
    /// </summary>
    public class WindowsUniversalAppXAppAssignmentSettings : MobileAppAssignmentSettings, IParsable 
    {
        /// <summary>If true, uses device execution context for Windows Universal AppX mobile app. Device-context install is not allowed when this type of app is targeted with Available intent. Defaults to false.</summary>
        public bool? UseDeviceContext {
            get { return BackingStore?.Get<bool?>("useDeviceContext"); }
            set { BackingStore?.Set("useDeviceContext", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="WindowsUniversalAppXAppAssignmentSettings"/> and sets the default values.
        /// </summary>
        public WindowsUniversalAppXAppAssignmentSettings() : base()
        {
            OdataType = "#microsoft.graph.windowsUniversalAppXAppAssignmentSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WindowsUniversalAppXAppAssignmentSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsUniversalAppXAppAssignmentSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsUniversalAppXAppAssignmentSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"useDeviceContext", n => { UseDeviceContext = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("useDeviceContext", UseDeviceContext);
        }
    }
}