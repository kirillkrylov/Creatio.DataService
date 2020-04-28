using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ScoringModel")]
	public class ScoringModel : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ColumnCaption")]
		public string ColumnCaption { get; set; }
		[CProperty(ColumnPath ="ColumnUId")]
		public Guid ColumnUId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ScoringObjectId")]
		public Guid ScoringObjectId { get; set; }
		[CProperty(ColumnPath ="SourceModelId")]
		public Guid SourceModelId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ScoringModel:SourceModelId")]
		public ScoringModel SourceModel { get; set; }
		[CProperty(Navigation ="VwSysModuleEntity:ScoringObjectId")]
		public VwSysModuleEntity ScoringObject { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ScoringModel:SourceModelId")]
		public virtual ICollection<ScoringModel> ScoringModelBySourceModel { get; set; }
		[CProperty(Association ="ScoringRule:ScoringModelId")]
		public virtual ICollection<ScoringRule> ScoringRuleByScoringModel { get; set; }
		#endregion
	}
}
