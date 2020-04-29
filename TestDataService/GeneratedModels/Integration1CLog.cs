using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Integration1CLog")]
	public class Integration1CLog : BaseEntity
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
		private Guid _Integration1CSessionId;
		[CProperty(ColumnPath ="Integration1CSessionId")]
		public Guid Integration1CSessionId
		{
			get{return _Integration1CSessionId;}
			set
			{
				_Integration1CSessionId = value;
				OnPropertyChanged();
			}
		}
		private Guid _IntegrationId;
		[CProperty(ColumnPath ="IntegrationId")]
		public Guid IntegrationId
		{
			get{return _IntegrationId;}
			set
			{
				_IntegrationId = value;
				OnPropertyChanged();
			}
		}
		private Guid _LogRecordTypeId;
		[CProperty(ColumnPath ="LogRecordTypeId")]
		public Guid LogRecordTypeId
		{
			get{return _LogRecordTypeId;}
			set
			{
				_LogRecordTypeId = value;
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
		private int _Number;
		[CProperty(ColumnPath ="Number")]
		public int Number
		{
			get{return _Number;}
			set
			{
				_Number = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Integration1C:IntegrationId")]
		public Integration1C Integration { get; set; }
		[CProperty(Navigation ="Integration1CSession:Integration1CSessionId")]
		public Integration1CSession Integration1CSession { get; set; }
		[CProperty(Navigation ="LogRecordType:LogRecordTypeId")]
		public LogRecordType LogRecordType { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
