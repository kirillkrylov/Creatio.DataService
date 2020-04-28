using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DwhDevKpi")]
	public class DwhDevKpi : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId { get; set; }
		[CProperty(ColumnPath ="HodId")]
		public Guid HodId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="JiraBillingTime")]
		public decimal JiraBillingTime { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="PeriodFrom")]
		public DateTime PeriodFrom { get; set; }
		[CProperty(ColumnPath ="PeriodName")]
		public string PeriodName { get; set; }
		[CProperty(ColumnPath ="PeriodTo")]
		public DateTime PeriodTo { get; set; }
		[CProperty(ColumnPath ="Position")]
		public string Position { get; set; }
		[CProperty(ColumnPath ="PracticeName")]
		public string PracticeName { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Productivity")]
		public decimal Productivity { get; set; }
		[CProperty(ColumnPath ="RateSP")]
		public decimal RateSP { get; set; }
		[CProperty(ColumnPath ="SkillLevel")]
		public string SkillLevel { get; set; }
		[CProperty(ColumnPath ="SkillProgress")]
		public decimal SkillProgress { get; set; }
		[CProperty(ColumnPath ="TeamName")]
		public string TeamName { get; set; }
		[CProperty(ColumnPath ="TotalSP")]
		public decimal TotalSP { get; set; }
		[CProperty(ColumnPath ="WorkDays")]
		public int WorkDays { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:EmployeeId")]
		public Contact Employee { get; set; }
		[CProperty(Navigation ="Contact:HodId")]
		public Contact Hod { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
