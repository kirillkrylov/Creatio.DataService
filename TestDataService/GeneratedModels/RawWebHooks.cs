using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "RawWebHooks")]
	public class RawWebHooks : BaseEntity
	{
		#region Values
		private bool _Failed;
		[CProperty(ColumnPath ="Failed")]
		public bool Failed
		{
			get{return _Failed;}
			set
			{
				_Failed = value;
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
		private byte[] _JsonData;
		[CProperty(ColumnPath ="JsonData")]
		public byte[] JsonData
		{
			get{return _JsonData;}
			set
			{
				_JsonData = value;
				OnPropertyChanged();
			}
		}
		private int _Type;
		[CProperty(ColumnPath ="Type")]
		public int Type
		{
			get{return _Type;}
			set
			{
				_Type = value;
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
