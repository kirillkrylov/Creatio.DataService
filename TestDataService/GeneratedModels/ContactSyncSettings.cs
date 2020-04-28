using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ContactSyncSettings")]
	public class ContactSyncSettings : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="ExportContacts")]
		public bool ExportContacts { get; set; }
		[CProperty(ColumnPath ="ExportContactsAll")]
		public bool ExportContactsAll { get; set; }
		[CProperty(ColumnPath ="ExportContactsCustomers")]
		public bool ExportContactsCustomers { get; set; }
		[CProperty(ColumnPath ="ExportContactsEmployers")]
		public bool ExportContactsEmployers { get; set; }
		[CProperty(ColumnPath ="ExportContactsFromGroups")]
		public bool ExportContactsFromGroups { get; set; }
		[CProperty(ColumnPath ="ExportContactsGroups")]
		public string ExportContactsGroups { get; set; }
		[CProperty(ColumnPath ="ExportContactsOwner")]
		public bool ExportContactsOwner { get; set; }
		[CProperty(ColumnPath ="ExportContactsSelected")]
		public bool ExportContactsSelected { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ImportContacts")]
		public bool ImportContacts { get; set; }
		[CProperty(ColumnPath ="ImportContactsAll")]
		public bool ImportContactsAll { get; set; }
		[CProperty(ColumnPath ="ImportContactsCategories")]
		public string ImportContactsCategories { get; set; }
		[CProperty(ColumnPath ="ImportContactsFolders")]
		public string ImportContactsFolders { get; set; }
		[CProperty(ColumnPath ="ImportContactsFromCategories")]
		public bool ImportContactsFromCategories { get; set; }
		[CProperty(ColumnPath ="ImportContactsFromFolders")]
		public bool ImportContactsFromFolders { get; set; }
		[CProperty(ColumnPath ="LastSyncDate")]
		public DateTime LastSyncDate { get; set; }
		[CProperty(ColumnPath ="LinkContactToAccountId")]
		public Guid LinkContactToAccountId { get; set; }
		[CProperty(ColumnPath ="LoadContactsFromDate")]
		public DateTime LoadContactsFromDate { get; set; }
		[CProperty(ColumnPath ="MailboxSyncSettingsId")]
		public Guid MailboxSyncSettingsId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="LinkContactToAccount:LinkContactToAccountId")]
		public LinkContactToAccount LinkContactToAccount { get; set; }
		[CProperty(Navigation ="MailboxSyncSettings:MailboxSyncSettingsId")]
		public MailboxSyncSettings MailboxSyncSettings { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
