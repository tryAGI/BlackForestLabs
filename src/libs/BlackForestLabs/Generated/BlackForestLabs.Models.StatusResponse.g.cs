
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum StatusResponse
    {
        /// <summary>
        /// 
        /// </summary>
        TaskNotFound,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        RequestModerated,
        /// <summary>
        /// 
        /// </summary>
        ContentModerated,
        /// <summary>
        /// 
        /// </summary>
        Ready,
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StatusResponseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StatusResponse value)
        {
            return value switch
            {
                StatusResponse.TaskNotFound => "Task not found",
                StatusResponse.Pending => "Pending",
                StatusResponse.RequestModerated => "Request Moderated",
                StatusResponse.ContentModerated => "Content Moderated",
                StatusResponse.Ready => "Ready",
                StatusResponse.Error => "Error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StatusResponse? ToEnum(string value)
        {
            return value switch
            {
                "Task not found" => StatusResponse.TaskNotFound,
                "Pending" => StatusResponse.Pending,
                "Request Moderated" => StatusResponse.RequestModerated,
                "Content Moderated" => StatusResponse.ContentModerated,
                "Ready" => StatusResponse.Ready,
                "Error" => StatusResponse.Error,
                _ => null,
            };
        }
    }
}