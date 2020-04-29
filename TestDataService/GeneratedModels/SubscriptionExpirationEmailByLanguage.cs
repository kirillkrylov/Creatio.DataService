using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SubscriptionExpirationEmailByLanguage")]
	public class SubscriptionExpirationEmailByLanguage : BaseEntity
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
		private string _ErrorMessage;
		[CProperty(ColumnPath ="ErrorMessage")]
		public string ErrorMessage
		{
			get{return _ErrorMessage;}
			set
			{
				_ErrorMessage = value;
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
		private Guid _SubscriptionExpirationEmailHistoryId;
		[CProperty(ColumnPath ="SubscriptionExpirationEmailHistoryId")]
		public Guid SubscriptionExpirationEmailHistoryId
		{
			get{return _SubscriptionExpirationEmailHistoryId;}
			set
			{
				_SubscriptionExpirationEmailHistoryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysLanguageId;
		[CProperty(ColumnPath ="SysLanguageId")]
		public Guid SysLanguageId
		{
			get{return _SysLanguageId;}
			set
			{
				_SysLanguageId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="ActivityStatus:StatusId")]
		public ActivityStatus Status { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SubscriptionExpirationEmailHistory:SubscriptionExpirationEmailHistoryId")]
		public SubscriptionExpirationEmailHistory SubscriptionExpirationEmailHistory { get; set; }
		[CProperty(Navigation ="SysLanguage:SysLanguageId")]
		public SysLanguage SysLanguage { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SubscriptionExpirationReceiver:SubscriptionExpirationEmailByLanguageId")]
		public virtual ICollection<SubscriptionExpirationReceiver> SubscriptionExpirationReceiverBySubscriptionExpirationEmailByLanguage { get; set; }
		#endregion
	}
}
