using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ContactCommunication")]
	public class ContactCommunication : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CommunicationTypeId")]
		public Guid CommunicationTypeId { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DateSetNonActual")]
		public DateTime DateSetNonActual { get; set; }
		[CProperty(ColumnPath ="ExternalCommunicationType")]
		public string ExternalCommunicationType { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsCreatedBySynchronization")]
		public bool IsCreatedBySynchronization { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="NonActual")]
		public bool NonActual { get; set; }
		[CProperty(ColumnPath ="NonActualReasonId")]
		public Guid NonActualReasonId { get; set; }
		[CProperty(ColumnPath ="Number")]
		public string Number { get; set; }
		[CProperty(ColumnPath ="Position")]
		public int Position { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SearchNumber")]
		public string SearchNumber { get; set; }
		[CProperty(ColumnPath ="SocialMediaId")]
		public string SocialMediaId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="CommunicationType:CommunicationTypeId")]
		public CommunicationType CommunicationType { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="NonActualReason:NonActualReasonId")]
		public NonActualReason NonActualReason { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
