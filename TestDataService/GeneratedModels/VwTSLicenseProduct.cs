using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwTSLicenseProduct")]
	public class VwTSLicenseProduct : BaseEntity
	{
		#region Values
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
		private bool _IsCompetitive;
		[CProperty(ColumnPath ="IsCompetitive")]
		public bool IsCompetitive
		{
			get{return _IsCompetitive;}
			set
			{
				_IsCompetitive = value;
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
		private string _ReadOnlyProductId;
		[CProperty(ColumnPath ="ReadOnlyProductId")]
		public string ReadOnlyProductId
		{
			get{return _ReadOnlyProductId;}
			set
			{
				_ReadOnlyProductId = value;
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
