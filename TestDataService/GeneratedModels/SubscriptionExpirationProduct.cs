using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SubscriptionExpirationProduct")]
	public class SubscriptionExpirationProduct : BaseEntity
	{
		#region Values
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
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductInSubscriptionId")]
		public Guid ProductInSubscriptionId { get; set; }
		[CProperty(ColumnPath ="SubscriptionExpirationEmailHistoryId")]
		public Guid SubscriptionExpirationEmailHistoryId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ProductInSubscription:ProductInSubscriptionId")]
		public ProductInSubscription ProductInSubscription { get; set; }
		[CProperty(Navigation ="SubscriptionExpirationEmailHistory:SubscriptionExpirationEmailHistoryId")]
		public SubscriptionExpirationEmailHistory SubscriptionExpirationEmailHistory { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
