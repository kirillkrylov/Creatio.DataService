using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OneCRegisterClass")]
	public class OneCRegisterClass : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
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
		[CProperty(Association ="OneCRegister:OneCRegisterClassId")]
		public virtual ICollection<OneCRegister> OneCRegisterByOneCRegisterClass { get; set; }
		[CProperty(Association ="OneCRegisterObject:RegisterClassId")]
		public virtual ICollection<OneCRegisterObject> OneCRegisterObjectByRegisterClass { get; set; }
		[CProperty(Association ="SyncColumn:RegisterClassId")]
		public virtual ICollection<SyncColumn> SyncColumnByRegisterClass { get; set; }
		[CProperty(Association ="SyncObject:OneCRegisterClassId")]
		public virtual ICollection<SyncObject> SyncObjectByOneCRegisterClass { get; set; }
		#endregion
	}
}
