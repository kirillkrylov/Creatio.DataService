using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ScreenResult")]
	public class ScreenResult : BaseEntity
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
		private bool _BOE;
		[CProperty(ColumnPath ="BOE")]
		public bool BOE
		{
			get{return _BOE;}
			set
			{
				_BOE = value;
				OnPropertyChanged();
			}
		}
		private bool _CFSP;
		[CProperty(ColumnPath ="CFSP")]
		public bool CFSP
		{
			get{return _CFSP;}
			set
			{
				_CFSP = value;
				OnPropertyChanged();
			}
		}
		private Guid _CityId;
		[CProperty(ColumnPath ="CityId")]
		public Guid CityId
		{
			get{return _CityId;}
			set
			{
				_CityId = value;
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
		private bool _DJSOR;
		[CProperty(ColumnPath ="DJSOR")]
		public bool DJSOR
		{
			get{return _DJSOR;}
			set
			{
				_DJSOR = value;
				OnPropertyChanged();
			}
		}
		private bool _DPL;
		[CProperty(ColumnPath ="DPL")]
		public bool DPL
		{
			get{return _DPL;}
			set
			{
				_DPL = value;
				OnPropertyChanged();
			}
		}
		private bool _EL;
		[CProperty(ColumnPath ="EL")]
		public bool EL
		{
			get{return _EL;}
			set
			{
				_EL = value;
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
		private bool _EUL;
		[CProperty(ColumnPath ="EUL")]
		public bool EUL
		{
			get{return _EUL;}
			set
			{
				_EUL = value;
				OnPropertyChanged();
			}
		}
		private bool _EURUDU;
		[CProperty(ColumnPath ="EURUDU")]
		public bool EURUDU
		{
			get{return _EURUDU;}
			set
			{
				_EURUDU = value;
				OnPropertyChanged();
			}
		}
		private bool _EURUKM;
		[CProperty(ColumnPath ="EURUKM")]
		public bool EURUKM
		{
			get{return _EURUKM;}
			set
			{
				_EURUKM = value;
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
		private bool _FINCEN;
		[CProperty(ColumnPath ="FINCEN")]
		public bool FINCEN
		{
			get{return _FINCEN;}
			set
			{
				_FINCEN = value;
				OnPropertyChanged();
			}
		}
		private bool _GoodGuy;
		[CProperty(ColumnPath ="GoodGuy")]
		public bool GoodGuy
		{
			get{return _GoodGuy;}
			set
			{
				_GoodGuy = value;
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
		private bool _IsActual;
		[CProperty(ColumnPath ="IsActual")]
		public bool IsActual
		{
			get{return _IsActual;}
			set
			{
				_IsActual = value;
				OnPropertyChanged();
			}
		}
		private bool _LADP;
		[CProperty(ColumnPath ="LADP")]
		public bool LADP
		{
			get{return _LADP;}
			set
			{
				_LADP = value;
				OnPropertyChanged();
			}
		}
		private bool _LSDP;
		[CProperty(ColumnPath ="LSDP")]
		public bool LSDP
		{
			get{return _LSDP;}
			set
			{
				_LSDP = value;
				OnPropertyChanged();
			}
		}
		private bool _MatchFound;
		[CProperty(ColumnPath ="MatchFound")]
		public bool MatchFound
		{
			get{return _MatchFound;}
			set
			{
				_MatchFound = value;
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
		private string _Notes;
		[CProperty(ColumnPath ="Notes")]
		public string Notes
		{
			get{return _Notes;}
			set
			{
				_Notes = value;
				OnPropertyChanged();
			}
		}
		private bool _NPS;
		[CProperty(ColumnPath ="NPS")]
		public bool NPS
		{
			get{return _NPS;}
			set
			{
				_NPS = value;
				OnPropertyChanged();
			}
		}
		private bool _OFACCSL;
		[CProperty(ColumnPath ="OFACCSL")]
		public bool OFACCSL
		{
			get{return _OFACCSL;}
			set
			{
				_OFACCSL = value;
				OnPropertyChanged();
			}
		}
		private string _Organization;
		[CProperty(ColumnPath ="Organization")]
		public string Organization
		{
			get{return _Organization;}
			set
			{
				_Organization = value;
				OnPropertyChanged();
			}
		}
		private string _PhoneNumber;
		[CProperty(ColumnPath ="PhoneNumber")]
		public string PhoneNumber
		{
			get{return _PhoneNumber;}
			set
			{
				_PhoneNumber = value;
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
		private Guid _RegionId;
		[CProperty(ColumnPath ="RegionId")]
		public Guid RegionId
		{
			get{return _RegionId;}
			set
			{
				_RegionId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ScreeningDate;
		[CProperty(ColumnPath ="ScreeningDate")]
		public DateTime ScreeningDate
		{
			get{return _ScreeningDate;}
			set
			{
				_ScreeningDate = value;
				OnPropertyChanged();
			}
		}
		private string _ScreeningEvent;
		[CProperty(ColumnPath ="ScreeningEvent")]
		public string ScreeningEvent
		{
			get{return _ScreeningEvent;}
			set
			{
				_ScreeningEvent = value;
				OnPropertyChanged();
			}
		}
		private Guid _ScreeningInitiatorId;
		[CProperty(ColumnPath ="ScreeningInitiatorId")]
		public Guid ScreeningInitiatorId
		{
			get{return _ScreeningInitiatorId;}
			set
			{
				_ScreeningInitiatorId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ScreeningResultStatusId;
		[CProperty(ColumnPath ="ScreeningResultStatusId")]
		public Guid ScreeningResultStatusId
		{
			get{return _ScreeningResultStatusId;}
			set
			{
				_ScreeningResultStatusId = value;
				OnPropertyChanged();
			}
		}
		private bool _SDN;
		[CProperty(ColumnPath ="SDN")]
		public bool SDN
		{
			get{return _SDN;}
			set
			{
				_SDN = value;
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
		private bool _UKUASL;
		[CProperty(ColumnPath ="UKUASL")]
		public bool UKUASL
		{
			get{return _UKUASL;}
			set
			{
				_UKUASL = value;
				OnPropertyChanged();
			}
		}
		private bool _UL;
		[CProperty(ColumnPath ="UL")]
		public bool UL
		{
			get{return _UL;}
			set
			{
				_UL = value;
				OnPropertyChanged();
			}
		}
		private bool _WBL;
		[CProperty(ColumnPath ="WBL")]
		public bool WBL
		{
			get{return _WBL;}
			set
			{
				_WBL = value;
				OnPropertyChanged();
			}
		}
		private bool _WithoutIntegration;
		[CProperty(ColumnPath ="WithoutIntegration")]
		public bool WithoutIntegration
		{
			get{return _WithoutIntegration;}
			set
			{
				_WithoutIntegration = value;
				OnPropertyChanged();
			}
		}
		private string _ZipCode;
		[CProperty(ColumnPath ="ZipCode")]
		public string ZipCode
		{
			get{return _ZipCode;}
			set
			{
				_ZipCode = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="AccountBillingInfo:AccountBillingInfoId")]
		public AccountBillingInfo AccountBillingInfo { get; set; }
		[CProperty(Navigation ="City:CityId")]
		public City City { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ScreeningInitiatorId")]
		public Contact ScreeningInitiator { get; set; }
		[CProperty(Navigation ="Country:CountryId")]
		public Country Country { get; set; }
		[CProperty(Navigation ="Region:RegionId")]
		public Region Region { get; set; }
		[CProperty(Navigation ="ScreeningResultStatus:ScreeningResultStatusId")]
		public ScreeningResultStatus ScreeningResultStatus { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="RestrictedParties:ScreeningResultId")]
		public virtual ICollection<RestrictedParties> RestrictedPartiesByScreeningResult { get; set; }
		[CProperty(Association ="ScreenResultFile:ScreenResultId")]
		public virtual ICollection<ScreenResultFile> ScreenResultFileByScreenResult { get; set; }
		[CProperty(Association ="ScreenResultInFolder:ScreenResultId")]
		public virtual ICollection<ScreenResultInFolder> ScreenResultInFolderByScreenResult { get; set; }
		[CProperty(Association ="ScreenResultInTag:EntityId")]
		public virtual ICollection<ScreenResultInTag> ScreenResultInTagByEntity { get; set; }
		[CProperty(Association ="ScreenResultVisa:ScreenResultId")]
		public virtual ICollection<ScreenResultVisa> ScreenResultVisaByScreenResult { get; set; }
		#endregion
	}
}
