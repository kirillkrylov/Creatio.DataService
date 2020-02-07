using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "FileType")]
	public class FileType : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
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
		[CProperty(Association ="AccountFile:TypeId")]
		public virtual ICollection<AccountFile> AccountFileByType { get; set; }
		[CProperty(Association ="ActivityFile:TypeId")]
		public virtual ICollection<ActivityFile> ActivityFileByType { get; set; }
		[CProperty(Association ="BulkEmailFile:TypeId")]
		public virtual ICollection<BulkEmailFile> BulkEmailFileByType { get; set; }
		[CProperty(Association ="BulkEmailSplitFile:TypeId")]
		public virtual ICollection<BulkEmailSplitFile> BulkEmailSplitFileByType { get; set; }
		[CProperty(Association ="CallFile:TypeId")]
		public virtual ICollection<CallFile> CallFileByType { get; set; }
		[CProperty(Association ="CampaignFile:TypeId")]
		public virtual ICollection<CampaignFile> CampaignFileByType { get; set; }
		[CProperty(Association ="CampaignPlannerFile:TypeId")]
		public virtual ICollection<CampaignPlannerFile> CampaignPlannerFileByType { get; set; }
		[CProperty(Association ="CaseFile:TypeId")]
		public virtual ICollection<CaseFile> CaseFileByType { get; set; }
		[CProperty(Association ="CertificationFile:TypeId")]
		public virtual ICollection<CertificationFile> CertificationFileByType { get; set; }
		[CProperty(Association ="ChangeFile:TypeId")]
		public virtual ICollection<ChangeFile> ChangeFileByType { get; set; }
		[CProperty(Association ="ConfItemFile:TypeId")]
		public virtual ICollection<ConfItemFile> ConfItemFileByType { get; set; }
		[CProperty(Association ="ContactFile:TypeId")]
		public virtual ICollection<ContactFile> ContactFileByType { get; set; }
		[CProperty(Association ="ContentBlockFile:TypeId")]
		public virtual ICollection<ContentBlockFile> ContentBlockFileByType { get; set; }
		[CProperty(Association ="ContractFile:TypeId")]
		public virtual ICollection<ContractFile> ContractFileByType { get; set; }
		[CProperty(Association ="DocumentFile:TypeId")]
		public virtual ICollection<DocumentFile> DocumentFileByType { get; set; }
		[CProperty(Association ="EmailTemplateFile:TypeId")]
		public virtual ICollection<EmailTemplateFile> EmailTemplateFileByType { get; set; }
		[CProperty(Association ="EmployeeFile:TypeId")]
		public virtual ICollection<EmployeeFile> EmployeeFileByType { get; set; }
		[CProperty(Association ="EventFile:TypeId")]
		public virtual ICollection<EventFile> EventFileByType { get; set; }
		[CProperty(Association ="ExternalAccessFile:TypeId")]
		public virtual ICollection<ExternalAccessFile> ExternalAccessFileByType { get; set; }
		[CProperty(Association ="File:TypeId")]
		public virtual ICollection<File> FileByType { get; set; }
		[CProperty(Association ="FileLead:TypeId")]
		public virtual ICollection<FileLead> FileLeadByType { get; set; }
		[CProperty(Association ="GeneratedWebFormFile:TypeId")]
		public virtual ICollection<GeneratedWebFormFile> GeneratedWebFormFileByType { get; set; }
		[CProperty(Association ="GuidedLearningFile:TypeId")]
		public virtual ICollection<GuidedLearningFile> GuidedLearningFileByType { get; set; }
		[CProperty(Association ="InvoiceFile:TypeId")]
		public virtual ICollection<InvoiceFile> InvoiceFileByType { get; set; }
		[CProperty(Association ="KnowledgeBaseFile:TypeId")]
		public virtual ICollection<KnowledgeBaseFile> KnowledgeBaseFileByType { get; set; }
		[CProperty(Association ="MailboxSettingsFile:TypeId")]
		public virtual ICollection<MailboxSettingsFile> MailboxSettingsFileByType { get; set; }
		[CProperty(Association ="MktgActivityFile:TypeId")]
		public virtual ICollection<MktgActivityFile> MktgActivityFileByType { get; set; }
		[CProperty(Association ="MLModelFile:TypeId")]
		public virtual ICollection<MLModelFile> MLModelFileByType { get; set; }
		[CProperty(Association ="OAuth20AppFile:TypeId")]
		public virtual ICollection<OAuth20AppFile> OAuth20AppFileByType { get; set; }
		[CProperty(Association ="OpportunityFile:TypeId")]
		public virtual ICollection<OpportunityFile> OpportunityFileByType { get; set; }
		[CProperty(Association ="OrderFile:TypeId")]
		public virtual ICollection<OrderFile> OrderFileByType { get; set; }
		[CProperty(Association ="PartnershipFile:TypeId")]
		public virtual ICollection<PartnershipFile> PartnershipFileByType { get; set; }
		[CProperty(Association ="PortalMessageFile:TypeId")]
		public virtual ICollection<PortalMessageFile> PortalMessageFileByType { get; set; }
		[CProperty(Association ="ProblemFile:TypeId")]
		public virtual ICollection<ProblemFile> ProblemFileByType { get; set; }
		[CProperty(Association ="ProductFile:TypeId")]
		public virtual ICollection<ProductFile> ProductFileByType { get; set; }
		[CProperty(Association ="ProjectFile:TypeId")]
		public virtual ICollection<ProjectFile> ProjectFileByType { get; set; }
		[CProperty(Association ="QandAFile:TypeId")]
		public virtual ICollection<QandAFile> QandAFileByType { get; set; }
		[CProperty(Association ="ReleaseFile:TypeId")]
		public virtual ICollection<ReleaseFile> ReleaseFileByType { get; set; }
		[CProperty(Association ="ServiceItemFile:TypeId")]
		public virtual ICollection<ServiceItemFile> ServiceItemFileByType { get; set; }
		[CProperty(Association ="ServicePactFile:TypeId")]
		public virtual ICollection<ServicePactFile> ServicePactFileByType { get; set; }
		[CProperty(Association ="SiteEventTypeFile:TypeId")]
		public virtual ICollection<SiteEventTypeFile> SiteEventTypeFileByType { get; set; }
		[CProperty(Association ="tsaTermFile:TypeId")]
		public virtual ICollection<tsaTermFile> tsaTermFileByType { get; set; }
		[CProperty(Association ="tsaTermTranslationFile:TypeId")]
		public virtual ICollection<tsaTermTranslationFile> tsaTermTranslationFileByType { get; set; }
		[CProperty(Association ="VwProcessLibFile:TypeId")]
		public virtual ICollection<VwProcessLibFile> VwProcessLibFileByType { get; set; }
		[CProperty(Association ="VwSysProcessFile:TypeId")]
		public virtual ICollection<VwSysProcessFile> VwSysProcessFileByType { get; set; }
		[CProperty(Association ="WebServiceV2File:TypeId")]
		public virtual ICollection<WebServiceV2File> WebServiceV2FileByType { get; set; }
		#endregion
	}
}
