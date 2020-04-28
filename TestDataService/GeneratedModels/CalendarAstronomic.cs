using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CalendarAstronomic")]
	public class CalendarAstronomic : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Date")]
		public DateTime Date { get; set; }
		[CProperty(ColumnPath ="Day")]
		public int Day { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Month")]
		public int Month { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Quart")]
		public int Quart { get; set; }
		[CProperty(ColumnPath ="Week")]
		public int Week { get; set; }
		[CProperty(ColumnPath ="WeekDay")]
		public int WeekDay { get; set; }
		[CProperty(ColumnPath ="Year")]
		public int Year { get; set; }
		[CProperty(ColumnPath ="YearMonth")]
		public int YearMonth { get; set; }
		[CProperty(ColumnPath ="YearQuart")]
		public int YearQuart { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
