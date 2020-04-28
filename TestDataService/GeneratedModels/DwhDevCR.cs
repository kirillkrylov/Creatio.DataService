using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DwhDevCR")]
	public class DwhDevCR : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActualDueDate")]
		public DateTime ActualDueDate { get; set; }
		[CProperty(ColumnPath ="ActualDuration")]
		public int ActualDuration { get; set; }
		[CProperty(ColumnPath ="ActualDuration05")]
		public int ActualDuration05 { get; set; }
		[CProperty(ColumnPath ="ActualDuration1")]
		public int ActualDuration1 { get; set; }
		[CProperty(ColumnPath ="ActualDuration2")]
		public int ActualDuration2 { get; set; }
		[CProperty(ColumnPath ="ActualDuration3")]
		public int ActualDuration3 { get; set; }
		[CProperty(ColumnPath ="ActualDuration5")]
		public int ActualDuration5 { get; set; }
		[CProperty(ColumnPath ="ActualDurationEE")]
		public int ActualDurationEE { get; set; }
		[CProperty(ColumnPath ="ActualDurationQT")]
		public int ActualDurationQT { get; set; }
		[CProperty(ColumnPath ="BugSP")]
		public decimal BugSP { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DescriptionStr")]
		public string DescriptionStr { get; set; }
		[CProperty(ColumnPath ="EmployeeLevel")]
		public string EmployeeLevel { get; set; }
		[CProperty(ColumnPath ="EmptyEstimate")]
		public bool EmptyEstimate { get; set; }
		[CProperty(ColumnPath ="HodId")]
		public Guid HodId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="JiraUrl")]
		public string JiraUrl { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Number")]
		public string Number { get; set; }
		[CProperty(ColumnPath ="OverEstimate")]
		public bool OverEstimate { get; set; }
		[CProperty(ColumnPath ="OwnerIdId")]
		public Guid OwnerIdId { get; set; }
		[CProperty(ColumnPath ="OwnerName")]
		public string OwnerName { get; set; }
		[CProperty(ColumnPath ="PeriodMonth")]
		public string PeriodMonth { get; set; }
		[CProperty(ColumnPath ="PeriodWeekNumber")]
		public string PeriodWeekNumber { get; set; }
		[CProperty(ColumnPath ="PracticeName")]
		public string PracticeName { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SkillProgress")]
		public decimal SkillProgress { get; set; }
		[CProperty(ColumnPath ="SP")]
		public decimal SP { get; set; }
		[CProperty(ColumnPath ="Sp05")]
		public decimal Sp05 { get; set; }
		[CProperty(ColumnPath ="Sp1")]
		public int Sp1 { get; set; }
		[CProperty(ColumnPath ="Sp2")]
		public int Sp2 { get; set; }
		[CProperty(ColumnPath ="Sp3")]
		public int Sp3 { get; set; }
		[CProperty(ColumnPath ="Sp5")]
		public int Sp5 { get; set; }
		[CProperty(ColumnPath ="StatusName")]
		public string StatusName { get; set; }
		[CProperty(ColumnPath ="TeamName")]
		public string TeamName { get; set; }
		[CProperty(ColumnPath ="TeamSize")]
		public int TeamSize { get; set; }
		[CProperty(ColumnPath ="TeamSkillProgress")]
		public decimal TeamSkillProgress { get; set; }
		[CProperty(ColumnPath ="WorkTerm")]
		public int WorkTerm { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerIdId")]
		public Contact OwnerId { get; set; }
		[CProperty(Navigation ="Contact:HodId")]
		public Contact Hod { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
