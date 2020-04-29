using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PaymentRule")]
	public class PaymentRule : BaseEntity
	{
		#region Values
		private Guid _AccrualMethodId;
		[CProperty(ColumnPath ="AccrualMethodId")]
		public Guid AccrualMethodId
		{
			get{return _AccrualMethodId;}
			set
			{
				_AccrualMethodId = value;
				OnPropertyChanged();
			}
		}
		private Guid _AccrualTypeId;
		[CProperty(ColumnPath ="AccrualTypeId")]
		public Guid AccrualTypeId
		{
			get{return _AccrualTypeId;}
			set
			{
				_AccrualTypeId = value;
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
		private DateTime _EndDate;
		[CProperty(ColumnPath ="EndDate")]
		public DateTime EndDate
		{
			get{return _EndDate;}
			set
			{
				_EndDate = value;
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
		private bool _IsActive;
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive
		{
			get{return _IsActive;}
			set
			{
				_IsActive = value;
				OnPropertyChanged();
			}
		}
		private bool _IsAutomatic;
		[CProperty(ColumnPath ="IsAutomatic")]
		public bool IsAutomatic
		{
			get{return _IsAutomatic;}
			set
			{
				_IsAutomatic = value;
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
		private bool _NeedApproval;
		[CProperty(ColumnPath ="NeedApproval")]
		public bool NeedApproval
		{
			get{return _NeedApproval;}
			set
			{
				_NeedApproval = value;
				OnPropertyChanged();
			}
		}
		private string _Notes;
		[CProperty(ColumnPath ="Notes")]
		public string Notes
		{
			get{return _Notes;}
			set
			{
				_Notes = value;
				OnPropertyChanged();
			}
		}
		private Guid _PayForSchemaId;
		[CProperty(ColumnPath ="PayForSchemaId")]
		public Guid PayForSchemaId
		{
			get{return _PayForSchemaId;}
			set
			{
				_PayForSchemaId = value;
				OnPropertyChanged();
			}
		}
		private string _PaymentTargetColumnCaption;
		[CProperty(ColumnPath ="PaymentTargetColumnCaption")]
		public string PaymentTargetColumnCaption
		{
			get{return _PaymentTargetColumnCaption;}
			set
			{
				_PaymentTargetColumnCaption = value;
				OnPropertyChanged();
			}
		}
		private string _PaymentTargetColumnFilter;
		[CProperty(ColumnPath ="PaymentTargetColumnFilter")]
		public string PaymentTargetColumnFilter
		{
			get{return _PaymentTargetColumnFilter;}
			set
			{
				_PaymentTargetColumnFilter = value;
				OnPropertyChanged();
			}
		}
		private string _PaymentTargetColumnPath;
		[CProperty(ColumnPath ="PaymentTargetColumnPath")]
		public string PaymentTargetColumnPath
		{
			get{return _PaymentTargetColumnPath;}
			set
			{
				_PaymentTargetColumnPath = value;
				OnPropertyChanged();
			}
		}
		private Guid _PeriodColumnUId;
		[CProperty(ColumnPath ="PeriodColumnUId")]
		public Guid PeriodColumnUId
		{
			get{return _PeriodColumnUId;}
			set
			{
				_PeriodColumnUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PeriodTypeId;
		[CProperty(ColumnPath ="PeriodTypeId")]
		public Guid PeriodTypeId
		{
			get{return _PeriodTypeId;}
			set
			{
				_PeriodTypeId = value;
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
		private string _QueryCondition;
		[CProperty(ColumnPath ="QueryCondition")]
		public string QueryCondition
		{
			get{return _QueryCondition;}
			set
			{
				_QueryCondition = value;
				OnPropertyChanged();
			}
		}
		private DateTime _StartDate;
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate
		{
			get{return _StartDate;}
			set
			{
				_StartDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _TypeId;
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId
		{
			get{return _TypeId;}
			set
			{
				_TypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ValueColumnUId;
		[CProperty(ColumnPath ="ValueColumnUId")]
		public Guid ValueColumnUId
		{
			get{return _ValueColumnUId;}
			set
			{
				_ValueColumnUId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="AccrualMethod:AccrualMethodId")]
		public AccrualMethod AccrualMethod { get; set; }
		[CProperty(Navigation ="AccrualType:AccrualTypeId")]
		public AccrualType AccrualType { get; set; }
		[CProperty(Navigation ="BonusRuleType:TypeId")]
		public BonusRuleType Type { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="PeriodType:PeriodTypeId")]
		public PeriodType PeriodType { get; set; }
		[CProperty(Navigation ="VwSysSchemaInfo:PayForSchemaId")]
		public VwSysSchemaInfo PayForSchema { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Bonus:CalculationRuleId")]
		public virtual ICollection<Bonus> BonusByCalculationRule { get; set; }
		[CProperty(Association ="BonusQueue:PaymentRuleId")]
		public virtual ICollection<BonusQueue> BonusQueueByPaymentRule { get; set; }
		[CProperty(Association ="InvoiceAccrueRole:PaymentRuleId")]
		public virtual ICollection<InvoiceAccrueRole> InvoiceAccrueRoleByPaymentRule { get; set; }
		[CProperty(Association ="PaymentRuleAccrualValue:PaymentRuleId")]
		public virtual ICollection<PaymentRuleAccrualValue> PaymentRuleAccrualValueByPaymentRule { get; set; }
		[CProperty(Association ="PaymentRuleFile:PaymentRuleId")]
		public virtual ICollection<PaymentRuleFile> PaymentRuleFileByPaymentRule { get; set; }
		[CProperty(Association ="PaymentRuleInFolder:PaymentRuleId")]
		public virtual ICollection<PaymentRuleInFolder> PaymentRuleInFolderByPaymentRule { get; set; }
		[CProperty(Association ="PaymentRuleInTag:EntityId")]
		public virtual ICollection<PaymentRuleInTag> PaymentRuleInTagByEntity { get; set; }
		[CProperty(Association ="VwBonusInRequest:CalculationRuleId")]
		public virtual ICollection<VwBonusInRequest> VwBonusInRequestByCalculationRule { get; set; }
		#endregion
	}
}
