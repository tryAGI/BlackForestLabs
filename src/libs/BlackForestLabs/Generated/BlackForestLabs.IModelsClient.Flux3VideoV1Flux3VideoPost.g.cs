#nullable enable

namespace BlackForestLabs
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Generate a video with FLUX 3.<br/>
        /// Submits a video generation task to FLUX 3 via the harness. The mode is explicit: t2v (`text-to-video`), i2v (`image-continuation`, keyframes), v2v (`video-continuation`, start_video), or draft_enhance (`draft-enhance`, full-quality render of a prior draft's `draft_cache`); the spelled-out aliases are accepted anywhere the short key is.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>> Flux3VideoV1Flux3VideoPostAsync(

            global::BlackForestLabs.Flux3VideoInputsBody request,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a video with FLUX 3.<br/>
        /// Submits a video generation task to FLUX 3 via the harness. The mode is explicit: t2v (`text-to-video`), i2v (`image-continuation`, keyframes), v2v (`video-continuation`, start_video), or draft_enhance (`draft-enhance`, full-quality render of a prior draft's `draft_cache`); the spelled-out aliases are accepted anywhere the short key is.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.AutoSDKHttpResponse<global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>>> Flux3VideoV1Flux3VideoPostAsResponseAsync(

            global::BlackForestLabs.Flux3VideoInputsBody request,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}