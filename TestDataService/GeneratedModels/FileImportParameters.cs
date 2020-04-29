using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "FileImportParameters")]
	public class FileImportParameters : BaseEntity
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
		private byte[] _FileData;
		[CProperty(ColumnPath ="FileData")]
		public byte[] FileData
		{
			get{return _FileData;}
			set
			{
				_FileData = value;
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
		private byte[] _ImportEntities;
		[CProperty(ColumnPath ="ImportEntities")]
		public byte[] ImportEntities
		{
			get{return _ImportEntities;}
			set
			{
				_ImportEntities = value;
				OnPropertyChanged();
			}
		}
		private byte[] _ImportParameters;
		[CProperty(ColumnPath ="ImportParameters")]
		public byte[] ImportParameters
		{
			get{return _ImportParameters;}
			set
			{
				_ImportParameters = value;
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
		private int _Size;
		[CProperty(ColumnPath ="Size")]
		public int Size
		{
			get{return _Size;}
			set
			{
				_Size = value;
				OnPropertyChanged();
			}
		}
		private int _Stage;
		[CProperty(ColumnPath ="Stage")]
		public int Stage
		{
			get{return _Stage;}
			set
			{
				_Stage = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ImportSessionChunk:ImportParametersId")]
		public virtual ICollection<ImportSessionChunk> ImportSessionChunkByImportParameters { get; set; }
		#endregion
	}
}
