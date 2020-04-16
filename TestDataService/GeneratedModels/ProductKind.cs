using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ProductKind")]
	public class ProductKind : BaseEntity
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
		[CProperty(ColumnPath ="IntegratedOn")]
		public DateTime IntegratedOn { get; set; }
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Uid1C")]
		public Guid Uid1C { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ClientARRInPeriod:ProductKindId")]
		public virtual ICollection<ClientARRInPeriod> ClientARRInPeriodByProductKind { get; set; }
		[CProperty(Association ="ClientSaaSMetrics:ProductFamilyId")]
		public virtual ICollection<ClientSaaSMetrics> ClientSaaSMetricsByProductFamily { get; set; }
		[CProperty(Association ="OppForecastWizDeliveryPlan:ProductKindId")]
		public virtual ICollection<OppForecastWizDeliveryPlan> OppForecastWizDeliveryPlanByProductKind { get; set; }
		[CProperty(Association ="OpportunityForecast:ProductKindId")]
		public virtual ICollection<OpportunityForecast> OpportunityForecastByProductKind { get; set; }
		[CProperty(Association ="OpportunityForecastHistory:ProductKindId")]
		public virtual ICollection<OpportunityForecastHistory> OpportunityForecastHistoryByProductKind { get; set; }
		[CProperty(Association ="Product:KindId")]
		public virtual ICollection<Product> ProductByKind { get; set; }
		[CProperty(Association ="SaaSMetrics:ProductFamilyId")]
		public virtual ICollection<SaaSMetrics> SaaSMetricsByProductFamily { get; set; }
		[CProperty(Association ="SaaSMetricsTransactions:ProductFamilyId")]
		public virtual ICollection<SaaSMetricsTransactions> SaaSMetricsTransactionsByProductFamily { get; set; }
		[CProperty(Association ="VwNewClientsBySubscription:KindId")]
		public virtual ICollection<VwNewClientsBySubscription> VwNewClientsBySubscriptionByKind { get; set; }
		[CProperty(Association ="VwTSLicProduct:KindId")]
		public virtual ICollection<VwTSLicProduct> VwTSLicProductByKind { get; set; }
		[CProperty(Association ="VwTSLicProductArchive:KindId")]
		public virtual ICollection<VwTSLicProductArchive> VwTSLicProductArchiveByKind { get; set; }
		#endregion
	}
}
