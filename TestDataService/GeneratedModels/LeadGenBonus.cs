using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LeadGenBonus")]
	public class LeadGenBonus : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BonusHours")]
		public decimal BonusHours { get; set; }
		[CProperty(ColumnPath ="CallCount")]
		public int CallCount { get; set; }
		[CProperty(ColumnPath ="CardActCount")]
		public int CardActCount { get; set; }
		[CProperty(ColumnPath ="CompletnessCount")]
		public int CompletnessCount { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="HourInMonts")]
		public int HourInMonts { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="MeetConductCount")]
		public int MeetConductCount { get; set; }
		[CProperty(ColumnPath ="MeetDoneCount")]
		public int MeetDoneCount { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Month")]
		public int Month { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Year")]
		public int Year { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
