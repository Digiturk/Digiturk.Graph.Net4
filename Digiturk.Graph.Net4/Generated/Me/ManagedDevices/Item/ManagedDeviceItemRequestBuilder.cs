// <auto-generated/>
using Microsoft.Graph.Me.ManagedDevices.Item.BypassActivationLock;
using Microsoft.Graph.Me.ManagedDevices.Item.CleanWindowsDevice;
using Microsoft.Graph.Me.ManagedDevices.Item.DeleteUserFromSharedAppleDevice;
using Microsoft.Graph.Me.ManagedDevices.Item.DeviceCategory;
using Microsoft.Graph.Me.ManagedDevices.Item.DeviceCompliancePolicyStates;
using Microsoft.Graph.Me.ManagedDevices.Item.DeviceConfigurationStates;
using Microsoft.Graph.Me.ManagedDevices.Item.DisableLostMode;
using Microsoft.Graph.Me.ManagedDevices.Item.LocateDevice;
using Microsoft.Graph.Me.ManagedDevices.Item.LogCollectionRequests;
using Microsoft.Graph.Me.ManagedDevices.Item.LogoutSharedAppleDeviceActiveUser;
using Microsoft.Graph.Me.ManagedDevices.Item.RebootNow;
using Microsoft.Graph.Me.ManagedDevices.Item.RecoverPasscode;
using Microsoft.Graph.Me.ManagedDevices.Item.RemoteLock;
using Microsoft.Graph.Me.ManagedDevices.Item.RequestRemoteAssistance;
using Microsoft.Graph.Me.ManagedDevices.Item.ResetPasscode;
using Microsoft.Graph.Me.ManagedDevices.Item.Retire;
using Microsoft.Graph.Me.ManagedDevices.Item.ShutDown;
using Microsoft.Graph.Me.ManagedDevices.Item.SyncDevice;
using Microsoft.Graph.Me.ManagedDevices.Item.UpdateWindowsDeviceAccount;
using Microsoft.Graph.Me.ManagedDevices.Item.Users;
using Microsoft.Graph.Me.ManagedDevices.Item.WindowsDefenderScan;
using Microsoft.Graph.Me.ManagedDevices.Item.WindowsDefenderUpdateSignatures;
using Microsoft.Graph.Me.ManagedDevices.Item.WindowsProtectionState;
using Microsoft.Graph.Me.ManagedDevices.Item.Wipe;
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
namespace Microsoft.Graph.Me.ManagedDevices.Item {
    /// <summary>
    /// Provides operations to manage the managedDevices property of the microsoft.graph.user entity.
    /// </summary>
    public class ManagedDeviceItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Provides operations to call the bypassActivationLock method.</summary>
        public BypassActivationLockRequestBuilder BypassActivationLock
        {
            get => new BypassActivationLockRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the cleanWindowsDevice method.</summary>
        public CleanWindowsDeviceRequestBuilder CleanWindowsDevice
        {
            get => new CleanWindowsDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the deleteUserFromSharedAppleDevice method.</summary>
        public DeleteUserFromSharedAppleDeviceRequestBuilder DeleteUserFromSharedAppleDevice
        {
            get => new DeleteUserFromSharedAppleDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceCategory property of the microsoft.graph.managedDevice entity.</summary>
        public DeviceCategoryRequestBuilder DeviceCategory
        {
            get => new DeviceCategoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceCompliancePolicyStates property of the microsoft.graph.managedDevice entity.</summary>
        public DeviceCompliancePolicyStatesRequestBuilder DeviceCompliancePolicyStates
        {
            get => new DeviceCompliancePolicyStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceConfigurationStates property of the microsoft.graph.managedDevice entity.</summary>
        public DeviceConfigurationStatesRequestBuilder DeviceConfigurationStates
        {
            get => new DeviceConfigurationStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the disableLostMode method.</summary>
        public DisableLostModeRequestBuilder DisableLostMode
        {
            get => new DisableLostModeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the locateDevice method.</summary>
        public LocateDeviceRequestBuilder LocateDevice
        {
            get => new LocateDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the logCollectionRequests property of the microsoft.graph.managedDevice entity.</summary>
        public LogCollectionRequestsRequestBuilder LogCollectionRequests
        {
            get => new LogCollectionRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the logoutSharedAppleDeviceActiveUser method.</summary>
        public LogoutSharedAppleDeviceActiveUserRequestBuilder LogoutSharedAppleDeviceActiveUser
        {
            get => new LogoutSharedAppleDeviceActiveUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the rebootNow method.</summary>
        public RebootNowRequestBuilder RebootNow
        {
            get => new RebootNowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the recoverPasscode method.</summary>
        public RecoverPasscodeRequestBuilder RecoverPasscode
        {
            get => new RecoverPasscodeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the remoteLock method.</summary>
        public RemoteLockRequestBuilder RemoteLock
        {
            get => new RemoteLockRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the requestRemoteAssistance method.</summary>
        public RequestRemoteAssistanceRequestBuilder RequestRemoteAssistance
        {
            get => new RequestRemoteAssistanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the resetPasscode method.</summary>
        public ResetPasscodeRequestBuilder ResetPasscode
        {
            get => new ResetPasscodeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the retire method.</summary>
        public RetireRequestBuilder Retire
        {
            get => new RetireRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the shutDown method.</summary>
        public ShutDownRequestBuilder ShutDown
        {
            get => new ShutDownRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the syncDevice method.</summary>
        public SyncDeviceRequestBuilder SyncDevice
        {
            get => new SyncDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the updateWindowsDeviceAccount method.</summary>
        public UpdateWindowsDeviceAccountRequestBuilder UpdateWindowsDeviceAccount
        {
            get => new UpdateWindowsDeviceAccountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the users property of the microsoft.graph.managedDevice entity.</summary>
        public UsersRequestBuilder Users
        {
            get => new UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the windowsDefenderScan method.</summary>
        public WindowsDefenderScanRequestBuilder WindowsDefenderScan
        {
            get => new WindowsDefenderScanRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the windowsDefenderUpdateSignatures method.</summary>
        public WindowsDefenderUpdateSignaturesRequestBuilder WindowsDefenderUpdateSignatures
        {
            get => new WindowsDefenderUpdateSignaturesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsProtectionState property of the microsoft.graph.managedDevice entity.</summary>
        public WindowsProtectionStateRequestBuilder WindowsProtectionState
        {
            get => new WindowsProtectionStateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the wipe method.</summary>
        public WipeRequestBuilder Wipe
        {
            get => new WipeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="ManagedDeviceItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ManagedDeviceItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/managedDevices/{managedDevice%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ManagedDeviceItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ManagedDeviceItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/managedDevices/{managedDevice%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property managedDevices for me
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// </summary>
        /// <returns>A <see cref="ManagedDevice"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ManagedDevice?> GetAsync(Action<RequestConfiguration<ManagedDeviceItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<ManagedDevice> GetAsync(Action<RequestConfiguration<ManagedDeviceItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ManagedDevice>(requestInfo, ManagedDevice.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property managedDevices in me
        /// </summary>
        /// <returns>A <see cref="ManagedDevice"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ManagedDevice?> PatchAsync(ManagedDevice body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<ManagedDevice> PatchAsync(ManagedDevice body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ManagedDevice>(requestInfo, ManagedDevice.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property managedDevices for me
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ManagedDeviceItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ManagedDeviceItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property managedDevices in me
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ManagedDevice body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ManagedDevice body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="ManagedDeviceItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ManagedDeviceItemRequestBuilder WithUrl(string rawUrl)
        {
            return new ManagedDeviceItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ManagedDeviceItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// </summary>
        public class ManagedDeviceItemRequestBuilderGetQueryParameters 
        {
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
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ManagedDeviceItemRequestBuilderGetRequestConfiguration : RequestConfiguration<ManagedDeviceItemRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ManagedDeviceItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}