using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CommunicationType")]
	public class CommunicationType : BaseEntity
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
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
				OnPropertyChanged();
			}
		}
		private string _HyperlinkTemplate;
		[CProperty(ColumnPath ="HyperlinkTemplate")]
		public string HyperlinkTemplate
		{
			get{return _HyperlinkTemplate;}
			set
			{
				_HyperlinkTemplate = value;
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
		private byte[] _Image;
		[CProperty(ColumnPath ="Image")]
		public byte[] Image
		{
			get{return _Image;}
			set
			{
				_Image = value;
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
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
				OnPropertyChanged();
			}
		}
		private string _NameEN;
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN
		{
			get{return _NameEN;}
			set
			{
				_NameEN = value;
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
		private Guid _SyncToAccountFieldId;
		[CProperty(ColumnPath ="SyncToAccountFieldId")]
		public Guid SyncToAccountFieldId
		{
			get{return _SyncToAccountFieldId;}
			set
			{
				_SyncToAccountFieldId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SyncToContactFieldId;
		[CProperty(ColumnPath ="SyncToContactFieldId")]
		public Guid SyncToContactFieldId
		{
			get{return _SyncToContactFieldId;}
			set
			{
				_SyncToContactFieldId = value;
				OnPropertyChanged();
			}
		}
		private bool _UseforAccounts;
		[CProperty(ColumnPath ="UseforAccounts")]
		public bool UseforAccounts
		{
			get{return _UseforAccounts;}
			set
			{
				_UseforAccounts = value;
				OnPropertyChanged();
			}
		}
		private bool _UseforContacts;
		[CProperty(ColumnPath ="UseforContacts")]
		public bool UseforContacts
		{
			get{return _UseforContacts;}
			set
			{
				_UseforContacts = value;
				OnPropertyChanged();
			}
		}
		private bool _UseforLeads;
		[CProperty(ColumnPath ="UseforLeads")]
		public bool UseforLeads
		{
			get{return _UseforLeads;}
			set
			{
				_UseforLeads = value;
				OnPropertyChanged();
			}
		}
		private bool _UseOnPortalForLead;
		[CProperty(ColumnPath ="UseOnPortalForLead")]
		public bool UseOnPortalForLead
		{
			get{return _UseOnPortalForLead;}
			set
			{
				_UseOnPortalForLead = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="CommunicationType:SyncToContactFieldId")]
		public CommunicationType SyncToContactField { get; set; }
		[CProperty(Navigation ="CommunicationType:SyncToAccountFieldId")]
		public CommunicationType SyncToAccountField { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AccountCommunication:CommunicationTypeId")]
		public virtual ICollection<AccountCommunication> AccountCommunicationByCommunicationType { get; set; }
		[CProperty(Association ="CommunicationType:SyncToContactFieldId")]
		public virtual ICollection<CommunicationType> CommunicationTypeBySyncToContactField { get; set; }
		[CProperty(Association ="CommunicationType:SyncToAccountFieldId")]
		public virtual ICollection<CommunicationType> CommunicationTypeBySyncToAccountField { get; set; }
		[CProperty(Association ="ComTypebyCommunication:CommunicationTypeId")]
		public virtual ICollection<ComTypebyCommunication> ComTypebyCommunicationByCommunicationType { get; set; }
		[CProperty(Association ="ContactCommunication:CommunicationTypeId")]
		public virtual ICollection<ContactCommunication> ContactCommunicationByCommunicationType { get; set; }
		[CProperty(Association ="ContactCorrespondence:SourceId")]
		public virtual ICollection<ContactCorrespondence> ContactCorrespondenceBySource { get; set; }
		[CProperty(Association ="CTISearchResult:CommunicationTypeId")]
		public virtual ICollection<CTISearchResult> CTISearchResultByCommunicationType { get; set; }
		[CProperty(Association ="EmailTemplateMacros:AccountCommunicationTypeId")]
		public virtual ICollection<EmailTemplateMacros> EmailTemplateMacrosByAccountCommunicationType { get; set; }
		[CProperty(Association ="EnrchTypeMapping:CommunicationTypeId")]
		public virtual ICollection<EnrchTypeMapping> EnrchTypeMappingByCommunicationType { get; set; }
		[CProperty(Association ="LeadCommunication:CommunicationTypeId")]
		public virtual ICollection<LeadCommunication> LeadCommunicationByCommunicationType { get; set; }
		[CProperty(Association ="SocialAccount:TypeId")]
		public virtual ICollection<SocialAccount> SocialAccountByType { get; set; }
		#endregion
	}
}
