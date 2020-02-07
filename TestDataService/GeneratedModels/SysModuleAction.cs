using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModuleAction")]
	public class SysModuleAction : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Caption")]
		public string Caption { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="HelpContextId")]
		public string HelpContextId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="Image")]
		public byte[] Image { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Position")]
		public int Position { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysModuleId")]
		public Guid SysModuleId { get; set; }
		[CProperty(ColumnPath ="SysProcessSchemaUId")]
		public Guid SysProcessSchemaUId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysModule:SysModuleId")]
		public SysModule SysModule { get; set; }
		[CProperty(Navigation ="SysModuleActionType:TypeId")]
		public SysModuleActionType Type { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SysModuleActionLczOld:RecordId")]
		public virtual ICollection<SysModuleActionLczOld> SysModuleActionLczOldByRecord { get; set; }
		#endregion
	}
}
