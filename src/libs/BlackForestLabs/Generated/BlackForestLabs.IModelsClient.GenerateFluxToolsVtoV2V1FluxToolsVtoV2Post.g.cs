#nullable enable

namespace BlackForestLabs
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Virtual try-on (v2)<br/>
        /// Submits a virtual try-on task against the v2 model. Identical request shape to /vto-v1, with reference and output resolution supported up to 4MP. Person and garment images are mapped to the underlying input image slots. An edit instruction is generated from the person and garment images, with the supplied prompt used as a fallback.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>> GenerateFluxToolsVtoV2V1FluxToolsVtoV2PostAsync(

            global::BlackForestLabs.Flux2KleinTryonInputs request,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Virtual try-on (v2)<br/>
        /// Submits a virtual try-on task against the v2 model. Identical request shape to /vto-v1, with reference and output resolution supported up to 4MP. Person and garment images are mapped to the underlying input image slots. An edit instruction is generated from the person and garment images, with the supplied prompt used as a fallback.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.AutoSDKHttpResponse<global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>>> GenerateFluxToolsVtoV2V1FluxToolsVtoV2PostAsResponseAsync(

            global::BlackForestLabs.Flux2KleinTryonInputs request,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Virtual try-on (v2)<br/>
        /// Submits a virtual try-on task against the v2 model. Identical request shape to /vto-v1, with reference and output resolution supported up to 4MP. Person and garment images are mapped to the underlying input image slots. An edit instruction is generated from the person and garment images, with the supplied prompt used as a fallback.
        /// </summary>
        /// <param name="prompt">
        /// Text prompt for VTO generation.<br/>
        /// Example: TRY-ON: The person of image 1 wearing the garments of image 2.
        /// </param>
        /// <param name="person">
        /// Person image (maps internally to input_image).
        /// </param>
        /// <param name="garment">
        /// Image of one more garments (maps internally to input_image_2).
        /// </param>
        /// <param name="seed">
        /// Optional seed for reproducibility.<br/>
        /// Example: 42
        /// </param>
        /// <param name="safetyTolerance">
        /// Tolerance level for input and output moderation. Between 0 and 5 for public use.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="outputFormat">
        /// Default Value: jpeg
        /// </param>
        /// <param name="webhookUrl">
        /// URL to receive webhook notifications
        /// </param>
        /// <param name="webhookSecret">
        /// Optional secret for webhook signature verification
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>> GenerateFluxToolsVtoV2V1FluxToolsVtoV2PostAsync(
            string prompt,
            string person,
            string garment,
            int? seed = default,
            int? safetyTolerance = default,
            global::BlackForestLabs.OutputFormat? outputFormat = default,
            string? webhookUrl = default,
            string? webhookSecret = default,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}