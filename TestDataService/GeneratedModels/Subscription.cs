using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Subscription")]
	public class Subscription : BaseEntity
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
		private DateTime _ActivationDate;
		[CProperty(ColumnPath ="ActivationDate")]
		public DateTime ActivationDate
		{
			get{return _ActivationDate;}
			set
			{
				_ActivationDate = value;
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
		private string _Number;
		[CProperty(ColumnPath ="Number")]
		public string Number
		{
			get{return _Number;}
			set
			{
				_Number = value;
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
		private DateTime _RenewalDate;
		[CProperty(ColumnPath ="RenewalDate")]
		public DateTime RenewalDate
		{
			get{return _RenewalDate;}
			set
			{
				_RenewalDate = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SubscriptionStatus:StatusId")]
		public SubscriptionStatus Status { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ConfItem:SubscriptionId")]
		public virtual ICollection<ConfItem> ConfItemBySubscription { get; set; }
		[CProperty(Association ="InternalRequest:CIDId")]
		public virtual ICollection<InternalRequest> InternalRequestByCID { get; set; }
		[CProperty(Association ="OrderProduct:SubscriptionId")]
		public virtual ICollection<OrderProduct> OrderProductBySubscription { get; set; }
		[CProperty(Association ="ProductForLicGenerator:SubscriptionId")]
		public virtual ICollection<ProductForLicGenerator> ProductForLicGeneratorBySubscription { get; set; }
		[CProperty(Association ="ProductInSubscription:SubscriptionId")]
		public virtual ICollection<ProductInSubscription> ProductInSubscriptionBySubscription { get; set; }
		[CProperty(Association ="SubscriptionExpirationEmailHistory:SubscriptionId")]
		public virtual ICollection<SubscriptionExpirationEmailHistory> SubscriptionExpirationEmailHistoryBySubscription { get; set; }
		[CProperty(Association ="SubscriptionInFolder:SubscriptionId")]
		public virtual ICollection<SubscriptionInFolder> SubscriptionInFolderBySubscription { get; set; }
		[CProperty(Association ="VwEARequestLog:SubscriptionId")]
		public virtual ICollection<VwEARequestLog> VwEARequestLogBySubscription { get; set; }
		[CProperty(Association ="VwProductBalance:SubscriptionId")]
		public virtual ICollection<VwProductBalance> VwProductBalanceBySubscription { get; set; }
		[CProperty(Association ="VwTransaction:SubscriptionId")]
		public virtual ICollection<VwTransaction> VwTransactionBySubscription { get; set; }
		[CProperty(Association ="VwTSLicProduct:SubscriptionId")]
		public virtual ICollection<VwTSLicProduct> VwTSLicProductBySubscription { get; set; }
		[CProperty(Association ="VwTSLicProductArchive:SubscriptionId")]
		public virtual ICollection<VwTSLicProductArchive> VwTSLicProductArchiveBySubscription { get; set; }
		[CProperty(Association ="VwTSSLA:SubscriptionId")]
		public virtual ICollection<VwTSSLA> VwTSSLABySubscription { get; set; }
		[CProperty(Association ="VwTSSLAArchive:SubscriptionId")]
		public virtual ICollection<VwTSSLAArchive> VwTSSLAArchiveBySubscription { get; set; }
		#endregion
	}
}
