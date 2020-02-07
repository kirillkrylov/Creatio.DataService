using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwOAuthAppUser")]
	public class VwOAuthAppUser : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccessToken")]
		public string AccessToken { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="ExpiresOn")]
		public int ExpiresOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OAuthAppId")]
		public Guid OAuthAppId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RefreshToken")]
		public string RefreshToken { get; set; }
		[CProperty(ColumnPath ="SysUserId")]
		public Guid SysUserId { get; set; }
		[CProperty(ColumnPath ="UserAppLogin")]
		public string UserAppLogin { get; set; }
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
