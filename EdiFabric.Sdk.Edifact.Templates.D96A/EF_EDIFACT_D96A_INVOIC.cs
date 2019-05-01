namespace EdiFabric.Templates.EdifactD96A
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    
    
    /// <summary>
    /// Loop for ALLOWANCE OR CHARGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ALC))]
    public class Loop_ALC_INVOIC
    {
        
        /// <summary>
        /// ALLOWANCE OR CHARGE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public ALC ALC { get; set; }
        /// <summary>
        /// Loop for QUANTITY
        /// </summary>
        [DataMember]
        [Pos(2)]
        public Loop_QTY_INVOIC QTYLoop { get; set; }
        /// <summary>
        /// Loop for PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public Loop_PCD_INVOIC PCDLoop { get; set; }
        /// <summary>
        /// Loop for MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public List<Loop_MOA_INVOIC> MOALoop { get; set; }
        /// <summary>
        /// Loop for RATE DETAILS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public Loop_RTE_INVOIC RTELoop { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public List<Loop_TAX_INVOIC> TAXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for ALLOWANCE OR CHARGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ALC))]
    public class Loop_ALC_INVOIC_2
    {
        
        /// <summary>
        /// ALLOWANCE OR CHARGE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public ALC ALC { get; set; }
        /// <summary>
        /// ADDITIONAL INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public List<ALI> ALI { get; set; }
        /// <summary>
        /// Loop for QUANTITY
        /// </summary>
        [DataMember]
        [Pos(3)]
        public Loop_QTY_INVOIC QTYLoop { get; set; }
        /// <summary>
        /// Loop for PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public Loop_PCD_INVOIC PCDLoop { get; set; }
        /// <summary>
        /// Loop for MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public List<Loop_MOA_INVOIC> MOALoop { get; set; }
        /// <summary>
        /// Loop for RATE DETAILS
        /// </summary>
        [DataMember]
        [Pos(6)]
        public Loop_RTE_INVOIC RTELoop { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public List<Loop_TAX_INVOIC> TAXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for ALLOWANCE OR CHARGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ALC))]
    public class Loop_ALC_INVOIC_3
    {
        
        /// <summary>
        /// ALLOWANCE OR CHARGE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public ALC ALC { get; set; }
        /// <summary>
        /// ADDITIONAL INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public ALI ALI { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public List<MOA> MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for CONTACT INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CTA))]
    public class Loop_CTA_INVOIC
    {
        
        /// <summary>
        /// CONTACT INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public CTA CTA { get; set; }
        /// <summary>
        /// COMMUNICATION CONTACT
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public List<COM> COM { get; set; }
    }
    
    /// <summary>
    /// Loop for CURRENCIES
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CUX))]
    public class Loop_CUX_INVOIC
    {
        
        /// <summary>
        /// CURRENCIES
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public CUX CUX { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for LINE ITEM
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIN))]
    public class Loop_LIN_INVOIC
    {
        
        /// <summary>
        /// LINE ITEM
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public LIN LIN { get; set; }
        /// <summary>
        /// ADDITIONAL PRODUCT ID
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(2)]
        public List<PIA> PIA { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public List<IMD> IMD { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public List<MEA> MEA { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public List<QTY> QTY { get; set; }
        /// <summary>
        /// ADDITIONAL INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public List<ALI> ALI { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(35)]
        [Pos(7)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// QUANTITY VARIANCES
        /// </summary>
        [DataMember]
        [Pos(8)]
        public QVR QVR { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(9)]
        public List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(10)]
        public List<Loop_MOA_INVOIC> MOALoop { get; set; }
        /// <summary>
        /// Loop for PAYMENT TERMS BASIS
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(11)]
        public List<Loop_PAT_INVOIC> PATLoop { get; set; }
        /// <summary>
        /// Loop for PRICE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(12)]
        public List<Loop_PRI_INVOIC> PRILoop { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(13)]
        public List<Loop_RFF_INVOIC> RFFLoop { get; set; }
        /// <summary>
        /// Loop for PACKAGE
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(14)]
        public List<Loop_PAC_INVOIC_2> PACLoop { get; set; }
        /// <summary>
        /// Loop for PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(15)]
        public List<Loop_LOC_INVOIC> LOCLoop { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(16)]
        public List<Loop_TAX_INVOIC> TAXLoop { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(17)]
        public List<Loop_NAD_INVOIC_2> NADLoop { get; set; }
        /// <summary>
        /// Loop for ALLOWANCE OR CHARGE
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(18)]
        public List<Loop_ALC_INVOIC_2> ALCLoop { get; set; }
        /// <summary>
        /// Loop for DETAILS OF TRANSPORT
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(19)]
        public List<Loop_TDT_INVOIC> TDTLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for PLACE/LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LOC))]
    public class Loop_LOC_INVOIC
    {
        
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public LOC LOC { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(2)]
        public List<QTY> QTY { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(MOA))]
    public class Loop_MOA_INVOIC
    {
        
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public MOA MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(MOA))]
    public class Loop_MOA_INVOIC_2
    {
        
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public MOA MOA { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public Loop_RFF_INVOIC RFFLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NAD))]
    public class Loop_NAD_INVOIC
    {
        
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public NAD NAD { get; set; }
        /// <summary>
        /// FINANCIAL INSTITUTION INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public List<FII> FII { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(3)]
        public List<Loop_RFF_INVOIC_2> RFFLoop { get; set; }
        /// <summary>
        /// Loop for CONTACT INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public List<Loop_CTA_INVOIC> CTALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NAD))]
    public class Loop_NAD_INVOIC_2
    {
        
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public NAD NAD { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public List<Loop_RFF_INVOIC_2> RFFLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for PACKAGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PAC))]
    public class Loop_PAC_INVOIC
    {
        
        /// <summary>
        /// PACKAGE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public PAC PAC { get; set; }
    }
    
    /// <summary>
    /// Loop for PACKAGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PAC))]
    public class Loop_PAC_INVOIC_2
    {
        
        /// <summary>
        /// PACKAGE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public PAC PAC { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public List<MEA> MEA { get; set; }
        /// <summary>
        /// Loop for PACKAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public List<Loop_PCI_INVOIC> PCILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for PAYMENT TERMS BASIS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PAT))]
    public class Loop_PAT_INVOIC
    {
        
        /// <summary>
        /// PAYMENT TERMS BASIS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public PAT PAT { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public PCD PCD { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Pos(4)]
        public MOA MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for PERCENTAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PCD))]
    public class Loop_PCD_INVOIC
    {
        
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public PCD PCD { get; set; }
    }
    
    /// <summary>
    /// Loop for PACKAGE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PCI))]
    public class Loop_PCI_INVOIC
    {
        
        /// <summary>
        /// PACKAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public PCI PCI { get; set; }
        /// <summary>
        /// GOODS IDENTITY NUMBER
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public List<GIN> GIN { get; set; }
    }
    
    /// <summary>
    /// Loop for PRICE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PRI))]
    public class Loop_PRI_INVOIC
    {
        
        /// <summary>
        /// PRICE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public PRI PRI { get; set; }
    }
    
    /// <summary>
    /// Loop for QUANTITY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(QTY))]
    public class Loop_QTY_INVOIC
    {
        
        /// <summary>
        /// QUANTITY
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public QTY QTY { get; set; }
    }
    
    /// <summary>
    /// Loop for REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RFF))]
    public class Loop_RFF_INVOIC
    {
        
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public RFF RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RFF))]
    public class Loop_RFF_INVOIC_2
    {
        
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public RFF RFF { get; set; }
    }
    
    /// <summary>
    /// Loop for RATE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RTE))]
    public class Loop_RTE_INVOIC
    {
        
        /// <summary>
        /// RATE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public RTE RTE { get; set; }
    }
    
    /// <summary>
    /// Loop for DUTY/TAX/FEE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TAX))]
    public class Loop_TAX_INVOIC
    {
        
        /// <summary>
        /// DUTY/TAX/FEE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public TAX TAX { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Pos(2)]
        public MOA MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for DUTY/TAX/FEE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TAX))]
    public class Loop_TAX_INVOIC_2
    {
        
        /// <summary>
        /// DUTY/TAX/FEE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public TAX TAX { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public List<MOA> MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for DETAILS OF TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TDT))]
    public class Loop_TDT_INVOIC
    {
        
        /// <summary>
        /// DETAILS OF TRANSPORT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public TDT TDT { get; set; }
    }
    
    /// <summary>
    /// Loop for TERMS OF DELIVERY OR TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TOD))]
    public class Loop_TOD_INVOIC
    {
        
        /// <summary>
        /// TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public TOD TOD { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public List<LOC> LOC { get; set; }
    }
    
    /// <summary>
    /// Invoice message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("EDIFACT", "D96A", "INVOIC")]
    public class TSINVOIC : EdiMessage
    {
        
        /// <summary>
        /// Message Header
        /// </summary>
        [DataMember]
        [Pos(1)]
        public UNH UNH { get; set; }
        /// <summary>
        /// BEGINNING OF MESSAGE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public BGM BGM { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(35)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// PAYMENT INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public PAI PAI { get; set; }
        /// <summary>
        /// ADDITIONAL INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public List<ALI> ALI { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(7)]
        public List<Loop_RFF_INVOIC> RFFLoop { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(8)]
        public List<Loop_NAD_INVOIC> NADLoop { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(9)]
        public List<Loop_TAX_INVOIC> TAXLoop { get; set; }
        /// <summary>
        /// Loop for CURRENCIES
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(10)]
        public List<Loop_CUX_INVOIC> CUXLoop { get; set; }
        /// <summary>
        /// Loop for PAYMENT TERMS BASIS
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(11)]
        public List<Loop_PAT_INVOIC> PATLoop { get; set; }
        /// <summary>
        /// Loop for DETAILS OF TRANSPORT
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(12)]
        public List<Loop_TDT_INVOIC> TDTLoop { get; set; }
        /// <summary>
        /// Loop for TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(13)]
        public List<Loop_TOD_INVOIC> TODLoop { get; set; }
        /// <summary>
        /// Loop for PACKAGE
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(14)]
        public List<Loop_PAC_INVOIC> PACLoop { get; set; }
        /// <summary>
        /// Loop for ALLOWANCE OR CHARGE
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(15)]
        public List<Loop_ALC_INVOIC> ALCLoop { get; set; }
        /// <summary>
        /// Loop for LINE ITEM
        /// </summary>
        [DataMember]
        [ListCount(9999999)]
        [Pos(16)]
        public List<Loop_LIN_INVOIC> LINLoop { get; set; }
        /// <summary>
        /// SECTION CONTROL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(17)]
        public UNS UNS { get; set; }
        /// <summary>
        /// CONTROL TOTAL
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(18)]
        public List<CNT> CNT { get; set; }
        /// <summary>
        /// Loop for MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(100)]
        [Pos(19)]
        public List<Loop_MOA_INVOIC_2> MOALoop { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(20)]
        public List<Loop_TAX_INVOIC_2> TAXLoop2 { get; set; }
        /// <summary>
        /// Loop for ALLOWANCE OR CHARGE
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(21)]
        public List<Loop_ALC_INVOIC_3> ALCLoop2 { get; set; }
        /// <summary>
        /// Message Trailer
        /// </summary>
        [DataMember]
        [Pos(22)]
        public UNT UNT { get; set; }
    }
}
