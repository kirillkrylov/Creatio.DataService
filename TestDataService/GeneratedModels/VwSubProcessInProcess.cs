using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSubProcessInProcess")]
	public class VwSubProcessInProcess : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActiveSubProcessId")]
		public Guid ActiveSubProcessId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="HostProcessId")]
		public Guid HostProcessId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ParentProcessId")]
		public Guid ParentProcessId { get; set; }
		[CProperty(ColumnPath ="ParentSubProcessId")]
		public Guid ParentSubProcessId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SubProcessId")]
		public Guid SubProcessId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="VwProcessLib:HostProcessId")]
		public VwProcessLib HostProcess { get; set; }
		[CProperty(Navigation ="VwProcessLib:ParentProcessId")]
		public VwProcessLib ParentProcess { get; set; }
		[CProperty(Navigation ="VwProcessLib:SubProcessId")]
		public VwProcessLib SubProcess { get; set; }
		[CProperty(Navigation ="VwProcessLib:ParentSubProcessId")]
		public VwProcessLib ParentSubProcess { get; set; }
		[CProperty(Navigation ="VwProcessLib:ActiveSubProcessId")]
		public VwProcessLib ActiveSubProcess { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
