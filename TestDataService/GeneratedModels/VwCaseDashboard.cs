using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwCaseDashboard")]
	public class VwCaseDashboard : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="OpenCaseDelay")]
		public int OpenCaseDelay { get; set; }
		[CProperty(ColumnPath ="OriginId")]
		public Guid OriginId { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ReactionDelay")]
		public int ReactionDelay { get; set; }
		[CProperty(ColumnPath ="ReactionTerm")]
		public int ReactionTerm { get; set; }
		[CProperty(ColumnPath ="RespondedOn")]
		public DateTime RespondedOn { get; set; }
		[CProperty(ColumnPath ="ResponseDate")]
		public DateTime ResponseDate { get; set; }
		[CProperty(ColumnPath ="ServiceItemId")]
		public Guid ServiceItemId { get; set; }
		[CProperty(ColumnPath ="SolutionDate")]
		public DateTime SolutionDate { get; set; }
		[CProperty(ColumnPath ="SolutionDelay")]
		public int SolutionDelay { get; set; }
		[CProperty(ColumnPath ="SolutionProvidedOn")]
		public DateTime SolutionProvidedOn { get; set; }
		[CProperty(ColumnPath ="SolutionTerm")]
		public int SolutionTerm { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="CaseCategory:CategoryId")]
		public CaseCategory Category { get; set; }
		[CProperty(Navigation ="CaseOrigin:OriginId")]
		public CaseOrigin Origin { get; set; }
		[CProperty(Navigation ="CaseStatus:StatusId")]
		public CaseStatus Status { get; set; }
		[CProperty(Navigation ="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="ServiceItem:ServiceItemId")]
		public ServiceItem ServiceItem { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
