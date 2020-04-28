using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AnniversaryType")]
	public class AnniversaryType : BaseEntity
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
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN { get; set; }
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
		[CProperty(Association ="AccountAnniversary:AnniversaryTypeId")]
		public virtual ICollection<AccountAnniversary> AccountAnniversaryByAnniversaryType { get; set; }
		[CProperty(Association ="ContactAnniversary:AnniversaryTypeId")]
		public virtual ICollection<ContactAnniversary> ContactAnniversaryByAnniversaryType { get; set; }
		[CProperty(Association ="GlbCustomerGift:GlbNoteworthyEventId")]
		public virtual ICollection<GlbCustomerGift> GlbCustomerGiftByGlbNoteworthyEvent { get; set; }
		[CProperty(Association ="VwAnniversary:AnniversaryTypeId")]
		public virtual ICollection<VwAnniversary> VwAnniversaryByAnniversaryType { get; set; }
		#endregion
	}
}
