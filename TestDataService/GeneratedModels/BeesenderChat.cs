using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BeesenderChat")]
	public class BeesenderChat : BaseEntity
	{
		#region Values
		private Guid _CategoryId;
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId
		{
			get{return _CategoryId;}
			set
			{
				_CategoryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ChannelId;
		[CProperty(ColumnPath ="ChannelId")]
		public Guid ChannelId
		{
			get{return _ChannelId;}
			set
			{
				_ChannelId = value;
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
		private bool _Closed;
		[CProperty(ColumnPath ="Closed")]
		public bool Closed
		{
			get{return _Closed;}
			set
			{
				_Closed = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContactId;
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId
		{
			get{return _ContactId;}
			set
			{
				_ContactId = value;
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
		private string _FirstMessage;
		[CProperty(ColumnPath ="FirstMessage")]
		public string FirstMessage
		{
			get{return _FirstMessage;}
			set
			{
				_FirstMessage = value;
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
		private bool _Processing;
		[CProperty(ColumnPath ="Processing")]
		public bool Processing
		{
			get{return _Processing;}
			set
			{
				_Processing = value;
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
		[CProperty(Navigation ="BeesenderChannel:ChannelId")]
		public BeesenderChannel Channel { get; set; }
		[CProperty(Navigation ="BeesenderChatCategory:CategoryId")]
		public BeesenderChatCategory Category { get; set; }
		[CProperty(Navigation ="BeesenderClient:ClientId")]
		public BeesenderClient Client { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Contact:OperatorContactId")]
		public Contact OperatorContact { get; set; }
		[CProperty(Navigation ="SysAdminUnit:OperatorId")]
		public SysAdminUnit Operator { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BeesenderChatFile:BeesenderChatId")]
		public virtual ICollection<BeesenderChatFile> BeesenderChatFileByBeesenderChat { get; set; }
		[CProperty(Association ="BeesenderChatInFolder:BeesenderChatId")]
		public virtual ICollection<BeesenderChatInFolder> BeesenderChatInFolderByBeesenderChat { get; set; }
		[CProperty(Association ="BeesenderChatInTag:EntityId")]
		public virtual ICollection<BeesenderChatInTag> BeesenderChatInTagByEntity { get; set; }
		[CProperty(Association ="BeesenderChatMessage:ChatId")]
		public virtual ICollection<BeesenderChatMessage> BeesenderChatMessageByChat { get; set; }
		#endregion
	}
}
