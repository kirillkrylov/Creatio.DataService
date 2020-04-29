using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Like")]
	public class Like : BaseEntity
	{
		#region Values
		private Guid _ContactId;
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId
		{
			get{return _ContactId;}
			set
			{
				_ContactId = value;
				OnPropertyChanged();
			}
		}
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
		private int _LikeIt;
		[CProperty(ColumnPath ="LikeIt")]
		public int LikeIt
		{
			get{return _LikeIt;}
			set
			{
				_LikeIt = value;
				OnPropertyChanged();
			}
		}
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
