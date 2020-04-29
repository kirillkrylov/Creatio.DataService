using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ClientARRInPeriod")]
	public class ClientARRInPeriod : BaseEntity
	{
		#region Values
		private Guid _AccountId;
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId
		{
			get{return _AccountId;}
			set
			{
				_AccountId = value;
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
		private Guid _PeriodId;
		[CProperty(ColumnPath ="PeriodId")]
		public Guid PeriodId
		{
			get{return _PeriodId;}
			set
			{
				_PeriodId = value;
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
		private Guid _ProductKindId;
		[CProperty(ColumnPath ="ProductKindId")]
		public Guid ProductKindId
		{
			get{return _ProductKindId;}
			set
			{
				_ProductKindId = value;
				OnPropertyChanged();
			}
		}
		private decimal _SaaSMetricsAmount;
		[CProperty(ColumnPath ="SaaSMetricsAmount")]
		public decimal SaaSMetricsAmount
		{
			get{return _SaaSMetricsAmount;}
			set
			{
				_SaaSMetricsAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _SubscriptionProductAmount;
		[CProperty(ColumnPath ="SubscriptionProductAmount")]
		public decimal SubscriptionProductAmount
		{
			get{return _SubscriptionProductAmount;}
			set
			{
				_SubscriptionProductAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _TotalAmount;
		[CProperty(ColumnPath ="TotalAmount")]
		public decimal TotalAmount
		{
			get{return _TotalAmount;}
			set
			{
				_TotalAmount = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Period:PeriodId")]
		public Period Period { get; set; }
		[CProperty(Navigation ="ProductKind:ProductKindId")]
		public ProductKind ProductKind { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
