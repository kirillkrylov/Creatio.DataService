using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysPrcElHistoryLog")]
	public class SysPrcElHistoryLog : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Caption")]
		public string Caption { get; set; }
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
		[CProperty(ColumnPath ="NodeId")]
		public string NodeId { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SchemaElementUId")]
		public Guid SchemaElementUId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="SysProcessId")]
		public Guid SysProcessId { get; set; }
		[CProperty(ColumnPath ="Type")]
		public string Type { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="SysPrcHistoryLog:SysProcessId")]
		public SysPrcHistoryLog SysProcess { get; set; }
		[CProperty(Navigation ="SysProcessStatus:StatusId")]
		public SysProcessStatus Status { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
