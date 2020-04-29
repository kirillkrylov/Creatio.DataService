using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DeduplicateExecLocker")]
	public class DeduplicateExecLocker : BaseEntity
	{
		#region Values
		private Guid _ConversationId;
		[CProperty(ColumnPath ="ConversationId")]
		public Guid ConversationId
		{
			get{return _ConversationId;}
			set
			{
				_ConversationId = value;
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
		private string _EntitySchemaName;
		[CProperty(ColumnPath ="EntitySchemaName")]
		public string EntitySchemaName
		{
			get{return _EntitySchemaName;}
			set
			{
				_EntitySchemaName = value;
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
		private bool _IsInProgress;
		[CProperty(ColumnPath ="IsInProgress")]
		public bool IsInProgress
		{
			get{return _IsInProgress;}
			set
			{
				_IsInProgress = value;
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
		private Guid _OperationId;
		[CProperty(ColumnPath ="OperationId")]
		public Guid OperationId
		{
			get{return _OperationId;}
			set
			{
				_OperationId = value;
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
		[CProperty(Navigation ="DeduplicateExecLog:ConversationId")]
		public DeduplicateExecLog Conversation { get; set; }
		[CProperty(Navigation ="DeduplicateOperation:OperationId")]
		public DeduplicateOperation Operation { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
