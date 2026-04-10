#nullable enable

namespace BlackForestLabs
{
    public partial interface IUtilityClient
    {
        /// <summary>
        /// Delete Finetune<br/>
        /// Delete a finetune_id that was created by the user
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.DeleteFinetuneResponse> DeleteFinetuneV1DeleteFinetunePostAsync(

            global::BlackForestLabs.DeleteFinetuneInputs request,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Finetune<br/>
        /// Delete a finetune_id that was created by the user
        /// </summary>
        /// <param name="finetuneId">
        /// Name of the LoRA to delete.<br/>
        /// Example: my-finetune
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.DeleteFinetuneResponse> DeleteFinetuneV1DeleteFinetunePostAsync(
            string finetuneId,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}