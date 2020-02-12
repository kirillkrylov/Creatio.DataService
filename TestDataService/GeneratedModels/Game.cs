using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Game")]
	public class Game : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate { get; set; }
		[CProperty(ColumnPath ="FinishTypeId")]
		public Guid FinishTypeId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="PointsLimit")]
		public int PointsLimit { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RoleId")]
		public Guid RoleId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="GameFinishType:FinishTypeId")]
		public GameFinishType FinishType { get; set; }
		[CProperty(Navigation ="GameStatus:StatusId")]
		public GameStatus Status { get; set; }
		[CProperty(Navigation ="GameType:TypeId")]
		public GameType Type { get; set; }
		[CProperty(Navigation ="SysAdminUnit:RoleId")]
		public SysAdminUnit Role { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="GameContactPoint:GameId")]
		public virtual ICollection<GameContactPoint> GameContactPointByGame { get; set; }
		[CProperty(Association ="GameReward:GameId")]
		public virtual ICollection<GameReward> GameRewardByGame { get; set; }
		[CProperty(Association ="GameScoringLog:GameId")]
		public virtual ICollection<GameScoringLog> GameScoringLogByGame { get; set; }
		[CProperty(Association ="GameScoringReason:GameId")]
		public virtual ICollection<GameScoringReason> GameScoringReasonByGame { get; set; }
		#endregion
	}
}
