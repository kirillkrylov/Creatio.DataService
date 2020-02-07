using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Currency")]
	public class Currency : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrecySymbolPosition")]
		public int CurrecySymbolPosition { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="Division")]
		public int Division { get; set; }
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
		[CProperty(ColumnPath ="Rate")]
		public decimal Rate { get; set; }
		[CProperty(ColumnPath ="RecalcDirection")]
		public int RecalcDirection { get; set; }
		[CProperty(ColumnPath ="ShortName")]
		public string ShortName { get; set; }
		[CProperty(ColumnPath ="Symbol")]
		public string Symbol { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AccountForecast:CurrencyId")]
		public virtual ICollection<AccountForecast> AccountForecastByCurrency { get; set; }
		[CProperty(Association ="CampaignPlanner:CurrencyId")]
		public virtual ICollection<CampaignPlanner> CampaignPlannerByCurrency { get; set; }
		[CProperty(Association ="Cashflow:CurrencyId")]
		public virtual ICollection<Cashflow> CashflowByCurrency { get; set; }
		[CProperty(Association ="ContactForecast:CurrencyId")]
		public virtual ICollection<ContactForecast> ContactForecastByCurrency { get; set; }
		[CProperty(Association ="Contract:CurrencyId")]
		public virtual ICollection<Contract> ContractByCurrency { get; set; }
		[CProperty(Association ="CurrencyRate:CurrencyId")]
		public virtual ICollection<CurrencyRate> CurrencyRateByCurrency { get; set; }
		[CProperty(Association ="Invoice:CurrencyId")]
		public virtual ICollection<Invoice> InvoiceByCurrency { get; set; }
		[CProperty(Association ="LeadTypeForecast:CurrencyId")]
		public virtual ICollection<LeadTypeForecast> LeadTypeForecastByCurrency { get; set; }
		[CProperty(Association ="MktgActivity:CurrencyId")]
		public virtual ICollection<MktgActivity> MktgActivityByCurrency { get; set; }
		[CProperty(Association ="OppDepartmentForecast:CurrencyId")]
		public virtual ICollection<OppDepartmentForecast> OppDepartmentForecastByCurrency { get; set; }
		[CProperty(Association ="Order:CurrencyId")]
		public virtual ICollection<Order> OrderByCurrency { get; set; }
		[CProperty(Association ="OrderProduct:CurrencyId")]
		public virtual ICollection<OrderProduct> OrderProductByCurrency { get; set; }
		[CProperty(Association ="Product:CurrencyId")]
		public virtual ICollection<Product> ProductByCurrency { get; set; }
		[CProperty(Association ="ProductPrice:CurrencyId")]
		public virtual ICollection<ProductPrice> ProductPriceByCurrency { get; set; }
		#endregion
	}
}
