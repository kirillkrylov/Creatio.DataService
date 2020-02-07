using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CmpgnPrtcpntEmailTargetOp")]
	public class CmpgnPrtcpntEmailTargetOp : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CampaignParticipantId")]
		public Guid CampaignParticipantId { get; set; }
		[CProperty(ColumnPath ="MandrillRecipientUId")]
		public Guid MandrillRecipientUId { get; set; }
		#endregion

		#region Navigation
		#endregion

		#region Associations
		#endregion
	}
}
