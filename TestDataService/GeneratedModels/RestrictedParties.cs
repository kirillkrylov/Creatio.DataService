using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "RestrictedParties")]
	public class RestrictedParties : BaseEntity
	{
		#region Values
		private Guid _AddressTypeId;
		[CProperty(ColumnPath ="AddressTypeId")]
		public Guid AddressTypeId
		{
			get{return _AddressTypeId;}
			set
			{
				_AddressTypeId = value;
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
		private string _Comment;
		[CProperty(ColumnPath ="Comment")]
		public string Comment
		{
			get{return _Comment;}
			set
			{
				_Comment = value;
				OnPropertyChanged();
			}
		}
		private Guid _CountryId;
		[CProperty(ColumnPath ="CountryId")]
		public Guid CountryId
		{
			get{return _CountryId;}
			set
			{
				_CountryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
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
		private bool _hasMoreDetails;
		[CProperty(ColumnPath ="hasMoreDetails")]
		public bool hasMoreDetails
		{
			get{return _hasMoreDetails;}
			set
			{
				_hasMoreDetails = value;
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
		private string _Info;
		[CProperty(ColumnPath ="Info")]
		public string Info
		{
			get{return _Info;}
			set
			{
				_Info = value;
				OnPropertyChanged();
			}
		}
		private bool _MatchConfirmed;
		[CProperty(ColumnPath ="MatchConfirmed")]
		public bool MatchConfirmed
		{
			get{return _MatchConfirmed;}
			set
			{
				_MatchConfirmed = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
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
		private string _name1;
		[CProperty(ColumnPath ="name1")]
		public string name1
		{
			get{return _name1;}
			set
			{
				_name1 = value;
				OnPropertyChanged();
			}
		}
		private string _name2;
		[CProperty(ColumnPath ="name2")]
		public string name2
		{
			get{return _name2;}
			set
			{
				_name2 = value;
				OnPropertyChanged();
			}
		}
		private string _name3;
		[CProperty(ColumnPath ="name3")]
		public string name3
		{
			get{return _name3;}
			set
			{
				_name3 = value;
				OnPropertyChanged();
			}
		}
		private string _name4;
		[CProperty(ColumnPath ="name4")]
		public string name4
		{
			get{return _name4;}
			set
			{
				_name4 = value;
				OnPropertyChanged();
			}
		}
		private string _Phone;
		[CProperty(ColumnPath ="Phone")]
		public string Phone
		{
			get{return _Phone;}
			set
			{
				_Phone = value;
				OnPropertyChanged();
			}
		}
		private string _PostalCode;
		[CProperty(ColumnPath ="PostalCode")]
		public string PostalCode
		{
			get{return _PostalCode;}
			set
			{
				_PostalCode = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
		private string _Region;
		[CProperty(ColumnPath ="Region")]
		public string Region
		{
			get{return _Region;}
			set
			{
				_Region = value;
				OnPropertyChanged();
			}
		}
		private DateTime _restrictionDate;
		[CProperty(ColumnPath ="restrictionDate")]
		public DateTime restrictionDate
		{
			get{return _restrictionDate;}
			set
			{
				_restrictionDate = value;
				OnPropertyChanged();
			}
		}
		private string _restrictionSource;
		[CProperty(ColumnPath ="restrictionSource")]
		public string restrictionSource
		{
			get{return _restrictionSource;}
			set
			{
				_restrictionSource = value;
				OnPropertyChanged();
			}
		}
		private string _restrictionType;
		[CProperty(ColumnPath ="restrictionType")]
		public string restrictionType
		{
			get{return _restrictionType;}
			set
			{
				_restrictionType = value;
				OnPropertyChanged();
			}
		}
		private string _SanctionListFullName;
		[CProperty(ColumnPath ="SanctionListFullName")]
		public string SanctionListFullName
		{
			get{return _SanctionListFullName;}
			set
			{
				_SanctionListFullName = value;
				OnPropertyChanged();
			}
		}
		private Guid _SanctionListId;
		[CProperty(ColumnPath ="SanctionListId")]
		public Guid SanctionListId
		{
			get{return _SanctionListId;}
			set
			{
				_SanctionListId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ScreeningResultId;
		[CProperty(ColumnPath ="ScreeningResultId")]
		public Guid ScreeningResultId
		{
			get{return _ScreeningResultId;}
			set
			{
				_ScreeningResultId = value;
				OnPropertyChanged();
			}
		}
		private decimal _similarity;
		[CProperty(ColumnPath ="similarity")]
		public decimal similarity
		{
			get{return _similarity;}
			set
			{
				_similarity = value;
				OnPropertyChanged();
			}
		}
		private string _sourceWebLink;
		[CProperty(ColumnPath ="sourceWebLink")]
		public string sourceWebLink
		{
			get{return _sourceWebLink;}
			set
			{
				_sourceWebLink = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation ="AddressType:AddressTypeId")]
		public AddressType AddressType { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Country:CountryId")]
		public Country Country { get; set; }
		[CProperty(Navigation ="SanctionList:SanctionListId")]
		public SanctionList SanctionList { get; set; }
		[CProperty(Navigation ="ScreenResult:ScreeningResultId")]
		public ScreenResult ScreeningResult { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
