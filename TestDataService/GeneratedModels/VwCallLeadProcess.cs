using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwCallLeadProcess")]
	public class VwCallLeadProcess : BaseEntity
	{
		#region Values
		private string _CallTitle;
		[CProperty(ColumnPath ="CallTitle")]
		public string CallTitle
		{
			get{return _CallTitle;}
			set
			{
				_CallTitle = value;
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
		private string _OppName;
		[CProperty(ColumnPath ="OppName")]
		public string OppName
		{
			get{return _OppName;}
			set
			{
				_OppName = value;
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
