using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Document")]
	public class Document : BaseEntity
	{
		#region Values
		private Guid _AccountId;
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId
		{
			get{return _AccountId;}
			set
			{
				_AccountId = value;
				OnPropertyChanged();
			}
		}
		private decimal _Amount;
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount
		{
			get{return _Amount;}
			set
			{
				_Amount = value;
				OnPropertyChanged();
			}
		}
		private decimal _AmountWithoutTax;
		[CProperty(ColumnPath ="AmountWithoutTax")]
		public decimal AmountWithoutTax
		{
			get{return _AmountWithoutTax;}
			set
			{
				_AmountWithoutTax = value;
				OnPropertyChanged();
			}
		}
		private string _Code1C;
		[CProperty(ColumnPath ="Code1C")]
		public string Code1C
		{
			get{return _Code1C;}
			set
			{
				_Code1C = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContactId;
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId
		{
			get{return _ContactId;}
			set
			{
				_ContactId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContractId;
		[CProperty(ColumnPath ="ContractId")]
		public Guid ContractId
		{
			get{return _ContractId;}
			set
			{
				_ContractId = value;
				OnPropertyChanged();
			}
		}
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
		private Guid _CurrencyId;
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId
		{
			get{return _CurrencyId;}
			set
			{
				_CurrencyId = value;
				OnPropertyChanged();
			}
		}
		private decimal _CurrencyRate;
		[CProperty(ColumnPath ="CurrencyRate")]
		public decimal CurrencyRate
		{
			get{return _CurrencyRate;}
			set
			{
				_CurrencyRate = value;
				OnPropertyChanged();
			}
		}
		private Guid _CustomerBillingInfoId;
		[CProperty(ColumnPath ="CustomerBillingInfoId")]
		public Guid CustomerBillingInfoId
		{
			get{return _CustomerBillingInfoId;}
			set
			{
				_CustomerBillingInfoId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _Date;
		[CProperty(ColumnPath ="Date")]
		public DateTime Date
		{
			get{return _Date;}
			set
			{
				_Date = value;
				OnPropertyChanged();
			}
		}
		private string _DeliveryAddress;
		[CProperty(ColumnPath ="DeliveryAddress")]
		public string DeliveryAddress
		{
			get{return _DeliveryAddress;}
			set
			{
				_DeliveryAddress = value;
				OnPropertyChanged();
			}
		}
		private DateTime _DeliveryDate;
		[CProperty(ColumnPath ="DeliveryDate")]
		public DateTime DeliveryDate
		{
			get{return _DeliveryDate;}
			set
			{
				_DeliveryDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _DeliveryServiceId;
		[CProperty(ColumnPath ="DeliveryServiceId")]
		public Guid DeliveryServiceId
		{
			get{return _DeliveryServiceId;}
			set
			{
				_DeliveryServiceId = value;
				OnPropertyChanged();
			}
		}
		private Guid _DeliveryTypeId;
		[CProperty(ColumnPath ="DeliveryTypeId")]
		public Guid DeliveryTypeId
		{
			get{return _DeliveryTypeId;}
			set
			{
				_DeliveryTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _EmployeeId;
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId
		{
			get{return _EmployeeId;}
			set
			{
				_EmployeeId = value;
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
		private Guid _InitiatorId;
		[CProperty(ColumnPath ="InitiatorId")]
		public Guid InitiatorId
		{
			get{return _InitiatorId;}
			set
			{
				_InitiatorId = value;
				OnPropertyChanged();
			}
		}
		private string _IntegrationId;
		[CProperty(ColumnPath ="IntegrationId")]
		public string IntegrationId
		{
			get{return _IntegrationId;}
			set
			{
				_IntegrationId = value;
				OnPropertyChanged();
			}
		}
		private Guid _InternalRequestId;
		[CProperty(ColumnPath ="InternalRequestId")]
		public Guid InternalRequestId
		{
			get{return _InternalRequestId;}
			set
			{
				_InternalRequestId = value;
				OnPropertyChanged();
			}
		}
		private bool _IsRecordLocked;
		[CProperty(ColumnPath ="IsRecordLocked")]
		public bool IsRecordLocked
		{
			get{return _IsRecordLocked;}
			set
			{
				_IsRecordLocked = value;
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
		private string _Notes;
		[CProperty(ColumnPath ="Notes")]
		public string Notes
		{
			get{return _Notes;}
			set
			{
				_Notes = value;
				OnPropertyChanged();
			}
		}
		private string _Number;
		[CProperty(ColumnPath ="Number")]
		public string Number
		{
			get{return _Number;}
			set
			{
				_Number = value;
				OnPropertyChanged();
			}
		}
		private Guid _OfficeId;
		[CProperty(ColumnPath ="OfficeId")]
		public Guid OfficeId
		{
			get{return _OfficeId;}
			set
			{
				_OfficeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _OpportunityId;
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId
		{
			get{return _OpportunityId;}
			set
			{
				_OpportunityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _OrderId;
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId
		{
			get{return _OrderId;}
			set
			{
				_OrderId = value;
				OnPropertyChanged();
			}
		}
		private string _OtherAccount;
		[CProperty(ColumnPath ="OtherAccount")]
		public string OtherAccount
		{
			get{return _OtherAccount;}
			set
			{
				_OtherAccount = value;
				OnPropertyChanged();
			}
		}
		private Guid _OwnerId;
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId
		{
			get{return _OwnerId;}
			set
			{
				_OwnerId = value;
				OnPropertyChanged();
			}
		}
		private decimal _PaymentAmount;
		[CProperty(ColumnPath ="PaymentAmount")]
		public decimal PaymentAmount
		{
			get{return _PaymentAmount;}
			set
			{
				_PaymentAmount = value;
				OnPropertyChanged();
			}
		}
		private DateTime _PaymentDate;
		[CProperty(ColumnPath ="PaymentDate")]
		public DateTime PaymentDate
		{
			get{return _PaymentDate;}
			set
			{
				_PaymentDate = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryAmount;
		[CProperty(ColumnPath ="PrimaryAmount")]
		public decimal PrimaryAmount
		{
			get{return _PrimaryAmount;}
			set
			{
				_PrimaryAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryAmountWithoutTax;
		[CProperty(ColumnPath ="PrimaryAmountWithoutTax")]
		public decimal PrimaryAmountWithoutTax
		{
			get{return _PrimaryAmountWithoutTax;}
			set
			{
				_PrimaryAmountWithoutTax = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryPaymentAmount;
		[CProperty(ColumnPath ="PrimaryPaymentAmount")]
		public decimal PrimaryPaymentAmount
		{
			get{return _PrimaryPaymentAmount;}
			set
			{
				_PrimaryPaymentAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryTaxAmount;
		[CProperty(ColumnPath ="PrimaryTaxAmount")]
		public decimal PrimaryTaxAmount
		{
			get{return _PrimaryTaxAmount;}
			set
			{
				_PrimaryTaxAmount = value;
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
		private Guid _ProjectId;
		[CProperty(ColumnPath ="ProjectId")]
		public Guid ProjectId
		{
			get{return _ProjectId;}
			set
			{
				_ProjectId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ResponsibleAccountantId;
		[CProperty(ColumnPath ="ResponsibleAccountantId")]
		public Guid ResponsibleAccountantId
		{
			get{return _ResponsibleAccountantId;}
			set
			{
				_ResponsibleAccountantId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StateId;
		[CProperty(ColumnPath ="StateId")]
		public Guid StateId
		{
			get{return _StateId;}
			set
			{
				_StateId = value;
				OnPropertyChanged();
			}
		}
		private decimal _TaxAmount;
		[CProperty(ColumnPath ="TaxAmount")]
		public decimal TaxAmount
		{
			get{return _TaxAmount;}
			set
			{
				_TaxAmount = value;
				OnPropertyChanged();
			}
		}
		private string _TrackingNumber;
		[CProperty(ColumnPath ="TrackingNumber")]
		public string TrackingNumber
		{
			get{return _TrackingNumber;}
			set
			{
				_TrackingNumber = value;
				OnPropertyChanged();
			}
		}
		private Guid _TypeId;
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId
		{
			get{return _TypeId;}
			set
			{
				_TypeId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="AccountBillingInfo:CustomerBillingInfoId")]
		public AccountBillingInfo CustomerBillingInfo { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Contact:ResponsibleAccountantId")]
		public Contact ResponsibleAccountant { get; set; }
		[CProperty(Navigation ="Contact:InitiatorId")]
		public Contact Initiator { get; set; }
		[CProperty(Navigation ="Contact:EmployeeId")]
		public Contact Employee { get; set; }
		[CProperty(Navigation ="Contract:ContractId")]
		public Contract Contract { get; set; }
		[CProperty(Navigation ="CountryCodes:OfficeId")]
		public CountryCodes Office { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="DeliveryService:DeliveryServiceId")]
		public DeliveryService DeliveryService { get; set; }
		[CProperty(Navigation ="DeliveryType:DeliveryTypeId")]
		public DeliveryType DeliveryType { get; set; }
		[CProperty(Navigation ="DocumentState:StateId")]
		public DocumentState State { get; set; }
		[CProperty(Navigation ="DocumentType:TypeId")]
		public DocumentType Type { get; set; }
		[CProperty(Navigation ="InternalRequest:InternalRequestId")]
		public InternalRequest InternalRequest { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="Project:ProjectId")]
		public Project Project { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:DocumentId")]
		public virtual ICollection<Activity> ActivityByDocument { get; set; }
		[CProperty(Association ="CorrespondenceLink:CorrespondenceId")]
		public virtual ICollection<CorrespondenceLink> CorrespondenceLinkByCorrespondence { get; set; }
		[CProperty(Association ="CorrespondenceLink:ActId")]
		public virtual ICollection<CorrespondenceLink> CorrespondenceLinkByAct { get; set; }
		[CProperty(Association ="CorrespondenceLink:CorrespondenceSourceId")]
		public virtual ICollection<CorrespondenceLink> CorrespondenceLinkByCorrespondenceSource { get; set; }
		[CProperty(Association ="DocumentFile:DocumentId")]
		public virtual ICollection<DocumentFile> DocumentFileByDocument { get; set; }
		[CProperty(Association ="DocumentInFolder:DocumentId")]
		public virtual ICollection<DocumentInFolder> DocumentInFolderByDocument { get; set; }
		[CProperty(Association ="DocumentInTag:EntityId")]
		public virtual ICollection<DocumentInTag> DocumentInTagByEntity { get; set; }
		[CProperty(Association ="DocumentParticipant:DocumentId")]
		public virtual ICollection<DocumentParticipant> DocumentParticipantByDocument { get; set; }
		[CProperty(Association ="DocumentRelationship:DocumentAId")]
		public virtual ICollection<DocumentRelationship> DocumentRelationshipByDocumentA { get; set; }
		[CProperty(Association ="DocumentRelationship:DocumentBId")]
		public virtual ICollection<DocumentRelationship> DocumentRelationshipByDocumentB { get; set; }
		[CProperty(Association ="DocumentVisa:DocumentId")]
		public virtual ICollection<DocumentVisa> DocumentVisaByDocument { get; set; }
		[CProperty(Association ="EmailFolderColumnValuesSetting:DocumentId")]
		public virtual ICollection<EmailFolderColumnValuesSetting> EmailFolderColumnValuesSettingByDocument { get; set; }
		[CProperty(Association ="InvoiceAct:ActId")]
		public virtual ICollection<InvoiceAct> InvoiceActByAct { get; set; }
		[CProperty(Association ="SupplyPaymentElement:ActId")]
		public virtual ICollection<SupplyPaymentElement> SupplyPaymentElementByAct { get; set; }
		#endregion
	}
}
