// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security {
    public class FilePlanDescriptor : Microsoft.Graph.Models.Entity, IParsable 
    {
        /// <summary>Represents the file plan descriptor of type authority applied to a particular retention label.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FilePlanAuthority? Authority {
            get { return BackingStore?.Get<FilePlanAuthority?>("authority"); }
            set { BackingStore?.Set("authority", value); }
        }
#nullable restore
#else
        public FilePlanAuthority Authority {
            get { return BackingStore?.Get<FilePlanAuthority>("authority"); }
            set { BackingStore?.Set("authority", value); }
        }
#endif
        /// <summary>Specifies the underlying authority that describes the type of content to be retained and its retention schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Security.AuthorityTemplate? AuthorityTemplate {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.AuthorityTemplate?>("authorityTemplate"); }
            set { BackingStore?.Set("authorityTemplate", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Security.AuthorityTemplate AuthorityTemplate {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.AuthorityTemplate>("authorityTemplate"); }
            set { BackingStore?.Set("authorityTemplate", value); }
        }
#endif
        /// <summary>The category property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FilePlanAppliedCategory? Category {
            get { return BackingStore?.Get<FilePlanAppliedCategory?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
#nullable restore
#else
        public FilePlanAppliedCategory Category {
            get { return BackingStore?.Get<FilePlanAppliedCategory>("category"); }
            set { BackingStore?.Set("category", value); }
        }
#endif
        /// <summary>Specifies a group of similar types of content in a particular department.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Security.CategoryTemplate? CategoryTemplate {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.CategoryTemplate?>("categoryTemplate"); }
            set { BackingStore?.Set("categoryTemplate", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Security.CategoryTemplate CategoryTemplate {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.CategoryTemplate>("categoryTemplate"); }
            set { BackingStore?.Set("categoryTemplate", value); }
        }
#endif
        /// <summary>Represents the file plan descriptor of type citation applied to a particular retention label.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FilePlanCitation? Citation {
            get { return BackingStore?.Get<FilePlanCitation?>("citation"); }
            set { BackingStore?.Set("citation", value); }
        }
#nullable restore
#else
        public FilePlanCitation Citation {
            get { return BackingStore?.Get<FilePlanCitation>("citation"); }
            set { BackingStore?.Set("citation", value); }
        }
#endif
        /// <summary>The specific rule or regulation created by a jurisdiction used to determine whether certain labels and content should be retained or deleted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Security.CitationTemplate? CitationTemplate {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.CitationTemplate?>("citationTemplate"); }
            set { BackingStore?.Set("citationTemplate", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Security.CitationTemplate CitationTemplate {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.CitationTemplate>("citationTemplate"); }
            set { BackingStore?.Set("citationTemplate", value); }
        }
#endif
        /// <summary>Represents the file plan descriptor of type department applied to a particular retention label.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FilePlanDepartment? Department {
            get { return BackingStore?.Get<FilePlanDepartment?>("department"); }
            set { BackingStore?.Set("department", value); }
        }
#nullable restore
#else
        public FilePlanDepartment Department {
            get { return BackingStore?.Get<FilePlanDepartment>("department"); }
            set { BackingStore?.Set("department", value); }
        }
#endif
        /// <summary>Specifies the  department or business unit of an organization to which a label belongs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Security.DepartmentTemplate? DepartmentTemplate {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.DepartmentTemplate?>("departmentTemplate"); }
            set { BackingStore?.Set("departmentTemplate", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Security.DepartmentTemplate DepartmentTemplate {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.DepartmentTemplate>("departmentTemplate"); }
            set { BackingStore?.Set("departmentTemplate", value); }
        }
#endif
        /// <summary>Represents the file plan descriptor of type filePlanReference applied to a particular retention label.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Security.FilePlanReference? FilePlanReference {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.FilePlanReference?>("filePlanReference"); }
            set { BackingStore?.Set("filePlanReference", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Security.FilePlanReference FilePlanReference {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.FilePlanReference>("filePlanReference"); }
            set { BackingStore?.Set("filePlanReference", value); }
        }
#endif
        /// <summary>Specifies a unique alpha-numeric identifier for an organization’s retention schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Security.FilePlanReferenceTemplate? FilePlanReferenceTemplate {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.FilePlanReferenceTemplate?>("filePlanReferenceTemplate"); }
            set { BackingStore?.Set("filePlanReferenceTemplate", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Security.FilePlanReferenceTemplate FilePlanReferenceTemplate {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.FilePlanReferenceTemplate>("filePlanReferenceTemplate"); }
            set { BackingStore?.Set("filePlanReferenceTemplate", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="FilePlanDescriptor"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new FilePlanDescriptor CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FilePlanDescriptor();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"authority", n => { Authority = n.GetObjectValue<FilePlanAuthority>(FilePlanAuthority.CreateFromDiscriminatorValue); } },
                {"authorityTemplate", n => { AuthorityTemplate = n.GetObjectValue<Microsoft.Graph.Models.Security.AuthorityTemplate>(Microsoft.Graph.Models.Security.AuthorityTemplate.CreateFromDiscriminatorValue); } },
                {"category", n => { Category = n.GetObjectValue<FilePlanAppliedCategory>(FilePlanAppliedCategory.CreateFromDiscriminatorValue); } },
                {"categoryTemplate", n => { CategoryTemplate = n.GetObjectValue<Microsoft.Graph.Models.Security.CategoryTemplate>(Microsoft.Graph.Models.Security.CategoryTemplate.CreateFromDiscriminatorValue); } },
                {"citation", n => { Citation = n.GetObjectValue<FilePlanCitation>(FilePlanCitation.CreateFromDiscriminatorValue); } },
                {"citationTemplate", n => { CitationTemplate = n.GetObjectValue<Microsoft.Graph.Models.Security.CitationTemplate>(Microsoft.Graph.Models.Security.CitationTemplate.CreateFromDiscriminatorValue); } },
                {"department", n => { Department = n.GetObjectValue<FilePlanDepartment>(FilePlanDepartment.CreateFromDiscriminatorValue); } },
                {"departmentTemplate", n => { DepartmentTemplate = n.GetObjectValue<Microsoft.Graph.Models.Security.DepartmentTemplate>(Microsoft.Graph.Models.Security.DepartmentTemplate.CreateFromDiscriminatorValue); } },
                {"filePlanReference", n => { FilePlanReference = n.GetObjectValue<Microsoft.Graph.Models.Security.FilePlanReference>(Microsoft.Graph.Models.Security.FilePlanReference.CreateFromDiscriminatorValue); } },
                {"filePlanReferenceTemplate", n => { FilePlanReferenceTemplate = n.GetObjectValue<Microsoft.Graph.Models.Security.FilePlanReferenceTemplate>(Microsoft.Graph.Models.Security.FilePlanReferenceTemplate.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<FilePlanAuthority>("authority", Authority);
            writer.WriteObjectValue<Microsoft.Graph.Models.Security.AuthorityTemplate>("authorityTemplate", AuthorityTemplate);
            writer.WriteObjectValue<FilePlanAppliedCategory>("category", Category);
            writer.WriteObjectValue<Microsoft.Graph.Models.Security.CategoryTemplate>("categoryTemplate", CategoryTemplate);
            writer.WriteObjectValue<FilePlanCitation>("citation", Citation);
            writer.WriteObjectValue<Microsoft.Graph.Models.Security.CitationTemplate>("citationTemplate", CitationTemplate);
            writer.WriteObjectValue<FilePlanDepartment>("department", Department);
            writer.WriteObjectValue<Microsoft.Graph.Models.Security.DepartmentTemplate>("departmentTemplate", DepartmentTemplate);
            writer.WriteObjectValue<Microsoft.Graph.Models.Security.FilePlanReference>("filePlanReference", FilePlanReference);
            writer.WriteObjectValue<Microsoft.Graph.Models.Security.FilePlanReferenceTemplate>("filePlanReferenceTemplate", FilePlanReferenceTemplate);
        }
    }
}
