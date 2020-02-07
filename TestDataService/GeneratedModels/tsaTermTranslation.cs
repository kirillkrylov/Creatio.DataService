using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "tsaTermTranslation")]
	public class tsaTermTranslation : BaseEntity
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
		[CProperty(ColumnPath ="tsaSourceTermId")]
		public Guid tsaSourceTermId { get; set; }
		[CProperty(ColumnPath ="tsaTermTranslationLanguageId")]
		public Guid tsaTermTranslationLanguageId { get; set; }
		[CProperty(ColumnPath ="tsaTranslationForTermId")]
		public Guid tsaTranslationForTermId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="tsaTerm:tsaSourceTermId")]
		public tsaTerm tsaSourceTerm { get; set; }
		[CProperty(Navigation ="tsaTerm:tsaTranslationForTermId")]
		public tsaTerm tsaTranslationForTerm { get; set; }
		[CProperty(Navigation ="tsaTermCulture:tsaTermTranslationLanguageId")]
		public tsaTermCulture tsaTermTranslationLanguage { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="tsaTermTranslationFile:tsaTermTranslationId")]
		public virtual ICollection<tsaTermTranslationFile> tsaTermTranslationFileBytsaTermTranslation { get; set; }
		[CProperty(Association ="tsaTermTranslationInFolder:tsaTermTranslationId")]
		public virtual ICollection<tsaTermTranslationInFolder> tsaTermTranslationInFolderBytsaTermTranslation { get; set; }
		[CProperty(Association ="tsaTermTranslationInTag:EntityId")]
		public virtual ICollection<tsaTermTranslationInTag> tsaTermTranslationInTagByEntity { get; set; }
		#endregion
	}
}
