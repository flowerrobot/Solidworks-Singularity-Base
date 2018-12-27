using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SingularityBase
{
    public class FeatureNameEnum
    {
        //TODO implement this for the below classes
        public enum Test : int
        {
            [StringValue("ExplodeLineProfileFeature")]
            swTnExplodeLineProfileFeature
        }
        /// <summary>
        /// This attribute is used to represent a string value
        /// for a value in an enum.
        /// </summary>
        public class StringValueAttribute : Attribute
        {

            #region Properties

            /// <summary>
            /// Holds the stringvalue for a value in an enum.
            /// </summary>
            public string StringValue { get; protected set; }

            #endregion

            #region Constructor

            /// <summary>
            /// Constructor used to init a StringValue Attribute
            /// </summary>
            /// <param name="value"></param>
            public StringValueAttribute(string value)
            {
                this.StringValue = value;
            }

            #endregion

        }



        public class AssemblyFeaturesEnum
        {

            public const string swTnExplodeLineProfileFeature = "ExplodeLineProfileFeature";

            public const string TnInContextFeatHolder = "InContextFeatHolder";

            public const string TnMateCoincident = "MateCoincident";

            public const string TnMateConcentric = "MateConcentric";

            public const string TnMateDistanceDim = "MateDistanceDim";

            public const string TnMateGroup = "MateGroup";

            public const string TnMateInPlace = "MateInPlace";

            public const string TnMateParallel = "MateParallel";

            public const string TnMatePerpendicular = "MatePerpendicular";

            public const string TnMatePlanarAngleDim = "MatePlanarAngleDim";

            public const string TnMateSymmetric = "MateSymmetric";

            public const string TnMateTangent = "MateTangent";

            public const string TnMateWidth = "MateWidth";

            public const string TnReference = "Reference";

            public const string TnSmartComponentFeature = "SmartComponentFeature";
        }

        public class BodyFeatureEnum
        {

            // Body Features
            public const string TnBaseBody = "BaseBody";

            public const string TnBlend = "Blend";

            public const string TnBlendCut = "BlendCut";

            public const string TnBoss = "Boss";

            public const string TnBossThin = "BossThin";

            public const string TnCavity = "Cavity";

            public const string TnChamfer = "Chamfer";

            public const string TnCirPattern = "CirPattern";

            public const string TnCombineBodies = "CombineBodies";

            public const string TnCosmeticThread = "CosmeticThread";

            public const string TnCurvePattern = "CurvePattern";

            public const string TnCut = "Cut";

            public const string TnCutThin = "CutThin";

            public const string TnDeform = "Deform";

            public const string TnDeleteBody = "DeleteBody";

            public const string TnDelFace = "DelFace";

            public const string TnDerivedCirPattern = "DerivedCirPattern";

            public const string TnDerivedLPattern = "DerivedLPattern";

            public const string TnDome = "Dome";

            public const string TnDraft = "Draft";

            public const string TnEmboss = "Emboss";

            public const string TnExtrusion = "Extrusion";

            public const string TnFillet = "Fillet";

            public const string TnHelix = "Helix";

            public const string TnHoleWzd = "HoleWzd";

            public const string TnImported = "Imported";

            public const string TnICE = "ICE";

            public const string TnLocalCirPattern = "LocalCirPattern";

            public const string TnLocalLPattern = "LocalLPattern";

            public const string TnLPattern = "LPattern";

            public const string TnMirrorPattern = "MirrorPattern";

            public const string TnMirrorSolid = "MirrorSolid";

            public const string TnMoveCopyBody = "MoveCopyBody";

            public const string TnReplaceFace = "ReplaceFace";

            public const string TnRevCut = "RevCut";

            public const string TnRevolution = "Revolution";

            public const string TnRevolutionThin = "RevolutionThin";

            public const string TnShape = "Shape";

            public const string TnShell = "Shell";

            public const string TnSplit = "Split";

            public const string TnStock = "Stock";

            public const string TnSweep = "Sweep";

            public const string TnSweepCut = "SweepCut";

            public const string TnTablePattern = "TablePattern";

            public const string TnThicken = "Thicken";

            public const string TnThickenCut = "ThickenCut";

            public const string TnVarFillet = "VarFillet";

            public const string TnVolSweep = "VolSweep";

            public const string TnVolSweepCut = "VolSweepCut";

            public const string TnMirrorStock = "MirrorStock";
        }

        public class DrawingFeatureEnum
        {

            // Drawing Features
            public const string TnAbsoluteView = "AbsoluteView";

            public const string TnAlignGroup = "AlignGroup";

            public const string TnAuxiliaryView = "AuxiliaryView";

            public const string TnBomTableAnchor = "BomTemplate";

            public const string TnBomTableFeature = "BomFeat";

            public const string TnBomTemplate = "BomTemplate";

            public const string TnBreakLine = "BreakLine";

            public const string TnCenterMark = "CenterMark";

            public const string TnDetailCircle = "DetailCircle";

            public const string TnDetailView = "DetailView";

            public const string TnDrBreakoutSectionLine = "DrBreakoutSectionLine";

            public const string TnDrSectionLine = "DrSectionLine";

            public const string TnDrSheet = "DrSheet";

            public const string TnDrTemplate = "DrTemplate";

            public const string TnDrViewDetached = "DrViewDetached";

            public const string TnGeneralTableAnchor = "GeneralTableAnchor";

            public const string TnHoleTableAnchor = "HoleTableAnchor";

            public const string TnHoleTableFeat = "HoleTableFeat";

            public const string TnHoleTableFeature = "HoleTableFeat";

            public const string TnLiveSection = "LiveSection";

            public const string TnRelativeView = "RelativeView";

            public const string TnRevisionTableAnchor = "RevisionTableAnchor";

            public const string TnRevisionTableFeature = "RevisionTableFeat";

            public const string TnSection = "Section";

            public const string TnSectionAssemView = "SectionAssemView";

            public const string TnSectionPartView = "SectionPartView";

            public const string TnSectionView = "SectionView";

            public const string TnUnfoldedView = "UnfoldedView";
        }

        public class FolderFeaturesEnum
        {

            // Folder Features
            public const string TnBlocksFolder = "BlockFolder";

            public const string TnCommentsFolder = "CommentsFolder";

            public const string TnCutListFolder = "CutListFolder";

            public const string TnDocsFolder = "DocsFolder";

            public const string TnFeatSolidBodyFolder = "FeatSolidBodyFolder";

            public const string TnFeatSurfaceBodyFolder = "FeatSurfaceBodyFolder";

            public const string TnFeatureFolder = "FtrFolder";

            public const string TnFtrFolder = "FtrFolder";

            public const string TnGridDetailFolder = "GridDetailFolder";

            public const string TnInsertedFeatureFolder = "InsertedFeatureFolder";

            public const string TnLiveSectionFolder = "LiveSectionFolder";

            public const string TnMateReferenceGroupFolder = "MateReferenceGroupFolder";

            public const string TnMaterialFolder = "MaterialFolder";

            public const string TnPosGroupFolder = "PosGroupFolder";

            public const string TnProfileFtrFolder = "ProfileFtrFolder";

            public const string TnRefAxisFtrFolder = "RefAxisFtrFolder";

            public const string TnRefPlaneFtrFolder = "RefPlaneFtrFolder";

            public const string TnSolidBodyFolder = "SolidBodyFolder";

            public const string TnSmartComponentFolder = "SmartComponentFolder";

            public const string TnSmartComponentRefFolder = "SmartComponentRefFolder";

            public const string TnSubAtomFolder = "SubAtomFolder";

            public const string TnSubWeldFolder = "SubWeldFolder";

            public const string TnSurfaceBodyFolder = "SurfaceBodyFolder";

            public const string TnTableFolder = "TableFolder";
        }

        public class MiscFeatureEnum
        {

            // Miscellaneous Features
            public const string TnAttribute = "Attribute";

            public const string TnBlockDef = "BlockDef";

            public const string TnComments = "Comments";

            public const string TnConfigBuilderFeature = "ConfigBuilderFeature";

            public const string TnConfiguration = "Configuration";

            public const string TnCurveInFile = "CurveInFile";

            public const string TnDesignTableFeature = "DesignTableFeature";

            public const string TnDetailCabinet = "DetailCabinet";

            public const string TnEmbedLinkDoc = "EmbedLinkDoc";

            public const string TnGridFeature = "GridFeature";

            public const string TnJournal = "Journal";

            public const string TnLibraryFeature = "LibraryFeature";

            public const string TnPartConfiguration = "PartConfiguration";

            public const string TnReferenceBrowser = "ReferenceBrowser";

            public const string TnReferenceEmbedded = "ReferenceEmbedded";

            public const string TnReferenceInternal = "ReferenceInternal";

            public const string TnScale = "Scale";

            public const string TnViewerBodyFeature = "ViewerBodyFeature";

            public const string TnXMLRulesFeature = "XMLRulesFeature";
        }

        public class MoldFeatureEnum
        {

            // Mold Features
            public const string TnMoldCoreCavitySolids = "MoldCoreCavitySolids";

            public const string TnMoldPartingGeom = "MoldPartingGeom";

            public const string TnMoldPartingLine = "MoldPartingLine";

            public const string TnMoldShutOffSrf = "MoldShutOffSrf";
        }

        public class Motion_SimFeaturesEnum
        {

            // Motion and Simulation Features
            public const string TnAEM3DContact = "AEM3DContact";

            public const string TnAEMGravity = "AEMGravity";

            public const string TnAEMLinearDamper = "AEMLinearDamper";

            public const string TnAEMLinearForce = "AEMLinearForce";

            public const string TnAEMLinearMotor = "AEMLinearMotor";

            public const string TnAEMLinearSpring = "AEMLinearSpring";

            public const string TnAEMRotationalMotor = "AEMRotationalMotor";

            public const string TnAEMSimFeature = "AEMSimFeature";

            public const string TnAEMTorque = "AEMTorque";

            public const string TnAEMTorsionalDamper = "AEMTorsionalDamper";

            public const string TnAEMTorsionalSpring = "AEMTorsionalSpring";
        }

        public class RefGeometryFeaturesEnum
        {

            // Reference Geometry Features
            public const string TnOrigin = "OriginProfileFeature";

            public const string TnCoordinateSystem = "CoordSys";

            public const string TnCoordSys = "CoordSys";

            public const string TnRefAxis = "RefAxis";

            public const string TnReferenceCurve = "ReferenceCurve";

            public const string TnRefPlane = "RefPlane";
        }

        public class SceneLightsCamerasEnum
        {

            // Scene, Lights, and Cameras
            public const string TnAmbientLight = "AmbientLight";

            public const string TnCameraFeature = "CameraFeature";

            public const string TnDirectionLight = "DirectionLight";

            public const string TnPointLight = "PointLight";

            public const string TnSpotLight = "SpotLight";
        }

        public class SheetMetalFeaturesEnum
        {

            // Sheet Metal Features
            public const string TnBaseFlange = "SMBaseFlange";

            public const string TnBending = "Bending";

            public const string TnBreakCorner = "BreakCorner";

            public const string TnCornerTrim = "CornerTrim";

            public const string TnCrossBreak = "CrossBreak";

            public const string TnEdgeFlange = "EdgeFlange";

            public const string TnFlatPattern = "FlatPattern";

            public const string TnFlattenBends = "FlattenBends";

            public const string TnFold = "Fold";

            public const string TnFormToolInstance = "FormToolInstance";

            public const string TnHem = "Hem";

            public const string TnLoftedBend = "LoftedBend";

            public const string TnOneBend = "OneBend";

            public const string TnProcessBends = "ProcessBends";

            public const string TnSheetMetal = "SheetMetal";

            public const string TnSketchBend = "SketchBend";

            public const string TnSM3dBend = "SM3dBend";

            public const string TnSMBaseFlange = "SMBaseFlange";

            public const string TnSMMiteredFlange = "SMMiteredFlange";

            public const string TnToroidalBend = "ToroidalBend";

            public const string TnUiBend = "UiBend";

            public const string TnUnFold = "UnFold";
        }

        public class SketchFeaturesEnum
        {

            // Sketch Features
            public const string Tn3DProfileFeature = "3DProfileFeature";

            public const string Tn3DSplineCurve = "3DSplineCurve";

            public const string TnCompositeCurve = "CompositeCurve";

            public const string TnLayoutProfileFeature = "LayoutProfileFeature";

            public const string TnPLine = "PLine";

            public const string TnProfileFeature = "ProfileFeature";

            public const string TnRefCurve = "RefCurve";

            public const string TnRefPoint = "RefPoint";

            public const string TnSketchBlockDefinition = "SketchBlockDef";

            public const string TnSketchHole = "SketchHole";

            public const string TnSketchPattern = "SketchPattern";

            public const string TnSketchPicture = "SketchBitmap";
        }

        public class SurfaceFeatures
        {

            // Surface Features
            public const string TnBlendRefSurface = "BlendRefSurface";

            public const string TnFillRefSurface = "FillRefSurface";

            public const string TnMidRefSurface = "MidRefSurface";

            public const string TnOffsetRefSurface = "OffsetRefSurface";

            public const string TnRadiateRefSurface = "RadiateRefSurface";

            public const string TnRefSurface = "RefSurface";

            public const string TnRevolvRefSurf = "RevolvRefSurf";

            public const string TnRuledSrfFromEdge = "RuledSrfFromEdge";

            public const string TnSewRefSurface = "SewRefSurface";

            public const string TnSurfCut = "SurfCut";

            public const string TnSweepRefSurface = "SweepRefSurface";

            public const string TnTrimRefSurface = "TrimRefSurface";

            public const string TnUnTrimRefSurf = "UnTrimRefSurf";

            public const string TnVolSweepRefSurface = "VolSweepRefSurface";
        }

        public class WeldmentFeatureEnum
        {

            // Weldment Features
            public const string TnGusset = "Gusset";

            public const string TnWeldMemberFeat = "WeldMemberFeat";

            public const string TnWeldmentFeature = "WeldmentFeature";

            public const string TnWeldmentTableAnchor = "WeldmentTableAnchor";

            public const string TnWeldmentTableFeature = "WeldmentTableFeat";
        }

        public enum FeatureNameType : int
        {

            NotFound = 0,

            Assembly = 1,

            Body = 2,

            Drawing = 3,

            Folder = 4,

            Misc = 5,

            Mold = 6,

            MotionSimulation = 7,

            RefGeometry = 8,

            SceneLightCamer = 9,

            SheetMetal = 10,

            Sketch = 11,

            Surface = 12,

            Weldment = 13,
        }

        public static FeatureNameType GetFeatureType(string Name)
        {
            if (GetConstantValues(typeof(AssemblyFeaturesEnum)).Contains(Name)) return FeatureNameType.Assembly;
            else if (GetConstantValues(typeof(BodyFeatureEnum)).Contains(Name)) return FeatureNameType.Body;
            else if (GetConstantValues(typeof(DrawingFeatureEnum)).Contains(Name)) return FeatureNameType.Drawing;
            else if (GetConstantValues(typeof(FolderFeaturesEnum)).Contains(Name)) return FeatureNameType.Folder;
            else if (GetConstantValues(typeof(MiscFeatureEnum)).Contains(Name)) return FeatureNameType.Misc;
            else if (GetConstantValues(typeof(MoldFeatureEnum)).Contains(Name)) return FeatureNameType.Mold;
            else if (GetConstantValues(typeof(Motion_SimFeaturesEnum)).Contains(Name)) return FeatureNameType.MotionSimulation;
            else if (GetConstantValues(typeof(RefGeometryFeaturesEnum)).Contains(Name)) return FeatureNameType.RefGeometry;
            else if (GetConstantValues(typeof(SceneLightsCamerasEnum)).Contains(Name)) return FeatureNameType.SceneLightCamer;
            else if (GetConstantValues(typeof(SheetMetalFeaturesEnum)).Contains(Name)) return FeatureNameType.SheetMetal;
            else if (GetConstantValues(typeof(SketchFeaturesEnum)).Contains(Name)) return FeatureNameType.Sketch;
            else if (GetConstantValues(typeof(SurfaceFeatures)).Contains(Name)) return FeatureNameType.Surface;
            else if (GetConstantValues(typeof(WeldmentFeatureEnum)).Contains(Name)) return FeatureNameType.Weldment;
            else return FeatureNameType.NotFound;

        }

        public static List<string> GetConstantValues(Type type)
        {
            FieldInfo[] fields = type.GetFields((BindingFlags.Public | (BindingFlags.Static | BindingFlags.FlattenHierarchy)));
            return (from item in fields where item.IsLiteral && !item.IsInitOnly && item.FieldType == typeof(string) select (string)item.GetRawConstantValue()).ToList();

        }
    }
}
