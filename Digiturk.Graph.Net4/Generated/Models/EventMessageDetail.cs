// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class EventMessageDetail : IAdditionalDataHolder, IBackedModel, IParsable 
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
        /// Instantiates a new <see cref="EventMessageDetail"/> and sets the default values.
        /// </summary>
        public EventMessageDetail()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EventMessageDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            EventMessageDetail result;
switch (mappingValue)
{
    case "#microsoft.graph.callEndedEventMessageDetail":
        result = new CallEndedEventMessageDetail();
        break;
    case "#microsoft.graph.callRecordingEventMessageDetail":
        result = new CallRecordingEventMessageDetail();
        break;
    case "#microsoft.graph.callStartedEventMessageDetail":
        result = new CallStartedEventMessageDetail();
        break;
    case "#microsoft.graph.callTranscriptEventMessageDetail":
        result = new CallTranscriptEventMessageDetail();
        break;
    case "#microsoft.graph.channelAddedEventMessageDetail":
        result = new ChannelAddedEventMessageDetail();
        break;
    case "#microsoft.graph.channelDeletedEventMessageDetail":
        result = new ChannelDeletedEventMessageDetail();
        break;
    case "#microsoft.graph.channelDescriptionUpdatedEventMessageDetail":
        result = new ChannelDescriptionUpdatedEventMessageDetail();
        break;
    case "#microsoft.graph.channelRenamedEventMessageDetail":
        result = new ChannelRenamedEventMessageDetail();
        break;
    case "#microsoft.graph.channelSetAsFavoriteByDefaultEventMessageDetail":
        result = new ChannelSetAsFavoriteByDefaultEventMessageDetail();
        break;
    case "#microsoft.graph.channelUnsetAsFavoriteByDefaultEventMessageDetail":
        result = new ChannelUnsetAsFavoriteByDefaultEventMessageDetail();
        break;
    case "#microsoft.graph.chatRenamedEventMessageDetail":
        result = new ChatRenamedEventMessageDetail();
        break;
    case "#microsoft.graph.conversationMemberRoleUpdatedEventMessageDetail":
        result = new ConversationMemberRoleUpdatedEventMessageDetail();
        break;
    case "#microsoft.graph.meetingPolicyUpdatedEventMessageDetail":
        result = new MeetingPolicyUpdatedEventMessageDetail();
        break;
    case "#microsoft.graph.membersAddedEventMessageDetail":
        result = new MembersAddedEventMessageDetail();
        break;
    case "#microsoft.graph.membersDeletedEventMessageDetail":
        result = new MembersDeletedEventMessageDetail();
        break;
    case "#microsoft.graph.membersJoinedEventMessageDetail":
        result = new MembersJoinedEventMessageDetail();
        break;
    case "#microsoft.graph.membersLeftEventMessageDetail":
        result = new MembersLeftEventMessageDetail();
        break;
    case "#microsoft.graph.messagePinnedEventMessageDetail":
        result = new MessagePinnedEventMessageDetail();
        break;
    case "#microsoft.graph.messageUnpinnedEventMessageDetail":
        result = new MessageUnpinnedEventMessageDetail();
        break;
    case "#microsoft.graph.tabUpdatedEventMessageDetail":
        result = new TabUpdatedEventMessageDetail();
        break;
    case "#microsoft.graph.teamArchivedEventMessageDetail":
        result = new TeamArchivedEventMessageDetail();
        break;
    case "#microsoft.graph.teamCreatedEventMessageDetail":
        result = new TeamCreatedEventMessageDetail();
        break;
    case "#microsoft.graph.teamDescriptionUpdatedEventMessageDetail":
        result = new TeamDescriptionUpdatedEventMessageDetail();
        break;
    case "#microsoft.graph.teamJoiningDisabledEventMessageDetail":
        result = new TeamJoiningDisabledEventMessageDetail();
        break;
    case "#microsoft.graph.teamJoiningEnabledEventMessageDetail":
        result = new TeamJoiningEnabledEventMessageDetail();
        break;
    case "#microsoft.graph.teamRenamedEventMessageDetail":
        result = new TeamRenamedEventMessageDetail();
        break;
    case "#microsoft.graph.teamsAppInstalledEventMessageDetail":
        result = new TeamsAppInstalledEventMessageDetail();
        break;
    case "#microsoft.graph.teamsAppRemovedEventMessageDetail":
        result = new TeamsAppRemovedEventMessageDetail();
        break;
    case "#microsoft.graph.teamsAppUpgradedEventMessageDetail":
        result = new TeamsAppUpgradedEventMessageDetail();
        break;
    case "#microsoft.graph.teamUnarchivedEventMessageDetail":
        result = new TeamUnarchivedEventMessageDetail();
        break;
    default:
        result = new EventMessageDetail();
        break;
}
return result;

// Original C# 8.0 code:
// return mappingValue switch
// {
//     "#microsoft.graph.callEndedEventMessageDetail" => new CallEndedEventMessageDetail(),
//     "#microsoft.graph.callRecordingEventMessageDetail" => new CallRecordingEventMessageDetail(),
//     "#microsoft.graph.callStartedEventMessageDetail" => new CallStartedEventMessageDetail(),
//     "#microsoft.graph.callTranscriptEventMessageDetail" => new CallTranscriptEventMessageDetail(),
//     "#microsoft.graph.channelAddedEventMessageDetail" => new ChannelAddedEventMessageDetail(),
//     "#microsoft.graph.channelDeletedEventMessageDetail" => new ChannelDeletedEventMessageDetail(),
//     "#microsoft.graph.channelDescriptionUpdatedEventMessageDetail" => new ChannelDescriptionUpdatedEventMessageDetail(),
//     "#microsoft.graph.channelRenamedEventMessageDetail" => new ChannelRenamedEventMessageDetail(),
//     "#microsoft.graph.channelSetAsFavoriteByDefaultEventMessageDetail" => new ChannelSetAsFavoriteByDefaultEventMessageDetail(),
//     "#microsoft.graph.channelUnsetAsFavoriteByDefaultEventMessageDetail" => new ChannelUnsetAsFavoriteByDefaultEventMessageDetail(),
//     "#microsoft.graph.chatRenamedEventMessageDetail" => new ChatRenamedEventMessageDetail(),
//     "#microsoft.graph.conversationMemberRoleUpdatedEventMessageDetail" => new ConversationMemberRoleUpdatedEventMessageDetail(),
//     "#microsoft.graph.meetingPolicyUpdatedEventMessageDetail" => new MeetingPolicyUpdatedEventMessageDetail(),
//     "#microsoft.graph.membersAddedEventMessageDetail" => new MembersAddedEventMessageDetail(),
//     "#microsoft.graph.membersDeletedEventMessageDetail" => new MembersDeletedEventMessageDetail(),
//     "#microsoft.graph.membersJoinedEventMessageDetail" => new MembersJoinedEventMessageDetail(),
//     "#microsoft.graph.membersLeftEventMessageDetail" => new MembersLeftEventMessageDetail(),
//     "#microsoft.graph.messagePinnedEventMessageDetail" => new MessagePinnedEventMessageDetail(),
//     "#microsoft.graph.messageUnpinnedEventMessageDetail" => new MessageUnpinnedEventMessageDetail(),
//     "#microsoft.graph.tabUpdatedEventMessageDetail" => new TabUpdatedEventMessageDetail(),
//     "#microsoft.graph.teamArchivedEventMessageDetail" => new TeamArchivedEventMessageDetail(),
//     "#microsoft.graph.teamCreatedEventMessageDetail" => new TeamCreatedEventMessageDetail(),
//     "#microsoft.graph.teamDescriptionUpdatedEventMessageDetail" => new TeamDescriptionUpdatedEventMessageDetail(),
//     "#microsoft.graph.teamJoiningDisabledEventMessageDetail" => new TeamJoiningDisabledEventMessageDetail(),
//     "#microsoft.graph.teamJoiningEnabledEventMessageDetail" => new TeamJoiningEnabledEventMessageDetail(),
//     "#microsoft.graph.teamRenamedEventMessageDetail" => new TeamRenamedEventMessageDetail(),
//     "#microsoft.graph.teamsAppInstalledEventMessageDetail" => new TeamsAppInstalledEventMessageDetail(),
//     "#microsoft.graph.teamsAppRemovedEventMessageDetail" => new TeamsAppRemovedEventMessageDetail(),
//     "#microsoft.graph.teamsAppUpgradedEventMessageDetail" => new TeamsAppUpgradedEventMessageDetail(),
//     "#microsoft.graph.teamUnarchivedEventMessageDetail" => new TeamUnarchivedEventMessageDetail(),
//     _ => new EventMessageDetail(),
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