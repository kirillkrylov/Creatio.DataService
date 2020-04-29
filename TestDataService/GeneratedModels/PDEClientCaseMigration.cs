using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PDEClientCaseMigration")]
	public class PDEClientCaseMigration : BaseEntity
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
		private Guid _PDEClientNeedId;
		[CProperty(ColumnPath ="PDEClientNeedId")]
		public Guid PDEClientNeedId
		{
			get{return _PDEClientNeedId;}
			set
			{
				_PDEClientNeedId = value;
				OnPropertyChanged();
			}
		}
		private string _PDECommentary;
		[CProperty(ColumnPath ="PDECommentary")]
		public string PDECommentary
		{
			get{return _PDECommentary;}
			set
			{
				_PDECommentary = value;
				OnPropertyChanged();
			}
		}
		private Guid _PDECompetitorProductId;
		[CProperty(ColumnPath ="PDECompetitorProductId")]
		public Guid PDECompetitorProductId
		{
			get{return _PDECompetitorProductId;}
			set
			{
				_PDECompetitorProductId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PDEKnowledgeBaseId;
		[CProperty(ColumnPath ="PDEKnowledgeBaseId")]
		public Guid PDEKnowledgeBaseId
		{
			get{return _PDEKnowledgeBaseId;}
			set
			{
				_PDEKnowledgeBaseId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PDEOurProductId;
		[CProperty(ColumnPath ="PDEOurProductId")]
		public Guid PDEOurProductId
		{
			get{return _PDEOurProductId;}
			set
			{
				_PDEOurProductId = value;
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
		[CProperty(Navigation ="CompetitorProduct:PDECompetitorProductId")]
		public CompetitorProduct PDECompetitorProduct { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="KnowledgeBase:PDEKnowledgeBaseId")]
		public KnowledgeBase PDEKnowledgeBase { get; set; }
		[CProperty(Navigation ="PDEClientCaseNeed:PDEClientNeedId")]
		public PDEClientCaseNeed PDEClientNeed { get; set; }
		[CProperty(Navigation ="Product:PDEOurProductId")]
		public Product PDEOurProduct { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
