using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysActiveCall")]
	public class SysActiveCall : BaseEntity
	{
		#region Values
		private int _BeforeConnectionTime;
		[CProperty(ColumnPath ="BeforeConnectionTime")]
		public int BeforeConnectionTime
		{
			get{return _BeforeConnectionTime;}
			set
			{
				_BeforeConnectionTime = value;
				OnPropertyChanged();
			}
		}
		private string _CallContext;
		[CProperty(ColumnPath ="CallContext")]
		public string CallContext
		{
			get{return _CallContext;}
			set
			{
				_CallContext = value;
				OnPropertyChanged();
			}
		}
		private string _CallContextType;
		[CProperty(ColumnPath ="CallContextType")]
		public string CallContextType
		{
			get{return _CallContextType;}
			set
			{
				_CallContextType = value;
				OnPropertyChanged();
			}
		}
		private string _CalledId;
		[CProperty(ColumnPath ="CalledId")]
		public string CalledId
		{
			get{return _CalledId;}
			set
			{
				_CalledId = value;
				OnPropertyChanged();
			}
		}
		private string _CallerId;
		[CProperty(ColumnPath ="CallerId")]
		public string CallerId
		{
			get{return _CallerId;}
			set
			{
				_CallerId = value;
				OnPropertyChanged();
			}
		}
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
		private DateTime _ConnectionStartTime;
		[CProperty(ColumnPath ="ConnectionStartTime")]
		public DateTime ConnectionStartTime
		{
			get{return _ConnectionStartTime;}
			set
			{
				_ConnectionStartTime = value;
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
		private DateTime _CurrentHoldStartTime;
		[CProperty(ColumnPath ="CurrentHoldStartTime")]
		public DateTime CurrentHoldStartTime
		{
			get{return _CurrentHoldStartTime;}
			set
			{
				_CurrentHoldStartTime = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CurrentTalkStartTime;
		[CProperty(ColumnPath ="CurrentTalkStartTime")]
		public DateTime CurrentTalkStartTime
		{
			get{return _CurrentTalkStartTime;}
			set
			{
				_CurrentTalkStartTime = value;
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
		private int _Duration;
		[CProperty(ColumnPath ="Duration")]
		public int Duration
		{
			get{return _Duration;}
			set
			{
				_Duration = value;
				OnPropertyChanged();
			}
		}
		private DateTime _EndDate;
		[CProperty(ColumnPath ="EndDate")]
		public DateTime EndDate
		{
			get{return _EndDate;}
			set
			{
				_EndDate = value;
				OnPropertyChanged();
			}
		}
		private int _HoldTime;
		[CProperty(ColumnPath ="HoldTime")]
		public int HoldTime
		{
			get{return _HoldTime;}
			set
			{
				_HoldTime = value;
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
		private string _IntegrationId;
		[CProperty(ColumnPath ="IntegrationId")]
		public string IntegrationId
		{
			get{return _IntegrationId;}
			set
			{
				_IntegrationId = value;
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
		private Guid _ParentCallId;
		[CProperty(ColumnPath ="ParentCallId")]
		public Guid ParentCallId
		{
			get{return _ParentCallId;}
			set
			{
				_ParentCallId = value;
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
		private string _RedirectingId;
		[CProperty(ColumnPath ="RedirectingId")]
		public string RedirectingId
		{
			get{return _RedirectingId;}
			set
			{
				_RedirectingId = value;
				OnPropertyChanged();
			}
		}
		private string _RedirectionId;
		[CProperty(ColumnPath ="RedirectionId")]
		public string RedirectionId
		{
			get{return _RedirectionId;}
			set
			{
				_RedirectionId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _StartDate;
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate
		{
			get{return _StartDate;}
			set
			{
				_StartDate = value;
				OnPropertyChanged();
			}
		}
		private string _State;
		[CProperty(ColumnPath ="State")]
		public string State
		{
			get{return _State;}
			set
			{
				_State = value;
				OnPropertyChanged();
			}
		}
		private int _TalkTime;
		[CProperty(ColumnPath ="TalkTime")]
		public int TalkTime
		{
			get{return _TalkTime;}
			set
			{
				_TalkTime = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Call:CallId")]
		public Call Call { get; set; }
		[CProperty(Navigation ="Call:ParentCallId")]
		public Call ParentCall { get; set; }
		[CProperty(Navigation ="CallDirection:DirectionId")]
		public CallDirection Direction { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
