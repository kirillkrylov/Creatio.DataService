using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Sites")]
	public class Sites : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="BPMPkgCode")]
		public string BPMPkgCode { get; set; }
		[CProperty(ColumnPath ="BPMPkgProductCode")]
		public string BPMPkgProductCode { get; set; }
		[CProperty(ColumnPath ="BPMPkgProductName")]
		public string BPMPkgProductName { get; set; }
		[CProperty(ColumnPath ="BPMPkgState")]
		public string BPMPkgState { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DatabaseServer")]
		public string DatabaseServer { get; set; }
		[CProperty(ColumnPath ="DataCenter")]
		public string DataCenter { get; set; }
		[CProperty(ColumnPath ="DataCenterDescription")]
		public string DataCenterDescription { get; set; }
		[CProperty(ColumnPath ="DataCenterDomain")]
		public string DataCenterDomain { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RedisServer")]
		public string RedisServer { get; set; }
		[CProperty(ColumnPath ="ServerBlock")]
		public string ServerBlock { get; set; }
		[CProperty(ColumnPath ="ServerBlockDescription")]
		public string ServerBlockDescription { get; set; }
		[CProperty(ColumnPath ="Site")]
		public string Site { get; set; }
		[CProperty(ColumnPath ="SiteDescription")]
		public string SiteDescription { get; set; }
		[CProperty(ColumnPath ="SitesId")]
		public int SitesId { get; set; }
		[CProperty(ColumnPath ="SiteState")]
		public string SiteState { get; set; }
		[CProperty(ColumnPath ="SiteURL")]
		public string SiteURL { get; set; }
		[CProperty(ColumnPath ="SubscribeId")]
		public Guid SubscribeId { get; set; }
		[CProperty(ColumnPath ="VirtualizationParams")]
		public string VirtualizationParams { get; set; }
		[CProperty(ColumnPath ="VirtualizationTypeCode")]
		public string VirtualizationTypeCode { get; set; }
		[CProperty(ColumnPath ="VirtualizationTypeName")]
		public string VirtualizationTypeName { get; set; }
		[CProperty(ColumnPath ="WebServer")]
		public string WebServer { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SocialSubscription:SubscribeId")]
		public SocialSubscription Subscribe { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
