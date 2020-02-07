using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "tsaTermCulture")]
	public class tsaTermCulture : BaseEntity
	{
		#region Values
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
		[CProperty(ColumnPath ="tsaTermCultureLanguageId")]
		public Guid tsaTermCultureLanguageId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysLanguage:tsaTermCultureLanguageId")]
		public SysLanguage tsaTermCultureLanguage { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="tsaTerm:tsaTermLanguageId")]
		public virtual ICollection<tsaTerm> tsaTermBytsaTermLanguage { get; set; }
		[CProperty(Association ="tsaTermTranslation:tsaTermTranslationLanguageId")]
		public virtual ICollection<tsaTermTranslation> tsaTermTranslationBytsaTermTranslationLanguage { get; set; }
		#endregion
	}
}
