using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysProcessData")]
	public class SysProcessData : BaseEntity
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
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="PropertiesData")]
		public byte[] PropertiesData { get; set; }
		[CProperty(ColumnPath ="SchemaElementUId")]
		public Guid SchemaElementUId { get; set; }
		[CProperty(ColumnPath ="Status")]
		public int Status { get; set; }
		[CProperty(ColumnPath ="SysSchemaId")]
		public Guid SysSchemaId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysProcessData:ParentId")]
		public SysProcessData Parent { get; set; }
		[CProperty(Navigation ="SysSchema:SysSchemaId")]
		public SysSchema SysSchema { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SysProcessData:ParentId")]
		public virtual ICollection<SysProcessData> SysProcessDataByParent { get; set; }
		[CProperty(Association ="SysProcessElementData:SysProcessId")]
		public virtual ICollection<SysProcessElementData> SysProcessElementDataBySysProcess { get; set; }
		[CProperty(Association ="VwProcessDashboard:ProcessDataId")]
		public virtual ICollection<VwProcessDashboard> VwProcessDashboardByProcessData { get; set; }
		#endregion
	}
}
