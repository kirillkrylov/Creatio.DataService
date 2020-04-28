using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BeesenderOperatorUnit")]
	public class BeesenderOperatorUnit : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AltDuty")]
		public bool AltDuty { get; set; }
		[CProperty(ColumnPath ="ChatConfigId")]
		public Guid ChatConfigId { get; set; }
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
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProcessName")]
		public string ProcessName { get; set; }
		[CProperty(ColumnPath ="QueuePosition")]
		public int QueuePosition { get; set; }
		[CProperty(ColumnPath ="Status")]
		public int Status { get; set; }
		[CProperty(ColumnPath ="SysAdminUnitId")]
		public Guid SysAdminUnitId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="Weight")]
		public decimal Weight { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="BeesenderChatConfiguration:ChatConfigId")]
		public BeesenderChatConfiguration ChatConfig { get; set; }
		[CProperty(Navigation ="BeesenderOperatorUnit:ParentId")]
		public BeesenderOperatorUnit Parent { get; set; }
		[CProperty(Navigation ="BeesenderOperatorUnitType:TypeId")]
		public BeesenderOperatorUnitType Type { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysAdminUnit:SysAdminUnitId")]
		public SysAdminUnit SysAdminUnit { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BeesenderOperatorChannel:UnitId")]
		public virtual ICollection<BeesenderOperatorChannel> BeesenderOperatorChannelByUnit { get; set; }
		[CProperty(Association ="BeesenderOperatorUnit:ParentId")]
		public virtual ICollection<BeesenderOperatorUnit> BeesenderOperatorUnitByParent { get; set; }
		#endregion
	}
}
