// <auto-generated/>
using Microsoft.Graph.DeviceAppManagement.MobileApps.Count;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphAndroidLobApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphAndroidStoreApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphIosLobApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphIosStoreApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphIosVppApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphMacOSDmgApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphMacOSLobApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphManagedAndroidLobApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphManagedIOSLobApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphManagedMobileLobApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphMicrosoftStoreForBusinessApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphWin32LobApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphWindowsAppX;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphWindowsMobileMSI;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphWindowsUniversalAppX;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphWindowsWebApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.Item;
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
namespace Microsoft.Graph.DeviceAppManagement.MobileApps {
    /// <summary>
    /// Provides operations to manage the mobileApps property of the microsoft.graph.deviceAppManagement entity.
    /// </summary>
    public class MobileAppsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public CountRequestBuilder Count
        {
            get => new CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to androidLobApp.</summary>
        public GraphAndroidLobAppRequestBuilder GraphAndroidLobApp
        {
            get => new GraphAndroidLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to androidStoreApp.</summary>
        public GraphAndroidStoreAppRequestBuilder GraphAndroidStoreApp
        {
            get => new GraphAndroidStoreAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to iosLobApp.</summary>
        public GraphIosLobAppRequestBuilder GraphIosLobApp
        {
            get => new GraphIosLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to iosStoreApp.</summary>
        public GraphIosStoreAppRequestBuilder GraphIosStoreApp
        {
            get => new GraphIosStoreAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to iosVppApp.</summary>
        public GraphIosVppAppRequestBuilder GraphIosVppApp
        {
            get => new GraphIosVppAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to macOSDmgApp.</summary>
        public GraphMacOSDmgAppRequestBuilder GraphMacOSDmgApp
        {
            get => new GraphMacOSDmgAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to macOSLobApp.</summary>
        public GraphMacOSLobAppRequestBuilder GraphMacOSLobApp
        {
            get => new GraphMacOSLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to managedAndroidLobApp.</summary>
        public GraphManagedAndroidLobAppRequestBuilder GraphManagedAndroidLobApp
        {
            get => new GraphManagedAndroidLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to managedIOSLobApp.</summary>
        public GraphManagedIOSLobAppRequestBuilder GraphManagedIOSLobApp
        {
            get => new GraphManagedIOSLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to managedMobileLobApp.</summary>
        public GraphManagedMobileLobAppRequestBuilder GraphManagedMobileLobApp
        {
            get => new GraphManagedMobileLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to microsoftStoreForBusinessApp.</summary>
        public GraphMicrosoftStoreForBusinessAppRequestBuilder GraphMicrosoftStoreForBusinessApp
        {
            get => new GraphMicrosoftStoreForBusinessAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to win32LobApp.</summary>
        public GraphWin32LobAppRequestBuilder GraphWin32LobApp
        {
            get => new GraphWin32LobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to windowsAppX.</summary>
        public GraphWindowsAppXRequestBuilder GraphWindowsAppX
        {
            get => new GraphWindowsAppXRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to windowsMobileMSI.</summary>
        public GraphWindowsMobileMSIRequestBuilder GraphWindowsMobileMSI
        {
            get => new GraphWindowsMobileMSIRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to windowsUniversalAppX.</summary>
        public GraphWindowsUniversalAppXRequestBuilder GraphWindowsUniversalAppX
        {
            get => new GraphWindowsUniversalAppXRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to windowsWebApp.</summary>
        public GraphWindowsWebAppRequestBuilder GraphWindowsWebApp
        {
            get => new GraphWindowsWebAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the mobileApps property of the microsoft.graph.deviceAppManagement entity.</summary>
        /// <param name="position">The unique identifier of mobileApp</param>
        /// <returns>A <see cref="MobileAppItemRequestBuilder"/></returns>
        public MobileAppItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("mobileApp%2Did", position);
                return new MobileAppItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="MobileAppsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MobileAppsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceAppManagement/mobileApps{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="MobileAppsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MobileAppsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceAppManagement/mobileApps{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// List properties and relationships of the managedMobileLobApp objects.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-apps-managedmobilelobapp-list?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="MobileAppCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<MobileAppCollectionResponse?> GetAsync(Action<RequestConfiguration<MobileAppsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<MobileAppCollectionResponse> GetAsync(Action<RequestConfiguration<MobileAppsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<MobileAppCollectionResponse>(requestInfo, MobileAppCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new iosiPadOSWebClip object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-apps-iosipadoswebclip-create?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="MobileApp"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<MobileApp?> PostAsync(MobileApp body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<MobileApp> PostAsync(MobileApp body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<MobileApp>(requestInfo, MobileApp.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List properties and relationships of the managedMobileLobApp objects.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MobileAppsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MobileAppsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a new iosiPadOSWebClip object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(MobileApp body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(MobileApp body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="MobileAppsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MobileAppsRequestBuilder WithUrl(string rawUrl)
        {
            return new MobileAppsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List properties and relationships of the managedMobileLobApp objects.
        /// </summary>
        public class MobileAppsRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Order items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24orderby")]
            public string[]? Orderby { get; set; }
#nullable restore
#else
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class MobileAppsRequestBuilderGetRequestConfiguration : RequestConfiguration<MobileAppsRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class MobileAppsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
