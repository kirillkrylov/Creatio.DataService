using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EmployeeScore")]
	public class EmployeeScore : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccrualRuleId")]
		public Guid AccrualRuleId { get; set; }
		[CProperty(ColumnPath ="Comment")]
		public string Comment { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId { get; set; }
		[CProperty(ColumnPath ="GiftId")]
		public Guid GiftId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="MarketplaceApplicationId")]
		public Guid MarketplaceApplicationId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ScoreBalance")]
		public decimal ScoreBalance { get; set; }
		[CProperty(ColumnPath ="ScoreDate")]
		public DateTime ScoreDate { get; set; }
		[CProperty(ColumnPath ="ScoreNumber")]
		public decimal ScoreNumber { get; set; }
		[CProperty(ColumnPath ="ScoreTypeId")]
		public Guid ScoreTypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:EmployeeId")]
		public Contact Employee { get; set; }
		[CProperty(Navigation ="Gift:GiftId")]
		public Gift Gift { get; set; }
		[CProperty(Navigation ="MarketplaceApplication:MarketplaceApplicationId")]
		public MarketplaceApplication MarketplaceApplication { get; set; }
		[CProperty(Navigation ="ScoreAccrualRule:AccrualRuleId")]
		public ScoreAccrualRule AccrualRule { get; set; }
		[CProperty(Navigation ="ScoreType:ScoreTypeId")]
		public ScoreType ScoreType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="EmployeeScoreFile:EmployeeScoreId")]
		public virtual ICollection<EmployeeScoreFile> EmployeeScoreFileByEmployeeScore { get; set; }
		[CProperty(Association ="EmployeeScoreInFolder:EmployeeScoreId")]
		public virtual ICollection<EmployeeScoreInFolder> EmployeeScoreInFolderByEmployeeScore { get; set; }
		[CProperty(Association ="EmployeeScoreInTag:EntityId")]
		public virtual ICollection<EmployeeScoreInTag> EmployeeScoreInTagByEntity { get; set; }
		#endregion
	}
}
