using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "GuidedLearningParticipants")]
	public class GuidedLearningParticipants : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="GuidedLearningId")]
		public Guid GuidedLearningId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="JoinUrl")]
		public string JoinUrl { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RegistrationDate")]
		public DateTime RegistrationDate { get; set; }
		[CProperty(ColumnPath ="RegistrationUrl")]
		public string RegistrationUrl { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="Surveysent")]
		public bool Surveysent { get; set; }
		[CProperty(ColumnPath ="WorkOrderId")]
		public string WorkOrderId { get; set; }
		[CProperty(ColumnPath ="WorkOrderProductId")]
		public string WorkOrderProductId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="GuidedLearning:GuidedLearningId")]
		public GuidedLearning GuidedLearning { get; set; }
		[CProperty(Navigation ="TrainingParticipantStatus:StatusId")]
		public TrainingParticipantStatus Status { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
