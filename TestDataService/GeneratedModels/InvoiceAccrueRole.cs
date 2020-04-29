using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "InvoiceAccrueRole")]
	public class InvoiceAccrueRole : BaseEntity
	{
		#region Values
		private decimal _AccrualPercent;
		[CProperty(ColumnPath ="AccrualPercent")]
		public decimal AccrualPercent
		{
			get{return _AccrualPercent;}
			set
			{
				_AccrualPercent = value;
				OnPropertyChanged();
			}
		}
		private Guid _BonusAccrueContactRoleId;
		[CProperty(ColumnPath ="BonusAccrueContactRoleId")]
		public Guid BonusAccrueContactRoleId
		{
			get{return _BonusAccrueContactRoleId;}
			set
			{
				_BonusAccrueContactRoleId = value;
				OnPropertyChanged();
			}
		}
		private decimal _BonusMargin;
		[CProperty(ColumnPath ="BonusMargin")]
		public decimal BonusMargin
		{
			get{return _BonusMargin;}
			set
			{
				_BonusMargin = value;
				OnPropertyChanged();
			}
		}
		private string _Comment;
		[CProperty(ColumnPath ="Comment")]
		public string Comment
		{
			get{return _Comment;}
			set
			{
				_Comment = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContactId;
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId
		{
			get{return _ContactId;}
			set
			{
				_ContactId = value;
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
		private bool _ExtraBonus;
		[CProperty(ColumnPath ="ExtraBonus")]
		public bool ExtraBonus
		{
			get{return _ExtraBonus;}
			set
			{
				_ExtraBonus = value;
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
		private bool _SetAmountManually;
		[CProperty(ColumnPath ="SetAmountManually")]
		public bool SetAmountManually
		{
			get{return _SetAmountManually;}
			set
			{
				_SetAmountManually = value;
				OnPropertyChanged();
			}
		}
		private decimal _TargetMargin;
		[CProperty(ColumnPath ="TargetMargin")]
		public decimal TargetMargin
		{
			get{return _TargetMargin;}
			set
			{
				_TargetMargin = value;
				OnPropertyChanged();
			}
		}
		private Guid _TeamLeaderId;
		[CProperty(ColumnPath ="TeamLeaderId")]
		public Guid TeamLeaderId
		{
			get{return _TeamLeaderId;}
			set
			{
				_TeamLeaderId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="BonusAccrueContactRole:BonusAccrueContactRoleId")]
		public BonusAccrueContactRole BonusAccrueContactRole { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Contact:TeamLeaderId")]
		public Contact TeamLeader { get; set; }
		[CProperty(Navigation ="Invoice:InvoiceId")]
		public Invoice Invoice { get; set; }
		[CProperty(Navigation ="PaymentRule:PaymentRuleId")]
		public PaymentRule PaymentRule { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BonusProduct:InvoiceAccrueRoleId")]
		public virtual ICollection<BonusProduct> BonusProductByInvoiceAccrueRole { get; set; }
		#endregion
	}
}
