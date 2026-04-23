#nullable enable

namespace BlackForestLabs
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Outpaint or extend an image with FLUX.2 [FLEX]<br/>
        /// Submits an outpainting task with FLUX.2 [FLEX]. The input image is placed on a (width, height) canvas with an adaptively-chosen monocolor padding, and the surrounding region is filled by a flex model fine-tuned for outpainting (BF16 baked checkpoint).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>> GenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostAsync(

            global::BlackForestLabs.OutpaintingInputs request,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Outpaint or extend an image with FLUX.2 [FLEX]<br/>
        /// Submits an outpainting task with FLUX.2 [FLEX]. The input image is placed on a (width, height) canvas with an adaptively-chosen monocolor padding, and the surrounding region is filled by a flex model fine-tuned for outpainting (BF16 baked checkpoint).
        /// </summary>
        /// <param name="prompt">
        /// Text prompt for outpainting. The trigger word 'OUTPAINT' is prepended automatically if absent. Defaults to a quality-focused outpainting prompt.
        /// </param>
        /// <param name="inputImage">
        /// Base64-encoded input image.
        /// </param>
        /// <param name="width">
        /// Target output width.
        /// </param>
        /// <param name="height">
        /// Target output height.
        /// </param>
        /// <param name="bboxX1">
        /// Left offset (px) of input image top-left corner on the canvas. Negative values are allowed. None = center horizontally.
        /// </param>
        /// <param name="bboxY1">
        /// Top offset (px) of input image top-left corner on the canvas. Negative values are allowed. None = center vertically.
        /// </param>
        /// <param name="autoCrop">
        /// If True, crop the input image to the canvas bounds when it extends beyond the edges. If False, an error is raised instead.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="prePadded">
        /// If True, skip padding and use the image as-is.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="promptUpsampling">
        /// Whether to upsample the prompt via VLM before inference.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="outputFormat">
        /// Default Value: png
        /// </param>
        /// <param name="steps">
        /// Number of diffusion steps. Defaults to 30 if not specified.
        /// </param>
        /// <param name="guidance">
        /// Guidance scale. Defaults to 4.0 if not specified.
        /// </param>
        /// <param name="cacheResidualDiffThreshold">
        /// Block caching threshold. 0 disables caching. Overrides effort if set.
        /// </param>
        /// <param name="effort">
        /// Effort mode: 'high' (no caching, best quality), 'medium', or 'low' (fastest). Defaults to 'high'.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>> GenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostAsync(
            string inputImage,
            string? prompt = default,
            int? width = default,
            int? height = default,
            int? bboxX1 = default,
            int? bboxY1 = default,
            bool? autoCrop = default,
            bool? prePadded = default,
            bool? promptUpsampling = default,
            global::BlackForestLabs.OutputFormat? outputFormat = default,
            int? steps = default,
            double? guidance = default,
            double? cacheResidualDiffThreshold = default,
            string? effort = default,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}