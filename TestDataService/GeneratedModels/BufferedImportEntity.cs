using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BufferedImportEntity")]
	public class BufferedImportEntity : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Column1")]
		public string Column1 { get; set; }
		[CProperty(ColumnPath ="Column10")]
		public string Column10 { get; set; }
		[CProperty(ColumnPath ="Column11")]
		public string Column11 { get; set; }
		[CProperty(ColumnPath ="Column12")]
		public string Column12 { get; set; }
		[CProperty(ColumnPath ="Column13")]
		public string Column13 { get; set; }
		[CProperty(ColumnPath ="Column14")]
		public string Column14 { get; set; }
		[CProperty(ColumnPath ="Column15")]
		public string Column15 { get; set; }
		[CProperty(ColumnPath ="Column16")]
		public string Column16 { get; set; }
		[CProperty(ColumnPath ="Column17")]
		public string Column17 { get; set; }
		[CProperty(ColumnPath ="Column18")]
		public string Column18 { get; set; }
		[CProperty(ColumnPath ="Column19")]
		public string Column19 { get; set; }
		[CProperty(ColumnPath ="Column2")]
		public string Column2 { get; set; }
		[CProperty(ColumnPath ="Column20")]
		public string Column20 { get; set; }
		[CProperty(ColumnPath ="Column21")]
		public string Column21 { get; set; }
		[CProperty(ColumnPath ="Column22")]
		public string Column22 { get; set; }
		[CProperty(ColumnPath ="Column23")]
		public string Column23 { get; set; }
		[CProperty(ColumnPath ="Column24")]
		public string Column24 { get; set; }
		[CProperty(ColumnPath ="Column25")]
		public string Column25 { get; set; }
		[CProperty(ColumnPath ="Column26")]
		public string Column26 { get; set; }
		[CProperty(ColumnPath ="Column27")]
		public string Column27 { get; set; }
		[CProperty(ColumnPath ="Column28")]
		public string Column28 { get; set; }
		[CProperty(ColumnPath ="Column29")]
		public string Column29 { get; set; }
		[CProperty(ColumnPath ="Column3")]
		public string Column3 { get; set; }
		[CProperty(ColumnPath ="Column30")]
		public string Column30 { get; set; }
		[CProperty(ColumnPath ="Column31")]
		public string Column31 { get; set; }
		[CProperty(ColumnPath ="Column32")]
		public string Column32 { get; set; }
		[CProperty(ColumnPath ="Column33")]
		public string Column33 { get; set; }
		[CProperty(ColumnPath ="Column34")]
		public string Column34 { get; set; }
		[CProperty(ColumnPath ="Column35")]
		public string Column35 { get; set; }
		[CProperty(ColumnPath ="Column36")]
		public string Column36 { get; set; }
		[CProperty(ColumnPath ="Column37")]
		public string Column37 { get; set; }
		[CProperty(ColumnPath ="Column38")]
		public string Column38 { get; set; }
		[CProperty(ColumnPath ="Column39")]
		public string Column39 { get; set; }
		[CProperty(ColumnPath ="Column4")]
		public string Column4 { get; set; }
		[CProperty(ColumnPath ="Column40")]
		public string Column40 { get; set; }
		[CProperty(ColumnPath ="Column41")]
		public string Column41 { get; set; }
		[CProperty(ColumnPath ="Column42")]
		public string Column42 { get; set; }
		[CProperty(ColumnPath ="Column43")]
		public string Column43 { get; set; }
		[CProperty(ColumnPath ="Column44")]
		public string Column44 { get; set; }
		[CProperty(ColumnPath ="Column45")]
		public string Column45 { get; set; }
		[CProperty(ColumnPath ="Column46")]
		public string Column46 { get; set; }
		[CProperty(ColumnPath ="Column47")]
		public string Column47 { get; set; }
		[CProperty(ColumnPath ="Column48")]
		public string Column48 { get; set; }
		[CProperty(ColumnPath ="Column49")]
		public string Column49 { get; set; }
		[CProperty(ColumnPath ="Column5")]
		public string Column5 { get; set; }
		[CProperty(ColumnPath ="Column50")]
		public string Column50 { get; set; }
		[CProperty(ColumnPath ="Column6")]
		public string Column6 { get; set; }
		[CProperty(ColumnPath ="Column7")]
		public string Column7 { get; set; }
		[CProperty(ColumnPath ="Column8")]
		public string Column8 { get; set; }
		[CProperty(ColumnPath ="Column9")]
		public string Column9 { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ImportExcelRowIndex")]
		public int ImportExcelRowIndex { get; set; }
		[CProperty(ColumnPath ="ImportSessionId")]
		public Guid ImportSessionId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
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
		#endregion
	}
}
