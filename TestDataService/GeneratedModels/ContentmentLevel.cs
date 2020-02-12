using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ContentmentLevel")]
	public class ContentmentLevel : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="HRTalks:TasksContentmentLevelId")]
		public virtual ICollection<HRTalks> HRTalksByTasksContentmentLevel { get; set; }
		[CProperty(Association ="HRTalks:TeamContentmentLevelId")]
		public virtual ICollection<HRTalks> HRTalksByTeamContentmentLevel { get; set; }
		[CProperty(Association ="HRTalks:HeadContentmentLevelId")]
		public virtual ICollection<HRTalks> HRTalksByHeadContentmentLevel { get; set; }
		[CProperty(Association ="HRTalks:DevelopmentContentmentLevelId")]
		public virtual ICollection<HRTalks> HRTalksByDevelopmentContentmentLevel { get; set; }
		[CProperty(Association ="HRTalks:IncomeContentmentLevelId")]
		public virtual ICollection<HRTalks> HRTalksByIncomeContentmentLevel { get; set; }
		[CProperty(Association ="InteractionWithManager:TasksId")]
		public virtual ICollection<InteractionWithManager> InteractionWithManagerByTasks { get; set; }
		[CProperty(Association ="InteractionWithManager:DevelopmentId")]
		public virtual ICollection<InteractionWithManager> InteractionWithManagerByDevelopment { get; set; }
		[CProperty(Association ="InteractionWithManager:SatisfactionOfInteractionWithManagerId")]
		public virtual ICollection<InteractionWithManager> InteractionWithManagerBySatisfactionOfInteractionWithManager { get; set; }
		[CProperty(Association ="InteractionWithManager:InteractionWithTeamId")]
		public virtual ICollection<InteractionWithManager> InteractionWithManagerByInteractionWithTeam { get; set; }
		[CProperty(Association ="InteractionWithManager:IncomeId")]
		public virtual ICollection<InteractionWithManager> InteractionWithManagerByIncome { get; set; }
		[CProperty(Association ="InteractionWithManager:TrainingQualityId")]
		public virtual ICollection<InteractionWithManager> InteractionWithManagerByTrainingQuality { get; set; }
		#endregion
	}
}
