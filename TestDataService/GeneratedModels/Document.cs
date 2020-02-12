using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Document")]
	public class Document : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount { get; set; }
		[CProperty(ColumnPath ="AmountWithoutTax")]
		public decimal AmountWithoutTax { get; set; }
		[CProperty(ColumnPath ="Code1C")]
		public string Code1C { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="ContractId")]
		public Guid ContractId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId { get; set; }
		[CProperty(ColumnPath ="CurrencyRate")]
		public decimal CurrencyRate { get; set; }
		[CProperty(ColumnPath ="CustomerBillingInfoId")]
		public Guid CustomerBillingInfoId { get; set; }
		[CProperty(ColumnPath ="Date")]
		public DateTime Date { get; set; }
		[CProperty(ColumnPath ="DeliveryAddress")]
		public string DeliveryAddress { get; set; }
		[CProperty(ColumnPath ="DeliveryDate")]
		public DateTime DeliveryDate { get; set; }
		[CProperty(ColumnPath ="DeliveryServiceId")]
		public Guid DeliveryServiceId { get; set; }
		[CProperty(ColumnPath ="DeliveryTypeId")]
		public Guid DeliveryTypeId { get; set; }
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="InitiatorId")]
		public Guid InitiatorId { get; set; }
		[CProperty(ColumnPath ="IntegrationId")]
		public string IntegrationId { get; set; }
		[CProperty(ColumnPath ="InternalRequestId")]
		public Guid InternalRequestId { get; set; }
		[CProperty(ColumnPath ="IsRecordLocked")]
		public bool IsRecordLocked { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="Number")]
		public string Number { get; set; }
		[CProperty(ColumnPath ="OfficeId")]
		public Guid OfficeId { get; set; }
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId { get; set; }
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId { get; set; }
		[CProperty(ColumnPath ="OtherAccount")]
		public string OtherAccount { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="PaymentAmount")]
		public decimal PaymentAmount { get; set; }
		[CProperty(ColumnPath ="PaymentDate")]
		public DateTime PaymentDate { get; set; }
		[CProperty(ColumnPath ="PrimaryAmount")]
		public decimal PrimaryAmount { get; set; }
		[CProperty(ColumnPath ="PrimaryAmountWithoutTax")]
		public decimal PrimaryAmountWithoutTax { get; set; }
		[CProperty(ColumnPath ="PrimaryPaymentAmount")]
		public decimal PrimaryPaymentAmount { get; set; }
		[CProperty(ColumnPath ="PrimaryTaxAmount")]
		public decimal PrimaryTaxAmount { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProjectId")]
		public Guid ProjectId { get; set; }
		[CProperty(ColumnPath ="ResponsibleAccountantId")]
		public Guid ResponsibleAccountantId { get; set; }
		[CProperty(ColumnPath ="StateId")]
		public Guid StateId { get; set; }
		[CProperty(ColumnPath ="TaxAmount")]
		public decimal TaxAmount { get; set; }
		[CProperty(ColumnPath ="TrackingNumber")]
		public string TrackingNumber { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
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
