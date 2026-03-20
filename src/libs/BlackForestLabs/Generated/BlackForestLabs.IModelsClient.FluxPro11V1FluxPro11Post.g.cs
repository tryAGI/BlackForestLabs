#nullable enable

namespace BlackForestLabs
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Generate an image with FLUX 1.1 [pro].<br/>
        /// Submits an image generation task with FLUX 1.1 [pro].
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>> FluxPro11V1FluxPro11PostAsync(

            global::BlackForestLabs.FluxPro11Inputs request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate an image with FLUX 1.1 [pro].<br/>
        /// Submits an image generation task with FLUX 1.1 [pro].
        /// </summary>
        /// <param name="prompt">
        /// Text prompt for image generation.<br/>
        /// Example: ein fantastisches bild
        /// </param>
        /// <param name="imagePrompt">
        /// Optional base64 encoded image to use with Flux Redux.
        /// </param>
        /// <param name="width">
        /// Width of the generated image in pixels. Must be a multiple of 32.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="height">
        /// Height of the generated image in pixels. Must be a multiple of 32.<br/>
        /// Default Value: 768
        /// </param>
        /// <param name="promptUpsampling">
        /// Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="seed">
        /// Optional seed for reproducibility.<br/>
        /// Example: 42
        /// </param>
        /// <param name="safetyTolerance">
        /// Tolerance level for input and output moderation. Between 0 and 6, 0 being most strict, 6 being least strict.<br/>
        /// Default Value: 2<br/>
        /// Example: 2
        /// </param>
        /// <param name="outputFormat">
        /// Output format for the generated image. Can be 'jpeg' or 'png'.<br/>
        /// Default Value: jpeg
        /// </param>
        /// <param name="webhookUrl">
        /// URL to receive webhook notifications
        /// </param>
        /// <param name="webhookSecret">
        /// Optional secret for webhook signature verification
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>> FluxPro11V1FluxPro11PostAsync(
            string? prompt = default,
            string? imagePrompt = default,
            int? width = default,
            int? height = default,
            bool? promptUpsampling = default,
            int? seed = default,
            int? safetyTolerance = default,
            global::BlackForestLabs.OutputFormat? outputFormat = default,
            string? webhookUrl = default,
            string? webhookSecret = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}