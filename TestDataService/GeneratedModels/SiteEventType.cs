using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SiteEventType")]
	public class SiteEventType : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="Identifier")]
		public string Identifier { get; set; }
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ScoringEventTypeId")]
		public Guid ScoringEventTypeId { get; set; }
		[CProperty(ColumnPath ="SelectorTypeId")]
		public Guid SelectorTypeId { get; set; }
		[CProperty(ColumnPath ="WebsiteEventTypeId")]
		public Guid WebsiteEventTypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ScoringEventType:ScoringEventTypeId")]
		public ScoringEventType ScoringEventType { get; set; }
		[CProperty(Navigation ="SelectorType:SelectorTypeId")]
		public SelectorType SelectorType { get; set; }
		[CProperty(Navigation ="WebsiteEventType:WebsiteEventTypeId")]
		public WebsiteEventType WebsiteEventType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SiteEvent:SiteEventTypeId")]
		public virtual ICollection<SiteEvent> SiteEventBySiteEventType { get; set; }
		[CProperty(Association ="SiteEventTypeFile:SiteEventTypeId")]
		public virtual ICollection<SiteEventTypeFile> SiteEventTypeFileBySiteEventType { get; set; }
		[CProperty(Association ="SiteEventTypeInFolder:SiteEventTypeId")]
		public virtual ICollection<SiteEventTypeInFolder> SiteEventTypeInFolderBySiteEventType { get; set; }
		[CProperty(Association ="SiteEventTypeInTag:EntityId")]
		public virtual ICollection<SiteEventTypeInTag> SiteEventTypeInTagByEntity { get; set; }
		[CProperty(Association ="VwSiteEvent:SiteEventTypeId")]
		public virtual ICollection<VwSiteEvent> VwSiteEventBySiteEventType { get; set; }
		#endregion
	}
}
