#nullable enable

namespace BlackForestLabs
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Generate an image with FLUX 3 Image Klein.<br/>
        /// Submits a text-to-image or image editing task with FLUX 3 Image Klein.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.AsyncResponse> Flux3ImageKleinV1Flux3ImageKleinPostAsync(

            global::BlackForestLabs.Flux3ImageKleinInputs request,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an image with FLUX 3 Image Klein.<br/>
        /// Submits a text-to-image or image editing task with FLUX 3 Image Klein.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.AutoSDKHttpResponse<global::BlackForestLabs.AsyncResponse>> Flux3ImageKleinV1Flux3ImageKleinPostAsResponseAsync(

            global::BlackForestLabs.Flux3ImageKleinInputs request,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an image with FLUX 3 Image Klein.<br/>
        /// Submits a text-to-image or image editing task with FLUX 3 Image Klein.
        /// </summary>
        /// <param name="user">
        /// Opaque identifier for the end user supplied by the calling platform.
        /// </param>
        /// <param name="prompt">
        /// Free-form prompt describing the image.
        /// </param>
        /// <param name="images">
        /// Optional reference image(s), each an http(s) URL or base64, one to 10 total. The first is the image being edited and sets the default output size.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio, as in flux-3-image. `auto` (default): for edits, the first reference's exact aspect; for text-to-image, a ratio picked from the prompt (prompt rewrite, else ratio keywords, else 16:9) at the requested tier. Ignored when width and height are set.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="resolution">
        /// Equal-area size tier, as in flux-3-image: `768sq`, `1k`, `1.5k`, `2k` or `4k`. Omitted: `1k` for text-to-image; for edits the first reference's own size, or its nearest tier when aspect_ratio is set. Ignored when width and height are set.
        /// </param>
        /// <param name="width">
        /// Exact output width in pixels, [64, 6256]; set together with height. Overrides resolution and aspect_ratio.
        /// </param>
        /// <param name="height">
        /// Exact output height in pixels, [64, 6256]; width x height at most 16822272 pixels (16.8 MP, the largest 4k bin).
        /// </param>
        /// <param name="seed">
        /// Seed for reproducibility; random when omitted.
        /// </param>
        /// <param name="safetyTolerance">
        /// Harm moderation tolerance from 0 to 7, with 0 the strictest. The route and organization determine the approved maximum and per-category ceilings. Unapproved levels return 422 with approved levels.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="outputFormat">
        /// Output image format: `jpeg` (default) or `png`.<br/>
        /// Default Value: jpeg
        /// </param>
        /// <param name="steps">
        /// Denoising steps (default 16).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.AsyncResponse> Flux3ImageKleinV1Flux3ImageKleinPostAsync(
            string prompt,
            string? user = default,
            global::BlackForestLabs.AnyOf<string, global::System.Collections.Generic.IList<string>>? images = default,
            global::BlackForestLabs.AnyOf<global::BlackForestLabs.Flux3ImageKleinInputsAspectRatio?, string>? aspectRatio = default,
            global::BlackForestLabs.Flux3ImageKleinInputsResolution? resolution = default,
            int? width = default,
            int? height = default,
            int? seed = default,
            int? safetyTolerance = default,
            global::BlackForestLabs.Flux3ImageKleinInputsOutputFormat? outputFormat = default,
            int? steps = default,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}