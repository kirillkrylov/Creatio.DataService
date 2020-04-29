using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ContactSyncSettings")]
	public class ContactSyncSettings : BaseEntity
	{
		#region Values
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
				OnPropertyChanged();
			}
		}
		private bool _ExportContacts;
		[CProperty(ColumnPath ="ExportContacts")]
		public bool ExportContacts
		{
			get{return _ExportContacts;}
			set
			{
				_ExportContacts = value;
				OnPropertyChanged();
			}
		}
		private bool _ExportContactsAll;
		[CProperty(ColumnPath ="ExportContactsAll")]
		public bool ExportContactsAll
		{
			get{return _ExportContactsAll;}
			set
			{
				_ExportContactsAll = value;
				OnPropertyChanged();
			}
		}
		private bool _ExportContactsCustomers;
		[CProperty(ColumnPath ="ExportContactsCustomers")]
		public bool ExportContactsCustomers
		{
			get{return _ExportContactsCustomers;}
			set
			{
				_ExportContactsCustomers = value;
				OnPropertyChanged();
			}
		}
		private bool _ExportContactsEmployers;
		[CProperty(ColumnPath ="ExportContactsEmployers")]
		public bool ExportContactsEmployers
		{
			get{return _ExportContactsEmployers;}
			set
			{
				_ExportContactsEmployers = value;
				OnPropertyChanged();
			}
		}
		private bool _ExportContactsFromGroups;
		[CProperty(ColumnPath ="ExportContactsFromGroups")]
		public bool ExportContactsFromGroups
		{
			get{return _ExportContactsFromGroups;}
			set
			{
				_ExportContactsFromGroups = value;
				OnPropertyChanged();
			}
		}
		private string _ExportContactsGroups;
		[CProperty(ColumnPath ="ExportContactsGroups")]
		public string ExportContactsGroups
		{
			get{return _ExportContactsGroups;}
			set
			{
				_ExportContactsGroups = value;
				OnPropertyChanged();
			}
		}
		private bool _ExportContactsOwner;
		[CProperty(ColumnPath ="ExportContactsOwner")]
		public bool ExportContactsOwner
		{
			get{return _ExportContactsOwner;}
			set
			{
				_ExportContactsOwner = value;
				OnPropertyChanged();
			}
		}
		private bool _ExportContactsSelected;
		[CProperty(ColumnPath ="ExportContactsSelected")]
		public bool ExportContactsSelected
		{
			get{return _ExportContactsSelected;}
			set
			{
				_ExportContactsSelected = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private bool _ImportContacts;
		[CProperty(ColumnPath ="ImportContacts")]
		public bool ImportContacts
		{
			get{return _ImportContacts;}
			set
			{
				_ImportContacts = value;
				OnPropertyChanged();
			}
		}
		private bool _ImportContactsAll;
		[CProperty(ColumnPath ="ImportContactsAll")]
		public bool ImportContactsAll
		{
			get{return _ImportContactsAll;}
			set
			{
				_ImportContactsAll = value;
				OnPropertyChanged();
			}
		}
		private string _ImportContactsCategories;
		[CProperty(ColumnPath ="ImportContactsCategories")]
		public string ImportContactsCategories
		{
			get{return _ImportContactsCategories;}
			set
			{
				_ImportContactsCategories = value;
				OnPropertyChanged();
			}
		}
		private string _ImportContactsFolders;
		[CProperty(ColumnPath ="ImportContactsFolders")]
		public string ImportContactsFolders
		{
			get{return _ImportContactsFolders;}
			set
			{
				_ImportContactsFolders = value;
				OnPropertyChanged();
			}
		}
		private bool _ImportContactsFromCategories;
		[CProperty(ColumnPath ="ImportContactsFromCategories")]
		public bool ImportContactsFromCategories
		{
			get{return _ImportContactsFromCategories;}
			set
			{
				_ImportContactsFromCategories = value;
				OnPropertyChanged();
			}
		}
		private bool _ImportContactsFromFolders;
		[CProperty(ColumnPath ="ImportContactsFromFolders")]
		public bool ImportContactsFromFolders
		{
			get{return _ImportContactsFromFolders;}
			set
			{
				_ImportContactsFromFolders = value;
				OnPropertyChanged();
			}
		}
		private DateTime _LastSyncDate;
		[CProperty(ColumnPath ="LastSyncDate")]
		public DateTime LastSyncDate
		{
			get{return _LastSyncDate;}
			set
			{
				_LastSyncDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _LinkContactToAccountId;
		[CProperty(ColumnPath ="LinkContactToAccountId")]
		public Guid LinkContactToAccountId
		{
			get{return _LinkContactToAccountId;}
			set
			{
				_LinkContactToAccountId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _LoadContactsFromDate;
		[CProperty(ColumnPath ="LoadContactsFromDate")]
		public DateTime LoadContactsFromDate
		{
			get{return _LoadContactsFromDate;}
			set
			{
				_LoadContactsFromDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _MailboxSyncSettingsId;
		[CProperty(ColumnPath ="MailboxSyncSettingsId")]
		public Guid MailboxSyncSettingsId
		{
			get{return _MailboxSyncSettingsId;}
			set
			{
				_MailboxSyncSettingsId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
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
