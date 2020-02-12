using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwActiveProduct")]
	public class VwActiveProduct : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActivationDate")]
		public DateTime ActivationDate { get; set; }
		[CProperty(ColumnPath ="Count")]
		public int Count { get; set; }
		[CProperty(ColumnPath ="DeactivationDate")]
		public DateTime DeactivationDate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="SubscriptionId")]
		public Guid SubscriptionId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="SocialSubscription:SubscriptionId")]
		public SocialSubscription Subscription { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
