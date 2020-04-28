using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "KnowledgeBaseTagDecoupling")]
	public class KnowledgeBaseTagDecoupling : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="KnowledgeBaseId")]
		public Guid KnowledgeBaseId { get; set; }
		[CProperty(ColumnPath ="TagId")]
		public Guid TagId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="KnowledgeBase:KnowledgeBaseId")]
		public KnowledgeBase KnowledgeBase { get; set; }
		[CProperty(Navigation ="KnowledgeBaseTag:TagId")]
		public KnowledgeBaseTag Tag { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
