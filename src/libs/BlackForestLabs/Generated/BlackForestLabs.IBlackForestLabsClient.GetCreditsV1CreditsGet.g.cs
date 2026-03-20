#nullable enable

namespace BlackForestLabs
{
    public partial interface IBlackForestLabsClient
    {
        /// <summary>
        /// Get the user's credits<br/>
        /// Get the user's credits
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.CreditsResponse> GetCreditsV1CreditsGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}