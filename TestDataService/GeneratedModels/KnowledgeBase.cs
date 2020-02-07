using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "KnowledgeBase")]
	public class KnowledgeBase : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="Keywords")]
		public string Keywords { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="NotHtmlNote")]
		public string NotHtmlNote { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="ViewsCount")]
		public int ViewsCount { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="KnowledgeBaseType:TypeId")]
		public KnowledgeBaseType Type { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Comment:KnowledgeBaseId")]
		public virtual ICollection<Comment> CommentByKnowledgeBase { get; set; }
		[CProperty(Association ="Favorites:KnowledgeBaseId")]
		public virtual ICollection<Favorites> FavoritesByKnowledgeBase { get; set; }
		[CProperty(Association ="KnowledgeBaseFile:KnowledgeBaseId")]
		public virtual ICollection<KnowledgeBaseFile> KnowledgeBaseFileByKnowledgeBase { get; set; }
		[CProperty(Association ="KnowledgeBaseInCase:KnowledgeBaseId")]
		public virtual ICollection<KnowledgeBaseInCase> KnowledgeBaseInCaseByKnowledgeBase { get; set; }
		[CProperty(Association ="KnowledgeBaseInFolder:KnowledgeBaseId")]
		public virtual ICollection<KnowledgeBaseInFolder> KnowledgeBaseInFolderByKnowledgeBase { get; set; }
		[CProperty(Association ="KnowledgeBaseInTagV2:EntityId")]
		public virtual ICollection<KnowledgeBaseInTagV2> KnowledgeBaseInTagV2ByEntity { get; set; }
		[CProperty(Association ="KnowledgeBaseTagDecoupling:KnowledgeBaseId")]
		public virtual ICollection<KnowledgeBaseTagDecoupling> KnowledgeBaseTagDecouplingByKnowledgeBase { get; set; }
		[CProperty(Association ="Like:KnowledgeBaseId")]
		public virtual ICollection<Like> LikeByKnowledgeBase { get; set; }
		#endregion
	}
}
