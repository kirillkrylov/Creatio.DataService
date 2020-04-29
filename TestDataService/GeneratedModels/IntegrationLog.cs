using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "IntegrationLog")]
	public class IntegrationLog : BaseEntity
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
		private DateTime _Date;
		[CProperty(ColumnPath ="Date")]
		public DateTime Date
		{
			get{return _Date;}
			set
			{
				_Date = value;
				OnPropertyChanged();
			}
		}
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
				OnPropertyChanged();
			}
		}
		private Guid _DirectionId;
		[CProperty(ColumnPath ="DirectionId")]
		public Guid DirectionId
		{
			get{return _DirectionId;}
			set
			{
				_DirectionId = value;
				OnPropertyChanged();
			}
		}
		private string _ErrorDescription;
		[CProperty(ColumnPath ="ErrorDescription")]
		public string ErrorDescription
		{
			get{return _ErrorDescription;}
			set
			{
				_ErrorDescription = value;
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
		private Guid _IntegrationSystemId;
		[CProperty(ColumnPath ="IntegrationSystemId")]
		public Guid IntegrationSystemId
		{
			get{return _IntegrationSystemId;}
			set
			{
				_IntegrationSystemId = value;
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
		private Guid _OperationId;
		[CProperty(ColumnPath ="OperationId")]
		public Guid OperationId
		{
			get{return _OperationId;}
			set
			{
				_OperationId = value;
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
		private Guid _ResultId;
		[CProperty(ColumnPath ="ResultId")]
		public Guid ResultId
		{
			get{return _ResultId;}
			set
			{
				_ResultId = value;
				OnPropertyChanged();
			}
		}
		private int _SessionNumber;
		[CProperty(ColumnPath ="SessionNumber")]
		public int SessionNumber
		{
			get{return _SessionNumber;}
			set
			{
				_SessionNumber = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="IntegrationDirection:DirectionId")]
		public IntegrationDirection Direction { get; set; }
		[CProperty(Navigation ="IntegrationOperation:OperationId")]
		public IntegrationOperation Operation { get; set; }
		[CProperty(Navigation ="IntegrationResult:ResultId")]
		public IntegrationResult Result { get; set; }
		[CProperty(Navigation ="IntegrationSystem:IntegrationSystemId")]
		public IntegrationSystem IntegrationSystem { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
