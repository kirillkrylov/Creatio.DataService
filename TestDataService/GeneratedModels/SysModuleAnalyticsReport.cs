using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModuleAnalyticsReport")]
	public class SysModuleAnalyticsReport : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AutoPreview")]
		public bool AutoPreview { get; set; }
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
		[CProperty(ColumnPath ="LogoId")]
		public Guid LogoId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ModuleSchemaName")]
		public string ModuleSchemaName { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysModuleId")]
		public Guid SysModuleId { get; set; }
		[CProperty(ColumnPath ="SysOptionsPageSchemaUId")]
		public Guid SysOptionsPageSchemaUId { get; set; }
		[CProperty(ColumnPath ="SysSchemaUId")]
		public Guid SysSchemaUId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysImage:LogoId")]
		public SysImage Logo { get; set; }
		[CProperty(Navigation ="SysModule:SysModuleId")]
		public SysModule SysModule { get; set; }
		[CProperty(Navigation ="SysModuleReportType:TypeId")]
		public SysModuleReportType Type { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SysModuleAnalyticsReportLczOld:RecordId")]
		public virtual ICollection<SysModuleAnalyticsReportLczOld> SysModuleAnalyticsReportLczOldByRecord { get; set; }
		#endregion
	}
}
