using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "GameScoringReason")]
	public class GameScoringReason : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Configuration")]
		public string Configuration { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="GameId")]
		public Guid GameId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="PathToPlayer")]
		public string PathToPlayer { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ScoringProcessUId")]
		public Guid ScoringProcessUId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Game:GameId")]
		public Game Game { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ContactGameAchievement:ScoringReasonId")]
		public virtual ICollection<ContactGameAchievement> ContactGameAchievementByScoringReason { get; set; }
		[CProperty(Association ="GameScoringLog:ReasonId")]
		public virtual ICollection<GameScoringLog> GameScoringLogByReason { get; set; }
		#endregion
	}
}
