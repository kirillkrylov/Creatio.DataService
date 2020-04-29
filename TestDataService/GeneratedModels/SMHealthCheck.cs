using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SMHealthCheck")]
	public class SMHealthCheck : BaseEntity
	{
		#region Values
		private int _AboutBuyingProcessSE;
		[CProperty(ColumnPath ="AboutBuyingProcessSE")]
		public int AboutBuyingProcessSE
		{
			get{return _AboutBuyingProcessSE;}
			set
			{
				_AboutBuyingProcessSE = value;
				OnPropertyChanged();
			}
		}
		private int _AboutBuyingProcessTL;
		[CProperty(ColumnPath ="AboutBuyingProcessTL")]
		public int AboutBuyingProcessTL
		{
			get{return _AboutBuyingProcessTL;}
			set
			{
				_AboutBuyingProcessTL = value;
				OnPropertyChanged();
			}
		}
		private Guid _AccountManagerId;
		[CProperty(ColumnPath ="AccountManagerId")]
		public Guid AccountManagerId
		{
			get{return _AccountManagerId;}
			set
			{
				_AccountManagerId = value;
				OnPropertyChanged();
			}
		}
		private int _ActivitiesSE;
		[CProperty(ColumnPath ="ActivitiesSE")]
		public int ActivitiesSE
		{
			get{return _ActivitiesSE;}
			set
			{
				_ActivitiesSE = value;
				OnPropertyChanged();
			}
		}
		private int _ActivitiesTL;
		[CProperty(ColumnPath ="ActivitiesTL")]
		public int ActivitiesTL
		{
			get{return _ActivitiesTL;}
			set
			{
				_ActivitiesTL = value;
				OnPropertyChanged();
			}
		}
		private int _AdditionalResoursesSE;
		[CProperty(ColumnPath ="AdditionalResoursesSE")]
		public int AdditionalResoursesSE
		{
			get{return _AdditionalResoursesSE;}
			set
			{
				_AdditionalResoursesSE = value;
				OnPropertyChanged();
			}
		}
		private int _AdditionalResoursesTL;
		[CProperty(ColumnPath ="AdditionalResoursesTL")]
		public int AdditionalResoursesTL
		{
			get{return _AdditionalResoursesTL;}
			set
			{
				_AdditionalResoursesTL = value;
				OnPropertyChanged();
			}
		}
		private int _BANTSE;
		[CProperty(ColumnPath ="BANTSE")]
		public int BANTSE
		{
			get{return _BANTSE;}
			set
			{
				_BANTSE = value;
				OnPropertyChanged();
			}
		}
		private int _BANTTL;
		[CProperty(ColumnPath ="BANTTL")]
		public int BANTTL
		{
			get{return _BANTTL;}
			set
			{
				_BANTTL = value;
				OnPropertyChanged();
			}
		}
		private int _Block9SE;
		[CProperty(ColumnPath ="Block9SE")]
		public int Block9SE
		{
			get{return _Block9SE;}
			set
			{
				_Block9SE = value;
				OnPropertyChanged();
			}
		}
		private int _Block9TL;
		[CProperty(ColumnPath ="Block9TL")]
		public int Block9TL
		{
			get{return _Block9TL;}
			set
			{
				_Block9TL = value;
				OnPropertyChanged();
			}
		}
		private int _BusinessCardSE;
		[CProperty(ColumnPath ="BusinessCardSE")]
		public int BusinessCardSE
		{
			get{return _BusinessCardSE;}
			set
			{
				_BusinessCardSE = value;
				OnPropertyChanged();
			}
		}
		private int _BusinessCardTL;
		[CProperty(ColumnPath ="BusinessCardTL")]
		public int BusinessCardTL
		{
			get{return _BusinessCardTL;}
			set
			{
				_BusinessCardTL = value;
				OnPropertyChanged();
			}
		}
		private int _BuyingProcessSE;
		[CProperty(ColumnPath ="BuyingProcessSE")]
		public int BuyingProcessSE
		{
			get{return _BuyingProcessSE;}
			set
			{
				_BuyingProcessSE = value;
				OnPropertyChanged();
			}
		}
		private int _BuyingProcessTL;
		[CProperty(ColumnPath ="BuyingProcessTL")]
		public int BuyingProcessTL
		{
			get{return _BuyingProcessTL;}
			set
			{
				_BuyingProcessTL = value;
				OnPropertyChanged();
			}
		}
		private int _ChampionFormationSE;
		[CProperty(ColumnPath ="ChampionFormationSE")]
		public int ChampionFormationSE
		{
			get{return _ChampionFormationSE;}
			set
			{
				_ChampionFormationSE = value;
				OnPropertyChanged();
			}
		}
		private int _ChampionFormationTL;
		[CProperty(ColumnPath ="ChampionFormationTL")]
		public int ChampionFormationTL
		{
			get{return _ChampionFormationTL;}
			set
			{
				_ChampionFormationTL = value;
				OnPropertyChanged();
			}
		}
		private int _ClearInfoSE;
		[CProperty(ColumnPath ="ClearInfoSE")]
		public int ClearInfoSE
		{
			get{return _ClearInfoSE;}
			set
			{
				_ClearInfoSE = value;
				OnPropertyChanged();
			}
		}
		private int _ClearInfoTL;
		[CProperty(ColumnPath ="ClearInfoTL")]
		public int ClearInfoTL
		{
			get{return _ClearInfoTL;}
			set
			{
				_ClearInfoTL = value;
				OnPropertyChanged();
			}
		}
		private int _ClientBudgetSE;
		[CProperty(ColumnPath ="ClientBudgetSE")]
		public int ClientBudgetSE
		{
			get{return _ClientBudgetSE;}
			set
			{
				_ClientBudgetSE = value;
				OnPropertyChanged();
			}
		}
		private int _ClientBudgetTL;
		[CProperty(ColumnPath ="ClientBudgetTL")]
		public int ClientBudgetTL
		{
			get{return _ClientBudgetTL;}
			set
			{
				_ClientBudgetTL = value;
				OnPropertyChanged();
			}
		}
		private int _ClientInfoSE;
		[CProperty(ColumnPath ="ClientInfoSE")]
		public int ClientInfoSE
		{
			get{return _ClientInfoSE;}
			set
			{
				_ClientInfoSE = value;
				OnPropertyChanged();
			}
		}
		private int _ClientInfoTL;
		[CProperty(ColumnPath ="ClientInfoTL")]
		public int ClientInfoTL
		{
			get{return _ClientInfoTL;}
			set
			{
				_ClientInfoTL = value;
				OnPropertyChanged();
			}
		}
		private int _CommunicationsHistorySE;
		[CProperty(ColumnPath ="CommunicationsHistorySE")]
		public int CommunicationsHistorySE
		{
			get{return _CommunicationsHistorySE;}
			set
			{
				_CommunicationsHistorySE = value;
				OnPropertyChanged();
			}
		}
		private int _CommunicationsHistoryTL;
		[CProperty(ColumnPath ="CommunicationsHistoryTL")]
		public int CommunicationsHistoryTL
		{
			get{return _CommunicationsHistoryTL;}
			set
			{
				_CommunicationsHistoryTL = value;
				OnPropertyChanged();
			}
		}
		private int _CompetitiveEnvironmentSE;
		[CProperty(ColumnPath ="CompetitiveEnvironmentSE")]
		public int CompetitiveEnvironmentSE
		{
			get{return _CompetitiveEnvironmentSE;}
			set
			{
				_CompetitiveEnvironmentSE = value;
				OnPropertyChanged();
			}
		}
		private int _CompetitiveEnvironmentTL;
		[CProperty(ColumnPath ="CompetitiveEnvironmentTL")]
		public int CompetitiveEnvironmentTL
		{
			get{return _CompetitiveEnvironmentTL;}
			set
			{
				_CompetitiveEnvironmentTL = value;
				OnPropertyChanged();
			}
		}
		private int _CompetitorSE;
		[CProperty(ColumnPath ="CompetitorSE")]
		public int CompetitorSE
		{
			get{return _CompetitorSE;}
			set
			{
				_CompetitorSE = value;
				OnPropertyChanged();
			}
		}
		private int _CompetitorTL;
		[CProperty(ColumnPath ="CompetitorTL")]
		public int CompetitorTL
		{
			get{return _CompetitorTL;}
			set
			{
				_CompetitorTL = value;
				OnPropertyChanged();
			}
		}
		private string _Conclusion;
		[CProperty(ColumnPath ="Conclusion")]
		public string Conclusion
		{
			get{return _Conclusion;}
			set
			{
				_Conclusion = value;
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
		private int _CriteriaUnderstandingSE;
		[CProperty(ColumnPath ="CriteriaUnderstandingSE")]
		public int CriteriaUnderstandingSE
		{
			get{return _CriteriaUnderstandingSE;}
			set
			{
				_CriteriaUnderstandingSE = value;
				OnPropertyChanged();
			}
		}
		private int _CriteriaUnderstandingTL;
		[CProperty(ColumnPath ="CriteriaUnderstandingTL")]
		public int CriteriaUnderstandingTL
		{
			get{return _CriteriaUnderstandingTL;}
			set
			{
				_CriteriaUnderstandingTL = value;
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
		private int _DatePlanningSE;
		[CProperty(ColumnPath ="DatePlanningSE")]
		public int DatePlanningSE
		{
			get{return _DatePlanningSE;}
			set
			{
				_DatePlanningSE = value;
				OnPropertyChanged();
			}
		}
		private int _DatePlanningTL;
		[CProperty(ColumnPath ="DatePlanningTL")]
		public int DatePlanningTL
		{
			get{return _DatePlanningTL;}
			set
			{
				_DatePlanningTL = value;
				OnPropertyChanged();
			}
		}
		private Guid _DDId;
		[CProperty(ColumnPath ="DDId")]
		public Guid DDId
		{
			get{return _DDId;}
			set
			{
				_DDId = value;
				OnPropertyChanged();
			}
		}
		private int _DecisionMapSE;
		[CProperty(ColumnPath ="DecisionMapSE")]
		public int DecisionMapSE
		{
			get{return _DecisionMapSE;}
			set
			{
				_DecisionMapSE = value;
				OnPropertyChanged();
			}
		}
		private int _DecisionMapTL;
		[CProperty(ColumnPath ="DecisionMapTL")]
		public int DecisionMapTL
		{
			get{return _DecisionMapTL;}
			set
			{
				_DecisionMapTL = value;
				OnPropertyChanged();
			}
		}
		private int _DifferentiationMatrixSE;
		[CProperty(ColumnPath ="DifferentiationMatrixSE")]
		public int DifferentiationMatrixSE
		{
			get{return _DifferentiationMatrixSE;}
			set
			{
				_DifferentiationMatrixSE = value;
				OnPropertyChanged();
			}
		}
		private int _DifferentiationMatrixTL;
		[CProperty(ColumnPath ="DifferentiationMatrixTL")]
		public int DifferentiationMatrixTL
		{
			get{return _DifferentiationMatrixTL;}
			set
			{
				_DifferentiationMatrixTL = value;
				OnPropertyChanged();
			}
		}
		private int _DiscoveryCall;
		[CProperty(ColumnPath ="DiscoveryCall")]
		public int DiscoveryCall
		{
			get{return _DiscoveryCall;}
			set
			{
				_DiscoveryCall = value;
				OnPropertyChanged();
			}
		}
		private int _DiscoveryCallPC;
		[CProperty(ColumnPath ="DiscoveryCallPC")]
		public int DiscoveryCallPC
		{
			get{return _DiscoveryCallPC;}
			set
			{
				_DiscoveryCallPC = value;
				OnPropertyChanged();
			}
		}
		private int _DiscoveryCallSE;
		[CProperty(ColumnPath ="DiscoveryCallSE")]
		public int DiscoveryCallSE
		{
			get{return _DiscoveryCallSE;}
			set
			{
				_DiscoveryCallSE = value;
				OnPropertyChanged();
			}
		}
		private int _DiscoveryCallTL;
		[CProperty(ColumnPath ="DiscoveryCallTL")]
		public int DiscoveryCallTL
		{
			get{return _DiscoveryCallTL;}
			set
			{
				_DiscoveryCallTL = value;
				OnPropertyChanged();
			}
		}
		private Guid _EmployeeId;
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId
		{
			get{return _EmployeeId;}
			set
			{
				_EmployeeId = value;
				OnPropertyChanged();
			}
		}
		private int _EvaluationPlanSE;
		[CProperty(ColumnPath ="EvaluationPlanSE")]
		public int EvaluationPlanSE
		{
			get{return _EvaluationPlanSE;}
			set
			{
				_EvaluationPlanSE = value;
				OnPropertyChanged();
			}
		}
		private int _EvaluationPlanTL;
		[CProperty(ColumnPath ="EvaluationPlanTL")]
		public int EvaluationPlanTL
		{
			get{return _EvaluationPlanTL;}
			set
			{
				_EvaluationPlanTL = value;
				OnPropertyChanged();
			}
		}
		private int _GiveGetSE;
		[CProperty(ColumnPath ="GiveGetSE")]
		public int GiveGetSE
		{
			get{return _GiveGetSE;}
			set
			{
				_GiveGetSE = value;
				OnPropertyChanged();
			}
		}
		private int _GiveGetTL;
		[CProperty(ColumnPath ="GiveGetTL")]
		public int GiveGetTL
		{
			get{return _GiveGetTL;}
			set
			{
				_GiveGetTL = value;
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
		private int _IntroductionSE;
		[CProperty(ColumnPath ="IntroductionSE")]
		public int IntroductionSE
		{
			get{return _IntroductionSE;}
			set
			{
				_IntroductionSE = value;
				OnPropertyChanged();
			}
		}
		private int _IntroductionTL;
		[CProperty(ColumnPath ="IntroductionTL")]
		public int IntroductionTL
		{
			get{return _IntroductionTL;}
			set
			{
				_IntroductionTL = value;
				OnPropertyChanged();
			}
		}
		private bool _IsActive;
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive
		{
			get{return _IsActive;}
			set
			{
				_IsActive = value;
				OnPropertyChanged();
			}
		}
		private int _KeyPainConfirmSE;
		[CProperty(ColumnPath ="KeyPainConfirmSE")]
		public int KeyPainConfirmSE
		{
			get{return _KeyPainConfirmSE;}
			set
			{
				_KeyPainConfirmSE = value;
				OnPropertyChanged();
			}
		}
		private int _KeyPainConfirmTL;
		[CProperty(ColumnPath ="KeyPainConfirmTL")]
		public int KeyPainConfirmTL
		{
			get{return _KeyPainConfirmTL;}
			set
			{
				_KeyPainConfirmTL = value;
				OnPropertyChanged();
			}
		}
		private int _KeyPlayerListSE;
		[CProperty(ColumnPath ="KeyPlayerListSE")]
		public int KeyPlayerListSE
		{
			get{return _KeyPlayerListSE;}
			set
			{
				_KeyPlayerListSE = value;
				OnPropertyChanged();
			}
		}
		private int _KeyPlayerListTL;
		[CProperty(ColumnPath ="KeyPlayerListTL")]
		public int KeyPlayerListTL
		{
			get{return _KeyPlayerListTL;}
			set
			{
				_KeyPlayerListTL = value;
				OnPropertyChanged();
			}
		}
		private Guid _MarketId;
		[CProperty(ColumnPath ="MarketId")]
		public Guid MarketId
		{
			get{return _MarketId;}
			set
			{
				_MarketId = value;
				OnPropertyChanged();
			}
		}
		private int _MeetingTimeSE;
		[CProperty(ColumnPath ="MeetingTimeSE")]
		public int MeetingTimeSE
		{
			get{return _MeetingTimeSE;}
			set
			{
				_MeetingTimeSE = value;
				OnPropertyChanged();
			}
		}
		private int _MeetingTimeTL;
		[CProperty(ColumnPath ="MeetingTimeTL")]
		public int MeetingTimeTL
		{
			get{return _MeetingTimeTL;}
			set
			{
				_MeetingTimeTL = value;
				OnPropertyChanged();
			}
		}
		private int _MeetTimeLimitSE;
		[CProperty(ColumnPath ="MeetTimeLimitSE")]
		public int MeetTimeLimitSE
		{
			get{return _MeetTimeLimitSE;}
			set
			{
				_MeetTimeLimitSE = value;
				OnPropertyChanged();
			}
		}
		private int _MeetTimeLimitTL;
		[CProperty(ColumnPath ="MeetTimeLimitTL")]
		public int MeetTimeLimitTL
		{
			get{return _MeetTimeLimitTL;}
			set
			{
				_MeetTimeLimitTL = value;
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
		private int _NecessaryQuestionsSE;
		[CProperty(ColumnPath ="NecessaryQuestionsSE")]
		public int NecessaryQuestionsSE
		{
			get{return _NecessaryQuestionsSE;}
			set
			{
				_NecessaryQuestionsSE = value;
				OnPropertyChanged();
			}
		}
		private int _NecessaryQuestionsTL;
		[CProperty(ColumnPath ="NecessaryQuestionsTL")]
		public int NecessaryQuestionsTL
		{
			get{return _NecessaryQuestionsTL;}
			set
			{
				_NecessaryQuestionsTL = value;
				OnPropertyChanged();
			}
		}
		private int _NextStepsSE;
		[CProperty(ColumnPath ="NextStepsSE")]
		public int NextStepsSE
		{
			get{return _NextStepsSE;}
			set
			{
				_NextStepsSE = value;
				OnPropertyChanged();
			}
		}
		private int _NextStepsTL;
		[CProperty(ColumnPath ="NextStepsTL")]
		public int NextStepsTL
		{
			get{return _NextStepsTL;}
			set
			{
				_NextStepsTL = value;
				OnPropertyChanged();
			}
		}
		private int _NotesSE;
		[CProperty(ColumnPath ="NotesSE")]
		public int NotesSE
		{
			get{return _NotesSE;}
			set
			{
				_NotesSE = value;
				OnPropertyChanged();
			}
		}
		private int _NotesTL;
		[CProperty(ColumnPath ="NotesTL")]
		public int NotesTL
		{
			get{return _NotesTL;}
			set
			{
				_NotesTL = value;
				OnPropertyChanged();
			}
		}
		private int _OverallCommon;
		[CProperty(ColumnPath ="OverallCommon")]
		public int OverallCommon
		{
			get{return _OverallCommon;}
			set
			{
				_OverallCommon = value;
				OnPropertyChanged();
			}
		}
		private int _OverallCommonPC;
		[CProperty(ColumnPath ="OverallCommonPC")]
		public int OverallCommonPC
		{
			get{return _OverallCommonPC;}
			set
			{
				_OverallCommonPC = value;
				OnPropertyChanged();
			}
		}
		private int _OverallCommonSE;
		[CProperty(ColumnPath ="OverallCommonSE")]
		public int OverallCommonSE
		{
			get{return _OverallCommonSE;}
			set
			{
				_OverallCommonSE = value;
				OnPropertyChanged();
			}
		}
		private int _OverallCommonTL;
		[CProperty(ColumnPath ="OverallCommonTL")]
		public int OverallCommonTL
		{
			get{return _OverallCommonTL;}
			set
			{
				_OverallCommonTL = value;
				OnPropertyChanged();
			}
		}
		private int _OverallInstruments;
		[CProperty(ColumnPath ="OverallInstruments")]
		public int OverallInstruments
		{
			get{return _OverallInstruments;}
			set
			{
				_OverallInstruments = value;
				OnPropertyChanged();
			}
		}
		private int _OverallInstrumentsPC;
		[CProperty(ColumnPath ="OverallInstrumentsPC")]
		public int OverallInstrumentsPC
		{
			get{return _OverallInstrumentsPC;}
			set
			{
				_OverallInstrumentsPC = value;
				OnPropertyChanged();
			}
		}
		private int _OverallInstrumentsSE;
		[CProperty(ColumnPath ="OverallInstrumentsSE")]
		public int OverallInstrumentsSE
		{
			get{return _OverallInstrumentsSE;}
			set
			{
				_OverallInstrumentsSE = value;
				OnPropertyChanged();
			}
		}
		private int _OverallInstrumentsTL;
		[CProperty(ColumnPath ="OverallInstrumentsTL")]
		public int OverallInstrumentsTL
		{
			get{return _OverallInstrumentsTL;}
			set
			{
				_OverallInstrumentsTL = value;
				OnPropertyChanged();
			}
		}
		private int _OverallMeeting;
		[CProperty(ColumnPath ="OverallMeeting")]
		public int OverallMeeting
		{
			get{return _OverallMeeting;}
			set
			{
				_OverallMeeting = value;
				OnPropertyChanged();
			}
		}
		private int _OverallMeetingPC;
		[CProperty(ColumnPath ="OverallMeetingPC")]
		public int OverallMeetingPC
		{
			get{return _OverallMeetingPC;}
			set
			{
				_OverallMeetingPC = value;
				OnPropertyChanged();
			}
		}
		private int _OverallMeetingSE;
		[CProperty(ColumnPath ="OverallMeetingSE")]
		public int OverallMeetingSE
		{
			get{return _OverallMeetingSE;}
			set
			{
				_OverallMeetingSE = value;
				OnPropertyChanged();
			}
		}
		private int _OverallMeetingTL;
		[CProperty(ColumnPath ="OverallMeetingTL")]
		public int OverallMeetingTL
		{
			get{return _OverallMeetingTL;}
			set
			{
				_OverallMeetingTL = value;
				OnPropertyChanged();
			}
		}
		private int _OverallPreparation;
		[CProperty(ColumnPath ="OverallPreparation")]
		public int OverallPreparation
		{
			get{return _OverallPreparation;}
			set
			{
				_OverallPreparation = value;
				OnPropertyChanged();
			}
		}
		private int _OverallPreparationPC;
		[CProperty(ColumnPath ="OverallPreparationPC")]
		public int OverallPreparationPC
		{
			get{return _OverallPreparationPC;}
			set
			{
				_OverallPreparationPC = value;
				OnPropertyChanged();
			}
		}
		private int _OverallPreparationSE;
		[CProperty(ColumnPath ="OverallPreparationSE")]
		public int OverallPreparationSE
		{
			get{return _OverallPreparationSE;}
			set
			{
				_OverallPreparationSE = value;
				OnPropertyChanged();
			}
		}
		private int _OverallPreparationTL;
		[CProperty(ColumnPath ="OverallPreparationTL")]
		public int OverallPreparationTL
		{
			get{return _OverallPreparationTL;}
			set
			{
				_OverallPreparationTL = value;
				OnPropertyChanged();
			}
		}
		private int _OverallQuestions;
		[CProperty(ColumnPath ="OverallQuestions")]
		public int OverallQuestions
		{
			get{return _OverallQuestions;}
			set
			{
				_OverallQuestions = value;
				OnPropertyChanged();
			}
		}
		private int _OverallQuestionsPC;
		[CProperty(ColumnPath ="OverallQuestionsPC")]
		public int OverallQuestionsPC
		{
			get{return _OverallQuestionsPC;}
			set
			{
				_OverallQuestionsPC = value;
				OnPropertyChanged();
			}
		}
		private int _OverallQuestionsSE;
		[CProperty(ColumnPath ="OverallQuestionsSE")]
		public int OverallQuestionsSE
		{
			get{return _OverallQuestionsSE;}
			set
			{
				_OverallQuestionsSE = value;
				OnPropertyChanged();
			}
		}
		private int _OverallQuestionsTL;
		[CProperty(ColumnPath ="OverallQuestionsTL")]
		public int OverallQuestionsTL
		{
			get{return _OverallQuestionsTL;}
			set
			{
				_OverallQuestionsTL = value;
				OnPropertyChanged();
			}
		}
		private int _OverallRating;
		[CProperty(ColumnPath ="OverallRating")]
		public int OverallRating
		{
			get{return _OverallRating;}
			set
			{
				_OverallRating = value;
				OnPropertyChanged();
			}
		}
		private int _OverallRatingPC;
		[CProperty(ColumnPath ="OverallRatingPC")]
		public int OverallRatingPC
		{
			get{return _OverallRatingPC;}
			set
			{
				_OverallRatingPC = value;
				OnPropertyChanged();
			}
		}
		private int _OverallSaleManagement;
		[CProperty(ColumnPath ="OverallSaleManagement")]
		public int OverallSaleManagement
		{
			get{return _OverallSaleManagement;}
			set
			{
				_OverallSaleManagement = value;
				OnPropertyChanged();
			}
		}
		private int _OverallSaleManagementPC;
		[CProperty(ColumnPath ="OverallSaleManagementPC")]
		public int OverallSaleManagementPC
		{
			get{return _OverallSaleManagementPC;}
			set
			{
				_OverallSaleManagementPC = value;
				OnPropertyChanged();
			}
		}
		private int _OverallSaleManagementSE;
		[CProperty(ColumnPath ="OverallSaleManagementSE")]
		public int OverallSaleManagementSE
		{
			get{return _OverallSaleManagementSE;}
			set
			{
				_OverallSaleManagementSE = value;
				OnPropertyChanged();
			}
		}
		private int _OverallSaleManagementTL;
		[CProperty(ColumnPath ="OverallSaleManagementTL")]
		public int OverallSaleManagementTL
		{
			get{return _OverallSaleManagementTL;}
			set
			{
				_OverallSaleManagementTL = value;
				OnPropertyChanged();
			}
		}
		private int _OverallSE;
		[CProperty(ColumnPath ="OverallSE")]
		public int OverallSE
		{
			get{return _OverallSE;}
			set
			{
				_OverallSE = value;
				OnPropertyChanged();
			}
		}
		private int _OverallSEpc;
		[CProperty(ColumnPath ="OverallSEpc")]
		public int OverallSEpc
		{
			get{return _OverallSEpc;}
			set
			{
				_OverallSEpc = value;
				OnPropertyChanged();
			}
		}
		private int _OverallTL;
		[CProperty(ColumnPath ="OverallTL")]
		public int OverallTL
		{
			get{return _OverallTL;}
			set
			{
				_OverallTL = value;
				OnPropertyChanged();
			}
		}
		private int _OverallTLpc;
		[CProperty(ColumnPath ="OverallTLpc")]
		public int OverallTLpc
		{
			get{return _OverallTLpc;}
			set
			{
				_OverallTLpc = value;
				OnPropertyChanged();
			}
		}
		private int _Pain3rolesSE;
		[CProperty(ColumnPath ="Pain3rolesSE")]
		public int Pain3rolesSE
		{
			get{return _Pain3rolesSE;}
			set
			{
				_Pain3rolesSE = value;
				OnPropertyChanged();
			}
		}
		private int _Pain3rolesTL;
		[CProperty(ColumnPath ="Pain3rolesTL")]
		public int Pain3rolesTL
		{
			get{return _Pain3rolesTL;}
			set
			{
				_Pain3rolesTL = value;
				OnPropertyChanged();
			}
		}
		private int _PainChainSE;
		[CProperty(ColumnPath ="PainChainSE")]
		public int PainChainSE
		{
			get{return _PainChainSE;}
			set
			{
				_PainChainSE = value;
				OnPropertyChanged();
			}
		}
		private int _PainChainTL;
		[CProperty(ColumnPath ="PainChainTL")]
		public int PainChainTL
		{
			get{return _PainChainTL;}
			set
			{
				_PainChainTL = value;
				OnPropertyChanged();
			}
		}
		private int _ParticipantsRolesSE;
		[CProperty(ColumnPath ="ParticipantsRolesSE")]
		public int ParticipantsRolesSE
		{
			get{return _ParticipantsRolesSE;}
			set
			{
				_ParticipantsRolesSE = value;
				OnPropertyChanged();
			}
		}
		private int _ParticipantsRolesTL;
		[CProperty(ColumnPath ="ParticipantsRolesTL")]
		public int ParticipantsRolesTL
		{
			get{return _ParticipantsRolesTL;}
			set
			{
				_ParticipantsRolesTL = value;
				OnPropertyChanged();
			}
		}
		private Guid _PeriodId;
		[CProperty(ColumnPath ="PeriodId")]
		public Guid PeriodId
		{
			get{return _PeriodId;}
			set
			{
				_PeriodId = value;
				OnPropertyChanged();
			}
		}
		private int _PlannedStepsSE;
		[CProperty(ColumnPath ="PlannedStepsSE")]
		public int PlannedStepsSE
		{
			get{return _PlannedStepsSE;}
			set
			{
				_PlannedStepsSE = value;
				OnPropertyChanged();
			}
		}
		private int _PlannedStepsTL;
		[CProperty(ColumnPath ="PlannedStepsTL")]
		public int PlannedStepsTL
		{
			get{return _PlannedStepsTL;}
			set
			{
				_PlannedStepsTL = value;
				OnPropertyChanged();
			}
		}
		private int _PowerSponsorSE;
		[CProperty(ColumnPath ="PowerSponsorSE")]
		public int PowerSponsorSE
		{
			get{return _PowerSponsorSE;}
			set
			{
				_PowerSponsorSE = value;
				OnPropertyChanged();
			}
		}
		private int _PowerSponsorTL;
		[CProperty(ColumnPath ="PowerSponsorTL")]
		public int PowerSponsorTL
		{
			get{return _PowerSponsorTL;}
			set
			{
				_PowerSponsorTL = value;
				OnPropertyChanged();
			}
		}
		private int _PPVVCSE;
		[CProperty(ColumnPath ="PPVVCSE")]
		public int PPVVCSE
		{
			get{return _PPVVCSE;}
			set
			{
				_PPVVCSE = value;
				OnPropertyChanged();
			}
		}
		private int _PPVVCTL;
		[CProperty(ColumnPath ="PPVVCTL")]
		public int PPVVCTL
		{
			get{return _PPVVCTL;}
			set
			{
				_PPVVCTL = value;
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
		private int _ProductKnowledgeSE;
		[CProperty(ColumnPath ="ProductKnowledgeSE")]
		public int ProductKnowledgeSE
		{
			get{return _ProductKnowledgeSE;}
			set
			{
				_ProductKnowledgeSE = value;
				OnPropertyChanged();
			}
		}
		private int _ProductKnowledgeTL;
		[CProperty(ColumnPath ="ProductKnowledgeTL")]
		public int ProductKnowledgeTL
		{
			get{return _ProductKnowledgeTL;}
			set
			{
				_ProductKnowledgeTL = value;
				OnPropertyChanged();
			}
		}
		private int _ReferencePresentationSE;
		[CProperty(ColumnPath ="ReferencePresentationSE")]
		public int ReferencePresentationSE
		{
			get{return _ReferencePresentationSE;}
			set
			{
				_ReferencePresentationSE = value;
				OnPropertyChanged();
			}
		}
		private int _ReferencePresentationTL;
		[CProperty(ColumnPath ="ReferencePresentationTL")]
		public int ReferencePresentationTL
		{
			get{return _ReferencePresentationTL;}
			set
			{
				_ReferencePresentationTL = value;
				OnPropertyChanged();
			}
		}
		private Guid _ResponsibleSEId;
		[CProperty(ColumnPath ="ResponsibleSEId")]
		public Guid ResponsibleSEId
		{
			get{return _ResponsibleSEId;}
			set
			{
				_ResponsibleSEId = value;
				OnPropertyChanged();
			}
		}
		private int _ResumeSE;
		[CProperty(ColumnPath ="ResumeSE")]
		public int ResumeSE
		{
			get{return _ResumeSE;}
			set
			{
				_ResumeSE = value;
				OnPropertyChanged();
			}
		}
		private int _ResumeTL;
		[CProperty(ColumnPath ="ResumeTL")]
		public int ResumeTL
		{
			get{return _ResumeTL;}
			set
			{
				_ResumeTL = value;
				OnPropertyChanged();
			}
		}
		private int _RightPresentationSE;
		[CProperty(ColumnPath ="RightPresentationSE")]
		public int RightPresentationSE
		{
			get{return _RightPresentationSE;}
			set
			{
				_RightPresentationSE = value;
				OnPropertyChanged();
			}
		}
		private int _RightPresentationTL;
		[CProperty(ColumnPath ="RightPresentationTL")]
		public int RightPresentationTL
		{
			get{return _RightPresentationTL;}
			set
			{
				_RightPresentationTL = value;
				OnPropertyChanged();
			}
		}
		private Guid _RoleId;
		[CProperty(ColumnPath ="RoleId")]
		public Guid RoleId
		{
			get{return _RoleId;}
			set
			{
				_RoleId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SegmentId;
		[CProperty(ColumnPath ="SegmentId")]
		public Guid SegmentId
		{
			get{return _SegmentId;}
			set
			{
				_SegmentId = value;
				OnPropertyChanged();
			}
		}
		private int _SmallTalkSE;
		[CProperty(ColumnPath ="SmallTalkSE")]
		public int SmallTalkSE
		{
			get{return _SmallTalkSE;}
			set
			{
				_SmallTalkSE = value;
				OnPropertyChanged();
			}
		}
		private int _SmallTalkTL;
		[CProperty(ColumnPath ="SmallTalkTL")]
		public int SmallTalkTL
		{
			get{return _SmallTalkTL;}
			set
			{
				_SmallTalkTL = value;
				OnPropertyChanged();
			}
		}
		private int _StartInTimeSE;
		[CProperty(ColumnPath ="StartInTimeSE")]
		public int StartInTimeSE
		{
			get{return _StartInTimeSE;}
			set
			{
				_StartInTimeSE = value;
				OnPropertyChanged();
			}
		}
		private int _StartInTimeTL;
		[CProperty(ColumnPath ="StartInTimeTL")]
		public int StartInTimeTL
		{
			get{return _StartInTimeTL;}
			set
			{
				_StartInTimeTL = value;
				OnPropertyChanged();
			}
		}
		private int _StrengthsWeaknessesSE;
		[CProperty(ColumnPath ="StrengthsWeaknessesSE")]
		public int StrengthsWeaknessesSE
		{
			get{return _StrengthsWeaknessesSE;}
			set
			{
				_StrengthsWeaknessesSE = value;
				OnPropertyChanged();
			}
		}
		private int _StrengthsWeaknessesTL;
		[CProperty(ColumnPath ="StrengthsWeaknessesTL")]
		public int StrengthsWeaknessesTL
		{
			get{return _StrengthsWeaknessesTL;}
			set
			{
				_StrengthsWeaknessesTL = value;
				OnPropertyChanged();
			}
		}
		private int _SuccessStoriesSE;
		[CProperty(ColumnPath ="SuccessStoriesSE")]
		public int SuccessStoriesSE
		{
			get{return _SuccessStoriesSE;}
			set
			{
				_SuccessStoriesSE = value;
				OnPropertyChanged();
			}
		}
		private int _SuccessStoriesTL;
		[CProperty(ColumnPath ="SuccessStoriesTL")]
		public int SuccessStoriesTL
		{
			get{return _SuccessStoriesTL;}
			set
			{
				_SuccessStoriesTL = value;
				OnPropertyChanged();
			}
		}
		private int _SWOTSE;
		[CProperty(ColumnPath ="SWOTSE")]
		public int SWOTSE
		{
			get{return _SWOTSE;}
			set
			{
				_SWOTSE = value;
				OnPropertyChanged();
			}
		}
		private int _SWOTTL;
		[CProperty(ColumnPath ="SWOTTL")]
		public int SWOTTL
		{
			get{return _SWOTTL;}
			set
			{
				_SWOTTL = value;
				OnPropertyChanged();
			}
		}
		private Guid _TypeId;
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId
		{
			get{return _TypeId;}
			set
			{
				_TypeId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Employee:AccountManagerId")]
		public Employee AccountManager { get; set; }
		[CProperty(Navigation ="Employee:EmployeeId")]
		public Employee Employee { get; set; }
		[CProperty(Navigation ="Employee:ResponsibleSEId")]
		public Employee ResponsibleSE { get; set; }
		[CProperty(Navigation ="Employee:DDId")]
		public Employee DD { get; set; }
		[CProperty(Navigation ="EmployeeJob:RoleId")]
		public EmployeeJob Role { get; set; }
		[CProperty(Navigation ="EvaluationPeriod:PeriodId")]
		public EvaluationPeriod Period { get; set; }
		[CProperty(Navigation ="MRKEvaluation:TypeId")]
		public MRKEvaluation Type { get; set; }
		[CProperty(Navigation ="TsSalesCareerMarket:MarketId")]
		public TsSalesCareerMarket Market { get; set; }
		[CProperty(Navigation ="TsSalesCareerSegment:SegmentId")]
		public TsSalesCareerSegment Segment { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
