using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PeriodType")]
	public class PeriodType : BaseEntity
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Forecast:PeriodTypeId")]
		public virtual ICollection<Forecast> ForecastByPeriodType { get; set; }
		[CProperty(Association ="ForecastSheet:PeriodTypeId")]
		public virtual ICollection<ForecastSheet> ForecastSheetByPeriodType { get; set; }
		[CProperty(Association ="PaymentRule:PeriodTypeId")]
		public virtual ICollection<PaymentRule> PaymentRuleByPeriodType { get; set; }
		[CProperty(Association ="Period:PeriodTypeId")]
		public virtual ICollection<Period> PeriodByPeriodType { get; set; }
		#endregion
	}
}
