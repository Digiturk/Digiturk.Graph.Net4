// <auto-generated/>
using Microsoft.Graph.Models.IdentityGovernance;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class SubjectSet : IAdditionalDataHolder, IBackedModel, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>
        /// Instantiates a new <see cref="SubjectSet"/> and sets the default values.
        /// </summary>
        public SubjectSet()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SubjectSet"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SubjectSet CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
SubjectSet result;
switch (mappingValue)
{
    case "#microsoft.graph.attributeRuleMembers":
        result = new AttributeRuleMembers();
        break;
    case "#microsoft.graph.connectedOrganizationMembers":
        result = new ConnectedOrganizationMembers();
        break;
    case "#microsoft.graph.externalSponsors":
        result = new ExternalSponsors();
        break;
    case "#microsoft.graph.groupMembers":
        result = new GroupMembers();
        break;
    case "#microsoft.graph.identityGovernance.ruleBasedSubjectSet":
        result = new RuleBasedSubjectSet();
        break;
    case "#microsoft.graph.internalSponsors":
        result = new InternalSponsors();
        break;
    case "#microsoft.graph.requestorManager":
        result = new RequestorManager();
        break;
    case "#microsoft.graph.singleServicePrincipal":
        result = new SingleServicePrincipal();
        break;
    case "#microsoft.graph.singleUser":
        result = new SingleUser();
        break;
    case "#microsoft.graph.targetApplicationOwners":
        result = new TargetApplicationOwners();
        break;
    case "#microsoft.graph.targetManager":
        result = new TargetManager();
        break;
    case "#microsoft.graph.targetUserSponsors":
        result = new TargetUserSponsors();
        break;
    default:
        result = new SubjectSet();
        break;
}
return result;

// Original C# 8.0 code:
// return mappingValue switch
// {
//     "#microsoft.graph.attributeRuleMembers" => new AttributeRuleMembers(),
//     "#microsoft.graph.connectedOrganizationMembers" => new ConnectedOrganizationMembers(),
//     "#microsoft.graph.externalSponsors" => new ExternalSponsors(),
//     "#microsoft.graph.groupMembers" => new GroupMembers(),
//     "#microsoft.graph.identityGovernance.ruleBasedSubjectSet" => new RuleBasedSubjectSet(),
//     "#microsoft.graph.internalSponsors" => new InternalSponsors(),
//     "#microsoft.graph.requestorManager" => new RequestorManager(),
//     "#microsoft.graph.singleServicePrincipal" => new SingleServicePrincipal(),
//     "#microsoft.graph.singleUser" => new SingleUser(),
//     "#microsoft.graph.targetApplicationOwners" => new TargetApplicationOwners(),
//     "#microsoft.graph.targetManager" => new TargetManager(),
//     "#microsoft.graph.targetUserSponsors" => new TargetUserSponsors(),
//     _ => new SubjectSet(),
// };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}