using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "UserSessionsNew")]
	public class UserSessionsNew : BaseEntity
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
		private int _Count;
		[CProperty(ColumnPath ="Count")]
		public int Count
		{
			get{return _Count;}
			set
			{
				_Count = value;
				OnPropertyChanged();
			}
		}
		private string _DatabaseName;
		[CProperty(ColumnPath ="DatabaseName")]
		public string DatabaseName
		{
			get{return _DatabaseName;}
			set
			{
				_DatabaseName = value;
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
		private DateTime _SessionDate;
		[CProperty(ColumnPath ="SessionDate")]
		public DateTime SessionDate
		{
			get{return _SessionDate;}
			set
			{
				_SessionDate = value;
				OnPropertyChanged();
			}
		}
		private string _UserName;
		[CProperty(ColumnPath ="UserName")]
		public string UserName
		{
			get{return _UserName;}
			set
			{
				_UserName = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
