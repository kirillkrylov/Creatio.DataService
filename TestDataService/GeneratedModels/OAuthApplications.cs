using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OAuthApplications")]
	public class OAuthApplications : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AppClassName")]
		public string AppClassName { get; set; }
		[CProperty(ColumnPath ="AuthorizeUrl")]
		public string AuthorizeUrl { get; set; }
		[CProperty(ColumnPath ="ClientClassName")]
		public string ClientClassName { get; set; }
		[CProperty(ColumnPath ="ClientId")]
		public string ClientId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CredentialsLocationInRequest")]
		public int CredentialsLocationInRequest { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ImageId")]
		public Guid ImageId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RevokeTokenUrl")]
		public string RevokeTokenUrl { get; set; }
		[CProperty(ColumnPath ="SharedUserId")]
		public Guid SharedUserId { get; set; }
		[CProperty(ColumnPath ="TokenUrl")]
		public string TokenUrl { get; set; }
		[CProperty(ColumnPath ="UseSharedUser")]
		public bool UseSharedUser { get; set; }
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
