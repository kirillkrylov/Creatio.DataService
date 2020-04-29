using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwOAuthAppUser")]
	public class VwOAuthAppUser : BaseEntity
	{
		#region Values
		private string _AccessToken;
		[CProperty(ColumnPath ="AccessToken")]
		public string AccessToken
		{
			get{return _AccessToken;}
			set
			{
				_AccessToken = value;
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
		private int _ExpiresOn;
		[CProperty(ColumnPath ="ExpiresOn")]
		public int ExpiresOn
		{
			get{return _ExpiresOn;}
			set
			{
				_ExpiresOn = value;
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
		private Guid _OAuthAppId;
		[CProperty(ColumnPath ="OAuthAppId")]
		public Guid OAuthAppId
		{
			get{return _OAuthAppId;}
			set
			{
				_OAuthAppId = value;
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
		private string _RefreshToken;
		[CProperty(ColumnPath ="RefreshToken")]
		public string RefreshToken
		{
			get{return _RefreshToken;}
			set
			{
				_RefreshToken = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysUserId;
		[CProperty(ColumnPath ="SysUserId")]
		public Guid SysUserId
		{
			get{return _SysUserId;}
			set
			{
				_SysUserId = value;
				OnPropertyChanged();
			}
		}
		private string _UserAppLogin;
		[CProperty(ColumnPath ="UserAppLogin")]
		public string UserAppLogin
		{
			get{return _UserAppLogin;}
			set
			{
				_UserAppLogin = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="OAuthApplications:OAuthAppId")]
		public OAuthApplications OAuthApp { get; set; }
		[CProperty(Navigation ="SysAdminUnit:SysUserId")]
		public SysAdminUnit SysUser { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
