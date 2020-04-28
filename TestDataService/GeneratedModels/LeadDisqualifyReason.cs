using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LeadDisqualifyReason")]
	public class LeadDisqualifyReason : BaseEntity
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
		[CProperty(ColumnPath ="LeadStageId")]
		public Guid LeadStageId { get; set; }
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="QualifyStatus:LeadStageId")]
		public QualifyStatus LeadStage { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Lead:LeadDisqualifyReasonId")]
		public virtual ICollection<Lead> LeadByLeadDisqualifyReason { get; set; }
		[CProperty(Association ="RoleInDisqualifyReason:DisqualifyReasonId")]
		public virtual ICollection<RoleInDisqualifyReason> RoleInDisqualifyReasonByDisqualifyReason { get; set; }
		[CProperty(Association ="SalesProcessEvent:LeadDisqualifyReasonId")]
		public virtual ICollection<SalesProcessEvent> SalesProcessEventByLeadDisqualifyReason { get; set; }
		[CProperty(Association ="VwLead:LeadDisqualifyReasonId")]
		public virtual ICollection<VwLead> VwLeadByLeadDisqualifyReason { get; set; }
		#endregion
	}
}