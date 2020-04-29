using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "MessageNotifier")]
	public class MessageNotifier : BaseEntity
	{
		#region Values
		private Guid _AliasNotifierId;
		[CProperty(ColumnPath ="AliasNotifierId")]
		public Guid AliasNotifierId
		{
			get{return _AliasNotifierId;}
			set
			{
				_AliasNotifierId = value;
				OnPropertyChanged();
			}
		}
		private string _ClassName;
		[CProperty(ColumnPath ="ClassName")]
		public string ClassName
		{
			get{return _ClassName;}
			set
			{
				_ClassName = value;
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
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
				OnPropertyChanged();
			}
		}
		private string _HistoryV2ClassName;
		[CProperty(ColumnPath ="HistoryV2ClassName")]
		public string HistoryV2ClassName
		{
			get{return _HistoryV2ClassName;}
			set
			{
				_HistoryV2ClassName = value;
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
		private Guid _SchemaUId;
		[CProperty(ColumnPath ="SchemaUId")]
		public Guid SchemaUId
		{
			get{return _SchemaUId;}
			set
			{
				_SchemaUId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="MessageNotifier:AliasNotifierId")]
		public MessageNotifier AliasNotifier { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="CaseMessageHistory:MessageNotifierId")]
		public virtual ICollection<CaseMessageHistory> CaseMessageHistoryByMessageNotifier { get; set; }
		[CProperty(Association ="LeadMessageHistory:MessageNotifierId")]
		public virtual ICollection<LeadMessageHistory> LeadMessageHistoryByMessageNotifier { get; set; }
		[CProperty(Association ="ListenerByNotifier:MessageNotifierId")]
		public virtual ICollection<ListenerByNotifier> ListenerByNotifierByMessageNotifier { get; set; }
		[CProperty(Association ="MessageNotifier:AliasNotifierId")]
		public virtual ICollection<MessageNotifier> MessageNotifierByAliasNotifier { get; set; }
		[CProperty(Association ="MessageNotifierBySection:MessageNotifierId")]
		public virtual ICollection<MessageNotifierBySection> MessageNotifierBySectionByMessageNotifier { get; set; }
		[CProperty(Association ="MktgActivityMessageHistory:MessageNotifierId")]
		public virtual ICollection<MktgActivityMessageHistory> MktgActivityMessageHistoryByMessageNotifier { get; set; }
		[CProperty(Association ="OpportunityMessageHistory:MessageNotifierId")]
		public virtual ICollection<OpportunityMessageHistory> OpportunityMessageHistoryByMessageNotifier { get; set; }
		[CProperty(Association ="VwMobileCaseMessageHistory:MessageNotifierId")]
		public virtual ICollection<VwMobileCaseMessageHistory> VwMobileCaseMessageHistoryByMessageNotifier { get; set; }
		#endregion
	}
}
