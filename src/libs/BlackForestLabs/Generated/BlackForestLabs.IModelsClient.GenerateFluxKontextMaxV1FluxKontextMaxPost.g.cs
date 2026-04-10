#nullable enable

namespace BlackForestLabs
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Create an image with FLUX.1 Kontext [max] (legacy, use FLUX.2 [PRO] for editing)<br/>
        /// Submits an image creation task with FLUX.1 Kontext [max]. For image editing, prefer FLUX.2 [PRO] (/flux-2-pro) or FLUX.2 [FLEX] (/flux-2-flex) which are the recommended default models for editing workflows.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>> GenerateFluxKontextMaxV1FluxKontextMaxPostAsync(

            global::BlackForestLabs.FluxKontextProInputs request,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an image with FLUX.1 Kontext [max] (legacy, use FLUX.2 [PRO] for editing)<br/>
        /// Submits an image creation task with FLUX.1 Kontext [max]. For image editing, prefer FLUX.2 [PRO] (/flux-2-pro) or FLUX.2 [FLEX] (/flux-2-flex) which are the recommended default models for editing workflows.
        /// </summary>
        /// <param name="prompt">
        /// Text prompt for image generation.<br/>
        /// Example: ein fantastisches bild
        /// </param>
        /// <param name="inputImage">
        /// Base64 encoded image or URL to use with Kontext.
        /// </param>
        /// <param name="inputImage2">
        /// Base64 encoded image or URL to use with Kontext. *Experimental Multiref*
        /// </param>
        /// <param name="inputImage3">
        /// Base64 encoded image or URL to use with Kontext. *Experimental Multiref*
        /// </param>
        /// <param name="inputImage4">
        /// Base64 encoded image or URL to use with Kontext. *Experimental Multiref*
        /// </param>
        /// <param name="seed">
        /// Optional seed for reproducibility.<br/>
        /// Example: 42
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio of the image between 21:9 and 9:21
        /// </param>
        /// <param name="outputFormat">
        /// Output format for the generated image. Can be 'jpeg', 'png', or 'webp'.<br/>
        /// Default Value: png
        /// </param>
        /// <param name="webhookUrl">
        /// URL to receive webhook notifications
        /// </param>
        /// <param name="webhookSecret">
        /// Optional secret for webhook signature verification
        /// </param>
        /// <param name="promptUpsampling">
        /// Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="safetyTolerance">
        /// Tolerance level for input and output moderation. Between 0 and 6, 0 being most strict, 6 being least strict.<br/>
        /// Default Value: 2<br/>
        /// Example: 2
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>> GenerateFluxKontextMaxV1FluxKontextMaxPostAsync(
            string prompt,
            string? inputImage = default,
            string? inputImage2 = default,
            string? inputImage3 = default,
            string? inputImage4 = default,
            int? seed = default,
            string? aspectRatio = default,
            global::BlackForestLabs.OutputFormat? outputFormat = default,
            string? webhookUrl = default,
            string? webhookSecret = default,
            bool? promptUpsampling = default,
            int? safetyTolerance = default,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}