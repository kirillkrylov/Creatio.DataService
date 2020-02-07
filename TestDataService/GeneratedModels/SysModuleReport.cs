using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModuleReport")]
	public class SysModuleReport : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AutoPreview")]
		public bool AutoPreview { get; set; }
		[CProperty(ColumnPath ="Caption")]
		public string Caption { get; set; }
		[CProperty(ColumnPath ="ConvertInPDF")]
		public bool ConvertInPDF { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="File")]
		public byte[] File { get; set; }
		[CProperty(ColumnPath ="FileName")]
		public string FileName { get; set; }
		[CProperty(ColumnPath ="HelpContextId")]
		public string HelpContextId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="MacrosList")]
		public string MacrosList { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ShowInCard")]
		public bool ShowInCard { get; set; }
		[CProperty(ColumnPath ="ShowInSection")]
		public bool ShowInSection { get; set; }
		[CProperty(ColumnPath ="SysModuleId")]
		public Guid SysModuleId { get; set; }
		[CProperty(ColumnPath ="SysOptionsPageSchemaUId")]
		public Guid SysOptionsPageSchemaUId { get; set; }
		[CProperty(ColumnPath ="SysReportSchemaUId")]
		public Guid SysReportSchemaUId { get; set; }
		[CProperty(ColumnPath ="TypeColumnValue")]
		public Guid TypeColumnValue { get; set; }
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
		[CProperty(Navigation ="SysModuleReportType:TypeId")]
		public SysModuleReportType Type { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SysModuleReportInPackage:SysModuleReportId")]
		public virtual ICollection<SysModuleReportInPackage> SysModuleReportInPackageBySysModuleReport { get; set; }
		[CProperty(Association ="SysModuleReportLczOld:RecordId")]
		public virtual ICollection<SysModuleReportLczOld> SysModuleReportLczOldByRecord { get; set; }
		[CProperty(Association ="SysModuleReportTable:SysModuleReportId")]
		public virtual ICollection<SysModuleReportTable> SysModuleReportTableBySysModuleReport { get; set; }
		#endregion
	}
}
