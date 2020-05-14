namespace EdiFabric.Templates.Hipaa5010
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;
    using EdiFabric.Core.Model.Edi.X12;
    
    
    public class HIPAA_5010_837P_Context : DbContext
    {
        public HIPAA_5010_837P_Context() : base("name=Hipaa5010837PConnectionString")
        {
            Configuration.AutoDetectChangesEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<All_AMT_837P> All_AMT_837P { get; set; }
        public DbSet<AMT_SalesTaxAmount> AMT_SalesTaxAmount { get; set; }
        public DbSet<AMT> AMT { get; set; }
        public DbSet<AMT_PostageClaimedAmount> AMT_PostageClaimedAmount { get; set; }
        public DbSet<All_AMT_837P_2> All_AMT_837P_2 { get; set; }
        public DbSet<AMT_CoordinationofBenefits> AMT_CoordinationofBenefits { get; set; }
        public DbSet<AMT_CoordinationofBenefits_2> AMT_CoordinationofBenefits_2 { get; set; }
        public DbSet<AMT_RemainingPatientLiability> AMT_RemainingPatientLiability { get; set; }
        public DbSet<All_CRC_837P> All_CRC_837P { get; set; }
        public DbSet<CRC_AmbulanceCertification> CRC_AmbulanceCertification { get; set; }
        public DbSet<CRC> CRC { get; set; }
        public DbSet<CRC_HospiceEmployeeIndicator> CRC_HospiceEmployeeIndicator { get; set; }
        public DbSet<CRC_ConditionIndicator> CRC_ConditionIndicator { get; set; }
        public DbSet<All_CRC_837P_2> All_CRC_837P_2 { get; set; }
        public DbSet<CRC_PatientConditionInformation> CRC_PatientConditionInformation { get; set; }
        public DbSet<CRC_HomeboundIndicator> CRC_HomeboundIndicator { get; set; }
        public DbSet<CRC_EPSDTReferral> CRC_EPSDTReferral { get; set; }
        public DbSet<All_DTP_837P> All_DTP_837P { get; set; }
        public DbSet<DTP_ClaimLevelServiceDate> DTP_ClaimLevelServiceDate { get; set; }
        public DbSet<DTP> DTP { get; set; }
        public DbSet<DTP_HearingandVisionPrescriptionDate> DTP_HearingandVisionPrescriptionDate { get; set; }
        public DbSet<DTP_CertificationRevision> DTP_CertificationRevision { get; set; }
        public DbSet<DTP_BeginTherapyDate> DTP_BeginTherapyDate { get; set; }
        public DbSet<DTP_LastCertificationDate> DTP_LastCertificationDate { get; set; }
        public DbSet<DTP_LastSeenDate> DTP_LastSeenDate { get; set; }
        public DbSet<DTP_TestDate> DTP_TestDate { get; set; }
        public DbSet<DTP_ShippedDate> DTP_ShippedDate { get; set; }
        public DbSet<DTP_LastXrayDate> DTP_LastXrayDate { get; set; }
        public DbSet<DTP_InitialTreatmentDate> DTP_InitialTreatmentDate { get; set; }
        public DbSet<All_DTP_837P_2> All_DTP_837P_2 { get; set; }
        public DbSet<DTP_OnsetofCurrentIllnessorSymptom> DTP_OnsetofCurrentIllnessorSymptom { get; set; }
        public DbSet<DTP_AcuteManifestation> DTP_AcuteManifestation { get; set; }
        public DbSet<DTP_AccidentDate_2> DTP_AccidentDate_2 { get; set; }
        public DbSet<DTP_LastMenstrualPeriod> DTP_LastMenstrualPeriod { get; set; }
        public DbSet<DTP_DisabilityDates> DTP_DisabilityDates { get; set; }
        public DbSet<DTP_LastWorked> DTP_LastWorked { get; set; }
        public DbSet<DTP_AuthorizedReturntoWork> DTP_AuthorizedReturntoWork { get; set; }
        public DbSet<DTP_AdmissionDate_4> DTP_AdmissionDate_4 { get; set; }
        public DbSet<DTP_Discharge> DTP_Discharge { get; set; }
        public DbSet<DTP_AssumedandRelinquishedCareDates> DTP_AssumedandRelinquishedCareDates { get; set; }
        public DbSet<DTP_PropertyandCasualtyDateofFirstContact> DTP_PropertyandCasualtyDateofFirstContact { get; set; }
        public DbSet<DTP_RepricerReceivedDate> DTP_RepricerReceivedDate { get; set; }
        public DbSet<All_HI_837P> All_HI_837P { get; set; }
        public DbSet<HI_DependentHealthCareDiagnosisCode> HI_DependentHealthCareDiagnosisCode { get; set; }

        public DbSet<HI_DependentHealthCareDiagnosisCode_2> HI_DependentHealthCareDiagnosisCode_2 { get; set; }
        public DbSet<C022_HealthCareCodeInformation_8> C022_HealthCareCodeInformation_8 { get; set; }
        public DbSet<C022> C022 { get; set; }
        public DbSet<C022_HealthCareCodeInformation_4> C022_HealthCareCodeInformation_4 { get; set; }
        public DbSet<C022_HealthCareCodeInformation> C022_HealthCareCodeInformation { get; set; }
        public DbSet<HI> HI { get; set; }
        public DbSet<HI_AnesthesiaRelatedProcedure> HI_AnesthesiaRelatedProcedure { get; set; }
        public DbSet<C022_HealthCareCodeInformation_12> C022_HealthCareCodeInformation_12 { get; set; }
        public DbSet<C022_HealthCareCodeInformation_15> C022_HealthCareCodeInformation_15 { get; set; }
        public DbSet<HI_ConditionInformation> HI_ConditionInformation { get; set; }
        public DbSet<C022_HealthCareCodeInformation_13> C022_HealthCareCodeInformation_13 { get; set; }
        public DbSet<All_NM1_837P> All_NM1_837P { get; set; }
        public DbSet<Loop_2010AA_837P> Loop_2010AA_837P { get; set; }
        public DbSet<Loop_2010AB_837P> Loop_2010AB_837P { get; set; }
        public DbSet<Loop_2010AC_837P> Loop_2010AC_837P { get; set; }
        public DbSet<All_NM1_837P_2> All_NM1_837P_2 { get; set; }
        public DbSet<Loop_2010BA_837P> Loop_2010BA_837P { get; set; }
        public DbSet<Loop_2010BB_837P> Loop_2010BB_837P { get; set; }
        public DbSet<All_NM1_837P_3> All_NM1_837P_3 { get; set; }
        public DbSet<Loop_2310A_837P> Loop_2310A_837P { get; set; }
        public DbSet<Loop_2310B_837P> Loop_2310B_837P { get; set; }
        public DbSet<Loop_2310C_837P> Loop_2310C_837P { get; set; }
        public DbSet<Loop_2310D_837P> Loop_2310D_837P { get; set; }
        public DbSet<Loop_2310E_837P> Loop_2310E_837P { get; set; }
        public DbSet<Loop_2310F_837P> Loop_2310F_837P { get; set; }
        public DbSet<All_NM1_837P_4> All_NM1_837P_4 { get; set; }
        public DbSet<Loop_2330A_837P> Loop_2330A_837P { get; set; }
        public DbSet<Loop_2330B_837P> Loop_2330B_837P { get; set; }
        public DbSet<Loop_2330C_837P> Loop_2330C_837P { get; set; }
        public DbSet<Loop_2330D_837P> Loop_2330D_837P { get; set; }
        public DbSet<Loop_2330E_837P> Loop_2330E_837P { get; set; }
        public DbSet<Loop_2330F_837P> Loop_2330F_837P { get; set; }
        public DbSet<Loop_2330G_837P> Loop_2330G_837P { get; set; }
        public DbSet<All_NM1_837P_5> All_NM1_837P_5 { get; set; }
        public DbSet<Loop_2420A_837P> Loop_2420A_837P { get; set; }
        public DbSet<Loop_2420B_837P> Loop_2420B_837P { get; set; }
        public DbSet<Loop_2420C_837P> Loop_2420C_837P { get; set; }
        public DbSet<Loop_2420D_837P> Loop_2420D_837P { get; set; }
        public DbSet<Loop_2420E_837P> Loop_2420E_837P { get; set; }
        public DbSet<Loop_2420F_837P> Loop_2420F_837P { get; set; }
        public DbSet<Loop_2420G_837P> Loop_2420G_837P { get; set; }
        public DbSet<Loop_2420H_837P> Loop_2420H_837P { get; set; }
        public DbSet<All_NM1_837P_6> All_NM1_837P_6 { get; set; }
        public DbSet<Loop_1000A_837P> Loop_1000A_837P { get; set; }
        public DbSet<Loop_1000B_837P> Loop_1000B_837P { get; set; }
        public DbSet<All_NTE_837P> All_NTE_837P { get; set; }
        public DbSet<NTE_LineNote> NTE_LineNote { get; set; }
        public DbSet<NTE> NTE { get; set; }
        public DbSet<NTE_ThirdPartyOrganizationNotes> NTE_ThirdPartyOrganizationNotes { get; set; }
        public DbSet<All_PWK_837P> All_PWK_837P { get; set; }
        public DbSet<PWK_ClaimSupplementalInformation_2> PWK_ClaimSupplementalInformation_2 { get; set; }
        public DbSet<C002_ActionsIndicated_2> C002_ActionsIndicated_2 { get; set; }
        public DbSet<C002> C002 { get; set; }
        public DbSet<PWK> PWK { get; set; }
        public DbSet<PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator> PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator { get; set; }
        public DbSet<All_QTY_837P> All_QTY_837P { get; set; }
        public DbSet<QTY_AmbulancePatientCount> QTY_AmbulancePatientCount { get; set; }
        public DbSet<C001_CompositeUnitOfMeasure> C001_CompositeUnitOfMeasure { get; set; }
        public DbSet<C001> C001 { get; set; }
        public DbSet<QTY> QTY { get; set; }
        public DbSet<QTY_ObstetricAnesthesiaAdditionalUnits> QTY_ObstetricAnesthesiaAdditionalUnits { get; set; }
        public DbSet<All_REF_837P> All_REF_837P { get; set; }
        public DbSet<REF_OtherPayerSecondaryIdentifier> REF_OtherPayerSecondaryIdentifier { get; set; }
        public DbSet<C040_ReferenceIdentifier> C040_ReferenceIdentifier { get; set; }
        public DbSet<C040> C040 { get; set; }
        public DbSet<REF> REF { get; set; }
        public DbSet<REF_OtherPayerPriorAuthorizationNumber> REF_OtherPayerPriorAuthorizationNumber { get; set; }

        public DbSet<REF_OtherPayerPriorAuthorizationNumber_2> REF_OtherPayerPriorAuthorizationNumber_2 { get; set; }
        public DbSet<REF_OtherPayerReferralNumber> REF_OtherPayerReferralNumber { get; set; }

        public DbSet<REF_OtherPayerReferralNumber_2> REF_OtherPayerReferralNumber_2 { get; set; }
        public DbSet<REF_OtherPayerClaimAdjustmentIndicator> REF_OtherPayerClaimAdjustmentIndicator { get; set; }
        public DbSet<REF_OtherPayerClaimControlNumber> REF_OtherPayerClaimControlNumber { get; set; }
        public DbSet<All_REF_837P_2> All_REF_837P_2 { get; set; }
        public DbSet<REF_RepricedLineItemReferenceNumber> REF_RepricedLineItemReferenceNumber { get; set; }
        public DbSet<REF_AdjustedRepricedLineItemReferenceNumber> REF_AdjustedRepricedLineItemReferenceNumber { get; set; }
        public DbSet<REF_LineItemControlNumber> REF_LineItemControlNumber { get; set; }
        public DbSet<REF_MammographyCertificationNumber> REF_MammographyCertificationNumber { get; set; }
        public DbSet<REF_ClinicalLaboratoryImprovementAmendment> REF_ClinicalLaboratoryImprovementAmendment { get; set; }
        public DbSet<REF_ReferringClinicalLaboratoryImprovementAmendment> REF_ReferringClinicalLaboratoryImprovementAmendment { get; set; }
        public DbSet<REF_ImmunizationBatchNumber> REF_ImmunizationBatchNumber { get; set; }
        public DbSet<All_REF_837P_3> All_REF_837P_3 { get; set; }
        public DbSet<REF_Pay> REF_Pay { get; set; }
        public DbSet<REF_BillingProviderTaxIdentification_2> REF_BillingProviderTaxIdentification_2 { get; set; }
        public DbSet<All_REF_837P_4> All_REF_837P_4 { get; set; }
        public DbSet<REF_OtherSubscriberSecondaryIdentification> REF_OtherSubscriberSecondaryIdentification { get; set; }
        public DbSet<REF_PropertyandCasualtyClaimNumber> REF_PropertyandCasualtyClaimNumber { get; set; }
        public DbSet<All_REF_837P_5> All_REF_837P_5 { get; set; }
        public DbSet<REF_BillingProviderSecondaryIdentification> REF_BillingProviderSecondaryIdentification { get; set; }

        public DbSet<REF_BillingProviderSecondaryIdentification_2> REF_BillingProviderSecondaryIdentification_2 { get; set; }
        public DbSet<All_REF_837P_6> All_REF_837P_6 { get; set; }
        public DbSet<REF_ServiceAuthorizationExceptionCode> REF_ServiceAuthorizationExceptionCode { get; set; }
        public DbSet<REF_MandatoryMedicare> REF_MandatoryMedicare { get; set; }
        public DbSet<REF_RepricedClaimNumber> REF_RepricedClaimNumber { get; set; }
        public DbSet<REF_AdjustedRepricedClaimNumber> REF_AdjustedRepricedClaimNumber { get; set; }
        public DbSet<REF_InvestigationalDeviceExemptionNumber> REF_InvestigationalDeviceExemptionNumber { get; set; }
        public DbSet<REF_ClaimIdentificationNumberForClearinghousesAndOtherTransmissionIntermediaries> REF_ClaimIdentificationNumberForClearinghousesAndOtherTransmissionIntermediaries { get; set; }
        public DbSet<REF_MedicalRecordNumber> REF_MedicalRecordNumber { get; set; }
        public DbSet<REF_DemonstrationProjectIdentifier> REF_DemonstrationProjectIdentifier { get; set; }
        public DbSet<REF_CarePlanOversight> REF_CarePlanOversight { get; set; }
        public DbSet<All_REF_837P_7> All_REF_837P_7 { get; set; }
        public DbSet<REF_PropertyandCasualtyPatientIdentifier> REF_PropertyandCasualtyPatientIdentifier { get; set; }
        public DbSet<C040_ReferenceIdentifier_7> C040_ReferenceIdentifier_7 { get; set; }
        public DbSet<All_REF_837P_8> All_REF_837P_8 { get; set; }
        public DbSet<REF_BillingProviderTaxIdentification> REF_BillingProviderTaxIdentification { get; set; }
        public DbSet<REF_BillingProviderUPIN> REF_BillingProviderUPIN { get; set; }
        public DbSet<NM1_InformationReceiverName_4> NM1_InformationReceiverName_4 { get; set; }
        public DbSet<NM1> NM1 { get; set; }
        public DbSet<PER_BillingProviderContactInformation> PER_BillingProviderContactInformation { get; set; }
        public DbSet<PER> PER { get; set; }
        public DbSet<NM1_ReceiverName> NM1_ReceiverName { get; set; }
        public DbSet<Loop_2000A_837P> Loop_2000A_837P { get; set; }
        public DbSet<HL_BillingProviderHierarchicalLevel> HL_BillingProviderHierarchicalLevel { get; set; }
        public DbSet<HL> HL { get; set; }
        public DbSet<PRV_BillingProviderSpecialtyInformation> PRV_BillingProviderSpecialtyInformation { get; set; }
        public DbSet<C035_ProviderSpecialtyInformation> C035_ProviderSpecialtyInformation { get; set; }
        public DbSet<C035> C035 { get; set; }
        public DbSet<PRV> PRV { get; set; }
        public DbSet<CUR_ForeignCurrencyInformation_3> CUR_ForeignCurrencyInformation_3 { get; set; }
        public DbSet<CUR> CUR { get; set; }
        public DbSet<Loop_2000B_837P> Loop_2000B_837P { get; set; }
        public DbSet<HL_SubscriberHierarchicalLevel> HL_SubscriberHierarchicalLevel { get; set; }
        public DbSet<SBR_SubscriberInformation> SBR_SubscriberInformation { get; set; }
        public DbSet<SBR> SBR { get; set; }
        public DbSet<PAT_PatientInformation_3> PAT_PatientInformation_3 { get; set; }
        public DbSet<PAT> PAT { get; set; }
        public DbSet<Loop_2000C_837P> Loop_2000C_837P { get; set; }
        public DbSet<HL_DependentLevel> HL_DependentLevel { get; set; }
        public DbSet<PAT_PatientInformation> PAT_PatientInformation { get; set; }
        public DbSet<Loop_2010CA_837P> Loop_2010CA_837P { get; set; }
        public DbSet<Loop_2300_837P> Loop_2300_837P { get; set; }
        public DbSet<NM1_BillingProviderName_2> NM1_BillingProviderName_2 { get; set; }
        public DbSet<N3_AdditionalPatientInformationContactAddress> N3_AdditionalPatientInformationContactAddress { get; set; }
        public DbSet<N3> N3 { get; set; }
        public DbSet<N4_AdditionalPatientInformationContactCity> N4_AdditionalPatientInformationContactCity { get; set; }
        public DbSet<N4> N4 { get; set; }
        public DbSet<NM1_Pay> NM1_Pay { get; set; }
        public DbSet<NM1_Pay_3> NM1_Pay_3 { get; set; }
        public DbSet<NM1_SubscriberName_5> NM1_SubscriberName_5 { get; set; }
        public DbSet<DMG_PatientDemographicInformation> DMG_PatientDemographicInformation { get; set; }
        public DbSet<C056_CompositeRaceOrEthnicityInformation> C056_CompositeRaceOrEthnicityInformation { get; set; }
        public DbSet<C056> C056 { get; set; }
        public DbSet<DMG> DMG { get; set; }
        public DbSet<PER_PropertyandCasualtyPatientContactInformation> PER_PropertyandCasualtyPatientContactInformation { get; set; }
        public DbSet<NM1_OtherPayerName> NM1_OtherPayerName { get; set; }
        public DbSet<NM1_PatientName_3> NM1_PatientName_3 { get; set; }
        public DbSet<CLM_ClaimInformation_3> CLM_ClaimInformation_3 { get; set; }
        public DbSet<C023_HealthCareServiceLocationInformation_2> C023_HealthCareServiceLocationInformation_2 { get; set; }
        public DbSet<C023> C023 { get; set; }
        public DbSet<C024_RelatedCausesInformation_3> C024_RelatedCausesInformation_3 { get; set; }
        public DbSet<C024> C024 { get; set; }
        public DbSet<CLM> CLM { get; set; }
        public DbSet<PWK_ClaimSupplementalInformation_3> PWK_ClaimSupplementalInformation_3 { get; set; }
        public DbSet<CN1_ContractInformation_2> CN1_ContractInformation_2 { get; set; }
        public DbSet<CN1> CN1 { get; set; }
        public DbSet<AMT_PatientAmountPaid> AMT_PatientAmountPaid { get; set; }
        public DbSet<K3_FileInformation> K3_FileInformation { get; set; }
        public DbSet<K3> K3 { get; set; }
        public DbSet<NTE_ClaimNote_2> NTE_ClaimNote_2 { get; set; }
        public DbSet<CR1_AmbulanceTransportInformation> CR1_AmbulanceTransportInformation { get; set; }
        public DbSet<CR1> CR1 { get; set; }
        public DbSet<CR2_SpinalManipulationServiceInformation> CR2_SpinalManipulationServiceInformation { get; set; }
        public DbSet<CR2> CR2 { get; set; }
        public DbSet<HCP_ClaimPricing> HCP_ClaimPricing { get; set; }
        public DbSet<HCP> HCP { get; set; }
        public DbSet<Loop_2320_837P> Loop_2320_837P { get; set; }
        public DbSet<Loop_2400_837P> Loop_2400_837P { get; set; }
        public DbSet<NM1_ReferringProviderName> NM1_ReferringProviderName { get; set; }
        public DbSet<REF_OrderingProviderSecondaryIdentification> REF_OrderingProviderSecondaryIdentification { get; set; }

        public DbSet<REF_OrderingProviderSecondaryIdentification_2> REF_OrderingProviderSecondaryIdentification_2 { get; set; }
        public DbSet<C040_ReferenceIdentifier_3> C040_ReferenceIdentifier_3 { get; set; }
        public DbSet<NM1_RenderingProviderName> NM1_RenderingProviderName { get; set; }
        public DbSet<PRV_RenderingProviderSpecialtyInformation> PRV_RenderingProviderSpecialtyInformation { get; set; }
        public DbSet<REF_AssistantSurgeonSecondaryIdentification> REF_AssistantSurgeonSecondaryIdentification { get; set; }

        public DbSet<REF_AssistantSurgeonSecondaryIdentification_2> REF_AssistantSurgeonSecondaryIdentification_2 { get; set; }
        public DbSet<NM1_ServiceFacilityLocation> NM1_ServiceFacilityLocation { get; set; }
        public DbSet<REF_OtherPayerServiceFacilityLocationSecondaryIdentification> REF_OtherPayerServiceFacilityLocationSecondaryIdentification { get; set; }
        public DbSet<NM1_SupervisingProviderName> NM1_SupervisingProviderName { get; set; }
        public DbSet<NM1_AmbulancePick> NM1_AmbulancePick { get; set; }
        public DbSet<NM1_AmbulanceDrop> NM1_AmbulanceDrop { get; set; }
        public DbSet<SBR_OtherSubscriberInformation> SBR_OtherSubscriberInformation { get; set; }
        public DbSet<CAS_ClaimLevelAdjustments> CAS_ClaimLevelAdjustments { get; set; }
        public DbSet<CAS> CAS { get; set; }
        public DbSet<OI_OtherInsuranceCoverageInformation_2> OI_OtherInsuranceCoverageInformation_2 { get; set; }
        public DbSet<OI> OI { get; set; }
        public DbSet<MOA_OutpatientAdjudicationInformation> MOA_OutpatientAdjudicationInformation { get; set; }
        public DbSet<MOA> MOA { get; set; }
        public DbSet<NM1_OtherSubscriberName> NM1_OtherSubscriberName { get; set; }
        public DbSet<DTP_ClaimCheckOrRemittanceDate> DTP_ClaimCheckOrRemittanceDate { get; set; }
        public DbSet<NM1_OtherPayerReferringProvider> NM1_OtherPayerReferringProvider { get; set; }
        public DbSet<NM1_OtherPayerRenderingProvider_2> NM1_OtherPayerRenderingProvider_2 { get; set; }
        public DbSet<NM1_OtherPayerServiceFacilityLocation> NM1_OtherPayerServiceFacilityLocation { get; set; }
        public DbSet<NM1_OtherPayerSupervisingProvider> NM1_OtherPayerSupervisingProvider { get; set; }
        public DbSet<NM1_OtherPayerBillingProvider> NM1_OtherPayerBillingProvider { get; set; }
        public DbSet<LX_HeaderNumber> LX_HeaderNumber { get; set; }
        public DbSet<LX> LX { get; set; }
        public DbSet<SV1_ProfessionalService> SV1_ProfessionalService { get; set; }
        public DbSet<C003_CompositeMedicalProcedureIdentifier_12> C003_CompositeMedicalProcedureIdentifier_12 { get; set; }
        public DbSet<C003> C003 { get; set; }
        public DbSet<C004_CompositeDiagnosisCodePointer> C004_CompositeDiagnosisCodePointer { get; set; }
        public DbSet<C004> C004 { get; set; }
        public DbSet<SV1> SV1 { get; set; }
        public DbSet<SV5_DurableMedicalEquipmentService> SV5_DurableMedicalEquipmentService { get; set; }
        public DbSet<C003_CompositeMedicalProcedureIdentifier_9> C003_CompositeMedicalProcedureIdentifier_9 { get; set; }
        public DbSet<SV5> SV5 { get; set; }
        public DbSet<CR3_DurableMedicalEquipmentCertification> CR3_DurableMedicalEquipmentCertification { get; set; }
        public DbSet<CR3> CR3 { get; set; }
        public DbSet<MEA_TestResult> MEA_TestResult { get; set; }
        public DbSet<MEA> MEA { get; set; }
        public DbSet<PS1_PurchasedServiceInformation> PS1_PurchasedServiceInformation { get; set; }
        public DbSet<PS1> PS1 { get; set; }
        public DbSet<HCP_LinePricing_3> HCP_LinePricing_3 { get; set; }
        public DbSet<Loop_2410_837P> Loop_2410_837P { get; set; }
        public DbSet<Loop_2430_837P> Loop_2430_837P { get; set; }
        public DbSet<Loop_2440_837P> Loop_2440_837P { get; set; }
        public DbSet<LIN_DrugIdentification_2> LIN_DrugIdentification_2 { get; set; }
        public DbSet<LIN> LIN { get; set; }
        public DbSet<CTP_DrugQuantity> CTP_DrugQuantity { get; set; }
        public DbSet<C001_CompositeUnitOfMeasure_2> C001_CompositeUnitOfMeasure_2 { get; set; }
        public DbSet<CTP> CTP { get; set; }
        public DbSet<REF_PrescriptionorCompoundDrugAssociationNumber> REF_PrescriptionorCompoundDrugAssociationNumber { get; set; }
        public DbSet<NM1_PurchasedServiceProviderName> NM1_PurchasedServiceProviderName { get; set; }
        public DbSet<NM1_OrderingProviderName> NM1_OrderingProviderName { get; set; }
        public DbSet<SVD_LineAdjudicationInformation> SVD_LineAdjudicationInformation { get; set; }

        public DbSet<SVD_LineAdjudicationInformation_3> SVD_LineAdjudicationInformation_3 { get; set; }
        public DbSet<C003_CompositeMedicalProcedureIdentifier_7> C003_CompositeMedicalProcedureIdentifier_7 { get; set; }
        public DbSet<SVD> SVD { get; set; }
        public DbSet<LQ_FormIdentificationCode> LQ_FormIdentificationCode { get; set; }
        public DbSet<LQ> LQ { get; set; }
        public DbSet<FRM_SupportingDocumentation> FRM_SupportingDocumentation { get; set; }
        public DbSet<FRM> FRM { get; set; }
        public DbSet<TS837P> TS837P { get; set; }
        public DbSet<ST> ST { get; set; }
        public DbSet<BHT_BeginningOfHierarchicalTransaction_8> BHT_BeginningOfHierarchicalTransaction_8 { get; set; }
        public DbSet<BHT> BHT { get; set; }
        public DbSet<SE> SE { get; set; }
    }
}
