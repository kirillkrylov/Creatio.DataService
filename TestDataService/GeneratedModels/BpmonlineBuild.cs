using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BpmonlineBuild")]
	public class BpmonlineBuild : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BpmonlineBuildDBMSId")]
		public Guid BpmonlineBuildDBMSId { get; set; }
		[CProperty(ColumnPath ="BpmonlineBuildVersionId")]
		public Guid BpmonlineBuildVersionId { get; set; }
		[CProperty(ColumnPath ="BpmonlineLczId")]
		public Guid BpmonlineLczId { get; set; }
		[CProperty(ColumnPath ="BpmonlineProductId")]
		public Guid BpmonlineProductId { get; set; }
		[CProperty(ColumnPath ="BpmonlineVersionId")]
		public Guid BpmonlineVersionId { get; set; }
		[CProperty(ColumnPath ="BuildTypeEntityId")]
		public Guid BuildTypeEntityId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="FileLink")]
		public string FileLink { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
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
		[CProperty(Navigation ="BpmonlineBuildDBMS:BpmonlineBuildDBMSId")]
		public BpmonlineBuildDBMS BpmonlineBuildDBMS { get; set; }
		[CProperty(Navigation ="BpmonlineBuildVersion:BpmonlineBuildVersionId")]
		public BpmonlineBuildVersion BpmonlineBuildVersion { get; set; }
		[CProperty(Navigation ="BpmonlineLcz:BpmonlineLczId")]
		public BpmonlineLcz BpmonlineLcz { get; set; }
		[CProperty(Navigation ="BpmonlineProduct:BpmonlineProductId")]
		public BpmonlineProduct BpmonlineProduct { get; set; }
		[CProperty(Navigation ="BpmonlineVersion:BpmonlineVersionId")]
		public BpmonlineVersion BpmonlineVersion { get; set; }
		[CProperty(Navigation ="BuildTypeEntity:BuildTypeEntityId")]
		public BuildTypeEntity BuildTypeEntity { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BpmonlineBuildFile:BpmonlineBuildId")]
		public virtual ICollection<BpmonlineBuildFile> BpmonlineBuildFileByBpmonlineBuild { get; set; }
		[CProperty(Association ="BpmonlineBuildInFolder:BpmonlineBuildId")]
		public virtual ICollection<BpmonlineBuildInFolder> BpmonlineBuildInFolderByBpmonlineBuild { get; set; }
		[CProperty(Association ="BpmonlineBuildInTag:EntityId")]
		public virtual ICollection<BpmonlineBuildInTag> BpmonlineBuildInTagByEntity { get; set; }
		[CProperty(Association ="ConfItem:BpmonlineBuildId")]
		public virtual ICollection<ConfItem> ConfItemByBpmonlineBuild { get; set; }
		[CProperty(Association ="Release:BpmonlineBuildId")]
		public virtual ICollection<Release> ReleaseByBpmonlineBuild { get; set; }
		#endregion
	}
}
