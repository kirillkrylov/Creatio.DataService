using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwProductBalance")]
	public class VwProductBalance : BaseEntity
	{
		#region Values
		private decimal _Credit;
		[CProperty(ColumnPath ="Credit")]
		public decimal Credit
		{
			get{return _Credit;}
			set
			{
				_Credit = value;
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
		private DateTime _DeactivationDate;
		[CProperty(ColumnPath ="DeactivationDate")]
		public DateTime DeactivationDate
		{
			get{return _DeactivationDate;}
			set
			{
				_DeactivationDate = value;
				OnPropertyChanged();
			}
		}
		private decimal _Debet;
		[CProperty(ColumnPath ="Debet")]
		public decimal Debet
		{
			get{return _Debet;}
			set
			{
				_Debet = value;
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
		private int _Interval;
		[CProperty(ColumnPath ="Interval")]
		public int Interval
		{
			get{return _Interval;}
			set
			{
				_Interval = value;
				OnPropertyChanged();
			}
		}
		private int _IsOnSite;
		[CProperty(ColumnPath ="IsOnSite")]
		public int IsOnSite
		{
			get{return _IsOnSite;}
			set
			{
				_IsOnSite = value;
				OnPropertyChanged();
			}
		}
		private DateTime _LastDate;
		[CProperty(ColumnPath ="LastDate")]
		public DateTime LastDate
		{
			get{return _LastDate;}
			set
			{
				_LastDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProductInSubscriptionId;
		[CProperty(ColumnPath ="ProductInSubscriptionId")]
		public Guid ProductInSubscriptionId
		{
			get{return _ProductInSubscriptionId;}
			set
			{
				_ProductInSubscriptionId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SubscriptionId;
		[CProperty(ColumnPath ="SubscriptionId")]
		public Guid SubscriptionId
		{
			get{return _SubscriptionId;}
			set
			{
				_SubscriptionId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="ProductInSubscription:ProductInSubscriptionId")]
		public ProductInSubscription ProductInSubscription { get; set; }
		[CProperty(Navigation ="Subscription:SubscriptionId")]
		public Subscription Subscription { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
