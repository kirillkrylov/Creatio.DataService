using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OneCRegister")]
	public class OneCRegister : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IntegrationId")]
		public Guid IntegrationId { get; set; }
		[CProperty(ColumnPath ="IsPeriodic")]
		public bool IsPeriodic { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OneCRegisterClassId")]
		public Guid OneCRegisterClassId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Integration1C:IntegrationId")]
		public Integration1C Integration { get; set; }
		[CProperty(Navigation ="OneCRegisterClass:OneCRegisterClassId")]
		public OneCRegisterClass OneCRegisterClass { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="OneCRegisterColumn:OneCRegisterId")]
		public virtual ICollection<OneCRegisterColumn> OneCRegisterColumnByOneCRegister { get; set; }
		[CProperty(Association ="SyncColumn:OneCRegisterId")]
		public virtual ICollection<SyncColumn> SyncColumnByOneCRegister { get; set; }
		#endregion
	}
}
