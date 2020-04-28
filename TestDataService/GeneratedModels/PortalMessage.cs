using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PortalMessage")]
	public class PortalMessage : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EntityId")]
		public Guid EntityId { get; set; }
		[CProperty(ColumnPath ="EntitySchemaUId")]
		public Guid EntitySchemaUId { get; set; }
		[CProperty(ColumnPath ="FromPortal")]
		public bool FromPortal { get; set; }
		[CProperty(ColumnPath ="HideOnPortal")]
		public bool HideOnPortal { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsNotPublished")]
		public bool IsNotPublished { get; set; }
		[CProperty(ColumnPath ="Message")]
		public string Message { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="PortalMessageType:TypeId")]
		public PortalMessageType Type { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="PortalMessageFile:PortalMessageId")]
		public virtual ICollection<PortalMessageFile> PortalMessageFileByPortalMessage { get; set; }
		#endregion
	}
}
