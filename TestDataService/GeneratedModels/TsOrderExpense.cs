using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TsOrderExpense")]
	public class TsOrderExpense : BaseEntity
	{
		#region Values
		private string _AccountComment;
		[CProperty(ColumnPath ="AccountComment")]
		public string AccountComment
		{
			get{return _AccountComment;}
			set
			{
				_AccountComment = value;
				OnPropertyChanged();
			}
		}
		private Guid _AccoutVisaId;
		[CProperty(ColumnPath ="AccoutVisaId")]
		public Guid AccoutVisaId
		{
			get{return _AccoutVisaId;}
			set
			{
				_AccoutVisaId = value;
				OnPropertyChanged();
			}
		}
		private decimal _Amount;
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount
		{
			get{return _Amount;}
			set
			{
				_Amount = value;
				OnPropertyChanged();
			}
		}
		private Guid _CalculateMethodId;
		[CProperty(ColumnPath ="CalculateMethodId")]
		public Guid CalculateMethodId
		{
			get{return _CalculateMethodId;}
			set
			{
				_CalculateMethodId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ClientId;
		[CProperty(ColumnPath ="ClientId")]
		public Guid ClientId
		{
			get{return _ClientId;}
			set
			{
				_ClientId = value;
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
		private DateTime _ExpenseDate;
		[CProperty(ColumnPath ="ExpenseDate")]
		public DateTime ExpenseDate
		{
			get{return _ExpenseDate;}
			set
			{
				_ExpenseDate = value;
				OnPropertyChanged();
			}
		}
		private string _FinanceComment;
		[CProperty(ColumnPath ="FinanceComment")]
		public string FinanceComment
		{
			get{return _FinanceComment;}
			set
			{
				_FinanceComment = value;
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
		private Guid _InvoiceOwnerId;
		[CProperty(ColumnPath ="InvoiceOwnerId")]
		public Guid InvoiceOwnerId
		{
			get{return _InvoiceOwnerId;}
			set
			{
				_InvoiceOwnerId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _InvoicePaidOn;
		[CProperty(ColumnPath ="InvoicePaidOn")]
		public DateTime InvoicePaidOn
		{
			get{return _InvoicePaidOn;}
			set
			{
				_InvoicePaidOn = value;
				OnPropertyChanged();
			}
		}
		private bool _IsRecordLocked;
		[CProperty(ColumnPath ="IsRecordLocked")]
		public bool IsRecordLocked
		{
			get{return _IsRecordLocked;}
			set
			{
				_IsRecordLocked = value;
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
		private string _Note;
		[CProperty(ColumnPath ="Note")]
		public string Note
		{
			get{return _Note;}
			set
			{
				_Note = value;
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
		private Guid _PartnerId;
		[CProperty(ColumnPath ="PartnerId")]
		public Guid PartnerId
		{
			get{return _PartnerId;}
			set
			{
				_PartnerId = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryAmount;
		[CProperty(ColumnPath ="PrimaryAmount")]
		public decimal PrimaryAmount
		{
			get{return _PrimaryAmount;}
			set
			{
				_PrimaryAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryAmountPlan;
		[CProperty(ColumnPath ="PrimaryAmountPlan")]
		public decimal PrimaryAmountPlan
		{
			get{return _PrimaryAmountPlan;}
			set
			{
				_PrimaryAmountPlan = value;
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
		private string _Products;
		[CProperty(ColumnPath ="Products")]
		public string Products
		{
			get{return _Products;}
			set
			{
				_Products = value;
				OnPropertyChanged();
			}
		}
		private Guid _StatusId;
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId
		{
			get{return _StatusId;}
			set
			{
				_StatusId = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:PartnerId")]
		public Account Partner { get; set; }
		[CProperty(Navigation ="Account:ClientId")]
		public Account Client { get; set; }
		[CProperty(Navigation ="AccountExpenseVisa:AccoutVisaId")]
		public AccountExpenseVisa AccoutVisa { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:InvoiceOwnerId")]
		public Contact InvoiceOwner { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="FormulasForCalculatingCosts:CalculateMethodId")]
		public FormulasForCalculatingCosts CalculateMethod { get; set; }
		[CProperty(Navigation ="Invoice:InvoiceId")]
		public Invoice Invoice { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="TsOrderExpenseStatus:StatusId")]
		public TsOrderExpenseStatus Status { get; set; }
		[CProperty(Navigation ="TsOrderExpenseType:TypeId")]
		public TsOrderExpenseType Type { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="TsOrderExpenseFile:TsOrderExpenseId")]
		public virtual ICollection<TsOrderExpenseFile> TsOrderExpenseFileByTsOrderExpense { get; set; }
		[CProperty(Association ="TsOrderExpenseHistory:TsOrderExpenseId")]
		public virtual ICollection<TsOrderExpenseHistory> TsOrderExpenseHistoryByTsOrderExpense { get; set; }
		[CProperty(Association ="TsOrderExpenseInFolder:TsOrderExpenseId")]
		public virtual ICollection<TsOrderExpenseInFolder> TsOrderExpenseInFolderByTsOrderExpense { get; set; }
		[CProperty(Association ="TsOrderExpenseInTag:EntityId")]
		public virtual ICollection<TsOrderExpenseInTag> TsOrderExpenseInTagByEntity { get; set; }
		[CProperty(Association ="TsOrderExpenseProduct:TsOrderExpenseId")]
		public virtual ICollection<TsOrderExpenseProduct> TsOrderExpenseProductByTsOrderExpense { get; set; }
		[CProperty(Association ="TsOrderExpenseVisa:TsOrderExpenseId")]
		public virtual ICollection<TsOrderExpenseVisa> TsOrderExpenseVisaByTsOrderExpense { get; set; }
		[CProperty(Association ="VwOrderExpenseProduct:TsOrderExpenseId")]
		public virtual ICollection<VwOrderExpenseProduct> VwOrderExpenseProductByTsOrderExpense { get; set; }
		[CProperty(Association ="VwPortalOrderExpenseProduct:TsOrderExpenseId")]
		public virtual ICollection<VwPortalOrderExpenseProduct> VwPortalOrderExpenseProductByTsOrderExpense { get; set; }
		#endregion
	}
}
