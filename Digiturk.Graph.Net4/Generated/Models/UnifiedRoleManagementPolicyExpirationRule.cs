// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class UnifiedRoleManagementPolicyExpirationRule : UnifiedRoleManagementPolicyRule, IParsable 
    {
        /// <summary>Indicates whether expiration is required or if it&apos;s a permanently active assignment or eligibility.</summary>
        public bool? IsExpirationRequired {
            get { return BackingStore?.Get<bool?>("isExpirationRequired"); }
            set { BackingStore?.Set("isExpirationRequired", value); }
        }
        /// <summary>The maximum duration allowed for eligibility or assignment that isn&apos;t permanent. Required when isExpirationRequired is true.</summary>
        public TimeSpan? MaximumDuration {
            get { return BackingStore?.Get<TimeSpan?>("maximumDuration"); }
            set { BackingStore?.Set("maximumDuration", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="UnifiedRoleManagementPolicyExpirationRule"/> and sets the default values.
        /// </summary>
        public UnifiedRoleManagementPolicyExpirationRule() : base()
        {
            OdataType = "#microsoft.graph.unifiedRoleManagementPolicyExpirationRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UnifiedRoleManagementPolicyExpirationRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnifiedRoleManagementPolicyExpirationRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleManagementPolicyExpirationRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"isExpirationRequired", n => { IsExpirationRequired = n.GetBoolValue(); } },
                {"maximumDuration", n => { MaximumDuration = n.GetTimeSpanValue(); } },
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
            writer.WriteBoolValue("isExpirationRequired", IsExpirationRequired);
            writer.WriteTimeSpanValue("maximumDuration", MaximumDuration);
        }
    }
}