using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PublicationStatus")]
	public class PublicationStatus : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
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
		[CProperty(Association ="MarketplaceApplication:PublicationStatusId")]
		public virtual ICollection<MarketplaceApplication> MarketplaceApplicationByPublicationStatus { get; set; }
		[CProperty(Association ="MarketplaceApplication:PublicationStatusRuId")]
		public virtual ICollection<MarketplaceApplication> MarketplaceApplicationByPublicationStatusRu { get; set; }
		[CProperty(Association ="MarketplaceApplication:PublicationStatusComId")]
		public virtual ICollection<MarketplaceApplication> MarketplaceApplicationByPublicationStatusCom { get; set; }
		[CProperty(Association ="MarketplaceApplication:PublicationStatusUaId")]
		public virtual ICollection<MarketplaceApplication> MarketplaceApplicationByPublicationStatusUa { get; set; }
		#endregion
	}
}
