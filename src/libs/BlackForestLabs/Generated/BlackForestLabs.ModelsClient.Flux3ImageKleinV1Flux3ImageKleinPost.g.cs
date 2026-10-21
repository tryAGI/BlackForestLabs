
#nullable enable

namespace BlackForestLabs
{
    public partial class ModelsClient
    {


        private static readonly global::BlackForestLabs.EndPointSecurityRequirement s_Flux3ImageKleinV1Flux3ImageKleinPostSecurityRequirement0 =
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
        private static readonly global::BlackForestLabs.EndPointSecurityRequirement[] s_Flux3ImageKleinV1Flux3ImageKleinPostSecurityRequirements =
            new global::BlackForestLabs.EndPointSecurityRequirement[]
            {                s_Flux3ImageKleinV1Flux3ImageKleinPostSecurityRequirement0,
            };
        partial void PrepareFlux3ImageKleinV1Flux3ImageKleinPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::BlackForestLabs.Flux3ImageKleinInputs request);
        partial void PrepareFlux3ImageKleinV1Flux3ImageKleinPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::BlackForestLabs.Flux3ImageKleinInputs request);
        partial void ProcessFlux3ImageKleinV1Flux3ImageKleinPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessFlux3ImageKleinV1Flux3ImageKleinPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate an image with FLUX 3 Image Klein.<br/>
        /// Submits a text-to-image or image editing task with FLUX 3 Image Klein.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::BlackForestLabs.AsyncResponse> Flux3ImageKleinV1Flux3ImageKleinPostAsync(

            global::BlackForestLabs.Flux3ImageKleinInputs request,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await Flux3ImageKleinV1Flux3ImageKleinPostAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Generate an image with FLUX 3 Image Klein.<br/>
        /// Submits a text-to-image or image editing task with FLUX 3 Image Klein.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::BlackForestLabs.AutoSDKHttpResponse<global::BlackForestLabs.AsyncResponse>> Flux3ImageKleinV1Flux3ImageKleinPostAsResponseAsync(

            global::BlackForestLabs.Flux3ImageKleinInputs request,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareFlux3ImageKleinV1Flux3ImageKleinPostArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::BlackForestLabs.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_Flux3ImageKleinV1Flux3ImageKleinPostSecurityRequirements,
                operationName: "Flux3ImageKleinV1Flux3ImageKleinPostAsync");

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
                                path: "/v1/flux-3-image-klein",
                                baseUri: HttpClient.BaseAddress);
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
                PrepareFlux3ImageKleinV1Flux3ImageKleinPostRequest(
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
                                operationId: "Flux3ImageKleinV1Flux3ImageKleinPost",
                                methodName: "Flux3ImageKleinV1Flux3ImageKleinPostAsync",
                                pathTemplate: "\"/v1/flux-3-image-klein\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "Flux3ImageKleinV1Flux3ImageKleinPost",
                                methodName: "Flux3ImageKleinV1Flux3ImageKleinPostAsync",
                                pathTemplate: "\"/v1/flux-3-image-klein\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "Flux3ImageKleinV1Flux3ImageKleinPost",
                                methodName: "Flux3ImageKleinV1Flux3ImageKleinPostAsync",
                                pathTemplate: "\"/v1/flux-3-image-klein\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                ProcessFlux3ImageKleinV1Flux3ImageKleinPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::BlackForestLabs.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::BlackForestLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Flux3ImageKleinV1Flux3ImageKleinPost",
                                methodName: "Flux3ImageKleinV1Flux3ImageKleinPostAsync",
                                pathTemplate: "\"/v1/flux-3-image-klein\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "Flux3ImageKleinV1Flux3ImageKleinPost",
                                methodName: "Flux3ImageKleinV1Flux3ImageKleinPostAsync",
                                pathTemplate: "\"/v1/flux-3-image-klein\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                ProcessFlux3ImageKleinV1Flux3ImageKleinPostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::BlackForestLabs.AsyncResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::BlackForestLabs.AutoSDKHttpResponse<global::BlackForestLabs.AsyncResponse>(
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

                                    var __value = await global::BlackForestLabs.AsyncResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::BlackForestLabs.AutoSDKHttpResponse<global::BlackForestLabs.AsyncResponse>(
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
        public async global::System.Threading.Tasks.Task<global::BlackForestLabs.AsyncResponse> Flux3ImageKleinV1Flux3ImageKleinPostAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::BlackForestLabs.Flux3ImageKleinInputs
            {
                User = user,
                Prompt = prompt,
                Images = images,
                AspectRatio = aspectRatio,
                Resolution = resolution,
                Width = width,
                Height = height,
                Seed = seed,
                SafetyTolerance = safetyTolerance,
                OutputFormat = outputFormat,
                Steps = steps,
            };

            return await Flux3ImageKleinV1Flux3ImageKleinPostAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}