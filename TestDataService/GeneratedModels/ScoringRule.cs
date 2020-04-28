using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ScoringRule")]
	public class ScoringRule : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Duration")]
		public int Duration { get; set; }
		[CProperty(ColumnPath ="FilterData")]
		public string FilterData { get; set; }
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
		[CProperty(ColumnPath ="ScoringCount")]
		public int ScoringCount { get; set; }
		[CProperty(ColumnPath ="ScoringModelId")]
		public Guid ScoringModelId { get; set; }
		[CProperty(ColumnPath ="ScoringPoints")]
		public decimal ScoringPoints { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ScoringModel:ScoringModelId")]
		public ScoringModel ScoringModel { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
