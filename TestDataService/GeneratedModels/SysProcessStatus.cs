using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysProcessStatus")]
	public class SysProcessStatus : BaseEntity
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
		[CProperty(ColumnPath ="Value")]
		public int Value { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SysPrcElHistoryLog:StatusId")]
		public virtual ICollection<SysPrcElHistoryLog> SysPrcElHistoryLogByStatus { get; set; }
		[CProperty(Association ="SysPrcHistoryLog:StatusId")]
		public virtual ICollection<SysPrcHistoryLog> SysPrcHistoryLogByStatus { get; set; }
		[CProperty(Association ="SysProcessElementLog:StatusId")]
		public virtual ICollection<SysProcessElementLog> SysProcessElementLogByStatus { get; set; }
		[CProperty(Association ="SysProcessLog:StatusId")]
		public virtual ICollection<SysProcessLog> SysProcessLogByStatus { get; set; }
		[CProperty(Association ="VwSysProcessElementLog:StatusId")]
		public virtual ICollection<VwSysProcessElementLog> VwSysProcessElementLogByStatus { get; set; }
		[CProperty(Association ="VwSysProcessLog:StatusId")]
		public virtual ICollection<VwSysProcessLog> VwSysProcessLogByStatus { get; set; }
		#endregion
	}
}
