using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwTSLicProductArchive")]
	public class VwTSLicProductArchive : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActivationDate")]
		public DateTime ActivationDate { get; set; }
		[CProperty(ColumnPath ="Count")]
		public int Count { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DeactivationDate")]
		public DateTime DeactivationDate { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsCompetitive")]
		public bool IsCompetitive { get; set; }
		[CProperty(ColumnPath ="IsTrial")]
		public bool IsTrial { get; set; }
		[CProperty(ColumnPath ="KindId")]
		public Guid KindId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Product")]
		public string Product { get; set; }
		[CProperty(ColumnPath ="SubscriptionId")]
		public Guid SubscriptionId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ProductKind:KindId")]
		public ProductKind Kind { get; set; }
		[CProperty(Navigation ="Subscription:SubscriptionId")]
		public Subscription Subscription { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
