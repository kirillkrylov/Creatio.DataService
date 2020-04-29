using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSysSetting")]
	public class VwSysSetting : BaseEntity
	{
		#region Values
		private string _Code;
		[CProperty(ColumnPath ="Code")]
		public string Code
		{
			get{return _Code;}
			set
			{
				_Code = value;
				OnPropertyChanged();
			}
		}
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
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
		private bool _IsCacheable;
		[CProperty(ColumnPath ="IsCacheable")]
		public bool IsCacheable
		{
			get{return _IsCacheable;}
			set
			{
				_IsCacheable = value;
				OnPropertyChanged();
			}
		}
		private bool _IsPersonal;
		[CProperty(ColumnPath ="IsPersonal")]
		public bool IsPersonal
		{
			get{return _IsPersonal;}
			set
			{
				_IsPersonal = value;
				OnPropertyChanged();
			}
		}
		private bool _IsSSPAvailable;
		[CProperty(ColumnPath ="IsSSPAvailable")]
		public bool IsSSPAvailable
		{
			get{return _IsSSPAvailable;}
			set
			{
				_IsSSPAvailable = value;
				OnPropertyChanged();
			}
		}
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
				OnPropertyChanged();
			}
		}
		private Guid _ReferenceSchemaUId;
		[CProperty(ColumnPath ="ReferenceSchemaUId")]
		public Guid ReferenceSchemaUId
		{
			get{return _ReferenceSchemaUId;}
			set
			{
				_ReferenceSchemaUId = value;
				OnPropertyChanged();
			}
		}
		private string _ValueTypeName;
		[CProperty(ColumnPath ="ValueTypeName")]
		public string ValueTypeName
		{
			get{return _ValueTypeName;}
			set
			{
				_ValueTypeName = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		#endregion

		#region Associations
		#endregion
	}
}
