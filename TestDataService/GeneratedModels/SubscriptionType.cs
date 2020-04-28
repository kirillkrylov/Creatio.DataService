using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SubscriptionType")]
	public class SubscriptionType : BaseEntity
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
		[CProperty(Association ="ProductForLicGenerator:SubscriptionTypeId")]
		public virtual ICollection<ProductForLicGenerator> ProductForLicGeneratorBySubscriptionType { get; set; }
		[CProperty(Association ="ProductInSubscription:SubscriptionTypeId")]
		public virtual ICollection<ProductInSubscription> ProductInSubscriptionBySubscriptionType { get; set; }
		[CProperty(Association ="VwTSSLA:SubscriptionTypeId")]
		public virtual ICollection<VwTSSLA> VwTSSLABySubscriptionType { get; set; }
		[CProperty(Association ="VwTSSLAArchive:SubscriptionTypeId")]
		public virtual ICollection<VwTSSLAArchive> VwTSSLAArchiveBySubscriptionType { get; set; }
		#endregion
	}
}
