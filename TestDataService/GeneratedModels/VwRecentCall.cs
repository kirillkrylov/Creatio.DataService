using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwRecentCall")]
	public class VwRecentCall : BaseEntity
	{
		#region Values
		private Guid _CallId;
		[CProperty(ColumnPath ="CallId")]
		public Guid CallId
		{
			get{return _CallId;}
			set
			{
				_CallId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
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
		[CProperty(Navigation ="Call:CallId")]
		public Call Call { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
