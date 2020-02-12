using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "IntegrationJob")]
	public class IntegrationJob : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="HoursInterval")]
		public int HoursInterval { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IntegrationId")]
		public Guid IntegrationId { get; set; }
		[CProperty(ColumnPath ="IntegrationJobTypeId")]
		public Guid IntegrationJobTypeId { get; set; }
		[CProperty(ColumnPath ="IntegrationTime")]
		public DateTime IntegrationTime { get; set; }
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive { get; set; }
		[CProperty(ColumnPath ="JobName")]
		public string JobName { get; set; }
		[CProperty(ColumnPath ="MinutesInterval")]
		public int MinutesInterval { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="UserId")]
		public Guid UserId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Integration1C:IntegrationId")]
		public Integration1C Integration { get; set; }
		[CProperty(Navigation ="IntegrationJobType:IntegrationJobTypeId")]
		public IntegrationJobType IntegrationJobType { get; set; }
		[CProperty(Navigation ="SysAdminUnit:UserId")]
		public SysAdminUnit User { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
