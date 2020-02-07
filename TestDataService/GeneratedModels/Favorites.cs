using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Favorites")]
	public class Favorites : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="KnowledgeBaseId")]
		public Guid KnowledgeBaseId { get; set; }
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
