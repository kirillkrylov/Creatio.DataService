using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AutoProcessingLog")]
	public class AutoProcessingLog : BaseEntity
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
		private string _Message;
		[CProperty(ColumnPath ="Message")]
		public string Message
		{
			get{return _Message;}
			set
			{
				_Message = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ProcessingDate;
		[CProperty(ColumnPath ="ProcessingDate")]
		public DateTime ProcessingDate
		{
			get{return _ProcessingDate;}
			set
			{
				_ProcessingDate = value;
				OnPropertyChanged();
			}
		}
		private string _ProcessingType;
		[CProperty(ColumnPath ="ProcessingType")]
		public string ProcessingType
		{
			get{return _ProcessingType;}
			set
			{
				_ProcessingType = value;
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
