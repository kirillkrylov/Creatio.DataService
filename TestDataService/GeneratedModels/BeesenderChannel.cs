using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BeesenderChannel")]
	public class BeesenderChannel : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ClientId")]
		public string ClientId { get; set; }
		[CProperty(ColumnPath ="ClientSecret")]
		public string ClientSecret { get; set; }
		[CProperty(ColumnPath ="ConfigurationId")]
		public Guid ConfigurationId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="InternalId")]
		public string InternalId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SiteCode")]
		public string SiteCode { get; set; }
		[CProperty(ColumnPath ="Token")]
		public string Token { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="Weight")]
		public decimal Weight { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="BeesenderChannelType:TypeId")]
		public BeesenderChannelType Type { get; set; }
		[CProperty(Navigation ="BeesenderChatConfiguration:ConfigurationId")]
		public BeesenderChatConfiguration Configuration { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BeesenderChat:ChannelId")]
		public virtual ICollection<BeesenderChat> BeesenderChatByChannel { get; set; }
		[CProperty(Association ="BeesenderOperatorChannel:ChannelId")]
		public virtual ICollection<BeesenderOperatorChannel> BeesenderOperatorChannelByChannel { get; set; }
		#endregion
	}
}
