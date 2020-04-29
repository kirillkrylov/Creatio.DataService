using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "MailServer")]
	public class MailServer : BaseEntity
	{
		#region Values
		private string _Address;
		[CProperty(ColumnPath ="Address")]
		public string Address
		{
			get{return _Address;}
			set
			{
				_Address = value;
				OnPropertyChanged();
			}
		}
		private bool _AllowEmailDownloading;
		[CProperty(ColumnPath ="AllowEmailDownloading")]
		public bool AllowEmailDownloading
		{
			get{return _AllowEmailDownloading;}
			set
			{
				_AllowEmailDownloading = value;
				OnPropertyChanged();
			}
		}
		private bool _AllowEmailSending;
		[CProperty(ColumnPath ="AllowEmailSending")]
		public bool AllowEmailSending
		{
			get{return _AllowEmailSending;}
			set
			{
				_AllowEmailSending = value;
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
		private Guid _EmailProtocolId;
		[CProperty(ColumnPath ="EmailProtocolId")]
		public Guid EmailProtocolId
		{
			get{return _EmailProtocolId;}
			set
			{
				_EmailProtocolId = value;
				OnPropertyChanged();
			}
		}
		private string _ExchangeEmailAddress;
		[CProperty(ColumnPath ="ExchangeEmailAddress")]
		public string ExchangeEmailAddress
		{
			get{return _ExchangeEmailAddress;}
			set
			{
				_ExchangeEmailAddress = value;
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
		private bool _IsExchengeAutodiscover;
		[CProperty(ColumnPath ="IsExchengeAutodiscover")]
		public bool IsExchengeAutodiscover
		{
			get{return _IsExchengeAutodiscover;}
			set
			{
				_IsExchengeAutodiscover = value;
				OnPropertyChanged();
			}
		}
		private bool _IsStartTls;
		[CProperty(ColumnPath ="IsStartTls")]
		public bool IsStartTls
		{
			get{return _IsStartTls;}
			set
			{
				_IsStartTls = value;
				OnPropertyChanged();
			}
		}
		private Guid _LogoId;
		[CProperty(ColumnPath ="LogoId")]
		public Guid LogoId
		{
			get{return _LogoId;}
			set
			{
				_LogoId = value;
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
		private Guid _OAuthApplicationId;
		[CProperty(ColumnPath ="OAuthApplicationId")]
		public Guid OAuthApplicationId
		{
			get{return _OAuthApplicationId;}
			set
			{
				_OAuthApplicationId = value;
				OnPropertyChanged();
			}
		}
		private int _Port;
		[CProperty(ColumnPath ="Port")]
		public int Port
		{
			get{return _Port;}
			set
			{
				_Port = value;
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
		private int _SMTPPort;
		[CProperty(ColumnPath ="SMTPPort")]
		public int SMTPPort
		{
			get{return _SMTPPort;}
			set
			{
				_SMTPPort = value;
				OnPropertyChanged();
			}
		}
		private string _SMTPServerAddress;
		[CProperty(ColumnPath ="SMTPServerAddress")]
		public string SMTPServerAddress
		{
			get{return _SMTPServerAddress;}
			set
			{
				_SMTPServerAddress = value;
				OnPropertyChanged();
			}
		}
		private int _SMTPServerTimeout;
		[CProperty(ColumnPath ="SMTPServerTimeout")]
		public int SMTPServerTimeout
		{
			get{return _SMTPServerTimeout;}
			set
			{
				_SMTPServerTimeout = value;
				OnPropertyChanged();
			}
		}
		private string _Strategy;
		[CProperty(ColumnPath ="Strategy")]
		public string Strategy
		{
			get{return _Strategy;}
			set
			{
				_Strategy = value;
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
		private bool _UseEmailAddressAsLogin;
		[CProperty(ColumnPath ="UseEmailAddressAsLogin")]
		public bool UseEmailAddressAsLogin
		{
			get{return _UseEmailAddressAsLogin;}
			set
			{
				_UseEmailAddressAsLogin = value;
				OnPropertyChanged();
			}
		}
		private bool _UseLogin;
		[CProperty(ColumnPath ="UseLogin")]
		public bool UseLogin
		{
			get{return _UseLogin;}
			set
			{
				_UseLogin = value;
				OnPropertyChanged();
			}
		}
		private bool _UseSSL;
		[CProperty(ColumnPath ="UseSSL")]
		public bool UseSSL
		{
			get{return _UseSSL;}
			set
			{
				_UseSSL = value;
				OnPropertyChanged();
			}
		}
		private bool _UseSSLforSending;
		[CProperty(ColumnPath ="UseSSLforSending")]
		public bool UseSSLforSending
		{
			get{return _UseSSLforSending;}
			set
			{
				_UseSSLforSending = value;
				OnPropertyChanged();
			}
		}
		private bool _UseUserNameAsLogin;
		[CProperty(ColumnPath ="UseUserNameAsLogin")]
		public bool UseUserNameAsLogin
		{
			get{return _UseUserNameAsLogin;}
			set
			{
				_UseUserNameAsLogin = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="EmailProtocol:EmailProtocolId")]
		public EmailProtocol EmailProtocol { get; set; }
		[CProperty(Navigation ="MailServerType:TypeId")]
		public MailServerType Type { get; set; }
		[CProperty(Navigation ="OAuthApplications:OAuthApplicationId")]
		public OAuthApplications OAuthApplication { get; set; }
		[CProperty(Navigation ="SysImage:LogoId")]
		public SysImage Logo { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="MailboxSyncSettings:MailServerId")]
		public virtual ICollection<MailboxSyncSettings> MailboxSyncSettingsByMailServer { get; set; }
		[CProperty(Association ="MailServerDomain:MailServerId")]
		public virtual ICollection<MailServerDomain> MailServerDomainByMailServer { get; set; }
		#endregion
	}
}
