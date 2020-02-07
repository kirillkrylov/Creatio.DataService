using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TimeZone")]
	public class TimeZone : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
		[CProperty(ColumnPath ="CodeAmerican")]
		public string CodeAmerican { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Offset")]
		public string Offset { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
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
		[CProperty(Association ="ZoomTimeZone:TimeZoneId")]
		public virtual ICollection<ZoomTimeZone> ZoomTimeZoneByTimeZone { get; set; }
		#endregion
	}
}
