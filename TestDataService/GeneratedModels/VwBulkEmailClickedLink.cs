using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwBulkEmailClickedLink")]
	public class VwBulkEmailClickedLink : BaseEntity
	{
		#region Values
		private Guid _BulkEmailHyperlinkId;
		[CProperty(ColumnPath ="BulkEmailHyperlinkId")]
		public Guid BulkEmailHyperlinkId
		{
			get{return _BulkEmailHyperlinkId;}
			set
			{
				_BulkEmailHyperlinkId = value;
				OnPropertyChanged();
			}
		}
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
		#endregion

		#region Navigation
		[CProperty(Navigation ="BulkEmailHyperlink:BulkEmailHyperlinkId")]
		public BulkEmailHyperlink BulkEmailHyperlink { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
