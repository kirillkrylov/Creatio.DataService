using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupCaseScoringGroup")]
	public class SupCaseScoringGroup : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		[CProperty(ColumnPath ="SupSysSchemaId")]
		public Guid SupSysSchemaId { get; set; }
		[CProperty(ColumnPath ="SupWeight")]
		public int SupWeight { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysSchema:SupSysSchemaId")]
		public SysSchema SupSysSchema { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SupCaseScoringSettings:SupCaseScoringGroupId")]
		public virtual ICollection<SupCaseScoringSettings> SupCaseScoringSettingsBySupCaseScoringGroup { get; set; }
		#endregion
	}
}
