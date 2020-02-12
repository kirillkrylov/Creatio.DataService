using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SMHealthCheck")]
	public class SMHealthCheck : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AboutBuyingProcessSE")]
		public int AboutBuyingProcessSE { get; set; }
		[CProperty(ColumnPath ="AboutBuyingProcessTL")]
		public int AboutBuyingProcessTL { get; set; }
		[CProperty(ColumnPath ="AccountManagerId")]
		public Guid AccountManagerId { get; set; }
		[CProperty(ColumnPath ="ActivitiesSE")]
		public int ActivitiesSE { get; set; }
		[CProperty(ColumnPath ="ActivitiesTL")]
		public int ActivitiesTL { get; set; }
		[CProperty(ColumnPath ="AdditionalResoursesSE")]
		public int AdditionalResoursesSE { get; set; }
		[CProperty(ColumnPath ="AdditionalResoursesTL")]
		public int AdditionalResoursesTL { get; set; }
		[CProperty(ColumnPath ="BANTSE")]
		public int BANTSE { get; set; }
		[CProperty(ColumnPath ="BANTTL")]
		public int BANTTL { get; set; }
		[CProperty(ColumnPath ="Block9SE")]
		public int Block9SE { get; set; }
		[CProperty(ColumnPath ="Block9TL")]
		public int Block9TL { get; set; }
		[CProperty(ColumnPath ="BusinessCardSE")]
		public int BusinessCardSE { get; set; }
		[CProperty(ColumnPath ="BusinessCardTL")]
		public int BusinessCardTL { get; set; }
		[CProperty(ColumnPath ="BuyingProcessSE")]
		public int BuyingProcessSE { get; set; }
		[CProperty(ColumnPath ="BuyingProcessTL")]
		public int BuyingProcessTL { get; set; }
		[CProperty(ColumnPath ="ChampionFormationSE")]
		public int ChampionFormationSE { get; set; }
		[CProperty(ColumnPath ="ChampionFormationTL")]
		public int ChampionFormationTL { get; set; }
		[CProperty(ColumnPath ="ClearInfoSE")]
		public int ClearInfoSE { get; set; }
		[CProperty(ColumnPath ="ClearInfoTL")]
		public int ClearInfoTL { get; set; }
		[CProperty(ColumnPath ="ClientBudgetSE")]
		public int ClientBudgetSE { get; set; }
		[CProperty(ColumnPath ="ClientBudgetTL")]
		public int ClientBudgetTL { get; set; }
		[CProperty(ColumnPath ="ClientInfoSE")]
		public int ClientInfoSE { get; set; }
		[CProperty(ColumnPath ="ClientInfoTL")]
		public int ClientInfoTL { get; set; }
		[CProperty(ColumnPath ="CommunicationsHistorySE")]
		public int CommunicationsHistorySE { get; set; }
		[CProperty(ColumnPath ="CommunicationsHistoryTL")]
		public int CommunicationsHistoryTL { get; set; }
		[CProperty(ColumnPath ="CompetitiveEnvironmentSE")]
		public int CompetitiveEnvironmentSE { get; set; }
		[CProperty(ColumnPath ="CompetitiveEnvironmentTL")]
		public int CompetitiveEnvironmentTL { get; set; }
		[CProperty(ColumnPath ="CompetitorSE")]
		public int CompetitorSE { get; set; }
		[CProperty(ColumnPath ="CompetitorTL")]
		public int CompetitorTL { get; set; }
		[CProperty(ColumnPath ="Conclusion")]
		public string Conclusion { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CriteriaUnderstandingSE")]
		public int CriteriaUnderstandingSE { get; set; }
		[CProperty(ColumnPath ="CriteriaUnderstandingTL")]
		public int CriteriaUnderstandingTL { get; set; }
		[CProperty(ColumnPath ="Date")]
		public DateTime Date { get; set; }
		[CProperty(ColumnPath ="DatePlanningSE")]
		public int DatePlanningSE { get; set; }
		[CProperty(ColumnPath ="DatePlanningTL")]
		public int DatePlanningTL { get; set; }
		[CProperty(ColumnPath ="DDId")]
		public Guid DDId { get; set; }
		[CProperty(ColumnPath ="DecisionMapSE")]
		public int DecisionMapSE { get; set; }
		[CProperty(ColumnPath ="DecisionMapTL")]
		public int DecisionMapTL { get; set; }
		[CProperty(ColumnPath ="DifferentiationMatrixSE")]
		public int DifferentiationMatrixSE { get; set; }
		[CProperty(ColumnPath ="DifferentiationMatrixTL")]
		public int DifferentiationMatrixTL { get; set; }
		[CProperty(ColumnPath ="DiscoveryCall")]
		public int DiscoveryCall { get; set; }
		[CProperty(ColumnPath ="DiscoveryCallPC")]
		public int DiscoveryCallPC { get; set; }
		[CProperty(ColumnPath ="DiscoveryCallSE")]
		public int DiscoveryCallSE { get; set; }
		[CProperty(ColumnPath ="DiscoveryCallTL")]
		public int DiscoveryCallTL { get; set; }
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId { get; set; }
		[CProperty(ColumnPath ="EvaluationPlanSE")]
		public int EvaluationPlanSE { get; set; }
		[CProperty(ColumnPath ="EvaluationPlanTL")]
		public int EvaluationPlanTL { get; set; }
		[CProperty(ColumnPath ="GiveGetSE")]
		public int GiveGetSE { get; set; }
		[CProperty(ColumnPath ="GiveGetTL")]
		public int GiveGetTL { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IntroductionSE")]
		public int IntroductionSE { get; set; }
		[CProperty(ColumnPath ="IntroductionTL")]
		public int IntroductionTL { get; set; }
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive { get; set; }
		[CProperty(ColumnPath ="KeyPainConfirmSE")]
		public int KeyPainConfirmSE { get; set; }
		[CProperty(ColumnPath ="KeyPainConfirmTL")]
		public int KeyPainConfirmTL { get; set; }
		[CProperty(ColumnPath ="KeyPlayerListSE")]
		public int KeyPlayerListSE { get; set; }
		[CProperty(ColumnPath ="KeyPlayerListTL")]
		public int KeyPlayerListTL { get; set; }
		[CProperty(ColumnPath ="MarketId")]
		public Guid MarketId { get; set; }
		[CProperty(ColumnPath ="MeetingTimeSE")]
		public int MeetingTimeSE { get; set; }
		[CProperty(ColumnPath ="MeetingTimeTL")]
		public int MeetingTimeTL { get; set; }
		[CProperty(ColumnPath ="MeetTimeLimitSE")]
		public int MeetTimeLimitSE { get; set; }
		[CProperty(ColumnPath ="MeetTimeLimitTL")]
		public int MeetTimeLimitTL { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="NecessaryQuestionsSE")]
		public int NecessaryQuestionsSE { get; set; }
		[CProperty(ColumnPath ="NecessaryQuestionsTL")]
		public int NecessaryQuestionsTL { get; set; }
		[CProperty(ColumnPath ="NextStepsSE")]
		public int NextStepsSE { get; set; }
		[CProperty(ColumnPath ="NextStepsTL")]
		public int NextStepsTL { get; set; }
		[CProperty(ColumnPath ="NotesSE")]
		public int NotesSE { get; set; }
		[CProperty(ColumnPath ="NotesTL")]
		public int NotesTL { get; set; }
		[CProperty(ColumnPath ="OverallCommon")]
		public int OverallCommon { get; set; }
		[CProperty(ColumnPath ="OverallCommonPC")]
		public int OverallCommonPC { get; set; }
		[CProperty(ColumnPath ="OverallCommonSE")]
		public int OverallCommonSE { get; set; }
		[CProperty(ColumnPath ="OverallCommonTL")]
		public int OverallCommonTL { get; set; }
		[CProperty(ColumnPath ="OverallInstruments")]
		public int OverallInstruments { get; set; }
		[CProperty(ColumnPath ="OverallInstrumentsPC")]
		public int OverallInstrumentsPC { get; set; }
		[CProperty(ColumnPath ="OverallInstrumentsSE")]
		public int OverallInstrumentsSE { get; set; }
		[CProperty(ColumnPath ="OverallInstrumentsTL")]
		public int OverallInstrumentsTL { get; set; }
		[CProperty(ColumnPath ="OverallMeeting")]
		public int OverallMeeting { get; set; }
		[CProperty(ColumnPath ="OverallMeetingPC")]
		public int OverallMeetingPC { get; set; }
		[CProperty(ColumnPath ="OverallMeetingSE")]
		public int OverallMeetingSE { get; set; }
		[CProperty(ColumnPath ="OverallMeetingTL")]
		public int OverallMeetingTL { get; set; }
		[CProperty(ColumnPath ="OverallPreparation")]
		public int OverallPreparation { get; set; }
		[CProperty(ColumnPath ="OverallPreparationPC")]
		public int OverallPreparationPC { get; set; }
		[CProperty(ColumnPath ="OverallPreparationSE")]
		public int OverallPreparationSE { get; set; }
		[CProperty(ColumnPath ="OverallPreparationTL")]
		public int OverallPreparationTL { get; set; }
		[CProperty(ColumnPath ="OverallQuestions")]
		public int OverallQuestions { get; set; }
		[CProperty(ColumnPath ="OverallQuestionsPC")]
		public int OverallQuestionsPC { get; set; }
		[CProperty(ColumnPath ="OverallQuestionsSE")]
		public int OverallQuestionsSE { get; set; }
		[CProperty(ColumnPath ="OverallQuestionsTL")]
		public int OverallQuestionsTL { get; set; }
		[CProperty(ColumnPath ="OverallRating")]
		public int OverallRating { get; set; }
		[CProperty(ColumnPath ="OverallRatingPC")]
		public int OverallRatingPC { get; set; }
		[CProperty(ColumnPath ="OverallSaleManagement")]
		public int OverallSaleManagement { get; set; }
		[CProperty(ColumnPath ="OverallSaleManagementPC")]
		public int OverallSaleManagementPC { get; set; }
		[CProperty(ColumnPath ="OverallSaleManagementSE")]
		public int OverallSaleManagementSE { get; set; }
		[CProperty(ColumnPath ="OverallSaleManagementTL")]
		public int OverallSaleManagementTL { get; set; }
		[CProperty(ColumnPath ="OverallSE")]
		public int OverallSE { get; set; }
		[CProperty(ColumnPath ="OverallSEpc")]
		public int OverallSEpc { get; set; }
		[CProperty(ColumnPath ="OverallTL")]
		public int OverallTL { get; set; }
		[CProperty(ColumnPath ="OverallTLpc")]
		public int OverallTLpc { get; set; }
		[CProperty(ColumnPath ="Pain3rolesSE")]
		public int Pain3rolesSE { get; set; }
		[CProperty(ColumnPath ="Pain3rolesTL")]
		public int Pain3rolesTL { get; set; }
		[CProperty(ColumnPath ="PainChainSE")]
		public int PainChainSE { get; set; }
		[CProperty(ColumnPath ="PainChainTL")]
		public int PainChainTL { get; set; }
		[CProperty(ColumnPath ="ParticipantsRolesSE")]
		public int ParticipantsRolesSE { get; set; }
		[CProperty(ColumnPath ="ParticipantsRolesTL")]
		public int ParticipantsRolesTL { get; set; }
		[CProperty(ColumnPath ="PeriodId")]
		public Guid PeriodId { get; set; }
		[CProperty(ColumnPath ="PlannedStepsSE")]
		public int PlannedStepsSE { get; set; }
		[CProperty(ColumnPath ="PlannedStepsTL")]
		public int PlannedStepsTL { get; set; }
		[CProperty(ColumnPath ="PowerSponsorSE")]
		public int PowerSponsorSE { get; set; }
		[CProperty(ColumnPath ="PowerSponsorTL")]
		public int PowerSponsorTL { get; set; }
		[CProperty(ColumnPath ="PPVVCSE")]
		public int PPVVCSE { get; set; }
		[CProperty(ColumnPath ="PPVVCTL")]
		public int PPVVCTL { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductKnowledgeSE")]
		public int ProductKnowledgeSE { get; set; }
		[CProperty(ColumnPath ="ProductKnowledgeTL")]
		public int ProductKnowledgeTL { get; set; }
		[CProperty(ColumnPath ="ReferencePresentationSE")]
		public int ReferencePresentationSE { get; set; }
		[CProperty(ColumnPath ="ReferencePresentationTL")]
		public int ReferencePresentationTL { get; set; }
		[CProperty(ColumnPath ="ResponsibleSEId")]
		public Guid ResponsibleSEId { get; set; }
		[CProperty(ColumnPath ="ResumeSE")]
		public int ResumeSE { get; set; }
		[CProperty(ColumnPath ="ResumeTL")]
		public int ResumeTL { get; set; }
		[CProperty(ColumnPath ="RightPresentationSE")]
		public int RightPresentationSE { get; set; }
		[CProperty(ColumnPath ="RightPresentationTL")]
		public int RightPresentationTL { get; set; }
		[CProperty(ColumnPath ="RoleId")]
		public Guid RoleId { get; set; }
		[CProperty(ColumnPath ="SegmentId")]
		public Guid SegmentId { get; set; }
		[CProperty(ColumnPath ="SmallTalkSE")]
		public int SmallTalkSE { get; set; }
		[CProperty(ColumnPath ="SmallTalkTL")]
		public int SmallTalkTL { get; set; }
		[CProperty(ColumnPath ="StartInTimeSE")]
		public int StartInTimeSE { get; set; }
		[CProperty(ColumnPath ="StartInTimeTL")]
		public int StartInTimeTL { get; set; }
		[CProperty(ColumnPath ="StrengthsWeaknessesSE")]
		public int StrengthsWeaknessesSE { get; set; }
		[CProperty(ColumnPath ="StrengthsWeaknessesTL")]
		public int StrengthsWeaknessesTL { get; set; }
		[CProperty(ColumnPath ="SuccessStoriesSE")]
		public int SuccessStoriesSE { get; set; }
		[CProperty(ColumnPath ="SuccessStoriesTL")]
		public int SuccessStoriesTL { get; set; }
		[CProperty(ColumnPath ="SWOTSE")]
		public int SWOTSE { get; set; }
		[CProperty(ColumnPath ="SWOTTL")]
		public int SWOTTL { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
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
