using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysInstalledApp")]
	public class SysInstalledApp : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="FileLink")]
		public string FileLink { get; set; }
		[CProperty(ColumnPath ="HelpLink")]
		public string HelpLink { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="InstallDate")]
		public DateTime InstallDate { get; set; }
		[CProperty(ColumnPath ="LastUpdate")]
		public DateTime LastUpdate { get; set; }
		[CProperty(ColumnPath ="Maintainer")]
		public string Maintainer { get; set; }
		[CProperty(ColumnPath ="MarketplaceLink")]
		public string MarketplaceLink { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OrderLink")]
		public string OrderLink { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SupportEmail")]
		public string SupportEmail { get; set; }
		[CProperty(ColumnPath ="SysInstalledAppStatusId")]
		public Guid SysInstalledAppStatusId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysInstalledAppStatus:SysInstalledAppStatusId")]
		public SysInstalledAppStatus SysInstalledAppStatus { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SysPackageInInstalledApp:SysInstalledAppId")]
		public virtual ICollection<SysPackageInInstalledApp> SysPackageInInstalledAppBySysInstalledApp { get; set; }
		#endregion
	}
}
