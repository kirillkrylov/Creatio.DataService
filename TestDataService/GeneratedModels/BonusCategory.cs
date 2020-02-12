using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BonusCategory")]
	public class BonusCategory : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsMultiyear")]
		public bool IsMultiyear { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Bonus:BonusCategoryId")]
		public virtual ICollection<Bonus> BonusByBonusCategory { get; set; }
		[CProperty(Association ="BonusProduct:BonusCategoryId")]
		public virtual ICollection<BonusProduct> BonusProductByBonusCategory { get; set; }
		[CProperty(Association ="Product:BonusCategoryId")]
		public virtual ICollection<Product> ProductByBonusCategory { get; set; }
		[CProperty(Association ="ProductCoefficients:BonusCategoriesId")]
		public virtual ICollection<ProductCoefficients> ProductCoefficientsByBonusCategories { get; set; }
		#endregion
	}
}
