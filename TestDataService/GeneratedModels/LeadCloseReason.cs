using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LeadCloseReason")]
	public class LeadCloseReason : BaseEntity
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
		[CProperty(ColumnPath ="UseForLeadProcess")]
		public bool UseForLeadProcess { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="DetailedReason:CloseReasonId")]
		public virtual ICollection<DetailedReason> DetailedReasonByCloseReason { get; set; }
		[CProperty(Association ="Lead:LeadCloseReasonId")]
		public virtual ICollection<Lead> LeadByLeadCloseReason { get; set; }
		[CProperty(Association ="SalesProcessEvent:LeadCloseReasonId")]
		public virtual ICollection<SalesProcessEvent> SalesProcessEventByLeadCloseReason { get; set; }
		[CProperty(Association ="VwLead:LeadCloseReasonId")]
		public virtual ICollection<VwLead> VwLeadByLeadCloseReason { get; set; }
		#endregion
	}
}
