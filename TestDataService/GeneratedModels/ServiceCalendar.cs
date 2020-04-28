using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ServiceCalendar")]
	public class ServiceCalendar : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CalendarId")]
		public Guid CalendarId { get; set; }
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
		[CProperty(ColumnPath ="SLATypeId")]
		public Guid SLATypeId { get; set; }
		[CProperty(ColumnPath ="TSOfficeId")]
		public Guid TSOfficeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Calendar:CalendarId")]
		public Calendar Calendar { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ServicePactType:SLATypeId")]
		public ServicePactType SLAType { get; set; }
		[CProperty(Navigation ="TSOffice:TSOfficeId")]
		public TSOffice TSOffice { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
