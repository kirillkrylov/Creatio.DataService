using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysLanguage")]
	public class SysLanguage : BaseEntity
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
		[CProperty(ColumnPath ="IsUsed")]
		public bool IsUsed { get; set; }
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
		[CProperty(Association ="Certification:LanguageId")]
		public virtual ICollection<Certification> CertificationByLanguage { get; set; }
		[CProperty(Association ="Contact:LanguageId")]
		public virtual ICollection<Contact> ContactByLanguage { get; set; }
		[CProperty(Association ="EmailTemplateLang:LanguageId")]
		public virtual ICollection<EmailTemplateLang> EmailTemplateLangByLanguage { get; set; }
		[CProperty(Association ="GuidedLearning:LanguageId")]
		public virtual ICollection<GuidedLearning> GuidedLearningByLanguage { get; set; }
		[CProperty(Association ="MailboxSyncSettings:MessageLanguageId")]
		public virtual ICollection<MailboxSyncSettings> MailboxSyncSettingsByMessageLanguage { get; set; }
		[CProperty(Association ="QandA:LanguageId")]
		public virtual ICollection<QandA> QandAByLanguage { get; set; }
		[CProperty(Association ="SysAdminUnit:DateTimeFormatId")]
		public virtual ICollection<SysAdminUnit> SysAdminUnitByDateTimeFormat { get; set; }
		[CProperty(Association ="SysCulture:LanguageId")]
		public virtual ICollection<SysCulture> SysCultureByLanguage { get; set; }
		[CProperty(Association ="tsaTermCulture:tsaTermCultureLanguageId")]
		public virtual ICollection<tsaTermCulture> tsaTermCultureBytsaTermCultureLanguage { get; set; }
		[CProperty(Association ="VwGroupSysAdminUnit:DateTimeFormatId")]
		public virtual ICollection<VwGroupSysAdminUnit> VwGroupSysAdminUnitByDateTimeFormat { get; set; }
		[CProperty(Association ="VwSysAdminUnit:DateTimeFormatId")]
		public virtual ICollection<VwSysAdminUnit> VwSysAdminUnitByDateTimeFormat { get; set; }
		#endregion
	}
}
