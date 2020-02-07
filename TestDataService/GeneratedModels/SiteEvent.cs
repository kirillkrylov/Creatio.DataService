using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SiteEvent")]
	public class SiteEvent : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BpmSessionId")]
		public Guid BpmSessionId { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EventDate")]
		public DateTime EventDate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="LeadTypeId")]
		public Guid LeadTypeId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SiteEventTypeId")]
		public Guid SiteEventTypeId { get; set; }
		[CProperty(ColumnPath ="Source")]
		public string Source { get; set; }
		[CProperty(ColumnPath ="Tag")]
		public string Tag { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="LeadType:LeadTypeId")]
		public LeadType LeadType { get; set; }
		[CProperty(Navigation ="SiteEventType:SiteEventTypeId")]
		public SiteEventType SiteEventType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AttributeInSiteEvent:SiteEventId")]
		public virtual ICollection<AttributeInSiteEvent> AttributeInSiteEventBySiteEvent { get; set; }
		#endregion
	}
}
