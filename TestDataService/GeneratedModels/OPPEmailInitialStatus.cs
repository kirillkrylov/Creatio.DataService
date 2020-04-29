using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OPPEmailInitialStatus")]
	public class OPPEmailInitialStatus : BaseEntity
	{
		#region Values
		private Guid _BulkEmailId;
		[CProperty(ColumnPath ="BulkEmailId")]
		public Guid BulkEmailId
		{
			get{return _BulkEmailId;}
			set
			{
				_BulkEmailId = value;
				OnPropertyChanged();
			}
		}
		private string _EmailAddress;
		[CProperty(ColumnPath ="EmailAddress")]
		public string EmailAddress
		{
			get{return _EmailAddress;}
			set
			{
				_EmailAddress = value;
				OnPropertyChanged();
			}
		}
		private Guid _EmailResponseId;
		[CProperty(ColumnPath ="EmailResponseId")]
		public Guid EmailResponseId
		{
			get{return _EmailResponseId;}
			set
			{
				_EmailResponseId = value;
				OnPropertyChanged();
			}
		}
		private Guid _MandrillId;
		[CProperty(ColumnPath ="MandrillId")]
		public Guid MandrillId
		{
			get{return _MandrillId;}
			set
			{
				_MandrillId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		#endregion

		#region Associations
		#endregion
	}
}
