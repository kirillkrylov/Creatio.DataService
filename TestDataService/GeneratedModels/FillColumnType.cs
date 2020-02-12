using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "FillColumnType")]
	public class FillColumnType : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="RegisterColumn:FillColumnTypeId")]
		public virtual ICollection<RegisterColumn> RegisterColumnByFillColumnType { get; set; }
		[CProperty(Association ="SyncColumn:FillColumnTypeId")]
		public virtual ICollection<SyncColumn> SyncColumnByFillColumnType { get; set; }
		[CProperty(Association ="SyncRegisterColumn:FillColumnTypeId")]
		public virtual ICollection<SyncRegisterColumn> SyncRegisterColumnByFillColumnType { get; set; }
		[CProperty(Association ="TableSyncColumn:FillColumnTypeId")]
		public virtual ICollection<TableSyncColumn> TableSyncColumnByFillColumnType { get; set; }
		#endregion
	}
}
