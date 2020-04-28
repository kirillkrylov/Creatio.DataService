using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SocialChannel")]
	public class SocialChannel : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ImageId")]
		public Guid ImageId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="PublisherRightKind")]
		public bool PublisherRightKind { get; set; }
		[CProperty(ColumnPath ="Title")]
		public string Title { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysImage:ImageId")]
		public SysImage Image { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SocialChannelInFolder:SocialChannelId")]
		public virtual ICollection<SocialChannelInFolder> SocialChannelInFolderBySocialChannel { get; set; }
		[CProperty(Association ="SocialChannelInTag:EntityId")]
		public virtual ICollection<SocialChannelInTag> SocialChannelInTagByEntity { get; set; }
		[CProperty(Association ="SocialChannelPublisher:ChannelId")]
		public virtual ICollection<SocialChannelPublisher> SocialChannelPublisherByChannel { get; set; }
		#endregion
	}
}
