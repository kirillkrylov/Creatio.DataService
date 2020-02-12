using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DefaultReport")]
	public class DefaultReport : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ContractTypeId")]
		public Guid ContractTypeId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CultureId")]
		public Guid CultureId { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsDefault")]
		public bool IsDefault { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OrderTypeId")]
		public Guid OrderTypeId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SupplierBillingInfoId")]
		public Guid SupplierBillingInfoId { get; set; }
		[CProperty(ColumnPath ="SupplierId")]
		public Guid SupplierId { get; set; }
		[CProperty(ColumnPath ="SysModuleId")]
		public Guid SysModuleId { get; set; }
		[CProperty(ColumnPath ="SysModuleReportId")]
		public Guid SysModuleReportId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:SupplierId")]
		public Account Supplier { get; set; }
		[CProperty(Navigation ="AccountBillingInfo:SupplierBillingInfoId")]
		public AccountBillingInfo SupplierBillingInfo { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ContractType:ContractTypeId")]
		public ContractType ContractType { get; set; }
		[CProperty(Navigation ="SysCulture:CultureId")]
		public SysCulture Culture { get; set; }
		[CProperty(Navigation ="SysModule:SysModuleId")]
		public SysModule SysModule { get; set; }
		[CProperty(Navigation ="SysModuleReport:SysModuleReportId")]
		public SysModuleReport SysModuleReport { get; set; }
		[CProperty(Navigation ="WorkOrderType:OrderTypeId")]
		public WorkOrderType OrderType { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
