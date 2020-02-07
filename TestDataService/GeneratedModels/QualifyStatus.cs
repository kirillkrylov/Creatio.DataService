using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "QualifyStatus")]
	public class QualifyStatus : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Color")]
		public string Color { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsDisplayed")]
		public bool IsDisplayed { get; set; }
		[CProperty(ColumnPath ="IsFinal")]
		public bool IsFinal { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="StageInnerOrder")]
		public int StageInnerOrder { get; set; }
		[CProperty(ColumnPath ="StageNumber")]
		public int StageNumber { get; set; }
		[CProperty(ColumnPath ="StageOrder")]
		public int StageOrder { get; set; }
		[CProperty(ColumnPath ="Successful")]
		public bool Successful { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Lead:QualifyStatusId")]
		public virtual ICollection<Lead> LeadByQualifyStatus { get; set; }
		[CProperty(Association ="LeadInQualifyStatus:QualifyStatusId")]
		public virtual ICollection<LeadInQualifyStatus> LeadInQualifyStatusByQualifyStatus { get; set; }
		[CProperty(Association ="QualifyStatusDecoupling:CurrentStatusId")]
		public virtual ICollection<QualifyStatusDecoupling> QualifyStatusDecouplingByCurrentStatus { get; set; }
		[CProperty(Association ="QualifyStatusDecoupling:AvailableStatusId")]
		public virtual ICollection<QualifyStatusDecoupling> QualifyStatusDecouplingByAvailableStatus { get; set; }
		#endregion
	}
}
