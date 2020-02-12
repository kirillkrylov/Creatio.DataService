using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SlackChannelMessage")]
	public class SlackChannelMessage : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ChannelId")]
		public Guid ChannelId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="MessageDateTime")]
		public DateTime MessageDateTime { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SubType")]
		public string SubType { get; set; }
		[CProperty(ColumnPath ="Text")]
		public string Text { get; set; }
		[CProperty(ColumnPath ="Timestamp")]
		public string Timestamp { get; set; }
		[CProperty(ColumnPath ="Type")]
		public string Type { get; set; }
		[CProperty(ColumnPath ="UserId")]
		public Guid UserId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SlackChannel:ChannelId")]
		public SlackChannel Channel { get; set; }
		[CProperty(Navigation ="SlackChannelMessage:ParentId")]
		public SlackChannelMessage Parent { get; set; }
		[CProperty(Navigation ="SlackUser:UserId")]
		public SlackUser User { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SlackChannelMessage:ParentId")]
		public virtual ICollection<SlackChannelMessage> SlackChannelMessageByParent { get; set; }
		#endregion
	}
}
