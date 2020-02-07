using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OpportunityDepartment")]
	public class OpportunityDepartment : BaseEntity
	{
		#region Values
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
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SalesDirectorId")]
		public Guid SalesDirectorId { get; set; }
		[CProperty(ColumnPath ="SysAdminUnitId")]
		public Guid SysAdminUnitId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:SalesDirectorId")]
		public Contact SalesDirector { get; set; }
		[CProperty(Navigation ="SysAdminUnit:SysAdminUnitId")]
		public SysAdminUnit SysAdminUnit { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Lead:OpportunityDepartmentId")]
		public virtual ICollection<Lead> LeadByOpportunityDepartment { get; set; }
		[CProperty(Association ="OppDepartmentForecast:OpportunityDepartmentId")]
		public virtual ICollection<OppDepartmentForecast> OppDepartmentForecastByOpportunityDepartment { get; set; }
		[CProperty(Association ="Opportunity:ResponsibleDepartmentId")]
		public virtual ICollection<Opportunity> OpportunityByResponsibleDepartment { get; set; }
		#endregion
	}
}
