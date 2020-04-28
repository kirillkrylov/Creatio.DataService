using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CmpgnPrtcpntEmailTarget")]
	public class CmpgnPrtcpntEmailTarget : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BulkEmailId")]
		public Guid BulkEmailId { get; set; }
		[CProperty(ColumnPath ="CampaignParticipantId")]
		public Guid CampaignParticipantId { get; set; }
		[CProperty(ColumnPath ="MandrillRecipientUId")]
		public Guid MandrillRecipientUId { get; set; }
		[CProperty(ColumnPath ="WasUsed")]
		public bool WasUsed { get; set; }
		#endregion

		#region Navigation
		#endregion

		#region Associations
		#endregion
	}
}
