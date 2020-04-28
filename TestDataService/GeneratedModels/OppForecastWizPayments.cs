using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OppForecastWizPayments")]
	public class OppForecastWizPayments : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="ForecastProductTypeId")]
		public Guid ForecastProductTypeId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OpportunityForecastStatusId")]
		public Guid OpportunityForecastStatusId { get; set; }
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId { get; set; }
		[CProperty(ColumnPath ="PaymentAmount")]
		public decimal PaymentAmount { get; set; }
		[CProperty(ColumnPath ="PaymentDate")]
		public DateTime PaymentDate { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="TCVPercent")]
		public decimal TCVPercent { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ForecastProductType:ForecastProductTypeId")]
		public ForecastProductType ForecastProductType { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="OpportunityForecastStatus:OpportunityForecastStatusId")]
		public OpportunityForecastStatus OpportunityForecastStatus { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
