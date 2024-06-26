// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class DirectoryObject : Entity, IParsable 
    {
        /// <summary>Date and time when this object was deleted. Always null when the object hasn&apos;t been deleted.</summary>
        public DateTimeOffset? DeletedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("deletedDateTime"); }
            set { BackingStore?.Set("deletedDateTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DirectoryObject"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DirectoryObject CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            DirectoryObject result;
switch (mappingValue)
{
    case "#microsoft.graph.activityBasedTimeoutPolicy":
        result = new ActivityBasedTimeoutPolicy();
        break;
    case "#microsoft.graph.administrativeUnit":
        result = new AdministrativeUnit();
        break;
    case "#microsoft.graph.application":
        result = new Application();
        break;
    case "#microsoft.graph.appManagementPolicy":
        result = new AppManagementPolicy();
        break;
    case "#microsoft.graph.appRoleAssignment":
        result = new AppRoleAssignment();
        break;
    case "#microsoft.graph.authorizationPolicy":
        result = new AuthorizationPolicy();
        break;
    case "#microsoft.graph.claimsMappingPolicy":
        result = new ClaimsMappingPolicy();
        break;
    case "#microsoft.graph.contract":
        result = new Contract();
        break;
    case "#microsoft.graph.crossTenantAccessPolicy":
        result = new CrossTenantAccessPolicy();
        break;
    case "#microsoft.graph.device":
        result = new Device();
        break;
    case "#microsoft.graph.directoryObjectPartnerReference":
        result = new DirectoryObjectPartnerReference();
        break;
    case "#microsoft.graph.directoryRole":
        result = new DirectoryRole();
        break;
    case "#microsoft.graph.directoryRoleTemplate":
        result = new DirectoryRoleTemplate();
        break;
    case "#microsoft.graph.endpoint":
        result = new Endpoint();
        break;
    case "#microsoft.graph.extensionProperty":
        result = new ExtensionProperty();
        break;
    case "#microsoft.graph.group":
        result = new Group();
        break;
    case "#microsoft.graph.groupSettingTemplate":
        result = new GroupSettingTemplate();
        break;
    case "#microsoft.graph.homeRealmDiscoveryPolicy":
        result = new HomeRealmDiscoveryPolicy();
        break;
    case "#microsoft.graph.identitySecurityDefaultsEnforcementPolicy":
        result = new IdentitySecurityDefaultsEnforcementPolicy();
        break;
    case "#microsoft.graph.organization":
        result = new Organization();
        break;
    case "#microsoft.graph.orgContact":
        result = new OrgContact();
        break;
    case "#microsoft.graph.permissionGrantPolicy":
        result = new PermissionGrantPolicy();
        break;
    case "#microsoft.graph.policyBase":
        result = new PolicyBase();
        break;
    case "#microsoft.graph.resourceSpecificPermissionGrant":
        result = new ResourceSpecificPermissionGrant();
        break;
    case "#microsoft.graph.servicePrincipal":
        result = new ServicePrincipal();
        break;
    case "#microsoft.graph.stsPolicy":
        result = new StsPolicy();
        break;
    case "#microsoft.graph.tenantAppManagementPolicy":
        result = new TenantAppManagementPolicy();
        break;
    case "#microsoft.graph.tokenIssuancePolicy":
        result = new TokenIssuancePolicy();
        break;
    case "#microsoft.graph.tokenLifetimePolicy":
        result = new TokenLifetimePolicy();
        break;
    case "#microsoft.graph.user":
        result = new User();
        break;
    default:
        result = new DirectoryObject();
        break;
}
return result;

// Original C# 8.0 code:
// return mappingValue switch
// {
//     "#microsoft.graph.activityBasedTimeoutPolicy" => new ActivityBasedTimeoutPolicy(),
//     "#microsoft.graph.administrativeUnit" => new AdministrativeUnit(),
//     "#microsoft.graph.application" => new Application(),
//     "#microsoft.graph.appManagementPolicy" => new AppManagementPolicy(),
//     "#microsoft.graph.appRoleAssignment" => new AppRoleAssignment(),
//     "#microsoft.graph.authorizationPolicy" => new AuthorizationPolicy(),
//     "#microsoft.graph.claimsMappingPolicy" => new ClaimsMappingPolicy(),
//     "#microsoft.graph.contract" => new Contract(),
//     "#microsoft.graph.crossTenantAccessPolicy" => new CrossTenantAccessPolicy(),
//     "#microsoft.graph.device" => new Device(),
//     "#microsoft.graph.directoryObjectPartnerReference" => new DirectoryObjectPartnerReference(),
//     "#microsoft.graph.directoryRole" => new DirectoryRole(),
//     "#microsoft.graph.directoryRoleTemplate" => new DirectoryRoleTemplate(),
//     "#microsoft.graph.endpoint" => new Endpoint(),
//     "#microsoft.graph.extensionProperty" => new ExtensionProperty(),
//     "#microsoft.graph.group" => new Group(),
//     "#microsoft.graph.groupSettingTemplate" => new GroupSettingTemplate(),
//     "#microsoft.graph.homeRealmDiscoveryPolicy" => new HomeRealmDiscoveryPolicy(),
//     "#microsoft.graph.identitySecurityDefaultsEnforcementPolicy" => new IdentitySecurityDefaultsEnforcementPolicy(),
//     "#microsoft.graph.organization" => new Organization(),
//     "#microsoft.graph.orgContact" => new OrgContact(),
//     "#microsoft.graph.permissionGrantPolicy" => new PermissionGrantPolicy(),
//     "#microsoft.graph.policyBase" => new PolicyBase(),
//     "#microsoft.graph.resourceSpecificPermissionGrant" => new ResourceSpecificPermissionGrant(),
//     "#microsoft.graph.servicePrincipal" => new ServicePrincipal(),
//     "#microsoft.graph.stsPolicy" => new StsPolicy(),
//     "#microsoft.graph.tenantAppManagementPolicy" => new TenantAppManagementPolicy(),
//     "#microsoft.graph.tokenIssuancePolicy" => new TokenIssuancePolicy(),
//     "#microsoft.graph.tokenLifetimePolicy" => new TokenLifetimePolicy(),
//     "#microsoft.graph.user" => new User(),
//     _ => new DirectoryObject(),
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
                {"deletedDateTime", n => { DeletedDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteDateTimeOffsetValue("deletedDateTime", DeletedDateTime);
        }
    }
}
