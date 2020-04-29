using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSalesOperationalIndicatorsBySalesDirector")]
	public class VwSalesOperationalIndicatorsBySalesDirector : BaseEntity
	{
		#region Values
		private Guid _ContactId;
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId
		{
			get{return _ContactId;}
			set
			{
				_ContactId = value;
				OnPropertyChanged();
			}
		}
		private int _Deals;
		[CProperty(ColumnPath ="Deals")]
		public int Deals
		{
			get{return _Deals;}
			set
			{
				_Deals = value;
				OnPropertyChanged();
			}
		}
		private decimal _Fact;
		[CProperty(ColumnPath ="Fact")]
		public decimal Fact
		{
			get{return _Fact;}
			set
			{
				_Fact = value;
				OnPropertyChanged();
			}
		}
		private decimal _FactToPlan;
		[CProperty(ColumnPath ="FactToPlan")]
		public decimal FactToPlan
		{
			get{return _FactToPlan;}
			set
			{
				_FactToPlan = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private decimal _LastMonthFact;
		[CProperty(ColumnPath ="LastMonthFact")]
		public decimal LastMonthFact
		{
			get{return _LastMonthFact;}
			set
			{
				_LastMonthFact = value;
				OnPropertyChanged();
			}
		}
		private decimal _LastMonthFactToPlan;
		[CProperty(ColumnPath ="LastMonthFactToPlan")]
		public decimal LastMonthFactToPlan
		{
			get{return _LastMonthFactToPlan;}
			set
			{
				_LastMonthFactToPlan = value;
				OnPropertyChanged();
			}
		}
		private decimal _LastMonthPlan;
		[CProperty(ColumnPath ="LastMonthPlan")]
		public decimal LastMonthPlan
		{
			get{return _LastMonthPlan;}
			set
			{
				_LastMonthPlan = value;
				OnPropertyChanged();
			}
		}
		private int _Opps;
		[CProperty(ColumnPath ="Opps")]
		public int Opps
		{
			get{return _Opps;}
			set
			{
				_Opps = value;
				OnPropertyChanged();
			}
		}
		private decimal _OppsToDeals;
		[CProperty(ColumnPath ="OppsToDeals")]
		public decimal OppsToDeals
		{
			get{return _OppsToDeals;}
			set
			{
				_OppsToDeals = value;
				OnPropertyChanged();
			}
		}
		private decimal _Plan;
		[CProperty(ColumnPath ="Plan")]
		public decimal Plan
		{
			get{return _Plan;}
			set
			{
				_Plan = value;
				OnPropertyChanged();
			}
		}
		private int _Sql;
		[CProperty(ColumnPath ="Sql")]
		public int Sql
		{
			get{return _Sql;}
			set
			{
				_Sql = value;
				OnPropertyChanged();
			}
		}
		private decimal _SqlToDeals;
		[CProperty(ColumnPath ="SqlToDeals")]
		public decimal SqlToDeals
		{
			get{return _SqlToDeals;}
			set
			{
				_SqlToDeals = value;
				OnPropertyChanged();
			}
		}
		private decimal _SqlToOpps;
		[CProperty(ColumnPath ="SqlToOpps")]
		public decimal SqlToOpps
		{
			get{return _SqlToOpps;}
			set
			{
				_SqlToOpps = value;
				OnPropertyChanged();
			}
		}
		private Guid _TerritoryId;
		[CProperty(ColumnPath ="TerritoryId")]
		public Guid TerritoryId
		{
			get{return _TerritoryId;}
			set
			{
				_TerritoryId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="OpportunityTerritory:TerritoryId")]
		public OpportunityTerritory Territory { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
