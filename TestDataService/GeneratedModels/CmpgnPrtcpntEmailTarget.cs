using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CmpgnPrtcpntEmailTarget")]
	public class CmpgnPrtcpntEmailTarget : BaseEntity
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
		private bool _WasUsed;
		[CProperty(ColumnPath ="WasUsed")]
		public bool WasUsed
		{
			get{return _WasUsed;}
			set
			{
				_WasUsed = value;
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
