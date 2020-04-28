using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ContractType")]
	public class ContractType : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsSlave")]
		public bool IsSlave { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		[CProperty(ColumnPath ="SubTypeId")]
		public Guid SubTypeId { get; set; }
		[CProperty(ColumnPath ="UseBillingInfoForService")]
		public bool UseBillingInfoForService { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ContractSubType:SubTypeId")]
		public ContractSubType SubType { get; set; }
		[CProperty(Navigation ="ContractType:ParentId")]
		public ContractType Parent { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Contract:TypeId")]
		public virtual ICollection<Contract> ContractByType { get; set; }
		[CProperty(Association ="ContractByProductType:ContractTypeId")]
		public virtual ICollection<ContractByProductType> ContractByProductTypeByContractType { get; set; }
		[CProperty(Association ="ContractType:ParentId")]
		public virtual ICollection<ContractType> ContractTypeByParent { get; set; }
		[CProperty(Association ="DefaultReport:ContractTypeId")]
		public virtual ICollection<DefaultReport> DefaultReportByContractType { get; set; }
		#endregion
	}
}
