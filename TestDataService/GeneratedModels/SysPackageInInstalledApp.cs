using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysPackageInInstalledApp")]
	public class SysPackageInInstalledApp : BaseEntity
	{
		#region Values
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
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysInstalledAppId")]
		public Guid SysInstalledAppId { get; set; }
		[CProperty(ColumnPath ="SysPackageId")]
		public Guid SysPackageId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysInstalledApp:SysInstalledAppId")]
		public SysInstalledApp SysInstalledApp { get; set; }
		[CProperty(Navigation ="SysPackage:SysPackageId")]
		public SysPackage SysPackage { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
