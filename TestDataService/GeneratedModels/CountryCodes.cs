using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CountryCodes")]
	public class CountryCodes : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Address")]
		public string Address { get; set; }
		[CProperty(ColumnPath ="CityId")]
		public Guid CityId { get; set; }
		[CProperty(ColumnPath ="CountryId")]
		public Guid CountryId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		[CProperty(ColumnPath ="TerritoryId")]
		public Guid TerritoryId { get; set; }
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
