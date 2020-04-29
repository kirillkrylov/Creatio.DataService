using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ProductCoefficients")]
	public class ProductCoefficients : BaseEntity
	{
		#region Values
		private Guid _BonusCategoriesId;
		[CProperty(ColumnPath ="BonusCategoriesId")]
		public Guid BonusCategoriesId
		{
			get{return _BonusCategoriesId;}
			set
			{
				_BonusCategoriesId = value;
				OnPropertyChanged();
			}
		}
		private decimal _Coefficient;
		[CProperty(ColumnPath ="Coefficient")]
		public decimal Coefficient
		{
			get{return _Coefficient;}
			set
			{
				_Coefficient = value;
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
		private Guid _VersionSMJId;
		[CProperty(ColumnPath ="VersionSMJId")]
		public Guid VersionSMJId
		{
			get{return _VersionSMJId;}
			set
			{
				_VersionSMJId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="BonusCategory:BonusCategoriesId")]
		public BonusCategory BonusCategories { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SaleType:SaleTypeId")]
		public SaleType SaleType { get; set; }
		[CProperty(Navigation ="TsVersionSMJ:VersionSMJId")]
		public TsVersionSMJ VersionSMJ { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
