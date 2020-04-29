using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BonusQueue")]
	public class BonusQueue : BaseEntity
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
		private Guid _CurrencyId;
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId
		{
			get{return _CurrencyId;}
			set
			{
				_CurrencyId = value;
				OnPropertyChanged();
			}
		}
		private decimal _CurrencyRate;
		[CProperty(ColumnPath ="CurrencyRate")]
		public decimal CurrencyRate
		{
			get{return _CurrencyRate;}
			set
			{
				_CurrencyRate = value;
				OnPropertyChanged();
			}
		}
		private Guid _EmployeeId;
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId
		{
			get{return _EmployeeId;}
			set
			{
				_EmployeeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _EntitySchemaUId;
		[CProperty(ColumnPath ="EntitySchemaUId")]
		public Guid EntitySchemaUId
		{
			get{return _EntitySchemaUId;}
			set
			{
				_EntitySchemaUId = value;
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
		private bool _IsProcessed;
		[CProperty(ColumnPath ="IsProcessed")]
		public bool IsProcessed
		{
			get{return _IsProcessed;}
			set
			{
				_IsProcessed = value;
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
		private Guid _OperationKey;
		[CProperty(ColumnPath ="OperationKey")]
		public Guid OperationKey
		{
			get{return _OperationKey;}
			set
			{
				_OperationKey = value;
				OnPropertyChanged();
			}
		}
		private Guid _PaymentRuleId;
		[CProperty(ColumnPath ="PaymentRuleId")]
		public Guid PaymentRuleId
		{
			get{return _PaymentRuleId;}
			set
			{
				_PaymentRuleId = value;
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
		private Guid _RecordId;
		[CProperty(ColumnPath ="RecordId")]
		public Guid RecordId
		{
			get{return _RecordId;}
			set
			{
				_RecordId = value;
				OnPropertyChanged();
			}
		}
		private decimal _Value;
		[CProperty(ColumnPath ="Value")]
		public decimal Value
		{
			get{return _Value;}
			set
			{
				_Value = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="Employee:EmployeeId")]
		public Employee Employee { get; set; }
		[CProperty(Navigation ="PaymentRule:PaymentRuleId")]
		public PaymentRule PaymentRule { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
