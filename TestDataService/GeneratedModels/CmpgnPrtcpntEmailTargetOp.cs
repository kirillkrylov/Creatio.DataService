using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CmpgnPrtcpntEmailTargetOp")]
	public class CmpgnPrtcpntEmailTargetOp : BaseEntity
	{
		#region Values
		private Guid _BulkEmailId;
		[CProperty(ColumnPath ="BulkEmailId")]
		public Guid BulkEmailId
		{
			get{return _BulkEmailId;}
			set
			{
				_BulkEmailId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CampaignParticipantId;
		[CProperty(ColumnPath ="CampaignParticipantId")]
		public Guid CampaignParticipantId
		{
			get{return _CampaignParticipantId;}
			set
			{
				_CampaignParticipantId = value;
				OnPropertyChanged();
			}
		}
		private Guid _MandrillRecipientUId;
		[CProperty(ColumnPath ="MandrillRecipientUId")]
		public Guid MandrillRecipientUId
		{
			get{return _MandrillRecipientUId;}
			set
			{
				_MandrillRecipientUId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		#endregion

		#region Associations
		#endregion
	}
}
