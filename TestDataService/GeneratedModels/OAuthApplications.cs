using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OAuthApplications")]
	public class OAuthApplications : BaseEntity
	{
		#region Values
		private string _AppClassName;
		[CProperty(ColumnPath ="AppClassName")]
		public string AppClassName
		{
			get{return _AppClassName;}
			set
			{
				_AppClassName = value;
				OnPropertyChanged();
			}
		}
		private string _AuthorizeUrl;
		[CProperty(ColumnPath ="AuthorizeUrl")]
		public string AuthorizeUrl
		{
			get{return _AuthorizeUrl;}
			set
			{
				_AuthorizeUrl = value;
				OnPropertyChanged();
			}
		}
		private string _ClientClassName;
		[CProperty(ColumnPath ="ClientClassName")]
		public string ClientClassName
		{
			get{return _ClientClassName;}
			set
			{
				_ClientClassName = value;
				OnPropertyChanged();
			}
		}
		private string _ClientId;
		[CProperty(ColumnPath ="ClientId")]
		public string ClientId
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
		private int _CredentialsLocationInRequest;
		[CProperty(ColumnPath ="CredentialsLocationInRequest")]
		public int CredentialsLocationInRequest
		{
			get{return _CredentialsLocationInRequest;}
			set
			{
				_CredentialsLocationInRequest = value;
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
		private Guid _ImageId;
		[CProperty(ColumnPath ="ImageId")]
		public Guid ImageId
		{
			get{return _ImageId;}
			set
			{
				_ImageId = value;
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
		private string _RevokeTokenUrl;
		[CProperty(ColumnPath ="RevokeTokenUrl")]
		public string RevokeTokenUrl
		{
			get{return _RevokeTokenUrl;}
			set
			{
				_RevokeTokenUrl = value;
				OnPropertyChanged();
			}
		}
		private Guid _SharedUserId;
		[CProperty(ColumnPath ="SharedUserId")]
		public Guid SharedUserId
		{
			get{return _SharedUserId;}
			set
			{
				_SharedUserId = value;
				OnPropertyChanged();
			}
		}
		private string _TokenUrl;
		[CProperty(ColumnPath ="TokenUrl")]
		public string TokenUrl
		{
			get{return _TokenUrl;}
			set
			{
				_TokenUrl = value;
				OnPropertyChanged();
			}
		}
		private bool _UseSharedUser;
		[CProperty(ColumnPath ="UseSharedUser")]
		public bool UseSharedUser
		{
			get{return _UseSharedUser;}
			set
			{
				_UseSharedUser = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysAdminUnit:SharedUserId")]
		public SysAdminUnit SharedUser { get; set; }
		[CProperty(Navigation ="SysImage:ImageId")]
		public SysImage Image { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="MailServer:OAuthApplicationId")]
		public virtual ICollection<MailServer> MailServerByOAuthApplication { get; set; }
		[CProperty(Association ="OAuth20AppFile:OAuth20AppId")]
		public virtual ICollection<OAuth20AppFile> OAuth20AppFileByOAuth20App { get; set; }
		[CProperty(Association ="OAuth20AppInFolder:OAuth20AppId")]
		public virtual ICollection<OAuth20AppInFolder> OAuth20AppInFolderByOAuth20App { get; set; }
		[CProperty(Association ="OAuth20AppInTag:EntityId")]
		public virtual ICollection<OAuth20AppInTag> OAuth20AppInTagByEntity { get; set; }
		[CProperty(Association ="OAuthAppScope:OAuth20AppId")]
		public virtual ICollection<OAuthAppScope> OAuthAppScopeByOAuth20App { get; set; }
		[CProperty(Association ="OAuthTokenStorage:OAuthAppId")]
		public virtual ICollection<OAuthTokenStorage> OAuthTokenStorageByOAuthApp { get; set; }
		[CProperty(Association ="VwOAuthAppUser:OAuthAppId")]
		public virtual ICollection<VwOAuthAppUser> VwOAuthAppUserByOAuthApp { get; set; }
		#endregion
	}
}
