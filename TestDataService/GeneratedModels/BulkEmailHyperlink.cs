using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BulkEmailHyperlink")]
	public class BulkEmailHyperlink : BaseEntity
	{
		#region Values
		private int _BpmReplicaMask;
		[CProperty(ColumnPath ="BpmReplicaMask")]
		public int BpmReplicaMask
		{
			get{return _BpmReplicaMask;}
			set
			{
				_BpmReplicaMask = value;
				OnPropertyChanged();
			}
		}
		private int _BpmTrackId;
		[CProperty(ColumnPath ="BpmTrackId")]
		public int BpmTrackId
		{
			get{return _BpmTrackId;}
			set
			{
				_BpmTrackId = value;
				OnPropertyChanged();
			}
		}
		private Guid _BulkEmailId;
		[CProperty(ColumnPath ="BulkEmailId")]
		public Guid BulkEmailId
		{
			get{return _BulkEmailId;}
			set
			{
				_BulkEmailId = value;
				OnPropertyChanged();
			}
		}
		private string _Caption;
		[CProperty(ColumnPath ="Caption")]
		public string Caption
		{
			get{return _Caption;}
			set
			{
				_Caption = value;
				OnPropertyChanged();
			}
		}
		private int _ClicksCount;
		[CProperty(ColumnPath ="ClicksCount")]
		public int ClicksCount
		{
			get{return _ClicksCount;}
			set
			{
				_ClicksCount = value;
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
		private Guid _Hash;
		[CProperty(ColumnPath ="Hash")]
		public Guid Hash
		{
			get{return _Hash;}
			set
			{
				_Hash = value;
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
		private string _Url;
		[CProperty(ColumnPath ="Url")]
		public string Url
		{
			get{return _Url;}
			set
			{
				_Url = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="BulkEmail:BulkEmailId")]
		public BulkEmail BulkEmail { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="VwBulkEmailClickedLink:BulkEmailHyperlinkId")]
		public virtual ICollection<VwBulkEmailClickedLink> VwBulkEmailClickedLinkByBulkEmailHyperlink { get; set; }
		#endregion
	}
}
