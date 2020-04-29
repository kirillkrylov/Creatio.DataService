using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PortalEmailMessage")]
	public class PortalEmailMessage : BaseEntity
	{
		#region Values
		private Guid _CaseMessageHistoryId;
		[CProperty(ColumnPath ="CaseMessageHistoryId")]
		public Guid CaseMessageHistoryId
		{
			get{return _CaseMessageHistoryId;}
			set
			{
				_CaseMessageHistoryId = value;
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
		private bool _IsHtmlBody;
		[CProperty(ColumnPath ="IsHtmlBody")]
		public bool IsHtmlBody
		{
			get{return _IsHtmlBody;}
			set
			{
				_IsHtmlBody = value;
				OnPropertyChanged();
			}
		}
		private Guid _MessageTypeId;
		[CProperty(ColumnPath ="MessageTypeId")]
		public Guid MessageTypeId
		{
			get{return _MessageTypeId;}
			set
			{
				_MessageTypeId = value;
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
		private string _Recipient;
		[CProperty(ColumnPath ="Recipient")]
		public string Recipient
		{
			get{return _Recipient;}
			set
			{
				_Recipient = value;
				OnPropertyChanged();
			}
		}
		private DateTime _SendDate;
		[CProperty(ColumnPath ="SendDate")]
		public DateTime SendDate
		{
			get{return _SendDate;}
			set
			{
				_SendDate = value;
				OnPropertyChanged();
			}
		}
		private string _Sender;
		[CProperty(ColumnPath ="Sender")]
		public string Sender
		{
			get{return _Sender;}
			set
			{
				_Sender = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="CaseMessageHistory:CaseMessageHistoryId")]
		public CaseMessageHistory CaseMessageHistory { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
