using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "tsaTerm")]
	public class tsaTerm : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="tsaName")]
		public string tsaName { get; set; }
		[CProperty(ColumnPath ="tsaNotes")]
		public string tsaNotes { get; set; }
		[CProperty(ColumnPath ="tsaTermContext")]
		public string tsaTermContext { get; set; }
		[CProperty(ColumnPath ="tsaTermLanguageId")]
		public Guid tsaTermLanguageId { get; set; }
		[CProperty(ColumnPath ="tsaTermMeaning")]
		public string tsaTermMeaning { get; set; }
		[CProperty(ColumnPath ="tsaTermOwnerAcaId")]
		public Guid tsaTermOwnerAcaId { get; set; }
		[CProperty(ColumnPath ="tsaTermOwnerRnDId")]
		public Guid tsaTermOwnerRnDId { get; set; }
		[CProperty(ColumnPath ="tsaTermOwnerTeamAcaId")]
		public Guid tsaTermOwnerTeamAcaId { get; set; }
		[CProperty(ColumnPath ="tsaTermOwnerTeamRnDId")]
		public Guid tsaTermOwnerTeamRnDId { get; set; }
		[CProperty(ColumnPath ="tsaTermStatusId")]
		public Guid tsaTermStatusId { get; set; }
		[CProperty(ColumnPath ="tsaTermTags")]
		public string tsaTermTags { get; set; }
		[CProperty(ColumnPath ="tsaTermTypeId")]
		public Guid tsaTermTypeId { get; set; }
		[CProperty(ColumnPath ="tsaTranslationKey")]
		public string tsaTranslationKey { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:tsaTermOwnerAcaId")]
		public Contact tsaTermOwnerAca { get; set; }
		[CProperty(Navigation ="Contact:tsaTermOwnerRnDId")]
		public Contact tsaTermOwnerRnD { get; set; }
		[CProperty(Navigation ="SysAdminUnit:tsaTermOwnerTeamAcaId")]
		public SysAdminUnit tsaTermOwnerTeamAca { get; set; }
		[CProperty(Navigation ="SysAdminUnit:tsaTermOwnerTeamRnDId")]
		public SysAdminUnit tsaTermOwnerTeamRnD { get; set; }
		[CProperty(Navigation ="tsaTermCulture:tsaTermLanguageId")]
		public tsaTermCulture tsaTermLanguage { get; set; }
		[CProperty(Navigation ="tsaTermStatus:tsaTermStatusId")]
		public tsaTermStatus tsaTermStatus { get; set; }
		[CProperty(Navigation ="tsaTermType:tsaTermTypeId")]
		public tsaTermType tsaTermType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:tsatsaTermId")]
		public virtual ICollection<Activity> ActivityBytsatsaTerm { get; set; }
		[CProperty(Association ="tsaTermFile:tsaTermId")]
		public virtual ICollection<tsaTermFile> tsaTermFileBytsaTerm { get; set; }
		[CProperty(Association ="tsaTermInFolder:tsaTermId")]
		public virtual ICollection<tsaTermInFolder> tsaTermInFolderBytsaTerm { get; set; }
		[CProperty(Association ="tsaTermInTag:EntityId")]
		public virtual ICollection<tsaTermInTag> tsaTermInTagByEntity { get; set; }
		[CProperty(Association ="tsaTermTranslation:tsaSourceTermId")]
		public virtual ICollection<tsaTermTranslation> tsaTermTranslationBytsaSourceTerm { get; set; }
		[CProperty(Association ="tsaTermTranslation:tsaTranslationForTermId")]
		public virtual ICollection<tsaTermTranslation> tsaTermTranslationBytsaTranslationForTerm { get; set; }
		[CProperty(Association ="tsaTermVariant:tsaTermId")]
		public virtual ICollection<tsaTermVariant> tsaTermVariantBytsaTerm { get; set; }
		[CProperty(Association ="tsaTermVisa:tsaTermId")]
		public virtual ICollection<tsaTermVisa> tsaTermVisaBytsaTerm { get; set; }
		#endregion
	}
}
