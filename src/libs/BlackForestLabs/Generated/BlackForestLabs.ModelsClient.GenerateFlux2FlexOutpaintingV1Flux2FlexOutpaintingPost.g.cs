
#nullable enable

namespace BlackForestLabs
{
    public partial class ModelsClient
    {

        private static readonly global::BlackForestLabs.AutoSDKServer[] s_GenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostServers = new global::BlackForestLabs.AutoSDKServer[]
        {            new global::BlackForestLabs.AutoSDKServer(
                id: "https-api-bfl-ai",
                name: "BFL API",
                url: "https://api.bfl.ai/",
                description: "BFL API"),
        };


        private static readonly global::BlackForestLabs.EndPointSecurityRequirement s_GenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostSecurityRequirement0 =
            new global::BlackForestLabs.EndPointSecurityRequirement
            {
                Authorizations = new global::BlackForestLabs.EndPointAuthorizationRequirement[]
                {                    new global::BlackForestLabs.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::BlackForestLabs.EndPointSecurityRequirement[] s_GenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostSecurityRequirements =
            new global::BlackForestLabs.EndPointSecurityRequirement[]
            {                s_GenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostSecurityRequirement0,
            };
        partial void PrepareGenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::BlackForestLabs.OutpaintingInputs request);
        partial void PrepareGenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::BlackForestLabs.OutpaintingInputs request);
        partial void ProcessGenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Outpaint or extend an image with FLUX.2 [FLEX]<br/>
        /// Submits an outpainting task with FLUX.2 [FLEX]. The input image is placed on a (width, height) canvas with an adaptively-chosen monocolor padding, and the surrounding region is filled by a flex model fine-tuned for outpainting (BF16 baked checkpoint).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>> GenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostAsync(

            global::BlackForestLabs.OutpaintingInputs request,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareGenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::BlackForestLabs.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostSecurityRequirements,
                operationName: "GenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostAsync");

            using var __timeoutCancellationTokenSource = global::BlackForestLabs.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::BlackForestLabs.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::BlackForestLabs.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::BlackForestLabs.PathBuilder(
                                path: "/v1/flux-2-flex-outpainting",
                                baseUri: ResolveBaseUri(
                                servers: s_GenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostServers,
                                defaultBaseUrl: "https://api.bfl.ai/"));
                            var __path = __pathBuilder.ToString();
                __path = global::BlackForestLabs.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::BlackForestLabs.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::BlackForestLabs.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::BlackForestLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPost",
                                methodName: "GenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostAsync",
                                pathTemplate: "\"/v1/flux-2-flex-outpainting\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::BlackForestLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::BlackForestLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPost",
                                methodName: "GenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostAsync",
                                pathTemplate: "\"/v1/flux-2-flex-outpainting\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::BlackForestLabs.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::BlackForestLabs.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::BlackForestLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::BlackForestLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPost",
                                methodName: "GenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostAsync",
                                pathTemplate: "\"/v1/flux-2-flex-outpainting\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::BlackForestLabs.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessGenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::BlackForestLabs.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::BlackForestLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPost",
                                methodName: "GenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostAsync",
                                pathTemplate: "\"/v1/flux-2-flex-outpainting\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::BlackForestLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::BlackForestLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPost",
                                methodName: "GenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostAsync",
                                pathTemplate: "\"/v1/flux-2-flex-outpainting\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Validation Error
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::BlackForestLabs.HTTPValidationError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::BlackForestLabs.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::BlackForestLabs.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }

                                throw new global::BlackForestLabs.ApiException<global::BlackForestLabs.HTTPValidationError>(
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_422,
                                    ResponseObject = __value_422,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessGenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::BlackForestLabs.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::BlackForestLabs.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
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
        public async global::System.Threading.Tasks.Task<global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>> GenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::BlackForestLabs.OutpaintingInputs
            {
                Prompt = prompt,
                InputImage = inputImage,
                Width = width,
                Height = height,
                BboxX1 = bboxX1,
                BboxY1 = bboxY1,
                AutoCrop = autoCrop,
                PrePadded = prePadded,
                PromptUpsampling = promptUpsampling,
                OutputFormat = outputFormat,
                Steps = steps,
                Guidance = guidance,
                CacheResidualDiffThreshold = cacheResidualDiffThreshold,
                Effort = effort,
            };

            return await GenerateFlux2FlexOutpaintingV1Flux2FlexOutpaintingPostAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}