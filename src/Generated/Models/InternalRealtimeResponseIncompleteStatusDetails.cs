// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    internal partial class InternalRealtimeResponseIncompleteStatusDetails : InternalRealtimeResponseStatusDetails
    {
        internal InternalRealtimeResponseIncompleteStatusDetails(InternalRealtimeResponseIncompleteStatusDetailsReason reason)
        {
            Type = ConversationStatus.Incomplete;
            Reason = reason;
        }

        internal InternalRealtimeResponseIncompleteStatusDetails(ConversationStatus type, IDictionary<string, BinaryData> serializedAdditionalRawData, InternalRealtimeResponseIncompleteStatusDetailsReason reason) : base(type, serializedAdditionalRawData)
        {
            Reason = reason;
        }

        internal InternalRealtimeResponseIncompleteStatusDetails()
        {
        }

        public InternalRealtimeResponseIncompleteStatusDetailsReason Reason { get; }
    }
}