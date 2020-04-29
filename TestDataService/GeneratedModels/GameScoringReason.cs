using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "GameScoringReason")]
	public class GameScoringReason : BaseEntity
	{
		#region Values
		private string _Configuration;
		[CProperty(ColumnPath ="Configuration")]
		public string Configuration
		{
			get{return _Configuration;}
			set
			{
				_Configuration = value;
				OnPropertyChanged();
			}
		}
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
				OnPropertyChanged();
			}
		}
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
				OnPropertyChanged();
			}
		}
		private Guid _GameId;
		[CProperty(ColumnPath ="GameId")]
		public Guid GameId
		{
			get{return _GameId;}
			set
			{
				_GameId = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
				OnPropertyChanged();
			}
		}
		private string _PathToPlayer;
		[CProperty(ColumnPath ="PathToPlayer")]
		public string PathToPlayer
		{
			get{return _PathToPlayer;}
			set
			{
				_PathToPlayer = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
		private Guid _ScoringProcessUId;
		[CProperty(ColumnPath ="ScoringProcessUId")]
		public Guid ScoringProcessUId
		{
			get{return _ScoringProcessUId;}
			set
			{
				_ScoringProcessUId = value;
				OnPropertyChanged();
			}
		}
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
