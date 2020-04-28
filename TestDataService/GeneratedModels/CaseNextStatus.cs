using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CaseNextStatus")]
	public class CaseNextStatus : BaseEntity
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
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NextStatusId")]
		public Guid NextStatusId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="CaseStatus:StatusId")]
		public CaseStatus Status { get; set; }
		[CProperty(Navigation ="CaseStatus:NextStatusId")]
		public CaseStatus NextStatus { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="CaseRuleInStage:CaseNextStatusId")]
		public virtual ICollection<CaseRuleInStage> CaseRuleInStageByCaseNextStatus { get; set; }
		#endregion
	}
}
