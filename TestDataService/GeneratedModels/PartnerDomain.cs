using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PartnerDomain")]
	public class PartnerDomain : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Approve")]
		public bool Approve { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IndustryId")]
		public Guid IndustryId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="PartnerAccountId")]
		public Guid PartnerAccountId { get; set; }
		[CProperty(ColumnPath ="PartnershipId")]
		public Guid PartnershipId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SuccessImplementation")]
		public bool SuccessImplementation { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:PartnerAccountId")]
		public Account PartnerAccount { get; set; }
		[CProperty(Navigation ="AccountIndustry:IndustryId")]
		public AccountIndustry Industry { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Partnership:PartnershipId")]
		public Partnership Partnership { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
