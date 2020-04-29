using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwAccountBillingInfo")]
	public class VwAccountBillingInfo : BaseEntity
	{
		#region Values
		private Guid _AccountBillingInfoId;
		[CProperty(ColumnPath ="AccountBillingInfoId")]
		public Guid AccountBillingInfoId
		{
			get{return _AccountBillingInfoId;}
			set
			{
				_AccountBillingInfoId = value;
				OnPropertyChanged();
			}
		}
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
		private string _City;
		[CProperty(ColumnPath ="City")]
		public string City
		{
			get{return _City;}
			set
			{
				_City = value;
				OnPropertyChanged();
			}
		}
		private string _CountryISO;
		[CProperty(ColumnPath ="CountryISO")]
		public string CountryISO
		{
			get{return _CountryISO;}
			set
			{
				_CountryISO = value;
				OnPropertyChanged();
			}
		}
		private DateTime _DateOfBirth;
		[CProperty(ColumnPath ="DateOfBirth")]
		public DateTime DateOfBirth
		{
			get{return _DateOfBirth;}
			set
			{
				_DateOfBirth = value;
				OnPropertyChanged();
			}
		}
		private string _District;
		[CProperty(ColumnPath ="District")]
		public string District
		{
			get{return _District;}
			set
			{
				_District = value;
				OnPropertyChanged();
			}
		}
		private string _Email;
		[CProperty(ColumnPath ="Email")]
		public string Email
		{
			get{return _Email;}
			set
			{
				_Email = value;
				OnPropertyChanged();
			}
		}
		private string _Fax;
		[CProperty(ColumnPath ="Fax")]
		public string Fax
		{
			get{return _Fax;}
			set
			{
				_Fax = value;
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
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
				OnPropertyChanged();
			}
		}
		private string _Name1;
		[CProperty(ColumnPath ="Name1")]
		public string Name1
		{
			get{return _Name1;}
			set
			{
				_Name1 = value;
				OnPropertyChanged();
			}
		}
		private string _Name2;
		[CProperty(ColumnPath ="Name2")]
		public string Name2
		{
			get{return _Name2;}
			set
			{
				_Name2 = value;
				OnPropertyChanged();
			}
		}
		private string _NameWithoutOwnership;
		[CProperty(ColumnPath ="NameWithoutOwnership")]
		public string NameWithoutOwnership
		{
			get{return _NameWithoutOwnership;}
			set
			{
				_NameWithoutOwnership = value;
				OnPropertyChanged();
			}
		}
		private string _Pc;
		[CProperty(ColumnPath ="Pc")]
		public string Pc
		{
			get{return _Pc;}
			set
			{
				_Pc = value;
				OnPropertyChanged();
			}
		}
		private string _Position;
		[CProperty(ColumnPath ="Position")]
		public string Position
		{
			get{return _Position;}
			set
			{
				_Position = value;
				OnPropertyChanged();
			}
		}
		private Guid _ReferenceComment;
		[CProperty(ColumnPath ="ReferenceComment")]
		public Guid ReferenceComment
		{
			get{return _ReferenceComment;}
			set
			{
				_ReferenceComment = value;
				OnPropertyChanged();
			}
		}
		private Guid _ReferenceId;
		[CProperty(ColumnPath ="ReferenceId")]
		public Guid ReferenceId
		{
			get{return _ReferenceId;}
			set
			{
				_ReferenceId = value;
				OnPropertyChanged();
			}
		}
		private string _Street;
		[CProperty(ColumnPath ="Street")]
		public string Street
		{
			get{return _Street;}
			set
			{
				_Street = value;
				OnPropertyChanged();
			}
		}
		private string _Surname;
		[CProperty(ColumnPath ="Surname")]
		public string Surname
		{
			get{return _Surname;}
			set
			{
				_Surname = value;
				OnPropertyChanged();
			}
		}
		private string _TelNo;
		[CProperty(ColumnPath ="TelNo")]
		public string TelNo
		{
			get{return _TelNo;}
			set
			{
				_TelNo = value;
				OnPropertyChanged();
			}
		}
		private string _Title;
		[CProperty(ColumnPath ="Title")]
		public string Title
		{
			get{return _Title;}
			set
			{
				_Title = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="AccountBillingInfo:AccountBillingInfoId")]
		public AccountBillingInfo AccountBillingInfo { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
