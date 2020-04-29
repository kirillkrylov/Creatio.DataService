using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DeduplicateExecLog")]
	public class DeduplicateExecLog : BaseEntity
	{
		#region Values
		private DateTime _CompletedOn;
		[CProperty(ColumnPath ="CompletedOn")]
		public DateTime CompletedOn
		{
			get{return _CompletedOn;}
			set
			{
				_CompletedOn = value;
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
		private DateTime _ExecutedOn;
		[CProperty(ColumnPath ="ExecutedOn")]
		public DateTime ExecutedOn
		{
			get{return _ExecutedOn;}
			set
			{
				_ExecutedOn = value;
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
		private string _ProcedureName;
		[CProperty(ColumnPath ="ProcedureName")]
		public string ProcedureName
		{
			get{return _ProcedureName;}
			set
			{
				_ProcedureName = value;
				OnPropertyChanged();
			}
		}
		private int _SqlErrorCode;
		[CProperty(ColumnPath ="SqlErrorCode")]
		public int SqlErrorCode
		{
			get{return _SqlErrorCode;}
			set
			{
				_SqlErrorCode = value;
				OnPropertyChanged();
			}
		}
		private string _SqlErrorMessage;
		[CProperty(ColumnPath ="SqlErrorMessage")]
		public string SqlErrorMessage
		{
			get{return _SqlErrorMessage;}
			set
			{
				_SqlErrorMessage = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		#endregion

		#region Associations
		[CProperty(Association ="DeduplicateExecLocker:ConversationId")]
		public virtual ICollection<DeduplicateExecLocker> DeduplicateExecLockerByConversation { get; set; }
		#endregion
	}
}
