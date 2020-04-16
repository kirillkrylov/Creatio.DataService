using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ForecastProductType")]
	public class ForecastProductType : BaseEntity
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
		[CProperty(ColumnPath ="RevenueRecognizeMethodId")]
		public Guid RevenueRecognizeMethodId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="RevenueRecogMethod:RevenueRecognizeMethodId")]
		public RevenueRecogMethod RevenueRecognizeMethod { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="OppForecastWizDeliveryPlan:ForecastProductTypeId")]
		public virtual ICollection<OppForecastWizDeliveryPlan> OppForecastWizDeliveryPlanByForecastProductType { get; set; }
		[CProperty(Association ="OppForecastWizPayments:ForecastProductTypeId")]
		public virtual ICollection<OppForecastWizPayments> OppForecastWizPaymentsByForecastProductType { get; set; }
		[CProperty(Association ="OpportunityForecast:ForecastProductTypeId")]
		public virtual ICollection<OpportunityForecast> OpportunityForecastByForecastProductType { get; set; }
		[CProperty(Association ="OpportunityForecastHistory:ForecastProductTypeId")]
		public virtual ICollection<OpportunityForecastHistory> OpportunityForecastHistoryByForecastProductType { get; set; }
		#endregion
	}
}
