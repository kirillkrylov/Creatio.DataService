using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DCRecipientOp")]
	public class DCRecipientOp : BaseEntity
	{
		#region Values
		private int _BlockIndex;
		[CProperty(ColumnPath ="BlockIndex")]
		public int BlockIndex
		{
			get{return _BlockIndex;}
			set
			{
				_BlockIndex = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
				OnPropertyChanged();
			}
		}
		private Guid _EntityId;
		[CProperty(ColumnPath ="EntityId")]
		public Guid EntityId
		{
			get{return _EntityId;}
			set
			{
				_EntityId = value;
				OnPropertyChanged();
			}
		}
		private int _GroupIndex;
		[CProperty(ColumnPath ="GroupIndex")]
		public int GroupIndex
		{
			get{return _GroupIndex;}
			set
			{
				_GroupIndex = value;
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
		private Guid _SessionId;
		[CProperty(ColumnPath ="SessionId")]
		public Guid SessionId
		{
			get{return _SessionId;}
			set
			{
				_SessionId = value;
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
