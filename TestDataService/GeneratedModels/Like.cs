using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Like")]
	public class Like : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="KnowledgeBaseId")]
		public Guid KnowledgeBaseId { get; set; }
		[CProperty(ColumnPath ="LikeIt")]
		public int LikeIt { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="KnowledgeBase:KnowledgeBaseId")]
		public KnowledgeBase KnowledgeBase { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
