// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    [Flags]
    public enum ChatMessageActions
    {
        [EnumMember(Value = "reactionAdded")]
        ReactionAdded = 1,
        [EnumMember(Value = "reactionRemoved")]
        ReactionRemoved = 2,
        [EnumMember(Value = "actionUndefined")]
        ActionUndefined = 4,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue = 8,
    }
}