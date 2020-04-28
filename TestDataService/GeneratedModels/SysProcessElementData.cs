using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysProcessElementData")]
	public class SysProcessElementData : BaseEntity
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
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="PropertiesData")]
		public byte[] PropertiesData { get; set; }
		[CProperty(ColumnPath ="SchemaElementUId")]
		public Guid SchemaElementUId { get; set; }
		[CProperty(ColumnPath ="SchemaUId")]
		public Guid SchemaUId { get; set; }
		[CProperty(ColumnPath ="Status")]
		public int Status { get; set; }
		[CProperty(ColumnPath ="SysProcessId")]
		public Guid SysProcessId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysProcessData:SysProcessId")]
		public SysProcessData SysProcess { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="EntryPoint:SysProcessElementDataId")]
		public virtual ICollection<EntryPoint> EntryPointBySysProcessElementData { get; set; }
		[CProperty(Association ="SysEntityCommonPrcEl:ProcessElementId")]
		public virtual ICollection<SysEntityCommonPrcEl> SysEntityCommonPrcElByProcessElement { get; set; }
		[CProperty(Association ="SysProcessIntermediateEvent:SysProcessElementId")]
		public virtual ICollection<SysProcessIntermediateEvent> SysProcessIntermediateEventBySysProcessElement { get; set; }
		[CProperty(Association ="VwProcessDashboard:ProcessElementId")]
		public virtual ICollection<VwProcessDashboard> VwProcessDashboardByProcessElement { get; set; }
		#endregion
	}
}
