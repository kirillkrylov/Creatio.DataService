using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SaaSMetrics")]
	public class SaaSMetrics : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="MetricId")]
		public Guid MetricId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ParentContractId")]
		public Guid ParentContractId { get; set; }
		[CProperty(ColumnPath ="PeriodId")]
		public Guid PeriodId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductFamilyId")]
		public Guid ProductFamilyId { get; set; }
		[CProperty(ColumnPath ="SpecificationId")]
		public Guid SpecificationId { get; set; }
		[CProperty(ColumnPath ="Value")]
		public decimal Value { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contract:SpecificationId")]
		public Contract Specification { get; set; }
		[CProperty(Navigation ="Contract:ParentContractId")]
		public Contract ParentContract { get; set; }
		[CProperty(Navigation ="Metrics:MetricId")]
		public Metrics Metric { get; set; }
		[CProperty(Navigation ="Period:PeriodId")]
		public Period Period { get; set; }
		[CProperty(Navigation ="ProductKind:ProductFamilyId")]
		public ProductKind ProductFamily { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
