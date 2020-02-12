using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwProductSLA")]
	public class VwProductSLA : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CalendarId")]
		public Guid CalendarId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ProductId")]
		public Guid ProductId { get; set; }
		[CProperty(ColumnPath ="ServicePactTypeId")]
		public Guid ServicePactTypeId { get; set; }
		[CProperty(ColumnPath ="SupportLevelId")]
		public Guid SupportLevelId { get; set; }
		[CProperty(ColumnPath ="TSOfficeId")]
		public Guid TSOfficeId { get; set; }
		[CProperty(ColumnPath ="TypeName")]
		public string TypeName { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Calendar:CalendarId")]
		public Calendar Calendar { get; set; }
		[CProperty(Navigation ="Product:ProductId")]
		public Product Product { get; set; }
		[CProperty(Navigation ="ServicePactType:ServicePactTypeId")]
		public ServicePactType ServicePactType { get; set; }
		[CProperty(Navigation ="SupportLevel:SupportLevelId")]
		public SupportLevel SupportLevel { get; set; }
		[CProperty(Navigation ="TSOffice:TSOfficeId")]
		public TSOffice TSOffice { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
