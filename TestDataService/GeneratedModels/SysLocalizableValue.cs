using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysLocalizableValue")]
	public class SysLocalizableValue : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ImageData")]
		public byte[] ImageData { get; set; }
		[CProperty(ColumnPath ="IsChanged")]
		public bool IsChanged { get; set; }
		[CProperty(ColumnPath ="Key")]
		public string Key { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ResourceManager")]
		public string ResourceManager { get; set; }
		[CProperty(ColumnPath ="ResourceType")]
		public int ResourceType { get; set; }
		[CProperty(ColumnPath ="SysCultureId")]
		public Guid SysCultureId { get; set; }
		[CProperty(ColumnPath ="SysPackageId")]
		public Guid SysPackageId { get; set; }
		[CProperty(ColumnPath ="SysSchemaId")]
		public Guid SysSchemaId { get; set; }
		[CProperty(ColumnPath ="Value")]
		public string Value { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysCulture:SysCultureId")]
		public SysCulture SysCulture { get; set; }
		[CProperty(Navigation ="SysPackage:SysPackageId")]
		public SysPackage SysPackage { get; set; }
		[CProperty(Navigation ="SysSchema:SysSchemaId")]
		public SysSchema SysSchema { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
