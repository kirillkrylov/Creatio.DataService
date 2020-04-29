using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Payments")]
	public class Payments : BaseEntity
	{
		#region Values
		private decimal _AmountWithOutTax;
		[CProperty(ColumnPath ="AmountWithOutTax")]
		public decimal AmountWithOutTax
		{
			get{return _AmountWithOutTax;}
			set
			{
				_AmountWithOutTax = value;
				OnPropertyChanged();
			}
		}
		private decimal _AmountWithTax;
		[CProperty(ColumnPath ="AmountWithTax")]
		public decimal AmountWithTax
		{
			get{return _AmountWithTax;}
			set
			{
				_AmountWithTax = value;
				OnPropertyChanged();
			}
		}
		private string _CheckingAccount;
		[CProperty(ColumnPath ="CheckingAccount")]
		public string CheckingAccount
		{
			get{return _CheckingAccount;}
			set
			{
				_CheckingAccount = value;
				OnPropertyChanged();
			}
		}
		private string _ContractNumber;
		[CProperty(ColumnPath ="ContractNumber")]
		public string ContractNumber
		{
			get{return _ContractNumber;}
			set
			{
				_ContractNumber = value;
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
		private DateTime _OperationDate;
		[CProperty(ColumnPath ="OperationDate")]
		public DateTime OperationDate
		{
			get{return _OperationDate;}
			set
			{
				_OperationDate = value;
				OnPropertyChanged();
			}
		}
		private string _Payer;
		[CProperty(ColumnPath ="Payer")]
		public string Payer
		{
			get{return _Payer;}
			set
			{
				_Payer = value;
				OnPropertyChanged();
			}
		}
		private string _PayerAccount;
		[CProperty(ColumnPath ="PayerAccount")]
		public string PayerAccount
		{
			get{return _PayerAccount;}
			set
			{
				_PayerAccount = value;
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
		private string _PurposeOfPayment;
		[CProperty(ColumnPath ="PurposeOfPayment")]
		public string PurposeOfPayment
		{
			get{return _PurposeOfPayment;}
			set
			{
				_PurposeOfPayment = value;
				OnPropertyChanged();
			}
		}
		private string _Recipient;
		[CProperty(ColumnPath ="Recipient")]
		public string Recipient
		{
			get{return _Recipient;}
			set
			{
				_Recipient = value;
				OnPropertyChanged();
			}
		}
		private decimal _TaxPercent;
		[CProperty(ColumnPath ="TaxPercent")]
		public decimal TaxPercent
		{
			get{return _TaxPercent;}
			set
			{
				_TaxPercent = value;
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
		#endregion

		#region Associations
		[CProperty(Association ="InvoicePayments:PaymentId")]
		public virtual ICollection<InvoicePayments> InvoicePaymentsByPayment { get; set; }
		[CProperty(Association ="PaymentsFile:PaymentsId")]
		public virtual ICollection<PaymentsFile> PaymentsFileByPayments { get; set; }
		[CProperty(Association ="PaymentsInFolder:PaymentsId")]
		public virtual ICollection<PaymentsInFolder> PaymentsInFolderByPayments { get; set; }
		[CProperty(Association ="PaymentsInTag:EntityId")]
		public virtual ICollection<PaymentsInTag> PaymentsInTagByEntity { get; set; }
		#endregion
	}
}
