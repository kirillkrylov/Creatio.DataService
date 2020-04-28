using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "MailServer")]
	public class MailServer : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Address")]
		public string Address { get; set; }
		[CProperty(ColumnPath ="AllowEmailDownloading")]
		public bool AllowEmailDownloading { get; set; }
		[CProperty(ColumnPath ="AllowEmailSending")]
		public bool AllowEmailSending { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EmailProtocolId")]
		public Guid EmailProtocolId { get; set; }
		[CProperty(ColumnPath ="ExchangeEmailAddress")]
		public string ExchangeEmailAddress { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsExchengeAutodiscover")]
		public bool IsExchengeAutodiscover { get; set; }
		[CProperty(ColumnPath ="IsStartTls")]
		public bool IsStartTls { get; set; }
		[CProperty(ColumnPath ="LogoId")]
		public Guid LogoId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OAuthApplicationId")]
		public Guid OAuthApplicationId { get; set; }
		[CProperty(ColumnPath ="Port")]
		public int Port { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SMTPPort")]
		public int SMTPPort { get; set; }
		[CProperty(ColumnPath ="SMTPServerAddress")]
		public string SMTPServerAddress { get; set; }
		[CProperty(ColumnPath ="SMTPServerTimeout")]
		public int SMTPServerTimeout { get; set; }
		[CProperty(ColumnPath ="Strategy")]
		public string Strategy { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="UseEmailAddressAsLogin")]
		public bool UseEmailAddressAsLogin { get; set; }
		[CProperty(ColumnPath ="UseLogin")]
		public bool UseLogin { get; set; }
		[CProperty(ColumnPath ="UseSSL")]
		public bool UseSSL { get; set; }
		[CProperty(ColumnPath ="UseSSLforSending")]
		public bool UseSSLforSending { get; set; }
		[CProperty(ColumnPath ="UseUserNameAsLogin")]
		public bool UseUserNameAsLogin { get; set; }
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
