#nullable enable

namespace BlackForestLabs
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Generate an image with FLUX 3.<br/>
        /// Submits an image generation task with FLUX 3.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.AsyncResponse> Flux3ImageV1Flux3ImagePostAsync(

            global::BlackForestLabs.Flux3ImageInputs request,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an image with FLUX 3.<br/>
        /// Submits an image generation task with FLUX 3.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.AutoSDKHttpResponse<global::BlackForestLabs.AsyncResponse>> Flux3ImageV1Flux3ImagePostAsResponseAsync(

            global::BlackForestLabs.Flux3ImageInputs request,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an image with FLUX 3.<br/>
        /// Submits an image generation task with FLUX 3.
        /// </summary>
        /// <param name="prompt">
        /// Free-form prompt describing the image.
        /// </param>
        /// <param name="images">
        /// Optional reference image(s) the prompt edits or draws from; each is an http(s) URL or base64, one to 10 total.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. Under `auto` a ratio the prompt asks for wins, otherwise the output keeps the first reference image's framing; without references the prompt decides, else 1:1.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="resolution">
        /// Image resolution class, an equal-pixel-area tier: `768sq`, `1k`, `1.5k`, `2k`, or `4k`. Exact dimensions vary with the aspect ratio.<br/>
        /// Default Value: 1k
        /// </param>
        /// <param name="safetyTolerance">
        /// Tolerance level for input and output harm moderation. Between 0 and 4, with 0 the strictest.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="grounding">
        /// When true (default) the prompt may be grounded in external research: web search and image search. When false, both are off.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="version">
        /// Endpoint version. `latest` (default) serves the current release; dated pinnable release tags are added here as they are published.<br/>
        /// Default Value: latest
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.AsyncResponse> Flux3ImageV1Flux3ImagePostAsync(
            string prompt,
            global::BlackForestLabs.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? images = default,
            global::BlackForestLabs.AnyOf<global::BlackForestLabs.Flux3ImageInputsAspectRatio?, string>? aspectRatio = default,
            global::BlackForestLabs.Flux3ImageInputsResolution? resolution = default,
            int? safetyTolerance = default,
            bool? grounding = default,
            string? version = default,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}