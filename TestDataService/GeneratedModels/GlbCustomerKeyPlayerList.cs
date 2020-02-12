using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "GlbCustomerKeyPlayerList")]
	public class GlbCustomerKeyPlayerList : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="GlbAccountInCustomerId")]
		public Guid GlbAccountInCustomerId { get; set; }
		[CProperty(ColumnPath ="GlbContactId")]
		public Guid GlbContactId { get; set; }
		[CProperty(ColumnPath ="GlbDescription")]
		public string GlbDescription { get; set; }
		[CProperty(ColumnPath ="GlbInfluenceId")]
		public Guid GlbInfluenceId { get; set; }
		[CProperty(ColumnPath ="GlbJobId")]
		public Guid GlbJobId { get; set; }
		[CProperty(ColumnPath ="GlbJobTitle")]
		public string GlbJobTitle { get; set; }
		[CProperty(ColumnPath ="GlbLoyaltyId")]
		public Guid GlbLoyaltyId { get; set; }
		[CProperty(ColumnPath ="GlbName")]
		public string GlbName { get; set; }
		[CProperty(ColumnPath ="GlbNotes")]
		public string GlbNotes { get; set; }
		[CProperty(ColumnPath ="GlbPain")]
		public string GlbPain { get; set; }
		[CProperty(ColumnPath ="GlbRoleId")]
		public Guid GlbRoleId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:GlbAccountInCustomerId")]
		public Account GlbAccountInCustomer { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:GlbContactId")]
		public Contact GlbContact { get; set; }
		[CProperty(Navigation ="Job:GlbJobId")]
		public Job GlbJob { get; set; }
		[CProperty(Navigation ="OppContactInfluence:GlbInfluenceId")]
		public OppContactInfluence GlbInfluence { get; set; }
		[CProperty(Navigation ="OppContactLoyality:GlbLoyaltyId")]
		public OppContactLoyality GlbLoyalty { get; set; }
		[CProperty(Navigation ="OppContactRole:GlbRoleId")]
		public OppContactRole GlbRole { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="GlbCustomerKeyPlayerListFile:GlbCustomerKeyPlayerListId")]
		public virtual ICollection<GlbCustomerKeyPlayerListFile> GlbCustomerKeyPlayerListFileByGlbCustomerKeyPlayerList { get; set; }
		[CProperty(Association ="GlbCustomerKeyPlayerListInFolder:GlbCustomerKeyPlayerListId")]
		public virtual ICollection<GlbCustomerKeyPlayerListInFolder> GlbCustomerKeyPlayerListInFolderByGlbCustomerKeyPlayerList { get; set; }
		[CProperty(Association ="GlbCustomerKeyPlayerListInTag:EntityId")]
		public virtual ICollection<GlbCustomerKeyPlayerListInTag> GlbCustomerKeyPlayerListInTagByEntity { get; set; }
		#endregion
	}
}
