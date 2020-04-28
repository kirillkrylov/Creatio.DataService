using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupportLevel")]
	public class SupportLevel : BaseEntity
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
		[CProperty(Association ="ManualSupportLevel:SupportLevelId")]
		public virtual ICollection<ManualSupportLevel> ManualSupportLevelBySupportLevel { get; set; }
		[CProperty(Association ="OppForecastWizSupport:SupportLevelId")]
		public virtual ICollection<OppForecastWizSupport> OppForecastWizSupportBySupportLevel { get; set; }
		[CProperty(Association ="OpportunityForecast:SupportLevelId")]
		public virtual ICollection<OpportunityForecast> OpportunityForecastBySupportLevel { get; set; }
		[CProperty(Association ="OpportunityForecastHistory:SupportLevelId")]
		public virtual ICollection<OpportunityForecastHistory> OpportunityForecastHistoryBySupportLevel { get; set; }
		[CProperty(Association ="PriorityInSupportLevel:SupportLevelId")]
		public virtual ICollection<PriorityInSupportLevel> PriorityInSupportLevelBySupportLevel { get; set; }
		[CProperty(Association ="Product:SupportLevelId")]
		public virtual ICollection<Product> ProductBySupportLevel { get; set; }
		[CProperty(Association ="ProductInServicePact:SupportLevelId")]
		public virtual ICollection<ProductInServicePact> ProductInServicePactBySupportLevel { get; set; }
		[CProperty(Association ="ServicePact:SupportLevelId")]
		public virtual ICollection<ServicePact> ServicePactBySupportLevel { get; set; }
		[CProperty(Association ="SupportRate:SupportLevelId")]
		public virtual ICollection<SupportRate> SupportRateBySupportLevel { get; set; }
		[CProperty(Association ="VwProductSLA:SupportLevelId")]
		public virtual ICollection<VwProductSLA> VwProductSLABySupportLevel { get; set; }
		#endregion
	}
}
