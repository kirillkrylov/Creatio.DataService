using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "FormulasForCalculatingCostsProduct")]
	public class FormulasForCalculatingCostsProduct : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="Formula")]
		public string Formula { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ObjectForRecording")]
		public string ObjectForRecording { get; set; }
		[CProperty(ColumnPath ="ParametersForApplyingMethod")]
		public string ParametersForApplyingMethod { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="StartSignal")]
		public string StartSignal { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="OrderProduct:CalcMethodId")]
		public virtual ICollection<OrderProduct> OrderProductByCalcMethod { get; set; }
		[CProperty(Association ="TsOrderExpenseProduct:CalculateMethodId")]
		public virtual ICollection<TsOrderExpenseProduct> TsOrderExpenseProductByCalculateMethod { get; set; }
		#endregion
	}
}
