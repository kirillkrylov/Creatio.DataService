using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CertificationParticipant")]
	public class CertificationParticipant : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Attentiveness")]
		public decimal Attentiveness { get; set; }
		[CProperty(ColumnPath ="CertificationId")]
		public Guid CertificationId { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Duration")]
		public DateTime Duration { get; set; }
		[CProperty(ColumnPath ="GuidedLearningOccurancesId")]
		public Guid GuidedLearningOccurancesId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsHost")]
		public bool IsHost { get; set; }
		[CProperty(ColumnPath ="JoinTime")]
		public DateTime JoinTime { get; set; }
		[CProperty(ColumnPath ="LeaveTime")]
		public DateTime LeaveTime { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ParticipantEmail")]
		public string ParticipantEmail { get; set; }
		[CProperty(ColumnPath ="ParticipantName")]
		public string ParticipantName { get; set; }
		[CProperty(ColumnPath ="ParticipantUserId")]
		public string ParticipantUserId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordHash")]
		public string RecordHash { get; set; }
		[CProperty(ColumnPath ="RecordingSent")]
		public bool RecordingSent { get; set; }
		[CProperty(ColumnPath ="ZoomParticipantId")]
		public string ZoomParticipantId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Certification:CertificationId")]
		public Certification Certification { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="GuidedLearningOccurances:GuidedLearningOccurancesId")]
		public GuidedLearningOccurances GuidedLearningOccurances { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
