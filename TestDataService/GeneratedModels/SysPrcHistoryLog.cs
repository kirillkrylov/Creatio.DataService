using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysPrcHistoryLog")]
	public class SysPrcHistoryLog : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CompleteDate")]
		public DateTime CompleteDate { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DurationInDays")]
		public decimal DurationInDays { get; set; }
		[CProperty(ColumnPath ="DurationInHours")]
		public decimal DurationInHours { get; set; }
		[CProperty(ColumnPath ="DurationInMilliseconds")]
		public decimal DurationInMilliseconds { get; set; }
		[CProperty(ColumnPath ="DurationInMinutes")]
		public decimal DurationInMinutes { get; set; }
		[CProperty(ColumnPath ="ErrorDescription")]
		public string ErrorDescription { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="PackageName")]
		public string PackageName { get; set; }
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="SysSchemaId")]
		public Guid SysSchemaId { get; set; }
		[CProperty(ColumnPath ="SysWorkspaceId")]
		public Guid SysWorkspaceId { get; set; }
		[CProperty(ColumnPath ="Version")]
		public int Version { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysPrcHistoryLog:ParentId")]
		public SysPrcHistoryLog Parent { get; set; }
		[CProperty(Navigation ="SysProcessStatus:StatusId")]
		public SysProcessStatus Status { get; set; }
		[CProperty(Navigation ="SysSchema:SysSchemaId")]
		public SysSchema SysSchema { get; set; }
		[CProperty(Navigation ="SysWorkspace:SysWorkspaceId")]
		public SysWorkspace SysWorkspace { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SysPrcElHistoryLog:SysProcessId")]
		public virtual ICollection<SysPrcElHistoryLog> SysPrcElHistoryLogBySysProcess { get; set; }
		[CProperty(Association ="SysPrcEntityHistory:SysProcessId")]
		public virtual ICollection<SysPrcEntityHistory> SysPrcEntityHistoryBySysProcess { get; set; }
		[CProperty(Association ="SysPrcHistoryLog:ParentId")]
		public virtual ICollection<SysPrcHistoryLog> SysPrcHistoryLogByParent { get; set; }
		#endregion
	}
}
