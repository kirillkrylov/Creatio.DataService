using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SubscriptionExpirationEmailHistory")]
	public class SubscriptionExpirationEmailHistory : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DaysBeforeDeactivation")]
		public int DaysBeforeDeactivation { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SubscriptionId")]
		public Guid SubscriptionId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Subscription:SubscriptionId")]
		public Subscription Subscription { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SubscriptionExpirationEmailByLanguage:SubscriptionExpirationEmailHistoryId")]
		public virtual ICollection<SubscriptionExpirationEmailByLanguage> SubscriptionExpirationEmailByLanguageBySubscriptionExpirationEmailHistory { get; set; }
		[CProperty(Association ="SubscriptionExpirationProduct:SubscriptionExpirationEmailHistoryId")]
		public virtual ICollection<SubscriptionExpirationProduct> SubscriptionExpirationProductBySubscriptionExpirationEmailHistory { get; set; }
		#endregion
	}
}
