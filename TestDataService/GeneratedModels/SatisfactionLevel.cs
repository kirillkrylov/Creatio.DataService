using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SatisfactionLevel")]
	public class SatisfactionLevel : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ImageId")]
		public Guid ImageId { get; set; }
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Point")]
		public int Point { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="CaseStatus:StatusId")]
		public CaseStatus Status { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysImage:ImageId")]
		public SysImage Image { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Case:SatisfactionLevelId")]
		public virtual ICollection<Case> CaseBySatisfactionLevel { get; set; }
		[CProperty(Association ="CaseLifecycle:SatisfactionLevelId")]
		public virtual ICollection<CaseLifecycle> CaseLifecycleBySatisfactionLevel { get; set; }
		[CProperty(Association ="Change:SatisfactionLevelId")]
		public virtual ICollection<Change> ChangeBySatisfactionLevel { get; set; }
		[CProperty(Association ="VwChange:SatisfactionLevelId")]
		public virtual ICollection<VwChange> VwChangeBySatisfactionLevel { get; set; }
		#endregion
	}
}
