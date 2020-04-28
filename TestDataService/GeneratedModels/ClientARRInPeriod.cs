using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ClientARRInPeriod")]
	public class ClientARRInPeriod : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="PeriodId")]
		public Guid PeriodId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductKindId")]
		public Guid ProductKindId { get; set; }
		[CProperty(ColumnPath ="SaaSMetricsAmount")]
		public decimal SaaSMetricsAmount { get; set; }
		[CProperty(ColumnPath ="SubscriptionProductAmount")]
		public decimal SubscriptionProductAmount { get; set; }
		[CProperty(ColumnPath ="TotalAmount")]
		public decimal TotalAmount { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Period:PeriodId")]
		public Period Period { get; set; }
		[CProperty(Navigation ="ProductKind:ProductKindId")]
		public ProductKind ProductKind { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
