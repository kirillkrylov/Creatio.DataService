using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Partnership")]
	public class Partnership : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="PartnerLevelId")]
		public Guid PartnerLevelId { get; set; }
		[CProperty(ColumnPath ="PartnerTypeId")]
		public Guid PartnerTypeId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ScoreLeft")]
		public int ScoreLeft { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="PartnerLevel:PartnerLevelId")]
		public PartnerLevel PartnerLevel { get; set; }
		[CProperty(Navigation ="PartnerType:PartnerTypeId")]
		public PartnerType PartnerType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Fund:PartnershipId")]
		public virtual ICollection<Fund> FundByPartnership { get; set; }
		[CProperty(Association ="PartnerParamHistory:PartnershipId")]
		public virtual ICollection<PartnerParamHistory> PartnerParamHistoryByPartnership { get; set; }
		[CProperty(Association ="PartnershipFile:PartnershipId")]
		public virtual ICollection<PartnershipFile> PartnershipFileByPartnership { get; set; }
		[CProperty(Association ="PartnershipInFolder:PartnershipId")]
		public virtual ICollection<PartnershipInFolder> PartnershipInFolderByPartnership { get; set; }
		[CProperty(Association ="PartnershipInTag:EntityId")]
		public virtual ICollection<PartnershipInTag> PartnershipInTagByEntity { get; set; }
		[CProperty(Association ="PartnershipParameter:PartnershipId")]
		public virtual ICollection<PartnershipParameter> PartnershipParameterByPartnership { get; set; }
		[CProperty(Association ="PRMTransaction:PartnershipId")]
		public virtual ICollection<PRMTransaction> PRMTransactionByPartnership { get; set; }
		#endregion
	}
}
