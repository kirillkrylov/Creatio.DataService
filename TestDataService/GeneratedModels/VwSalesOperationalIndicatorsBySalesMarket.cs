using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSalesOperationalIndicatorsBySalesMarket")]
	public class VwSalesOperationalIndicatorsBySalesMarket : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Deals")]
		public int Deals { get; set; }
		[CProperty(ColumnPath ="Fact")]
		public decimal Fact { get; set; }
		[CProperty(ColumnPath ="FactToPlan")]
		public decimal FactToPlan { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="LastMonthFact")]
		public decimal LastMonthFact { get; set; }
		[CProperty(ColumnPath ="LastMonthFactToPlan")]
		public decimal LastMonthFactToPlan { get; set; }
		[CProperty(ColumnPath ="LastMonthPlan")]
		public decimal LastMonthPlan { get; set; }
		[CProperty(ColumnPath ="Opps")]
		public int Opps { get; set; }
		[CProperty(ColumnPath ="OppsToDeals")]
		public decimal OppsToDeals { get; set; }
		[CProperty(ColumnPath ="Plan")]
		public decimal Plan { get; set; }
		[CProperty(ColumnPath ="Sql")]
		public int Sql { get; set; }
		[CProperty(ColumnPath ="SqlToDeals")]
		public decimal SqlToDeals { get; set; }
		[CProperty(ColumnPath ="SqlToOpps")]
		public decimal SqlToOpps { get; set; }
		[CProperty(ColumnPath ="TerritoryId")]
		public Guid TerritoryId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="OpportunityTerritory:TerritoryId")]
		public OpportunityTerritory Territory { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
