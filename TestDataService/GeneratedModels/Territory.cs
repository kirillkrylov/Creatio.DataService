using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Territory")]
	public class Territory : BaseEntity
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="CostCenter:TerritoryId")]
		public virtual ICollection<CostCenter> CostCenterByTerritory { get; set; }
		[CProperty(Association ="CountryCodes:TerritoryId")]
		public virtual ICollection<CountryCodes> CountryCodesByTerritory { get; set; }
		[CProperty(Association ="Event:TerritoryId")]
		public virtual ICollection<Event> EventByTerritory { get; set; }
		[CProperty(Association ="ExesInRequest:PayerTerritoryId")]
		public virtual ICollection<ExesInRequest> ExesInRequestByPayerTerritory { get; set; }
		[CProperty(Association ="InternalRequest:TerrId")]
		public virtual ICollection<InternalRequest> InternalRequestByTerr { get; set; }
		[CProperty(Association ="RequestBudgetHolderByExesType:BudgetTerritoryId")]
		public virtual ICollection<RequestBudgetHolderByExesType> RequestBudgetHolderByExesTypeByBudgetTerritory { get; set; }
		[CProperty(Association ="TripsDailyAllowance:TerritoryId")]
		public virtual ICollection<TripsDailyAllowance> TripsDailyAllowanceByTerritory { get; set; }
		#endregion
	}
}
