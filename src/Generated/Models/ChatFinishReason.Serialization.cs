// <auto-generated/>

#nullable disable

using System;

namespace OpenAI.Chat
{
    internal static partial class ChatFinishReasonExtensions
    {
        public static string ToSerialString(this ChatFinishReason value) => value switch
        {
            ChatFinishReason.Stop => "stop",
            ChatFinishReason.Length => "length",
            ChatFinishReason.ToolCalls => "tool_calls",
            ChatFinishReason.ContentFilter => "content_filter",
            ChatFinishReason.FunctionCall => "function_call",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ChatFinishReason value.")
        };

        public static ChatFinishReason ToChatFinishReason(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "stop")) return ChatFinishReason.Stop;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "length")) return ChatFinishReason.Length;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "tool_calls")) return ChatFinishReason.ToolCalls;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "content_filter")) return ChatFinishReason.ContentFilter;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "function_call")) return ChatFinishReason.FunctionCall;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ChatFinishReason value.");
        }
    }
}