
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public enum AsyncTaskStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncTaskStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncTaskStatus value)
        {
            return value switch
            {
                AsyncTaskStatus.Completed => "completed",
                AsyncTaskStatus.Error => "error",
                AsyncTaskStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncTaskStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AsyncTaskStatus.Completed,
                "error" => AsyncTaskStatus.Error,
                "pending" => AsyncTaskStatus.Pending,
                _ => null,
            };
        }
    }
}