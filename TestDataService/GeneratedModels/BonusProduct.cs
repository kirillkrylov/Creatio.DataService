using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BonusProduct")]
	public class BonusProduct : BaseEntity
	{
		#region Values
		private Guid _BonusCategoryId;
		[CProperty(ColumnPath ="BonusCategoryId")]
		public Guid BonusCategoryId
		{
			get{return _BonusCategoryId;}
			set
			{
				_BonusCategoryId = value;
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
		private Guid _InvoiceAccrueRoleId;
		[CProperty(ColumnPath ="InvoiceAccrueRoleId")]
		public Guid InvoiceAccrueRoleId
		{
			get{return _InvoiceAccrueRoleId;}
			set
			{
				_InvoiceAccrueRoleId = value;
				OnPropertyChanged();
			}
		}
		private Guid _InvoiceProductId;
		[CProperty(ColumnPath ="InvoiceProductId")]
		public Guid InvoiceProductId
		{
			get{return _InvoiceProductId;}
			set
			{
				_InvoiceProductId = value;
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
		private decimal _ProductMargin;
		[CProperty(ColumnPath ="ProductMargin")]
		public decimal ProductMargin
		{
			get{return _ProductMargin;}
			set
			{
				_ProductMargin = value;
				OnPropertyChanged();
			}
		}
		private Guid _SaleTypeId;
		[CProperty(ColumnPath ="SaleTypeId")]
		public Guid SaleTypeId
		{
			get{return _SaleTypeId;}
			set
			{
				_SaleTypeId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="BonusCategory:BonusCategoryId")]
		public BonusCategory BonusCategory { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="InvoiceAccrueRole:InvoiceAccrueRoleId")]
		public InvoiceAccrueRole InvoiceAccrueRole { get; set; }
		[CProperty(Navigation ="InvoiceProduct:InvoiceProductId")]
		public InvoiceProduct InvoiceProduct { get; set; }
		[CProperty(Navigation ="SaleType:SaleTypeId")]
		public SaleType SaleType { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
