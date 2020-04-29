using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwAccountStatusHistory")]
	public class VwAccountStatusHistory : BaseEntity
	{
		#region Values
		private Guid _AccountId;
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId
		{
			get{return _AccountId;}
			set
			{
				_AccountId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ChangeDate;
		[CProperty(ColumnPath ="ChangeDate")]
		public DateTime ChangeDate
		{
			get{return _ChangeDate;}
			set
			{
				_ChangeDate = value;
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
		private Guid _NewStatusId;
		[CProperty(ColumnPath ="NewStatusId")]
		public Guid NewStatusId
		{
			get{return _NewStatusId;}
			set
			{
				_NewStatusId = value;
				OnPropertyChanged();
			}
		}
		private Guid _OldStatusId;
		[CProperty(ColumnPath ="OldStatusId")]
		public Guid OldStatusId
		{
			get{return _OldStatusId;}
			set
			{
				_OldStatusId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="AccountStatus:OldStatusId")]
		public AccountStatus OldStatus { get; set; }
		[CProperty(Navigation ="AccountStatus:NewStatusId")]
		public AccountStatus NewStatus { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
