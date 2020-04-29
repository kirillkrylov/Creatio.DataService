using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DefaultReport")]
	public class DefaultReport : BaseEntity
	{
		#region Values
		private Guid _ContractTypeId;
		[CProperty(ColumnPath ="ContractTypeId")]
		public Guid ContractTypeId
		{
			get{return _ContractTypeId;}
			set
			{
				_ContractTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
				OnPropertyChanged();
			}
		}
		private Guid _CultureId;
		[CProperty(ColumnPath ="CultureId")]
		public Guid CultureId
		{
			get{return _CultureId;}
			set
			{
				_CultureId = value;
				OnPropertyChanged();
			}
		}
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private bool _IsDefault;
		[CProperty(ColumnPath ="IsDefault")]
		public bool IsDefault
		{
			get{return _IsDefault;}
			set
			{
				_IsDefault = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
				OnPropertyChanged();
			}
		}
		private Guid _OrderTypeId;
		[CProperty(ColumnPath ="OrderTypeId")]
		public Guid OrderTypeId
		{
			get{return _OrderTypeId;}
			set
			{
				_OrderTypeId = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
		private bool _RecordInactive;
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive
		{
			get{return _RecordInactive;}
			set
			{
				_RecordInactive = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupplierBillingInfoId;
		[CProperty(ColumnPath ="SupplierBillingInfoId")]
		public Guid SupplierBillingInfoId
		{
			get{return _SupplierBillingInfoId;}
			set
			{
				_SupplierBillingInfoId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupplierId;
		[CProperty(ColumnPath ="SupplierId")]
		public Guid SupplierId
		{
			get{return _SupplierId;}
			set
			{
				_SupplierId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysModuleId;
		[CProperty(ColumnPath ="SysModuleId")]
		public Guid SysModuleId
		{
			get{return _SysModuleId;}
			set
			{
				_SysModuleId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysModuleReportId;
		[CProperty(ColumnPath ="SysModuleReportId")]
		public Guid SysModuleReportId
		{
			get{return _SysModuleReportId;}
			set
			{
				_SysModuleReportId = value;
				OnPropertyChanged();
			}
		}
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
