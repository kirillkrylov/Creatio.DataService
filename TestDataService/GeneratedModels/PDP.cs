using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PDP")]
	public class PDP : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Comment")]
		public string Comment { get; set; }
		[CProperty(ColumnPath ="CompetenceId")]
		public Guid CompetenceId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Development")]
		public string Development { get; set; }
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate { get; set; }
		[CProperty(ColumnPath ="ExpectedResult")]
		public string ExpectedResult { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="InteractionWithManagerId")]
		public Guid InteractionWithManagerId { get; set; }
		[CProperty(ColumnPath ="Mentor")]
		public string Mentor { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Steps")]
		public string Steps { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Competence:CompetenceId")]
		public Competence Competence { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="InteractionWithManager:InteractionWithManagerId")]
		public InteractionWithManager InteractionWithManager { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
