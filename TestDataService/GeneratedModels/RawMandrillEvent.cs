using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "RawMandrillEvent")]
	public class RawMandrillEvent : BaseEntity
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
		#endregion

		#region Navigation
		#endregion

		#region Associations
		#endregion
	}
}
