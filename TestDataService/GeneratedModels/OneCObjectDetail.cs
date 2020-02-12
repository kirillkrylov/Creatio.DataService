using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OneCObjectDetail")]
	public class OneCObjectDetail : BaseEntity
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
		[CProperty(ColumnPath ="OneCObjectId")]
		public Guid OneCObjectId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="OneCObject:OneCObjectId")]
		public OneCObject OneCObject { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="OneCObjectDetailColumn:OneCObjectDetailId")]
		public virtual ICollection<OneCObjectDetailColumn> OneCObjectDetailColumnByOneCObjectDetail { get; set; }
		[CProperty(Association ="SyncColumn:OneCDetailId")]
		public virtual ICollection<SyncColumn> SyncColumnByOneCDetail { get; set; }
		#endregion
	}
}
