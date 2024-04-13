// <auto-generated/>
using Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.Analytics;
using Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.Columns;
using Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.ContentTypes;
using Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.CreatedByUser;
using Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.Drive;
using Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.Drives;
using Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.ExternalColumns;
using Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetActivitiesByInterval;
using Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval;
using Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId;
using Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1;
using Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.Items;
using Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.LastModifiedByUser;
using Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.Lists;
using Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.Onenote;
using Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.Operations;
using Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.Pages;
using Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.Permissions;
using Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.Sites;
using Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.TermStore;
using Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.TermStores;
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
namespace Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath {
    /// <summary>
    /// Provides operations to call the getByPath method.
    /// </summary>
    public class GetByPathWithPathRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Provides operations to manage the analytics property of the microsoft.graph.site entity.</summary>
        public AnalyticsRequestBuilder Analytics
        {
            get => new AnalyticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the columns property of the microsoft.graph.site entity.</summary>
        public ColumnsRequestBuilder Columns
        {
            get => new ColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the contentTypes property of the microsoft.graph.site entity.</summary>
        public ContentTypesRequestBuilder ContentTypes
        {
            get => new ContentTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the createdByUser property of the microsoft.graph.baseItem entity.</summary>
        public CreatedByUserRequestBuilder CreatedByUser
        {
            get => new CreatedByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the drive property of the microsoft.graph.site entity.</summary>
        public DriveRequestBuilder Drive
        {
            get => new DriveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the drives property of the microsoft.graph.site entity.</summary>
        public DrivesRequestBuilder Drives
        {
            get => new DrivesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the externalColumns property of the microsoft.graph.site entity.</summary>
        public ExternalColumnsRequestBuilder ExternalColumns
        {
            get => new ExternalColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getActivitiesByInterval method.</summary>
        public GetActivitiesByIntervalRequestBuilder GetActivitiesByInterval
        {
            get => new GetActivitiesByIntervalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the items property of the microsoft.graph.site entity.</summary>
        public ItemsRequestBuilder Items
        {
            get => new ItemsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lastModifiedByUser property of the microsoft.graph.baseItem entity.</summary>
        public LastModifiedByUserRequestBuilder LastModifiedByUser
        {
            get => new LastModifiedByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lists property of the microsoft.graph.site entity.</summary>
        public ListsRequestBuilder Lists
        {
            get => new ListsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the onenote property of the microsoft.graph.site entity.</summary>
        public OnenoteRequestBuilder Onenote
        {
            get => new OnenoteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the operations property of the microsoft.graph.site entity.</summary>
        public OperationsRequestBuilder Operations
        {
            get => new OperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the pages property of the microsoft.graph.site entity.</summary>
        public PagesRequestBuilder Pages
        {
            get => new PagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the permissions property of the microsoft.graph.site entity.</summary>
        public PermissionsRequestBuilder Permissions
        {
            get => new PermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sites property of the microsoft.graph.site entity.</summary>
        public Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.Sites.SitesRequestBuilder Sites
        {
            get => new Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.Sites.SitesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the termStore property of the microsoft.graph.site entity.</summary>
        public TermStoreRequestBuilder TermStore
        {
            get => new TermStoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the termStores property of the microsoft.graph.site entity.</summary>
        public TermStoresRequestBuilder TermStores
        {
            get => new TermStoresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="GetByPathWithPathRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="path">Usage: path=&apos;{path}&apos;</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetByPathWithPathRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string path = "") : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/sites/{site%2Did}/getByPath(path='{path}')", pathParameters)
        {
            if (!string.IsNullOrWhiteSpace(path)) PathParameters.Add("path", path);
        }
        /// <summary>
        /// Instantiates a new <see cref="GetByPathWithPathRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetByPathWithPathRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/sites/{site%2Did}/getByPath(path='{path}')", rawUrl)
        {
        }
        /// <summary>
        /// Provides operations to call the getActivitiesByInterval method.
        /// </summary>
        /// <returns>A <see cref="GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder"/></returns>
        /// <param name="endDateTime">Usage: endDateTime=&apos;{endDateTime}&apos;</param>
        /// <param name="interval">Usage: interval=&apos;{interval}&apos;</param>
        /// <param name="startDateTime">Usage: startDateTime=&apos;{startDateTime}&apos;</param>
        public GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval(string endDateTime, string interval, string startDateTime)
        {
            if(string.IsNullOrEmpty(endDateTime)) throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(interval)) throw new ArgumentNullException(nameof(interval));
            if(string.IsNullOrEmpty(startDateTime)) throw new ArgumentNullException(nameof(startDateTime));
            return new GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder(PathParameters, RequestAdapter, endDateTime, interval, startDateTime);
        }
        /// <summary>
        /// Provides operations to call the getApplicableContentTypesForList method.
        /// </summary>
        /// <returns>A <see cref="GetApplicableContentTypesForListWithListIdRequestBuilder"/></returns>
        /// <param name="listId">Usage: listId=&apos;{listId}&apos;</param>
        public GetApplicableContentTypesForListWithListIdRequestBuilder GetApplicableContentTypesForListWithListId(string listId)
        {
            if(string.IsNullOrEmpty(listId)) throw new ArgumentNullException(nameof(listId));
            return new GetApplicableContentTypesForListWithListIdRequestBuilder(PathParameters, RequestAdapter, listId);
        }
        /// <summary>
        /// Invoke function getByPath
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.Site"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.Site?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.Site> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.Site>(requestInfo, Microsoft.Graph.Models.Site.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to call the getByPath method.
        /// </summary>
        /// <returns>A <see cref="GetByPathWithPath1RequestBuilder"/></returns>
        /// <param name="path1">Usage: path=&apos;{path1}&apos;</param>
        public GetByPathWithPath1RequestBuilder GetByPathWithPath1(string path1)
        {
            if(string.IsNullOrEmpty(path1)) throw new ArgumentNullException(nameof(path1));
            return new GetByPathWithPath1RequestBuilder(PathParameters, RequestAdapter, path1);
        }
        /// <summary>
        /// Invoke function getByPath
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="GetByPathWithPathRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public GetByPathWithPathRequestBuilder WithUrl(string rawUrl)
        {
            return new GetByPathWithPathRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class GetByPathWithPathRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
