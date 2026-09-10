#nullable enable

namespace BlackForestLabs
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Edit a video with FLUX 3.<br/>
        /// Submits a video edit task: the supplied clip is transformed according to the edit instruction. Duration, resolution, aspect ratio, and audio follow the source clip; inference controls are pinned server-side.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>> GenerateFluxToolsVideoEditV1V1FluxToolsVideoEditV1PostAsync(

            global::BlackForestLabs.Flux3VideoVE2VNamedInputs request,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit a video with FLUX 3.<br/>
        /// Submits a video edit task: the supplied clip is transformed according to the edit instruction. Duration, resolution, aspect ratio, and audio follow the source clip; inference controls are pinned server-side.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.AutoSDKHttpResponse<global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>>> GenerateFluxToolsVideoEditV1V1FluxToolsVideoEditV1PostAsResponseAsync(

            global::BlackForestLabs.Flux3VideoVE2VNamedInputs request,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit a video with FLUX 3.<br/>
        /// Submits a video edit task: the supplied clip is transformed according to the edit instruction. Duration, resolution, aspect ratio, and audio follow the source clip; inference controls are pinned server-side.
        /// </summary>
        /// <param name="video">
        /// The video to edit, an http(s) URL or base64-encoded mp4.
        /// </param>
        /// <param name="prompt">
        /// Edit instruction, stripped of surrounding whitespace.
        /// </param>
        /// <param name="safetyTolerance">
        /// Tolerance level for input and output harm moderation. Between 0 and 4, with 0 the strictest. Sexual content is limited to level 3 and hate content to level 2 regardless of the requested tolerance.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>> GenerateFluxToolsVideoEditV1V1FluxToolsVideoEditV1PostAsync(
            string video,
            string prompt,
            int? safetyTolerance = default,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}