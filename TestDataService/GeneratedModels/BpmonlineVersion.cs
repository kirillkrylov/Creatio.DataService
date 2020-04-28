using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BpmonlineVersion")]
	public class BpmonlineVersion : BaseEntity
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
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ReleaseDate")]
		public DateTime ReleaseDate { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BpmonlineBuild:BpmonlineVersionId")]
		public virtual ICollection<BpmonlineBuild> BpmonlineBuildByBpmonlineVersion { get; set; }
		[CProperty(Association ="BpmonlineBuildVersion:BpmonlineVersionId")]
		public virtual ICollection<BpmonlineBuildVersion> BpmonlineBuildVersionByBpmonlineVersion { get; set; }
		[CProperty(Association ="ConfItem:BpmonlineVersionId")]
		public virtual ICollection<ConfItem> ConfItemByBpmonlineVersion { get; set; }
		[CProperty(Association ="Problem:FoundInVersionId")]
		public virtual ICollection<Problem> ProblemByFoundInVersion { get; set; }
		[CProperty(Association ="Problem:ResolvedInVersionId")]
		public virtual ICollection<Problem> ProblemByResolvedInVersion { get; set; }
		[CProperty(Association ="Product:PlatformVersionId")]
		public virtual ICollection<Product> ProductByPlatformVersion { get; set; }
		[CProperty(Association ="Release:BpmonlineVersionId")]
		public virtual ICollection<Release> ReleaseByBpmonlineVersion { get; set; }
		#endregion
	}
}
