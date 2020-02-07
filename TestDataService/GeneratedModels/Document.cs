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
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="ContractId")]
		public Guid ContractId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Date")]
		public DateTime Date { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="Number")]
		public string Number { get; set; }
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId { get; set; }
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="PaymentAmount")]
		public decimal PaymentAmount { get; set; }
		[CProperty(ColumnPath ="PaymentDate")]
		public DateTime PaymentDate { get; set; }
		[CProperty(ColumnPath ="PrimaryPaymentAmount")]
		public decimal PrimaryPaymentAmount { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProjectId")]
		public Guid ProjectId { get; set; }
		[CProperty(ColumnPath ="StateId")]
		public Guid StateId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Contract:ContractId")]
		public Contract Contract { get; set; }
		[CProperty(Navigation ="DocumentState:StateId")]
		public DocumentState State { get; set; }
		[CProperty(Navigation ="DocumentType:TypeId")]
		public DocumentType Type { get; set; }
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
		#endregion
	}
}
