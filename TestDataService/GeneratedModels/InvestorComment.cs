using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "InvestorComment")]
	public class InvestorComment : BaseEntity
	{
		#region Values
		private Guid _ActivityId;
		[CProperty(ColumnPath ="ActivityId")]
		public Guid ActivityId
		{
			get{return _ActivityId;}
			set
			{
				_ActivityId = value;
				OnPropertyChanged();
			}
		}
		private string _BlindCopyRecipient;
		[CProperty(ColumnPath ="BlindCopyRecipient")]
		public string BlindCopyRecipient
		{
			get{return _BlindCopyRecipient;}
			set
			{
				_BlindCopyRecipient = value;
				OnPropertyChanged();
			}
		}
		private string _Body;
		[CProperty(ColumnPath ="Body")]
		public string Body
		{
			get{return _Body;}
			set
			{
				_Body = value;
				OnPropertyChanged();
			}
		}
		private string _Comment;
		[CProperty(ColumnPath ="Comment")]
		public string Comment
		{
			get{return _Comment;}
			set
			{
				_Comment = value;
				OnPropertyChanged();
			}
		}
		private string _CopyRecipient;
		[CProperty(ColumnPath ="CopyRecipient")]
		public string CopyRecipient
		{
			get{return _CopyRecipient;}
			set
			{
				_CopyRecipient = value;
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
		private Guid _InvestorId;
		[CProperty(ColumnPath ="InvestorId")]
		public Guid InvestorId
		{
			get{return _InvestorId;}
			set
			{
				_InvestorId = value;
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
		private string _Subject;
		[CProperty(ColumnPath ="Subject")]
		public string Subject
		{
			get{return _Subject;}
			set
			{
				_Subject = value;
				OnPropertyChanged();
			}
		}
		private Guid _TypeId;
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId
		{
			get{return _TypeId;}
			set
			{
				_TypeId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Activity:ActivityId")]
		public Activity Activity { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Investor:InvestorId")]
		public Investor Investor { get; set; }
		[CProperty(Navigation ="InvestorCommentType:TypeId")]
		public InvestorCommentType Type { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="InvestorCommentFile:InvestorCommentId")]
		public virtual ICollection<InvestorCommentFile> InvestorCommentFileByInvestorComment { get; set; }
		#endregion
	}
}
