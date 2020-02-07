using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CampaignItem")]
	public class CampaignItem : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CampaignElementType")]
		public string CampaignElementType { get; set; }
		[CProperty(ColumnPath ="CampaignId")]
		public Guid CampaignId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsDeleted")]
		public bool IsDeleted { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordId")]
		public Guid RecordId { get; set; }
		[CProperty(ColumnPath ="SysSchemaUId")]
		public Guid SysSchemaUId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Campaign:CampaignId")]
		public Campaign Campaign { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="CampaignLog:CampaignItemId")]
		public virtual ICollection<CampaignLog> CampaignLogByCampaignItem { get; set; }
		[CProperty(Association ="CampaignParticipant:CampaignItemId")]
		public virtual ICollection<CampaignParticipant> CampaignParticipantByCampaignItem { get; set; }
		[CProperty(Association ="CampaignParticipantOp:CampaignItemId")]
		public virtual ICollection<CampaignParticipantOp> CampaignParticipantOpByCampaignItem { get; set; }
		[CProperty(Association ="CampaignParticipantOp:InitialCampaignItemId")]
		public virtual ICollection<CampaignParticipantOp> CampaignParticipantOpByInitialCampaignItem { get; set; }
		[CProperty(Association ="CampaignQueue:CampaignItemId")]
		public virtual ICollection<CampaignQueue> CampaignQueueByCampaignItem { get; set; }
		[CProperty(Association ="CampaignSignal:CampaignItemId")]
		public virtual ICollection<CampaignSignal> CampaignSignalByCampaignItem { get; set; }
		[CProperty(Association ="VwBulkEmailInCampaign:CampaignItemId")]
		public virtual ICollection<VwBulkEmailInCampaign> VwBulkEmailInCampaignByCampaignItem { get; set; }
		[CProperty(Association ="VwCampaignLog:CampaignItemId")]
		public virtual ICollection<VwCampaignLog> VwCampaignLogByCampaignItem { get; set; }
		[CProperty(Association ="VwEventInCampaign:CampaignItemId")]
		public virtual ICollection<VwEventInCampaign> VwEventInCampaignByCampaignItem { get; set; }
		[CProperty(Association ="VwFolderInCampaign:CampaignItemId")]
		public virtual ICollection<VwFolderInCampaign> VwFolderInCampaignByCampaignItem { get; set; }
		[CProperty(Association ="VwLandingInCampaign:CampaignItemId")]
		public virtual ICollection<VwLandingInCampaign> VwLandingInCampaignByCampaignItem { get; set; }
		#endregion
	}
}
