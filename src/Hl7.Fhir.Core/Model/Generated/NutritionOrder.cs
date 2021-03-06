﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

//
// Generated on Thu, Apr 2, 2015 14:21+0200 for FHIR v0.5.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// A request for a diet, formula or nutritional supplement
    /// </summary>
    [FhirType("NutritionOrder", IsResource=true)]
    [DataContract]
    public partial class NutritionOrder : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.NutritionOrder; } }
        [NotMapped]
        public override string TypeName { get { return "NutritionOrder"; } }
        
        /// <summary>
        /// Codes specifying the state of the request. Describes the lifecycle of the nutrition order.
        /// </summary>
        [FhirEnumeration("NutritionOrderStatus")]
        public enum NutritionOrderStatus
        {
            /// <summary>
            /// The request has been proposed.
            /// </summary>
            [EnumLiteral("proposed")]
            Proposed,
            /// <summary>
            /// The request is in preliminary form prior to being sent.
            /// </summary>
            [EnumLiteral("draft")]
            Draft,
            /// <summary>
            /// The request has been planned.
            /// </summary>
            [EnumLiteral("planned")]
            Planned,
            /// <summary>
            /// The request has been placed.
            /// </summary>
            [EnumLiteral("requested")]
            Requested,
            /// <summary>
            /// The request is 'actionable', but not all actions that are implied by it have occurred yet.
            /// </summary>
            [EnumLiteral("active")]
            Active,
            /// <summary>
            /// Actions implied by the request have been temporarily halted, but are expected to continue later. May also be called "suspended".
            /// </summary>
            [EnumLiteral("on-hold")]
            OnHold,
            /// <summary>
            /// All actions that are implied by the order have occurred and no continuation is planned (this will rarely be made explicit).
            /// </summary>
            [EnumLiteral("completed")]
            Completed,
            /// <summary>
            /// The request has been withdrawn and is no longer actionable.
            /// </summary>
            [EnumLiteral("cancelled")]
            Cancelled,
        }
        
        [FhirType("NutritionOrderOralDietComponent")]
        [DataContract]
        public partial class NutritionOrderOralDietComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "NutritionOrderOralDietComponent"; } }
            
            /// <summary>
            /// Type of oral diet or diet restrictions that describe what can be consumed orally
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> Type
            {
                get { if(_Type==null) _Type = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _Type;
            
            /// <summary>
            /// Scheduled frequency of diet
            /// </summary>
            [FhirElement("scheduled", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.Timing Scheduled
            {
                get { return _Scheduled; }
                set { _Scheduled = value; OnPropertyChanged("Scheduled"); }
            }
            
            private Hl7.Fhir.Model.Timing _Scheduled;
            
            /// <summary>
            /// Required  nutrient modifications
            /// </summary>
            [FhirElement("nutrient", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.NutritionOrder.NutritionOrderOralDietNutrientComponent> Nutrient
            {
                get { if(_Nutrient==null) _Nutrient = new List<Hl7.Fhir.Model.NutritionOrder.NutritionOrderOralDietNutrientComponent>(); return _Nutrient; }
                set { _Nutrient = value; OnPropertyChanged("Nutrient"); }
            }
            
            private List<Hl7.Fhir.Model.NutritionOrder.NutritionOrderOralDietNutrientComponent> _Nutrient;
            
            /// <summary>
            /// Required  texture modifications
            /// </summary>
            [FhirElement("texture", InSummary=true, Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.NutritionOrder.NutritionOrderOralDietTextureComponent> Texture
            {
                get { if(_Texture==null) _Texture = new List<Hl7.Fhir.Model.NutritionOrder.NutritionOrderOralDietTextureComponent>(); return _Texture; }
                set { _Texture = value; OnPropertyChanged("Texture"); }
            }
            
            private List<Hl7.Fhir.Model.NutritionOrder.NutritionOrderOralDietTextureComponent> _Texture;
            
            /// <summary>
            /// The required consistency of fluids and liquids provided to the patient
            /// </summary>
            [FhirElement("fluidConsistencyType", InSummary=true, Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> FluidConsistencyType
            {
                get { if(_FluidConsistencyType==null) _FluidConsistencyType = new List<Hl7.Fhir.Model.CodeableConcept>(); return _FluidConsistencyType; }
                set { _FluidConsistencyType = value; OnPropertyChanged("FluidConsistencyType"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _FluidConsistencyType;
            
            /// <summary>
            /// Instructions or additional information about the oral diet
            /// </summary>
            [FhirElement("instruction", InSummary=true, Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString InstructionElement
            {
                get { return _InstructionElement; }
                set { _InstructionElement = value; OnPropertyChanged("InstructionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _InstructionElement;
            
            /// <summary>
            /// Instructions or additional information about the oral diet
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Instruction
            {
                get { return InstructionElement != null ? InstructionElement.Value : null; }
                set
                {
                    if(value == null)
                      InstructionElement = null; 
                    else
                      InstructionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Instruction");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as NutritionOrderOralDietComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = new List<Hl7.Fhir.Model.CodeableConcept>(Type.DeepCopy());
                    if(Scheduled != null) dest.Scheduled = (Hl7.Fhir.Model.Timing)Scheduled.DeepCopy();
                    if(Nutrient != null) dest.Nutrient = new List<Hl7.Fhir.Model.NutritionOrder.NutritionOrderOralDietNutrientComponent>(Nutrient.DeepCopy());
                    if(Texture != null) dest.Texture = new List<Hl7.Fhir.Model.NutritionOrder.NutritionOrderOralDietTextureComponent>(Texture.DeepCopy());
                    if(FluidConsistencyType != null) dest.FluidConsistencyType = new List<Hl7.Fhir.Model.CodeableConcept>(FluidConsistencyType.DeepCopy());
                    if(InstructionElement != null) dest.InstructionElement = (Hl7.Fhir.Model.FhirString)InstructionElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new NutritionOrderOralDietComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as NutritionOrderOralDietComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Scheduled, otherT.Scheduled)) return false;
                if( !DeepComparable.Matches(Nutrient, otherT.Nutrient)) return false;
                if( !DeepComparable.Matches(Texture, otherT.Texture)) return false;
                if( !DeepComparable.Matches(FluidConsistencyType, otherT.FluidConsistencyType)) return false;
                if( !DeepComparable.Matches(InstructionElement, otherT.InstructionElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as NutritionOrderOralDietComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Scheduled, otherT.Scheduled)) return false;
                if( !DeepComparable.IsExactly(Nutrient, otherT.Nutrient)) return false;
                if( !DeepComparable.IsExactly(Texture, otherT.Texture)) return false;
                if( !DeepComparable.IsExactly(FluidConsistencyType, otherT.FluidConsistencyType)) return false;
                if( !DeepComparable.IsExactly(InstructionElement, otherT.InstructionElement)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("NutritionOrderSupplementComponent")]
        [DataContract]
        public partial class NutritionOrderSupplementComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "NutritionOrderSupplementComponent"; } }
            
            /// <summary>
            /// Type of supplement product requested
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Type;
            
            /// <summary>
            /// Product or brand name of the nutritional supplement
            /// </summary>
            [FhirElement("productName", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString ProductNameElement
            {
                get { return _ProductNameElement; }
                set { _ProductNameElement = value; OnPropertyChanged("ProductNameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _ProductNameElement;
            
            /// <summary>
            /// Product or brand name of the nutritional supplement
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string ProductName
            {
                get { return ProductNameElement != null ? ProductNameElement.Value : null; }
                set
                {
                    if(value == null)
                      ProductNameElement = null; 
                    else
                      ProductNameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("ProductName");
                }
            }
            
            /// <summary>
            /// Scheduled frequency of supplement
            /// </summary>
            [FhirElement("scheduled", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.Timing Scheduled
            {
                get { return _Scheduled; }
                set { _Scheduled = value; OnPropertyChanged("Scheduled"); }
            }
            
            private Hl7.Fhir.Model.Timing _Scheduled;
            
            /// <summary>
            /// Amount of the nutritional supplement
            /// </summary>
            [FhirElement("quantity", InSummary=true, Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.Quantity Quantity
            {
                get { return _Quantity; }
                set { _Quantity = value; OnPropertyChanged("Quantity"); }
            }
            
            private Hl7.Fhir.Model.Quantity _Quantity;
            
            /// <summary>
            /// Instructions or additional information about the oral supplement
            /// </summary>
            [FhirElement("instruction", InSummary=true, Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString InstructionElement
            {
                get { return _InstructionElement; }
                set { _InstructionElement = value; OnPropertyChanged("InstructionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _InstructionElement;
            
            /// <summary>
            /// Instructions or additional information about the oral supplement
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Instruction
            {
                get { return InstructionElement != null ? InstructionElement.Value : null; }
                set
                {
                    if(value == null)
                      InstructionElement = null; 
                    else
                      InstructionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Instruction");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as NutritionOrderSupplementComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                    if(ProductNameElement != null) dest.ProductNameElement = (Hl7.Fhir.Model.FhirString)ProductNameElement.DeepCopy();
                    if(Scheduled != null) dest.Scheduled = (Hl7.Fhir.Model.Timing)Scheduled.DeepCopy();
                    if(Quantity != null) dest.Quantity = (Hl7.Fhir.Model.Quantity)Quantity.DeepCopy();
                    if(InstructionElement != null) dest.InstructionElement = (Hl7.Fhir.Model.FhirString)InstructionElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new NutritionOrderSupplementComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as NutritionOrderSupplementComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(ProductNameElement, otherT.ProductNameElement)) return false;
                if( !DeepComparable.Matches(Scheduled, otherT.Scheduled)) return false;
                if( !DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.Matches(InstructionElement, otherT.InstructionElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as NutritionOrderSupplementComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(ProductNameElement, otherT.ProductNameElement)) return false;
                if( !DeepComparable.IsExactly(Scheduled, otherT.Scheduled)) return false;
                if( !DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.IsExactly(InstructionElement, otherT.InstructionElement)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("NutritionOrderEnteralFormulaComponent")]
        [DataContract]
        public partial class NutritionOrderEnteralFormulaComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "NutritionOrderEnteralFormulaComponent"; } }
            
            /// <summary>
            /// Formula feeding instructions expressed as text
            /// </summary>
            [FhirElement("administrationInstructions", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString AdministrationInstructionsElement
            {
                get { return _AdministrationInstructionsElement; }
                set { _AdministrationInstructionsElement = value; OnPropertyChanged("AdministrationInstructionsElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _AdministrationInstructionsElement;
            
            /// <summary>
            /// Formula feeding instructions expressed as text
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string AdministrationInstructions
            {
                get { return AdministrationInstructionsElement != null ? AdministrationInstructionsElement.Value : null; }
                set
                {
                    if(value == null)
                      AdministrationInstructionsElement = null; 
                    else
                      AdministrationInstructionsElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("AdministrationInstructions");
                }
            }
            
            /// <summary>
            /// Type of enteral or infant formula
            /// </summary>
            [FhirElement("baseFormulaType", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept BaseFormulaType
            {
                get { return _BaseFormulaType; }
                set { _BaseFormulaType = value; OnPropertyChanged("BaseFormulaType"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _BaseFormulaType;
            
            /// <summary>
            /// Product or brand name of the enteral or infant formula
            /// </summary>
            [FhirElement("baseFormulaProductName", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString BaseFormulaProductNameElement
            {
                get { return _BaseFormulaProductNameElement; }
                set { _BaseFormulaProductNameElement = value; OnPropertyChanged("BaseFormulaProductNameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _BaseFormulaProductNameElement;
            
            /// <summary>
            /// Product or brand name of the enteral or infant formula
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string BaseFormulaProductName
            {
                get { return BaseFormulaProductNameElement != null ? BaseFormulaProductNameElement.Value : null; }
                set
                {
                    if(value == null)
                      BaseFormulaProductNameElement = null; 
                    else
                      BaseFormulaProductNameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("BaseFormulaProductName");
                }
            }
            
            /// <summary>
            /// Scheduled frequency of enteral feeding
            /// </summary>
            [FhirElement("scheduled", InSummary=true, Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.Timing Scheduled
            {
                get { return _Scheduled; }
                set { _Scheduled = value; OnPropertyChanged("Scheduled"); }
            }
            
            private Hl7.Fhir.Model.Timing _Scheduled;
            
            /// <summary>
            /// Type of modular component to add to the feeding
            /// </summary>
            [FhirElement("additiveType", InSummary=true, Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept AdditiveType
            {
                get { return _AdditiveType; }
                set { _AdditiveType = value; OnPropertyChanged("AdditiveType"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _AdditiveType;
            
            /// <summary>
            /// Product or brand name of the modular additive
            /// </summary>
            [FhirElement("additiveProductName", InSummary=true, Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString AdditiveProductNameElement
            {
                get { return _AdditiveProductNameElement; }
                set { _AdditiveProductNameElement = value; OnPropertyChanged("AdditiveProductNameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _AdditiveProductNameElement;
            
            /// <summary>
            /// Product or brand name of the modular additive
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string AdditiveProductName
            {
                get { return AdditiveProductNameElement != null ? AdditiveProductNameElement.Value : null; }
                set
                {
                    if(value == null)
                      AdditiveProductNameElement = null; 
                    else
                      AdditiveProductNameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("AdditiveProductName");
                }
            }
            
            /// <summary>
            /// Amount of energy per specified volume that is required
            /// </summary>
            [FhirElement("caloricDensity", InSummary=true, Order=100)]
            [DataMember]
            public Hl7.Fhir.Model.Quantity CaloricDensity
            {
                get { return _CaloricDensity; }
                set { _CaloricDensity = value; OnPropertyChanged("CaloricDensity"); }
            }
            
            private Hl7.Fhir.Model.Quantity _CaloricDensity;
            
            /// <summary>
            /// How the formula should enter the patient's gastrointestinal tract
            /// </summary>
            [FhirElement("routeofAdministration", InSummary=true, Order=110)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept RouteofAdministration
            {
                get { return _RouteofAdministration; }
                set { _RouteofAdministration = value; OnPropertyChanged("RouteofAdministration"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _RouteofAdministration;
            
            /// <summary>
            /// The volume of formula to provide
            /// </summary>
            [FhirElement("quantity", InSummary=true, Order=120)]
            [DataMember]
            public Hl7.Fhir.Model.Quantity Quantity
            {
                get { return _Quantity; }
                set { _Quantity = value; OnPropertyChanged("Quantity"); }
            }
            
            private Hl7.Fhir.Model.Quantity _Quantity;
            
            /// <summary>
            /// Speed with which the formula is provided per period of time
            /// </summary>
            [FhirElement("rate", InSummary=true, Order=130)]
            [DataMember]
            public Hl7.Fhir.Model.Ratio Rate
            {
                get { return _Rate; }
                set { _Rate = value; OnPropertyChanged("Rate"); }
            }
            
            private Hl7.Fhir.Model.Ratio _Rate;
            
            /// <summary>
            /// Change in the rate of administration over a given time
            /// </summary>
            [FhirElement("rateAdjustment", InSummary=true, Order=140)]
            [DataMember]
            public Hl7.Fhir.Model.Quantity RateAdjustment
            {
                get { return _RateAdjustment; }
                set { _RateAdjustment = value; OnPropertyChanged("RateAdjustment"); }
            }
            
            private Hl7.Fhir.Model.Quantity _RateAdjustment;
            
            /// <summary>
            /// Upper limit on formula volume per unit of time
            /// </summary>
            [FhirElement("maxVolumeToDeliver", InSummary=true, Order=150)]
            [DataMember]
            public Hl7.Fhir.Model.Quantity MaxVolumeToDeliver
            {
                get { return _MaxVolumeToDeliver; }
                set { _MaxVolumeToDeliver = value; OnPropertyChanged("MaxVolumeToDeliver"); }
            }
            
            private Hl7.Fhir.Model.Quantity _MaxVolumeToDeliver;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as NutritionOrderEnteralFormulaComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(AdministrationInstructionsElement != null) dest.AdministrationInstructionsElement = (Hl7.Fhir.Model.FhirString)AdministrationInstructionsElement.DeepCopy();
                    if(BaseFormulaType != null) dest.BaseFormulaType = (Hl7.Fhir.Model.CodeableConcept)BaseFormulaType.DeepCopy();
                    if(BaseFormulaProductNameElement != null) dest.BaseFormulaProductNameElement = (Hl7.Fhir.Model.FhirString)BaseFormulaProductNameElement.DeepCopy();
                    if(Scheduled != null) dest.Scheduled = (Hl7.Fhir.Model.Timing)Scheduled.DeepCopy();
                    if(AdditiveType != null) dest.AdditiveType = (Hl7.Fhir.Model.CodeableConcept)AdditiveType.DeepCopy();
                    if(AdditiveProductNameElement != null) dest.AdditiveProductNameElement = (Hl7.Fhir.Model.FhirString)AdditiveProductNameElement.DeepCopy();
                    if(CaloricDensity != null) dest.CaloricDensity = (Hl7.Fhir.Model.Quantity)CaloricDensity.DeepCopy();
                    if(RouteofAdministration != null) dest.RouteofAdministration = (Hl7.Fhir.Model.CodeableConcept)RouteofAdministration.DeepCopy();
                    if(Quantity != null) dest.Quantity = (Hl7.Fhir.Model.Quantity)Quantity.DeepCopy();
                    if(Rate != null) dest.Rate = (Hl7.Fhir.Model.Ratio)Rate.DeepCopy();
                    if(RateAdjustment != null) dest.RateAdjustment = (Hl7.Fhir.Model.Quantity)RateAdjustment.DeepCopy();
                    if(MaxVolumeToDeliver != null) dest.MaxVolumeToDeliver = (Hl7.Fhir.Model.Quantity)MaxVolumeToDeliver.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new NutritionOrderEnteralFormulaComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as NutritionOrderEnteralFormulaComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(AdministrationInstructionsElement, otherT.AdministrationInstructionsElement)) return false;
                if( !DeepComparable.Matches(BaseFormulaType, otherT.BaseFormulaType)) return false;
                if( !DeepComparable.Matches(BaseFormulaProductNameElement, otherT.BaseFormulaProductNameElement)) return false;
                if( !DeepComparable.Matches(Scheduled, otherT.Scheduled)) return false;
                if( !DeepComparable.Matches(AdditiveType, otherT.AdditiveType)) return false;
                if( !DeepComparable.Matches(AdditiveProductNameElement, otherT.AdditiveProductNameElement)) return false;
                if( !DeepComparable.Matches(CaloricDensity, otherT.CaloricDensity)) return false;
                if( !DeepComparable.Matches(RouteofAdministration, otherT.RouteofAdministration)) return false;
                if( !DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.Matches(Rate, otherT.Rate)) return false;
                if( !DeepComparable.Matches(RateAdjustment, otherT.RateAdjustment)) return false;
                if( !DeepComparable.Matches(MaxVolumeToDeliver, otherT.MaxVolumeToDeliver)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as NutritionOrderEnteralFormulaComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(AdministrationInstructionsElement, otherT.AdministrationInstructionsElement)) return false;
                if( !DeepComparable.IsExactly(BaseFormulaType, otherT.BaseFormulaType)) return false;
                if( !DeepComparable.IsExactly(BaseFormulaProductNameElement, otherT.BaseFormulaProductNameElement)) return false;
                if( !DeepComparable.IsExactly(Scheduled, otherT.Scheduled)) return false;
                if( !DeepComparable.IsExactly(AdditiveType, otherT.AdditiveType)) return false;
                if( !DeepComparable.IsExactly(AdditiveProductNameElement, otherT.AdditiveProductNameElement)) return false;
                if( !DeepComparable.IsExactly(CaloricDensity, otherT.CaloricDensity)) return false;
                if( !DeepComparable.IsExactly(RouteofAdministration, otherT.RouteofAdministration)) return false;
                if( !DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.IsExactly(Rate, otherT.Rate)) return false;
                if( !DeepComparable.IsExactly(RateAdjustment, otherT.RateAdjustment)) return false;
                if( !DeepComparable.IsExactly(MaxVolumeToDeliver, otherT.MaxVolumeToDeliver)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("NutritionOrderOralDietNutrientComponent")]
        [DataContract]
        public partial class NutritionOrderOralDietNutrientComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "NutritionOrderOralDietNutrientComponent"; } }
            
            /// <summary>
            /// Type of nutrient that is being modified
            /// </summary>
            [FhirElement("modifier", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Modifier
            {
                get { return _Modifier; }
                set { _Modifier = value; OnPropertyChanged("Modifier"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Modifier;
            
            /// <summary>
            /// Quantity of the specified nutrient
            /// </summary>
            [FhirElement("amount", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.Quantity Amount
            {
                get { return _Amount; }
                set { _Amount = value; OnPropertyChanged("Amount"); }
            }
            
            private Hl7.Fhir.Model.Quantity _Amount;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as NutritionOrderOralDietNutrientComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Modifier != null) dest.Modifier = (Hl7.Fhir.Model.CodeableConcept)Modifier.DeepCopy();
                    if(Amount != null) dest.Amount = (Hl7.Fhir.Model.Quantity)Amount.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new NutritionOrderOralDietNutrientComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as NutritionOrderOralDietNutrientComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Modifier, otherT.Modifier)) return false;
                if( !DeepComparable.Matches(Amount, otherT.Amount)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as NutritionOrderOralDietNutrientComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Modifier, otherT.Modifier)) return false;
                if( !DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("NutritionOrderOralDietTextureComponent")]
        [DataContract]
        public partial class NutritionOrderOralDietTextureComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "NutritionOrderOralDietTextureComponent"; } }
            
            /// <summary>
            /// Code to indicate how to alter the texture of the foods, e.g., pureed
            /// </summary>
            [FhirElement("modifier", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Modifier
            {
                get { return _Modifier; }
                set { _Modifier = value; OnPropertyChanged("Modifier"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Modifier;
            
            /// <summary>
            /// Concepts that are used to identify an entity that is ingested for nutritional purposes
            /// </summary>
            [FhirElement("foodType", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept FoodType
            {
                get { return _FoodType; }
                set { _FoodType = value; OnPropertyChanged("FoodType"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _FoodType;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as NutritionOrderOralDietTextureComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Modifier != null) dest.Modifier = (Hl7.Fhir.Model.CodeableConcept)Modifier.DeepCopy();
                    if(FoodType != null) dest.FoodType = (Hl7.Fhir.Model.CodeableConcept)FoodType.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new NutritionOrderOralDietTextureComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as NutritionOrderOralDietTextureComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Modifier, otherT.Modifier)) return false;
                if( !DeepComparable.Matches(FoodType, otherT.FoodType)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as NutritionOrderOralDietTextureComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Modifier, otherT.Modifier)) return false;
                if( !DeepComparable.IsExactly(FoodType, otherT.FoodType)) return false;
                
                return true;
            }
            
        }
        
        
        /// <summary>
        /// The person who requires the diet, formula or nutritional supplement
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=90)]
        [References("Patient")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Patient
        {
            get { return _Patient; }
            set { _Patient = value; OnPropertyChanged("Patient"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Patient;
        
        /// <summary>
        /// Who ordered the diet, formula or nutritional supplement
        /// </summary>
        [FhirElement("orderer", InSummary=true, Order=100)]
        [References("Practitioner")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Orderer
        {
            get { return _Orderer; }
            set { _Orderer = value; OnPropertyChanged("Orderer"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Orderer;
        
        /// <summary>
        /// Identifiers assigned to this order
        /// </summary>
        [FhirElement("identifier", Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// The encounter associated with that this nutrition order
        /// </summary>
        [FhirElement("encounter", Order=120)]
        [References("Encounter")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Encounter
        {
            get { return _Encounter; }
            set { _Encounter = value; OnPropertyChanged("Encounter"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Encounter;
        
        /// <summary>
        /// Date and time the nutrition order was requested
        /// </summary>
        [FhirElement("dateTime", InSummary=true, Order=130)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime DateTimeElement
        {
            get { return _DateTimeElement; }
            set { _DateTimeElement = value; OnPropertyChanged("DateTimeElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _DateTimeElement;
        
        /// <summary>
        /// Date and time the nutrition order was requested
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string DateTime
        {
            get { return DateTimeElement != null ? DateTimeElement.Value : null; }
            set
            {
                if(value == null)
                  DateTimeElement = null; 
                else
                  DateTimeElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("DateTime");
            }
        }
        
        /// <summary>
        /// proposed | draft | planned | requested | active | on-hold | completed | cancelled
        /// </summary>
        [FhirElement("status", InSummary=true, Order=140)]
        [DataMember]
        public Code<Hl7.Fhir.Model.NutritionOrder.NutritionOrderStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.NutritionOrder.NutritionOrderStatus> _StatusElement;
        
        /// <summary>
        /// proposed | draft | planned | requested | active | on-hold | completed | cancelled
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.NutritionOrder.NutritionOrderStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.NutritionOrder.NutritionOrderStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// List of the patient's food and nutrition-related allergies and intolerances
        /// </summary>
        [FhirElement("allergyIntolerance", Order=150)]
        [References("AllergyIntolerance")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> AllergyIntolerance
        {
            get { if(_AllergyIntolerance==null) _AllergyIntolerance = new List<Hl7.Fhir.Model.ResourceReference>(); return _AllergyIntolerance; }
            set { _AllergyIntolerance = value; OnPropertyChanged("AllergyIntolerance"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _AllergyIntolerance;
        
        /// <summary>
        /// Order-specific modifier about the type of food that should be given
        /// </summary>
        [FhirElement("foodPreferenceModifier", Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> FoodPreferenceModifier
        {
            get { if(_FoodPreferenceModifier==null) _FoodPreferenceModifier = new List<Hl7.Fhir.Model.CodeableConcept>(); return _FoodPreferenceModifier; }
            set { _FoodPreferenceModifier = value; OnPropertyChanged("FoodPreferenceModifier"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _FoodPreferenceModifier;
        
        /// <summary>
        /// Order-specific modifier about the type of food that should not be given
        /// </summary>
        [FhirElement("excludeFoodModifier", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> ExcludeFoodModifier
        {
            get { if(_ExcludeFoodModifier==null) _ExcludeFoodModifier = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ExcludeFoodModifier; }
            set { _ExcludeFoodModifier = value; OnPropertyChanged("ExcludeFoodModifier"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _ExcludeFoodModifier;
        
        /// <summary>
        /// Oral diet components
        /// </summary>
        [FhirElement("oralDiet", Order=180)]
        [DataMember]
        public Hl7.Fhir.Model.NutritionOrder.NutritionOrderOralDietComponent OralDiet
        {
            get { return _OralDiet; }
            set { _OralDiet = value; OnPropertyChanged("OralDiet"); }
        }
        
        private Hl7.Fhir.Model.NutritionOrder.NutritionOrderOralDietComponent _OralDiet;
        
        /// <summary>
        /// Supplement components
        /// </summary>
        [FhirElement("supplement", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.NutritionOrder.NutritionOrderSupplementComponent> Supplement
        {
            get { if(_Supplement==null) _Supplement = new List<Hl7.Fhir.Model.NutritionOrder.NutritionOrderSupplementComponent>(); return _Supplement; }
            set { _Supplement = value; OnPropertyChanged("Supplement"); }
        }
        
        private List<Hl7.Fhir.Model.NutritionOrder.NutritionOrderSupplementComponent> _Supplement;
        
        /// <summary>
        /// Enteral formula components
        /// </summary>
        [FhirElement("enteralFormula", Order=200)]
        [DataMember]
        public Hl7.Fhir.Model.NutritionOrder.NutritionOrderEnteralFormulaComponent EnteralFormula
        {
            get { return _EnteralFormula; }
            set { _EnteralFormula = value; OnPropertyChanged("EnteralFormula"); }
        }
        
        private Hl7.Fhir.Model.NutritionOrder.NutritionOrderEnteralFormulaComponent _EnteralFormula;
        
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as NutritionOrder;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Patient != null) dest.Patient = (Hl7.Fhir.Model.ResourceReference)Patient.DeepCopy();
                if(Orderer != null) dest.Orderer = (Hl7.Fhir.Model.ResourceReference)Orderer.DeepCopy();
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(Encounter != null) dest.Encounter = (Hl7.Fhir.Model.ResourceReference)Encounter.DeepCopy();
                if(DateTimeElement != null) dest.DateTimeElement = (Hl7.Fhir.Model.FhirDateTime)DateTimeElement.DeepCopy();
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.NutritionOrder.NutritionOrderStatus>)StatusElement.DeepCopy();
                if(AllergyIntolerance != null) dest.AllergyIntolerance = new List<Hl7.Fhir.Model.ResourceReference>(AllergyIntolerance.DeepCopy());
                if(FoodPreferenceModifier != null) dest.FoodPreferenceModifier = new List<Hl7.Fhir.Model.CodeableConcept>(FoodPreferenceModifier.DeepCopy());
                if(ExcludeFoodModifier != null) dest.ExcludeFoodModifier = new List<Hl7.Fhir.Model.CodeableConcept>(ExcludeFoodModifier.DeepCopy());
                if(OralDiet != null) dest.OralDiet = (Hl7.Fhir.Model.NutritionOrder.NutritionOrderOralDietComponent)OralDiet.DeepCopy();
                if(Supplement != null) dest.Supplement = new List<Hl7.Fhir.Model.NutritionOrder.NutritionOrderSupplementComponent>(Supplement.DeepCopy());
                if(EnteralFormula != null) dest.EnteralFormula = (Hl7.Fhir.Model.NutritionOrder.NutritionOrderEnteralFormulaComponent)EnteralFormula.DeepCopy();
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new NutritionOrder());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as NutritionOrder;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if( !DeepComparable.Matches(Orderer, otherT.Orderer)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if( !DeepComparable.Matches(DateTimeElement, otherT.DateTimeElement)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(AllergyIntolerance, otherT.AllergyIntolerance)) return false;
            if( !DeepComparable.Matches(FoodPreferenceModifier, otherT.FoodPreferenceModifier)) return false;
            if( !DeepComparable.Matches(ExcludeFoodModifier, otherT.ExcludeFoodModifier)) return false;
            if( !DeepComparable.Matches(OralDiet, otherT.OralDiet)) return false;
            if( !DeepComparable.Matches(Supplement, otherT.Supplement)) return false;
            if( !DeepComparable.Matches(EnteralFormula, otherT.EnteralFormula)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as NutritionOrder;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if( !DeepComparable.IsExactly(Orderer, otherT.Orderer)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if( !DeepComparable.IsExactly(DateTimeElement, otherT.DateTimeElement)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(AllergyIntolerance, otherT.AllergyIntolerance)) return false;
            if( !DeepComparable.IsExactly(FoodPreferenceModifier, otherT.FoodPreferenceModifier)) return false;
            if( !DeepComparable.IsExactly(ExcludeFoodModifier, otherT.ExcludeFoodModifier)) return false;
            if( !DeepComparable.IsExactly(OralDiet, otherT.OralDiet)) return false;
            if( !DeepComparable.IsExactly(Supplement, otherT.Supplement)) return false;
            if( !DeepComparable.IsExactly(EnteralFormula, otherT.EnteralFormula)) return false;
            
            return true;
        }
        
    }
    
}
