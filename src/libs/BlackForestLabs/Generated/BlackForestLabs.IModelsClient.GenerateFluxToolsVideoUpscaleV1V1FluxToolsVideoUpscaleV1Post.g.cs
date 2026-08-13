#nullable enable

namespace BlackForestLabs
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Upscale a video with FLUX 3.<br/>
        /// Submits a video upscaling task: 1.5x-3x super-resolution of the source clip (up to 20 seconds, 13.75 MP output frames). `creativity` selects precise source-faithful upscaling (0) or creative detail enhancement (1).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>> GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostAsync(

            global::BlackForestLabs.Flux3VideoUpscaleInputs request,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upscale a video with FLUX 3.<br/>
        /// Submits a video upscaling task: 1.5x-3x super-resolution of the source clip (up to 20 seconds, 13.75 MP output frames). `creativity` selects precise source-faithful upscaling (0) or creative detail enhancement (1).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.AutoSDKHttpResponse<global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>>> GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostAsResponseAsync(

            global::BlackForestLabs.Flux3VideoUpscaleInputs request,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upscale a video with FLUX 3.<br/>
        /// Submits a video upscaling task: 1.5x-3x super-resolution of the source clip (up to 20 seconds, 13.75 MP output frames). `creativity` selects precise source-faithful upscaling (0) or creative detail enhancement (1).
        /// </summary>
        /// <param name="inputVideo">
        /// The clip to upscale: base64-encoded mp4 (max 50MB) or an http(s) URL. At most 20 seconds of source footage.
        /// </param>
        /// <param name="prompt">
        /// Optional description of the clip's content, steering the enhanced detail. Leave empty for a neutral upscale.
        /// </param>
        /// <param name="creativity">
        /// Upscale behavior: 0 preserves the source precisely; 1 allows creative detail enhancement.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="upscaleFactor">
        /// Output scaling relative to the source resolution, between 1.5 and 3. The output preserves the source aspect ratio and is capped at a 13.75 MP frame: very large sources are upscaled by less than the requested factor.<br/>
        /// Default Value: 2F
        /// </param>
        /// <param name="safetyTolerance">
        /// Tolerance level for harm moderation, between 0 and 4 with 0 the strictest. It bounds every harm class on the prompt, which is screened before any generation, and on the delivered frames, which are withheld when their sexual-content level exceeds what the tolerance allows. Sexual is capped at level 3 and hate at level 2 regardless of the requested tolerance.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="webhookUrl">
        /// URL to receive the result callback.
        /// </param>
        /// <param name="webhookSecret">
        /// Secret echoed in the webhook signature header.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>> GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostAsync(
            string inputVideo,
            string? prompt = default,
            int? creativity = default,
            double? upscaleFactor = default,
            int? safetyTolerance = default,
            string? webhookUrl = default,
            string? webhookSecret = default,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}