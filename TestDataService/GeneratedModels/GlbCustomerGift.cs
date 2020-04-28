using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "GlbCustomerGift")]
	public class GlbCustomerGift : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="GlbGiftAccountId")]
		public Guid GlbGiftAccountId { get; set; }
		[CProperty(ColumnPath ="GlbGiftContactId")]
		public Guid GlbGiftContactId { get; set; }
		[CProperty(ColumnPath ="GlbGiftName")]
		public string GlbGiftName { get; set; }
		[CProperty(ColumnPath ="GlbGiftNote")]
		public string GlbGiftNote { get; set; }
		[CProperty(ColumnPath ="GlbNotes")]
		public string GlbNotes { get; set; }
		[CProperty(ColumnPath ="GlbNoteworthyEventId")]
		public Guid GlbNoteworthyEventId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:GlbGiftAccountId")]
		public Account GlbGiftAccount { get; set; }
		[CProperty(Navigation ="AnniversaryType:GlbNoteworthyEventId")]
		public AnniversaryType GlbNoteworthyEvent { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:GlbGiftContactId")]
		public Contact GlbGiftContact { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="GlbCustomerGiftFile:GlbCustomerGiftId")]
		public virtual ICollection<GlbCustomerGiftFile> GlbCustomerGiftFileByGlbCustomerGift { get; set; }
		[CProperty(Association ="GlbCustomerGiftInFolder:GlbCustomerGiftId")]
		public virtual ICollection<GlbCustomerGiftInFolder> GlbCustomerGiftInFolderByGlbCustomerGift { get; set; }
		[CProperty(Association ="GlbCustomerGiftInTag:EntityId")]
		public virtual ICollection<GlbCustomerGiftInTag> GlbCustomerGiftInTagByEntity { get; set; }
		#endregion
	}
}
