using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwProductSLA")]
	public class VwProductSLA : BaseEntity
	{
		#region Values
		private Guid _CalendarId;
		[CProperty(ColumnPath ="CalendarId")]
		public Guid CalendarId
		{
			get{return _CalendarId;}
			set
			{
				_CalendarId = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProductId;
		[CProperty(ColumnPath ="ProductId")]
		public Guid ProductId
		{
			get{return _ProductId;}
			set
			{
				_ProductId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ServicePactTypeId;
		[CProperty(ColumnPath ="ServicePactTypeId")]
		public Guid ServicePactTypeId
		{
			get{return _ServicePactTypeId;}
			set
			{
				_ServicePactTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupportLevelId;
		[CProperty(ColumnPath ="SupportLevelId")]
		public Guid SupportLevelId
		{
			get{return _SupportLevelId;}
			set
			{
				_SupportLevelId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TSOfficeId;
		[CProperty(ColumnPath ="TSOfficeId")]
		public Guid TSOfficeId
		{
			get{return _TSOfficeId;}
			set
			{
				_TSOfficeId = value;
				OnPropertyChanged();
			}
		}
		private string _TypeName;
		[CProperty(ColumnPath ="TypeName")]
		public string TypeName
		{
			get{return _TypeName;}
			set
			{
				_TypeName = value;
				OnPropertyChanged();
			}
		}
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
