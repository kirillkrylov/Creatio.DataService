using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwProjectHierarchy")]
	public class VwProjectHierarchy : BaseEntity
	{
		#region Values
		private Guid _AccountId;
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId
		{
			get{return _AccountId;}
			set
			{
				_AccountId = value;
				OnPropertyChanged();
			}
		}
		private Guid _BaseProjectId;
		[CProperty(ColumnPath ="BaseProjectId")]
		public Guid BaseProjectId
		{
			get{return _BaseProjectId;}
			set
			{
				_BaseProjectId = value;
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
		private bool _IsFirst;
		[CProperty(ColumnPath ="IsFirst")]
		public bool IsFirst
		{
			get{return _IsFirst;}
			set
			{
				_IsFirst = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProjectId;
		[CProperty(ColumnPath ="ProjectId")]
		public Guid ProjectId
		{
			get{return _ProjectId;}
			set
			{
				_ProjectId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Project:ProjectId")]
		public Project Project { get; set; }
		[CProperty(Navigation ="Project:BaseProjectId")]
		public Project BaseProject { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
