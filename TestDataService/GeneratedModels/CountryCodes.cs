using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CountryCodes")]
	public class CountryCodes : BaseEntity
	{
		#region Values
		private string _Address;
		[CProperty(ColumnPath ="Address")]
		public string Address
		{
			get{return _Address;}
			set
			{
				_Address = value;
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
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
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
		private bool _RecordInactive;
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive
		{
			get{return _RecordInactive;}
			set
			{
				_RecordInactive = value;
				OnPropertyChanged();
			}
		}
		private Guid _TerritoryId;
		[CProperty(ColumnPath ="TerritoryId")]
		public Guid TerritoryId
		{
			get{return _TerritoryId;}
			set
			{
				_TerritoryId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="City:CityId")]
		public City City { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Country:CountryId")]
		public Country Country { get; set; }
		[CProperty(Navigation ="Territory:TerritoryId")]
		public Territory Territory { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Applicant:OfficeId")]
		public virtual ICollection<Applicant> ApplicantByOffice { get; set; }
		[CProperty(Association ="CI:OfficeId")]
		public virtual ICollection<CI> CIByOffice { get; set; }
		[CProperty(Association ="Document:OfficeId")]
		public virtual ICollection<Document> DocumentByOffice { get; set; }
		[CProperty(Association ="InternalRequest:OfficeId")]
		public virtual ICollection<InternalRequest> InternalRequestByOffice { get; set; }
		[CProperty(Association ="InternalRequest:CalendarId")]
		public virtual ICollection<InternalRequest> InternalRequestByCalendar { get; set; }
		[CProperty(Association ="OrgStructureUnit:OfficeId")]
		public virtual ICollection<OrgStructureUnit> OrgStructureUnitByOffice { get; set; }
		[CProperty(Association ="OrgStructureUnit:CalendarId")]
		public virtual ICollection<OrgStructureUnit> OrgStructureUnitByCalendar { get; set; }
		[CProperty(Association ="TripsDailyAllowance:EmployeeOfficeId")]
		public virtual ICollection<TripsDailyAllowance> TripsDailyAllowanceByEmployeeOffice { get; set; }
		#endregion
	}
}
