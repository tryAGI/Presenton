
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookEvent
    {
        /// <summary>
        /// 
        /// </summary>
        PresentationGenerationCompleted,
        /// <summary>
        /// 
        /// </summary>
        PresentationGenerationFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookEvent value)
        {
            return value switch
            {
                WebhookEvent.PresentationGenerationCompleted => "presentation.generation.completed",
                WebhookEvent.PresentationGenerationFailed => "presentation.generation.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookEvent? ToEnum(string value)
        {
            return value switch
            {
                "presentation.generation.completed" => WebhookEvent.PresentationGenerationCompleted,
                "presentation.generation.failed" => WebhookEvent.PresentationGenerationFailed,
                _ => null,
            };
        }
    }
}