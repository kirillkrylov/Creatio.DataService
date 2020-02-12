using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OneCRegisterColumn")]
	public class OneCRegisterColumn : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OneCRegisterId")]
		public Guid OneCRegisterId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Type")]
		public string Type { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="OneCRegister:OneCRegisterId")]
		public OneCRegister OneCRegister { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="RegisterColumn:OneCRegesterColumnId")]
		public virtual ICollection<RegisterColumn> RegisterColumnByOneCRegesterColumn { get; set; }
		[CProperty(Association ="SyncColumn:RegesterLinkColumnId")]
		public virtual ICollection<SyncColumn> SyncColumnByRegesterLinkColumn { get; set; }
		[CProperty(Association ="SyncColumn:RegesterLinkColumnFilterId")]
		public virtual ICollection<SyncColumn> SyncColumnByRegesterLinkColumnFilter { get; set; }
		#endregion
	}
}
