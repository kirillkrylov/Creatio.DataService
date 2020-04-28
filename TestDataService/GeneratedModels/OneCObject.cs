using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OneCObject")]
	public class OneCObject : BaseEntity
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
		[CProperty(ColumnPath ="IntegrationId")]
		public Guid IntegrationId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
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
		[CProperty(Navigation ="Integration1C:IntegrationId")]
		public Integration1C Integration { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AgregateObject:OneCObjectId")]
		public virtual ICollection<AgregateObject> AgregateObjectByOneCObject { get; set; }
		[CProperty(Association ="OneCObjectColumn:OneCObjectId")]
		public virtual ICollection<OneCObjectColumn> OneCObjectColumnByOneCObject { get; set; }
		[CProperty(Association ="OneCObjectDetail:OneCObjectId")]
		public virtual ICollection<OneCObjectDetail> OneCObjectDetailByOneCObject { get; set; }
		[CProperty(Association ="SyncObject:OneCObjectId")]
		public virtual ICollection<SyncObject> SyncObjectByOneCObject { get; set; }
		#endregion
	}
}
