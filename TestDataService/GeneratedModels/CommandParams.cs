using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CommandParams")]
	public class CommandParams : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AdditionalParamId")]
		public Guid AdditionalParamId { get; set; }
		[CProperty(ColumnPath ="CommandId")]
		public Guid CommandId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="MainParamId")]
		public Guid MainParamId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="AdditionalParam:AdditionalParamId")]
		public AdditionalParam AdditionalParam { get; set; }
		[CProperty(Navigation ="Command:CommandId")]
		public Command Command { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="MainParam:MainParamId")]
		public MainParam MainParam { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
