using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OrderProductPeriod")]
	public class OrderProductPeriod : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Days")]
		public int Days { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsNew")]
		public bool IsNew { get; set; }
		[CProperty(ColumnPath ="IsUseInForecast")]
		public bool IsUseInForecast { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SerialYearNumber")]
		public int SerialYearNumber { get; set; }
		[CProperty(ColumnPath ="Years")]
		public int Years { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="InvoiceProduct:PeriodId")]
		public virtual ICollection<InvoiceProduct> InvoiceProductByPeriod { get; set; }
		[CProperty(Association ="OppForecastWizDeliveryPlan:PeriodId")]
		public virtual ICollection<OppForecastWizDeliveryPlan> OppForecastWizDeliveryPlanByPeriod { get; set; }
		[CProperty(Association ="OppForecastWizSupport:PeriodId")]
		public virtual ICollection<OppForecastWizSupport> OppForecastWizSupportByPeriod { get; set; }
		[CProperty(Association ="OpportunityForecast:PeriodId")]
		public virtual ICollection<OpportunityForecast> OpportunityForecastByPeriod { get; set; }
		[CProperty(Association ="OpportunityForecastHistory:PeriodId")]
		public virtual ICollection<OpportunityForecastHistory> OpportunityForecastHistoryByPeriod { get; set; }
		[CProperty(Association ="OrderProduct:PeriodId")]
		public virtual ICollection<OrderProduct> OrderProductByPeriod { get; set; }
		[CProperty(Association ="VwInvoiceProduct:PeriodId")]
		public virtual ICollection<VwInvoiceProduct> VwInvoiceProductByPeriod { get; set; }
		#endregion
	}
}
