using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwProductBalance")]
	public class VwProductBalance : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Credit")]
		public decimal Credit { get; set; }
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId { get; set; }
		[CProperty(ColumnPath ="CurrencyRate")]
		public decimal CurrencyRate { get; set; }
		[CProperty(ColumnPath ="DeactivationDate")]
		public DateTime DeactivationDate { get; set; }
		[CProperty(ColumnPath ="Debet")]
		public decimal Debet { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="Interval")]
		public int Interval { get; set; }
		[CProperty(ColumnPath ="IsOnSite")]
		public int IsOnSite { get; set; }
		[CProperty(ColumnPath ="LastDate")]
		public DateTime LastDate { get; set; }
		[CProperty(ColumnPath ="ProductInSubscriptionId")]
		public Guid ProductInSubscriptionId { get; set; }
		[CProperty(ColumnPath ="SubscriptionId")]
		public Guid SubscriptionId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="ProductInSubscription:ProductInSubscriptionId")]
		public ProductInSubscription ProductInSubscription { get; set; }
		[CProperty(Navigation ="Subscription:SubscriptionId")]
		public Subscription Subscription { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
