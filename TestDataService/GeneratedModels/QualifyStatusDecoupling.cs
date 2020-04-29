using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "QualifyStatusDecoupling")]
	public class QualifyStatusDecoupling : BaseEntity
	{
		#region Values
		private Guid _AvailableStatusId;
		[CProperty(ColumnPath ="AvailableStatusId")]
		public Guid AvailableStatusId
		{
			get{return _AvailableStatusId;}
			set
			{
				_AvailableStatusId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CurrentStatusId;
		[CProperty(ColumnPath ="CurrentStatusId")]
		public Guid CurrentStatusId
		{
			get{return _CurrentStatusId;}
			set
			{
				_CurrentStatusId = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation ="QualifyStatus:CurrentStatusId")]
		public QualifyStatus CurrentStatus { get; set; }
		[CProperty(Navigation ="QualifyStatus:AvailableStatusId")]
		public QualifyStatus AvailableStatus { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
