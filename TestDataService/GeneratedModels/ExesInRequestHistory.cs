using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ExesInRequestHistory")]
	public class ExesInRequestHistory : BaseEntity
	{
		#region Values
		private decimal _AmountEuro;
		[CProperty(ColumnPath ="AmountEuro")]
		public decimal AmountEuro
		{
			get{return _AmountEuro;}
			set
			{
				_AmountEuro = value;
				OnPropertyChanged();
			}
		}
		private Guid _BaseCurrencyId;
		[CProperty(ColumnPath ="BaseCurrencyId")]
		public Guid BaseCurrencyId
		{
			get{return _BaseCurrencyId;}
			set
			{
				_BaseCurrencyId = value;
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
		private Guid _ExesInRequestId;
		[CProperty(ColumnPath ="ExesInRequestId")]
		public Guid ExesInRequestId
		{
			get{return _ExesInRequestId;}
			set
			{
				_ExesInRequestId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _HistoryDate;
		[CProperty(ColumnPath ="HistoryDate")]
		public DateTime HistoryDate
		{
			get{return _HistoryDate;}
			set
			{
				_HistoryDate = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Currency:BaseCurrencyId")]
		public Currency BaseCurrency { get; set; }
		[CProperty(Navigation ="ExesInRequest:ExesInRequestId")]
		public ExesInRequest ExesInRequest { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
