// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Teams.Item.Channels.Item.ProvisionEmail {
    /// <summary>
    /// Provides operations to call the provisionEmail method.
    /// </summary>
    public class ProvisionEmailRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="ProvisionEmailRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProvisionEmailRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/teams/{team%2Did}/channels/{channel%2Did}/provisionEmail", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ProvisionEmailRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProvisionEmailRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/teams/{team%2Did}/channels/{channel%2Did}/provisionEmail", rawUrl)
        {
        }
        /// <summary>
        /// Provision an email address for a channel. Microsoft Teams doesn&apos;t automatically provision an email address for a channel by default. To have Teams provision an email address, you can call provisionEmail, or through the Teams user interface, select Get email address, which triggers Teams to generate an email address if it has not already provisioned one. To remove the email address of a channel, use the removeEmail method.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/channel-provisionemail?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="ProvisionChannelEmailResult"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ProvisionChannelEmailResult?> PostAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<ProvisionChannelEmailResult> PostAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ProvisionChannelEmailResult>(requestInfo, ProvisionChannelEmailResult.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provision an email address for a channel. Microsoft Teams doesn&apos;t automatically provision an email address for a channel by default. To have Teams provision an email address, you can call provisionEmail, or through the Teams user interface, select Get email address, which triggers Teams to generate an email address if it has not already provisioned one. To remove the email address of a channel, use the removeEmail method.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="ProvisionEmailRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ProvisionEmailRequestBuilder WithUrl(string rawUrl)
        {
            return new ProvisionEmailRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ProvisionEmailRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}