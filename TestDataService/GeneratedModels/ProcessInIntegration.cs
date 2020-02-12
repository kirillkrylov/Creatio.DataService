using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ProcessInIntegration")]
	public class ProcessInIntegration : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BusinessProcessId")]
		public Guid BusinessProcessId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IntegrationId")]
		public Guid IntegrationId { get; set; }
		[CProperty(ColumnPath ="IsEnabled")]
		public bool IsEnabled { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
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
		[CProperty(Navigation ="SysSchema:BusinessProcessId")]
		public SysSchema BusinessProcess { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
