using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BeesenderChatConfiguration")]
	public class BeesenderChatConfiguration : BaseEntity
	{
		#region Values
		private bool _CloseChat;
		[CProperty(ColumnPath ="CloseChat")]
		public bool CloseChat
		{
			get{return _CloseChat;}
			set
			{
				_CloseChat = value;
				OnPropertyChanged();
			}
		}
		private int _CloseChatTimeout;
		[CProperty(ColumnPath ="CloseChatTimeout")]
		public int CloseChatTimeout
		{
			get{return _CloseChatTimeout;}
			set
			{
				_CloseChatTimeout = value;
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
		private string _Login;
		[CProperty(ColumnPath ="Login")]
		public string Login
		{
			get{return _Login;}
			set
			{
				_Login = value;
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
		private string _Password;
		[CProperty(ColumnPath ="Password")]
		public string Password
		{
			get{return _Password;}
			set
			{
				_Password = value;
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
		private bool _SaveAfkChats;
		[CProperty(ColumnPath ="SaveAfkChats")]
		public bool SaveAfkChats
		{
			get{return _SaveAfkChats;}
			set
			{
				_SaveAfkChats = value;
				OnPropertyChanged();
			}
		}
		private int _SaveAfkChatTimeout;
		[CProperty(ColumnPath ="SaveAfkChatTimeout")]
		public int SaveAfkChatTimeout
		{
			get{return _SaveAfkChatTimeout;}
			set
			{
				_SaveAfkChatTimeout = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BeesenderChannel:ConfigurationId")]
		public virtual ICollection<BeesenderChannel> BeesenderChannelByConfiguration { get; set; }
		[CProperty(Association ="BeesenderChatConfigurationFile:BeesenderChatConfigurationId")]
		public virtual ICollection<BeesenderChatConfigurationFile> BeesenderChatConfigurationFileByBeesenderChatConfiguration { get; set; }
		[CProperty(Association ="BeesenderOperatorUnit:ChatConfigId")]
		public virtual ICollection<BeesenderOperatorUnit> BeesenderOperatorUnitByChatConfig { get; set; }
		#endregion
	}
}
