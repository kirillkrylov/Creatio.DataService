using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwOrderExpenseProduct")]
	public class VwOrderExpenseProduct : BaseEntity
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
		private Guid _InvoiceId;
		[CProperty(ColumnPath ="InvoiceId")]
		public Guid InvoiceId
		{
			get{return _InvoiceId;}
			set
			{
				_InvoiceId = value;
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
		private Guid _OrderId;
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId
		{
			get{return _OrderId;}
			set
			{
				_OrderId = value;
				OnPropertyChanged();
			}
		}
		private string _OrderProductName;
		[CProperty(ColumnPath ="OrderProductName")]
		public string OrderProductName
		{
			get{return _OrderProductName;}
			set
			{
				_OrderProductName = value;
				OnPropertyChanged();
			}
		}
		private decimal _OrderProductTotalAmount;
		[CProperty(ColumnPath ="OrderProductTotalAmount")]
		public decimal OrderProductTotalAmount
		{
			get{return _OrderProductTotalAmount;}
			set
			{
				_OrderProductTotalAmount = value;
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
		private Guid _TsOrderExpenseId;
		[CProperty(ColumnPath ="TsOrderExpenseId")]
		public Guid TsOrderExpenseId
		{
			get{return _TsOrderExpenseId;}
			set
			{
				_TsOrderExpenseId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TsOrderExpenseProductId;
		[CProperty(ColumnPath ="TsOrderExpenseProductId")]
		public Guid TsOrderExpenseProductId
		{
			get{return _TsOrderExpenseProductId;}
			set
			{
				_TsOrderExpenseProductId = value;
				OnPropertyChanged();
			}
		}
		private bool _UseInExpense;
		[CProperty(ColumnPath ="UseInExpense")]
		public bool UseInExpense
		{
			get{return _UseInExpense;}
			set
			{
				_UseInExpense = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Invoice:InvoiceId")]
		public Invoice Invoice { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="TsOrderExpense:TsOrderExpenseId")]
		public TsOrderExpense TsOrderExpense { get; set; }
		[CProperty(Navigation ="TsOrderExpenseProduct:TsOrderExpenseProductId")]
		public TsOrderExpenseProduct TsOrderExpenseProduct { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
