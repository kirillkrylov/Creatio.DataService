using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OpportunityForecastStatus")]
	public class OpportunityForecastStatus : BaseEntity
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="OppForecastWizDeliveryPlan:OpportunityForecastStatusId")]
		public virtual ICollection<OppForecastWizDeliveryPlan> OppForecastWizDeliveryPlanByOpportunityForecastStatus { get; set; }
		[CProperty(Association ="OppForecastWizPayments:OpportunityForecastStatusId")]
		public virtual ICollection<OppForecastWizPayments> OppForecastWizPaymentsByOpportunityForecastStatus { get; set; }
		[CProperty(Association ="OpportunityForecast:StatusId")]
		public virtual ICollection<OpportunityForecast> OpportunityForecastByStatus { get; set; }
		[CProperty(Association ="OpportunityForecastHistory:StatusId")]
		public virtual ICollection<OpportunityForecastHistory> OpportunityForecastHistoryByStatus { get; set; }
		[CProperty(Association ="TransactionForecast:OpportunityForecastStatusId")]
		public virtual ICollection<TransactionForecast> TransactionForecastByOpportunityForecastStatus { get; set; }
		#endregion
	}
}
