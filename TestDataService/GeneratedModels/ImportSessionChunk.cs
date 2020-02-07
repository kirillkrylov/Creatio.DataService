using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ImportSessionChunk")]
	public class ImportSessionChunk : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Data")]
		public byte[] Data { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ImportParametersId")]
		public Guid ImportParametersId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="State")]
		public int State { get; set; }
		[CProperty(ColumnPath ="Type")]
		public int Type { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="FileImportParameters:ImportParametersId")]
		public FileImportParameters ImportParameters { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ChunkProcessResult:ImportSessionChunkId")]
		public virtual ICollection<ChunkProcessResult> ChunkProcessResultByImportSessionChunk { get; set; }
		#endregion
	}
}
