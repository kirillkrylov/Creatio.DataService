using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "KnowledgeBaseTagDecoupling")]
	public class KnowledgeBaseTagDecoupling : BaseEntity
	{
		#region Values
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private Guid _KnowledgeBaseId;
		[CProperty(ColumnPath ="KnowledgeBaseId")]
		public Guid KnowledgeBaseId
		{
			get{return _KnowledgeBaseId;}
			set
			{
				_KnowledgeBaseId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TagId;
		[CProperty(ColumnPath ="TagId")]
		public Guid TagId
		{
			get{return _TagId;}
			set
			{
				_TagId = value;
				OnPropertyChanged();
			}
		}
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
