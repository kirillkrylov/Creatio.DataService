using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BeesenderChatMessage")]
	public class BeesenderChatMessage : BaseEntity
	{
		#region Values
		private string _Buttons;
		[CProperty(ColumnPath ="Buttons")]
		public string Buttons
		{
			get{return _Buttons;}
			set
			{
				_Buttons = value;
				OnPropertyChanged();
			}
		}
		private Guid _ChatId;
		[CProperty(ColumnPath ="ChatId")]
		public Guid ChatId
		{
			get{return _ChatId;}
			set
			{
				_ChatId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ClientContactId;
		[CProperty(ColumnPath ="ClientContactId")]
		public Guid ClientContactId
		{
			get{return _ClientContactId;}
			set
			{
				_ClientContactId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ClientId;
		[CProperty(ColumnPath ="ClientId")]
		public Guid ClientId
		{
			get{return _ClientId;}
			set
			{
				_ClientId = value;
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
		private string _InternalId;
		[CProperty(ColumnPath ="InternalId")]
		public string InternalId
		{
			get{return _InternalId;}
			set
			{
				_InternalId = value;
				OnPropertyChanged();
			}
		}
		private int _MessageType;
		[CProperty(ColumnPath ="MessageType")]
		public int MessageType
		{
			get{return _MessageType;}
			set
			{
				_MessageType = value;
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
		private Guid _OperatorContactId;
		[CProperty(ColumnPath ="OperatorContactId")]
		public Guid OperatorContactId
		{
			get{return _OperatorContactId;}
			set
			{
				_OperatorContactId = value;
				OnPropertyChanged();
			}
		}
		private Guid _OperatorId;
		[CProperty(ColumnPath ="OperatorId")]
		public Guid OperatorId
		{
			get{return _OperatorId;}
			set
			{
				_OperatorId = value;
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
		private bool _SendByOperator;
		[CProperty(ColumnPath ="SendByOperator")]
		public bool SendByOperator
		{
			get{return _SendByOperator;}
			set
			{
				_SendByOperator = value;
				OnPropertyChanged();
			}
		}
		private string _Text;
		[CProperty(ColumnPath ="Text")]
		public string Text
		{
			get{return _Text;}
			set
			{
				_Text = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="BeesenderChat:ChatId")]
		public BeesenderChat Chat { get; set; }
		[CProperty(Navigation ="BeesenderClient:ClientId")]
		public BeesenderClient Client { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OperatorContactId")]
		public Contact OperatorContact { get; set; }
		[CProperty(Navigation ="Contact:ClientContactId")]
		public Contact ClientContact { get; set; }
		[CProperty(Navigation ="SysAdminUnit:OperatorId")]
		public SysAdminUnit Operator { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
