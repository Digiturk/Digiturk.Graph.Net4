// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class ListItemVersion : BaseItemVersion, IParsable 
    {
        /// <summary>A collection of the fields and values for this version of the list item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FieldValueSet? Fields {
            get { return BackingStore?.Get<FieldValueSet?>("fields"); }
            set { BackingStore?.Set("fields", value); }
        }
#nullable restore
#else
        public FieldValueSet Fields {
            get { return BackingStore?.Get<FieldValueSet>("fields"); }
            set { BackingStore?.Set("fields", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ListItemVersion"/> and sets the default values.
        /// </summary>
        public ListItemVersion() : base()
        {
            OdataType = "#microsoft.graph.listItemVersion";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ListItemVersion"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ListItemVersion CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
ListItemVersion result;
switch (mappingValue)
{
    case "#microsoft.graph.documentSetVersion":
        result = new DocumentSetVersion();
        break;
    default:
        result = new ListItemVersion();
        break;
}
return result;

// Original C# 8.0 code:
// return mappingValue switch
// {
//     "#microsoft.graph.documentSetVersion" => new DocumentSetVersion(),
//     _ => new ListItemVersion(),
// };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"fields", n => { Fields = n.GetObjectValue<FieldValueSet>(FieldValueSet.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<FieldValueSet>("fields", Fields);
        }
    }
}
