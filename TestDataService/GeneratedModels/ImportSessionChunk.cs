using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ImportSessionChunk")]
	public class ImportSessionChunk : BaseEntity
	{
		#region Values
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
		private byte[] _Data;
		[CProperty(ColumnPath ="Data")]
		public byte[] Data
		{
			get{return _Data;}
			set
			{
				_Data = value;
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
		private Guid _ImportParametersId;
		[CProperty(ColumnPath ="ImportParametersId")]
		public Guid ImportParametersId
		{
			get{return _ImportParametersId;}
			set
			{
				_ImportParametersId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
		private int _State;
		[CProperty(ColumnPath ="State")]
		public int State
		{
			get{return _State;}
			set
			{
				_State = value;
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
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="FileImportParameters:ImportParametersId")]
		public FileImportParameters ImportParameters { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ChunkProcessResult:ImportSessionChunkId")]
		public virtual ICollection<ChunkProcessResult> ChunkProcessResultByImportSessionChunk { get; set; }
		#endregion
	}
}
