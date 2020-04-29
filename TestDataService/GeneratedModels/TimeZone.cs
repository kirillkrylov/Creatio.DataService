using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TimeZone")]
	public class TimeZone : BaseEntity
	{
		#region Values
		private string _Code;
		[CProperty(ColumnPath ="Code")]
		public string Code
		{
			get{return _Code;}
			set
			{
				_Code = value;
				OnPropertyChanged();
			}
		}
		private string _CodeAmerican;
		[CProperty(ColumnPath ="CodeAmerican")]
		public string CodeAmerican
		{
			get{return _CodeAmerican;}
			set
			{
				_CodeAmerican = value;
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
		private string _Offset;
		[CProperty(ColumnPath ="Offset")]
		public string Offset
		{
			get{return _Offset;}
			set
			{
				_Offset = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:TimeZoneId")]
		public virtual ICollection<Activity> ActivityByTimeZone { get; set; }
		[CProperty(Association ="Calendar:TimeZoneId")]
		public virtual ICollection<Calendar> CalendarByTimeZone { get; set; }
		[CProperty(Association ="City:TimeZoneId")]
		public virtual ICollection<City> CityByTimeZone { get; set; }
		[CProperty(Association ="Country:TimeZoneId")]
		public virtual ICollection<Country> CountryByTimeZone { get; set; }
		[CProperty(Association ="Region:TimeZoneId")]
		public virtual ICollection<Region> RegionByTimeZone { get; set; }
		[CProperty(Association ="VwSysAdminUnit:TimeZoneId")]
		public virtual ICollection<VwSysAdminUnit> VwSysAdminUnitByTimeZone { get; set; }
		#endregion
	}
}
