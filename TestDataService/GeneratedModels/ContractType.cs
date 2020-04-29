using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ContractType")]
	public class ContractType : BaseEntity
	{
		#region Values
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
		private bool _IsSlave;
		[CProperty(ColumnPath ="IsSlave")]
		public bool IsSlave
		{
			get{return _IsSlave;}
			set
			{
				_IsSlave = value;
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
		private Guid _ParentId;
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId
		{
			get{return _ParentId;}
			set
			{
				_ParentId = value;
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
		private Guid _SubTypeId;
		[CProperty(ColumnPath ="SubTypeId")]
		public Guid SubTypeId
		{
			get{return _SubTypeId;}
			set
			{
				_SubTypeId = value;
				OnPropertyChanged();
			}
		}
		private bool _UseBillingInfoForService;
		[CProperty(ColumnPath ="UseBillingInfoForService")]
		public bool UseBillingInfoForService
		{
			get{return _UseBillingInfoForService;}
			set
			{
				_UseBillingInfoForService = value;
				OnPropertyChanged();
			}
		}
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
