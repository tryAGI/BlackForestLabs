#nullable enable

namespace BlackForestLabs
{
    public partial interface IUtilityClient
    {
        /// <summary>
        /// My Finetunes<br/>
        /// List all finetune_ids created by the user
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.MyFinetunesResponse> MyFinetunesV1MyFinetunesGetAsync(
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}