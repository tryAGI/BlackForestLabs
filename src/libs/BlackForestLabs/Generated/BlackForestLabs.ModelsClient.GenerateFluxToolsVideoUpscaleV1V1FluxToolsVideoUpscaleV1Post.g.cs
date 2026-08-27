
#nullable enable

namespace BlackForestLabs
{
    public partial class ModelsClient
    {

        private static readonly global::BlackForestLabs.AutoSDKServer[] s_GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostServers = new global::BlackForestLabs.AutoSDKServer[]
        {            new global::BlackForestLabs.AutoSDKServer(
                id: "https-api-bfl-ai",
                name: "BFL API",
                url: "https://api.bfl.ai/",
                description: "BFL API"),
        };


        private static readonly global::BlackForestLabs.EndPointSecurityRequirement s_GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostSecurityRequirement0 =
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
        private static readonly global::BlackForestLabs.EndPointSecurityRequirement[] s_GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostSecurityRequirements =
            new global::BlackForestLabs.EndPointSecurityRequirement[]
            {                s_GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostSecurityRequirement0,
            };
        partial void PrepareGenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::BlackForestLabs.Flux3VideoUpscaleInputs request);
        partial void PrepareGenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::BlackForestLabs.Flux3VideoUpscaleInputs request);
        partial void ProcessGenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upscale a video with FLUX 3.<br/>
        /// Submits a video upscaling task: 1.5x-3x super-resolution of the source clip (up to 2560x1440 in, 13.75 MP output frames). The upscale covers the first 20 seconds of the source; clips well past that are rejected. `creativity` selects precise source-faithful upscaling (0) or creative detail enhancement (1).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>> GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostAsync(

            global::BlackForestLabs.Flux3VideoUpscaleInputs request,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Upscale a video with FLUX 3.<br/>
        /// Submits a video upscaling task: 1.5x-3x super-resolution of the source clip (up to 2560x1440 in, 13.75 MP output frames). The upscale covers the first 20 seconds of the source; clips well past that are rejected. `creativity` selects precise source-faithful upscaling (0) or creative detail enhancement (1).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::BlackForestLabs.AutoSDKHttpResponse<global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>>> GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostAsResponseAsync(

            global::BlackForestLabs.Flux3VideoUpscaleInputs request,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareGenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::BlackForestLabs.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostSecurityRequirements,
                operationName: "GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostAsync");

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
                                path: "/v1/flux-tools/video-upscale-v1",
                                baseUri: ResolveBaseUri(
                                servers: s_GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostServers,
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
                PrepareGenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostRequest(
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
                                operationId: "GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1Post",
                                methodName: "GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostAsync",
                                pathTemplate: "\"/v1/flux-tools/video-upscale-v1\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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
                        var __retryDelay = global::BlackForestLabs.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::BlackForestLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::BlackForestLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1Post",
                                methodName: "GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostAsync",
                                pathTemplate: "\"/v1/flux-tools/video-upscale-v1\"",
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
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::BlackForestLabs.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::BlackForestLabs.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::BlackForestLabs.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::BlackForestLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::BlackForestLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1Post",
                                methodName: "GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostAsync",
                                pathTemplate: "\"/v1/flux-tools/video-upscale-v1\"",
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
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::BlackForestLabs.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
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
                ProcessGenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::BlackForestLabs.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::BlackForestLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1Post",
                                methodName: "GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostAsync",
                                pathTemplate: "\"/v1/flux-tools/video-upscale-v1\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::BlackForestLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::BlackForestLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1Post",
                                methodName: "GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostAsync",
                                pathTemplate: "\"/v1/flux-tools/video-upscale-v1\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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


                                throw global::BlackForestLabs.ApiException<global::BlackForestLabs.HTTPValidationError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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
                                ProcessGenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::BlackForestLabs.AutoSDKHttpResponse<global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>>(
                                        statusCode: __response.StatusCode,
                                        headers: global::BlackForestLabs.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::BlackForestLabs.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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

                                    var __value = await global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::BlackForestLabs.AutoSDKHttpResponse<global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>>(
                                        statusCode: __response.StatusCode,
                                        headers: global::BlackForestLabs.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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

                                    throw global::BlackForestLabs.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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
        /// Upscale a video with FLUX 3.<br/>
        /// Submits a video upscaling task: 1.5x-3x super-resolution of the source clip (up to 2560x1440 in, 13.75 MP output frames). The upscale covers the first 20 seconds of the source; clips well past that are rejected. `creativity` selects precise source-faithful upscaling (0) or creative detail enhancement (1).
        /// </summary>
        /// <param name="inputVideo">
        /// The clip to upscale: base64-encoded mp4 (max 50MB) or an http(s) URL. The upscale covers the first 20 seconds; a clip slightly over that is upscaled up to the 20 second mark, and one well over is rejected. At most 2560x1440 (3.7 megapixels) per frame: this endpoint upscales toward 4K, so downscale a larger source before submitting it.
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
        public async global::System.Threading.Tasks.Task<global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>> GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostAsync(
            string inputVideo,
            string? prompt = default,
            int? creativity = default,
            double? upscaleFactor = default,
            int? safetyTolerance = default,
            string? webhookUrl = default,
            string? webhookSecret = default,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::BlackForestLabs.Flux3VideoUpscaleInputs
            {
                InputVideo = inputVideo,
                Prompt = prompt,
                Creativity = creativity,
                UpscaleFactor = upscaleFactor,
                SafetyTolerance = safetyTolerance,
                WebhookUrl = webhookUrl,
                WebhookSecret = webhookSecret,
            };

            return await GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}