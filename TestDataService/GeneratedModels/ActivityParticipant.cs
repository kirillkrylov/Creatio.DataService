using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ActivityParticipant")]
	public class ActivityParticipant : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActivityId")]
		public Guid ActivityId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="InviteParticipant")]
		public bool InviteParticipant { get; set; }
		[CProperty(ColumnPath ="InviteResponseId")]
		public Guid InviteResponseId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ParticipantId")]
		public Guid ParticipantId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ReadMark")]
		public bool ReadMark { get; set; }
		[CProperty(ColumnPath ="RoleId")]
		public Guid RoleId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Activity:ActivityId")]
		public Activity Activity { get; set; }
		[CProperty(Navigation ="ActivityParticipantRole:RoleId")]
		public ActivityParticipantRole Role { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ParticipantId")]
		public Contact Participant { get; set; }
		[CProperty(Navigation ="ParticipantResponse:InviteResponseId")]
		public ParticipantResponse InviteResponse { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
