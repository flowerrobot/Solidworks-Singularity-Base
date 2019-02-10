using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SingularityBase
{

    /// <summary>
    /// Directly comparable to the GetTypeName2 call on features
    /// </summary>
    /// TODO what about swSelectType
    public enum FeatureName
    {
       [Feature("None", "None", "NoFeatureName")]   None,
        [Feature("Assembly", "ISketch", "ExplodeLineProfileFeature")] ExplodeLineProfileFeature,
        [Feature("Assembly", "IFeature", "InContextFeatHolder")] InContextFeatHolder,
        [Feature("Assembly", "IFeature", "MagneticGroundPlane")] MagneticGroundPlane,
        [Feature("Assembly", "IMate2", "MateCoincident")] MateCoincident,
        [Feature("Assembly", "IMate2", "MateConcentric")] MateConcentric,
        [Feature("Assembly", "IDistanceMateFeatureData", "MateDistanceDim")] MateDistanceDim,
        [Feature("Assembly", "IMate2", "MateInPlace")] MateInPlace,
        [Feature("Assembly", "ILinearCouplerMateFeatureData", "MateLinearCoupler")] MateLinearCoupler,
        [Feature("Assembly", "IMate2", "MateParallel")] MateParallel,
        [Feature("Assembly", "IMate2", "MatePerpendicular")] MatePerpendicular,
        [Feature("Assembly", "IAngleMateFeatureData", "MatePlanarAngleDim")] MatePlanarAngleDim,
        [Feature("Assembly", "IProfileCenterMateFeatureData", "MateProfileCenter")] MateProfileCenter,
        [Feature("Assembly", "ISymmetricMateFeatureData", "MateSymmetric")] MateSymmetric,
        [Feature("Assembly", "IMate2", "MateTangent")] MateTangent,
        [Feature("Assembly", "IWidthMateFeatureData", "MateWidth")] MateWidth,
        [Feature("Assembly", "IMateReference", "Reference")] Reference,
        [Feature("Assembly", "ISmartComponentFeatureData", "SmartComponentFeature")] SmartComponentFeature,

        [Feature("Body", "IAdvancedHoleFeatureData", "AdvHoleWzd")] AdvHoleWzd,
        [Feature("Body", "IFillPatternFeatureData", "APattern")] APattern,
        [Feature("Body", "IExtrudeFeatureData2", "BaseBody")] BaseBody,
        [Feature("Body", "None (Flex feature)", "Bending")] Bending,
        [Feature("Body", "ILoftFeatureData", "Blend")] Blend,
        [Feature("Body", "ILoftFeatureData", "BlendCut")] BlendCut,
        [Feature("Body", "IExtrudeFeatureData2", "Boss")] Boss,
        [Feature("Body", "IExtrudeFeatureData2", "BossThin")] BossThin,
        [Feature("Body", "IChamferFeatureData2", "Chamfer")] Chamfer,
        [Feature("Body", "ICircularPatternFeatureData", "CirPattern")] CirPattern,
        [Feature("Body", "ICombineBodiesFeatureData", "CombineBodies")] CombineBodies,
        [Feature("Body", "ICosmeticThreadFeatureData", "CosmeticThread")] CosmeticThread,
        [Feature("Body", "ISaveBodyFeatureData", "CreateAssemFeat")] CreateAssemFeat,
        [Feature("Body", "ICurveDrivenPatternFeatureData", "CurvePattern")] CurvePattern,
        [Feature("Body", "IExtrudeFeatureData2", "Cut")] Cut,
        [Feature("Body", "IExtrudeFeatureData2", "CutThin")] CutThin,
        [Feature("Body", "None (Deform feature)", "Deform")] Deform,
        [Feature("Body", "IDeleteBodyFeatureData", "DeleteBody")] DeleteBody,
        [Feature("Body", "IDeleteFaceFeatureData", "DelFace")] DelFace,
        [Feature("Body", "IDerivedPatternFeatureData", "DerivedCirPattern")] DerivedCirPattern,
        [Feature("Body", "IDerivedPatternFeatureData", "DerivedLPattern")] DerivedLPattern,
        [Feature("Body", "IDimPatternFeatureData", "DimPattern")] DimPattern,
        [Feature("Body", "IDomeFeatureData2", "Dome")] Dome,
        [Feature("Body", "IDraftFeatureData2", "Draft")] Draft,
        [Feature("Body", "IHealEdgesFeatureData", "EdgeMerge")] EdgeMerge,
        [Feature("Body", "IWrapSketchFeatureData", "Emboss")] Emboss,
        [Feature("Body", "IExtrudeFeatureData2", "Extrusion")] Extrusion,
        [Feature("Body", "ISimpleFilletFeatureData2", "Fillet")] Fillet,
        [Feature("Body", "IHelixFeatureData", "Helix")] Helix,
        [Feature("Body", "IHoleSeriesFeatureData2", "HoleSeries")] HoleSeries,
        [Feature("Body", "IWizardHoleFeatureData2", "HoleWzd")] HoleWzd,
        [Feature("Body", "None (Imported feature)", "Imported")] Imported,
        [Feature("Body", "IChainPatternFeatureData", "LocalChainPattern")] LocalChainPattern,
        [Feature("Body", "ILocalCircularPatternFeatureData", "LocalCirPattern")] LocalCirPattern,
        [Feature("Body", "ILocalCurvePatternFeatureData", "LocalCurvePattern")] LocalCurvePattern,
        [Feature("Body", "ILocalLinearPatternFeatureData", "LocalLPattern")] LocalLPattern,
        [Feature("Body", "ILinearPatternFeatureData", "LPattern")] LPattern,
        [Feature("Body", "IMacroFeatureData", "MacroFeature")] MacroFeature,
        [Feature("Body", "IMirrorPatternFeatureData", "MirrorPattern")] MirrorPattern,
        [Feature("Body", "IMirrorSolidFeatureData", "MirrorSolid")] MirrorSolid,
        [Feature("Body", "IMirrorPartFeatureData", "MirrorStock")] MirrorStock,
        [Feature("Body", "IMoveCopyBodyFeatureData", "MoveCopyBody")] MoveCopyBody,
        [Feature("Body", "IBoundaryBossFeatureData", "NetBlend")] NetBlend,
        [Feature("Body", "IIndentFeatureData", "Punch")] Punch,
        [Feature("Body", "IReplaceFaceFeatureData", "ReplaceFace")] ReplaceFace,
        [Feature("Body", "IRevolveFeatureData2", "RevCut")] RevCut,
        [Feature("Body", "ISimpleFilletFeatureData2", "Round fillet corner")] RoundFilletCorner,
        [Feature("Body", "IRevolveFeatureData2", "Revolution")] Revolution,
        [Feature("Body", "IRevolveFeatureData2", "RevolutionThin")] RevolutionThin,
        [Feature("Body", "IRibFeatureData2", "Rib")] Rib,
        [Feature("Body", "IRipFeatureData", "Rip")] Rip,
        [Feature("Body", "IIntersectFeatureData", "Sculpt")] Sculpt,
        [Feature("Body", "Obsolete", "Shape")] Shape,
        [Feature("Body", "IShellFeatureData", "Shell")] Shell,
        [Feature("Body", "ISplitBodyFeatureData", "Split")] Split,
        [Feature("Body", "", "SplitBody")] SplitBody,
        [Feature("Body", "IDerivedPartFeatureData", "Stock")] Stock,
        [Feature("Body", "ISweepFeatureData", "Sweep")] Sweep,
        [Feature("Body", "ISweepFeatureData", "SweepCut")] SweepCut,
        [Feature("Body", "IThreadFeatureData", "SweepThread")] SweepThread,
        [Feature("Body", "ITablePatternFeatureData", "TablePattern")] TablePattern,
        [Feature("Body", "IThickenFeatureData", "Thicken")] Thicken,
        [Feature("Body", "IThickenFeatureData", "ThickenCut")] ThickenCut,
        [Feature("Body", "IVariableFilletFeatureData2", "VarFillet")] VarFillet,


        [Feature("Drawing", "ITableAnchor", "BendTableAchor")] BendTableAchor,
        [Feature("Drawing", "IBomFeature", "BomFeat")] BomFeat,
        [Feature("Drawing", "ITableAnchor", "BomTemplate")] BomTemplate,
        [Feature("Drawing", "IDetailCircle", "DetailCircle")] DetailCircle,
        [Feature("Drawing", "IDrSection or IBrokenOutSectionFeatureData", "DrBreakoutSectionLine")] DrBreakoutSectionLine,
        [Feature("Drawing", "IDrSection", "DrSectionLine")] DrSectionLine,
        [Feature("Drawing", "ITableAnchor", "GeneralTableAnchor")] GeneralTableAnchor,
        [Feature("Drawing", "ITableAnchor", "HoleTableAnchor")] HoleTableAnchor,
        [Feature("Drawing", "IRefPlane", "LiveSection")] LiveSection,
        [Feature("Drawing", "ITableAnchor", "PunchTableAnchor")] PunchTableAnchor,
        [Feature("Drawing", "ITableAnchor", "RevisionTableAnchor")] RevisionTableAnchor,
        [Feature("Drawing", "ITableAnchor", "WeldmentTableAnchor")] WeldmentTableAnchor,
        [Feature("Drawing", "ITableAnchor", "WeldTableAnchor")] WeldTableAnchor,

        [Feature("Folder", "Obsolete", "BlockFolder")] BlockFolder,
        [Feature("Folder", "ICommentFolder", "CommentsFolder")] CommentsFolder,
        [Feature("Folder", "ICosmeticWeldBeadFolder", "CosmeticWeldSubFolder")] CosmeticWeldSubFolder,
        [Feature("Folder", "IBodyFolder", "CutListFolder")] CutListFolder,
        [Feature("Folder", "IBodyFolder", "FeatSolidBodyFolder")] FeatSolidBodyFolder,
        [Feature("Folder", "IBodyFolder", "FeatSurfaceBodyFolder")] FeatSurfaceBodyFolder,
        [Feature("Folder", "IFeatureFolder", "FtrFolder")] FtrFolder,
        [Feature("Folder", "IFeatureFolder", "InsertedFeatureFolder")] InsertedFeatureFolder,
        [Feature("Folder", "IFeatureFolder", "MateReferenceGroupFolder")] MateReferenceGroupFolder,
        [Feature("Folder", "IMateReference", "PosGroupFolder")] PosGroupFolder,
        [Feature("Folder", "IFeatureFolder", "ProfileFtrFolder")] ProfileFtrFolder,
        [Feature("Folder", "IFeatureFolder", "RefAxisFtrFolder")] RefAxisFtrFolder,
        [Feature("Folder", "IFeatureFolder", "RefPlaneFtrFolder")] RefPlaneFtrFolder,
        [Feature("Folder", "IBodyFolder", "SolidBodyFolder")] SolidBodyFolder,
        [Feature("Folder", "IBodyFolder if a body", "SubAtomFolder")] SubAtomFolder,
        [Feature("Folder", "IBodyFolder", "SubWeldFolder")] SubWeldFolder,
        [Feature("Folder", "IBodyFolder", "SurfaceBodyFolder")] SurfaceBodyFolder,
        [Feature("Folder", "IFlatPatternFolder", "TemplateFlatPattern")] TemplateFlatPattern,

        [Feature("Miscellaneous", "IAttribute", "Attribute")] Attribute,
        [Feature("Miscellaneous", "Obsolete", "BlockDef")] BlockDef,
        [Feature("Miscellaneous", "IFreePointCurveFeatureData", "CurveInFile")] CurveInFile,
        [Feature("Miscellaneous", "None (Grid feature)", "GridFeature")] GridFeature,
        [Feature("Miscellaneous", "ILibraryFeatureData", "LibraryFeature")] LibraryFeature,
        [Feature("Miscellaneous", "IScaleFeatureData", "Scale")] Scale,
        [Feature("Miscellaneous", "ISensor", "Sensor")] Sensor,
        [Feature("Miscellaneous", "Obsolete", "ViewBodyFeature")] ViewBodyFeature,

        [Feature("Mold", "ICavityFeatureData", "Cavity")] Cavity,
        [Feature("Mold", "IToolingSplitFeatureData", "MoldCoreCavitySolids")] MoldCoreCavitySolids,
        [Feature("Mold", "IPartingSurfaceFeatureData", "MoldPartingGeom")] MoldPartingGeom,
        [Feature("Mold", "IPartingLineFeatureData", "MoldPartLine")] MoldPartLine,
        [Feature("Mold", "IShutOffSurfaceFeatureData", "MoldShutOffSrf")] MoldShutOffSrf,
        [Feature("Mold", "ICoreFeatureData", "SideCore")] SideCore,
        [Feature("Mold", "DerivedPartFeatureData", "XformStock")] XformStock,


        [Feature("Motion and Simulation", "ISimulation3DContactFeatureData", "AEM3DContact")] AEM3DContact,
        [Feature("Motion and Simulation", "ISimulationGravityFeatureData", "AEMGravity")] AEMGravity,
        [Feature("Motion and Simulation", "ISimulationDamperFeatureData", "AEMLinearDamper")] AEMLinearDamper,
        [Feature("Motion and Simulation", "ISimulationMotorFeatureData", "AEMLinearMotor")] AEMLinearMotor,
        [Feature("Motion and Simulation", "ISimulationLinearSpringFeatureData", "AEMLinearSpring")] AEMLinearSpring,
        [Feature("Motion and Simulation", "ISimulationMotorFeatureData", "AEMRotationalMotor")] AEMRotationalMotor,
        [Feature("Motion and Simulation", "ISimulationForceFeatureData", "AEMTorque")] AEMTorque,
        [Feature("Motion and Simulation", "ISimulationDamperFeatureData", "AEMTorsionalDamper")] AEMTorsionalDamper,
        [Feature("Motion and Simulation", "None (TorsionalSpring feature)", "AEMTorsionalSpring")] AEMTorsionalSpring,
        [Feature("Motion and Simulation", "IMotionPlotFeatureData", "SimPlotFeature")] SimPlotFeature,
        [Feature("Motion and Simulation", "IMotionPlotAxisFeatureData", "SimPlotXAxisFeature")] SimPlotXAxisFeature,
        [Feature("Motion and Simulation", "IMotionPlotAxisFeatureData", "SimPlotYAxisFeature")] SimPlotYAxisFeature,
        [Feature("Motion and Simulation", "IMotionStudyResults", "SimResultFolder")] SimResultFolder,


        [Feature("Reference Geometry", "ICoordinateSystemFeatureData", "CoordSys")] CoordSys,
        [Feature("Reference Geometry", "IRefAxis or IRefAxisFeatureData", "RefAxis")] RefAxis,
        [Feature("Reference Geometry", "IRefPlane or IRefPlaneFeatureData", "RefPlane")] RefPlane,


        [Feature("Scenes, Lights, and Cameras", "ILight", "AmbientLight")] AmbientLight,
        [Feature("Scenes, Lights, and Cameras", "ICamera", "CameraFeature")] CameraFeature,
        [Feature("Scenes, Lights, and Cameras", "ILight", "DirectionLight")] DirectionLight,
        [Feature("Scenes, Lights, and Cameras", "ILight", "PointLight")] PointLight,
        [Feature("Scenes, Lights, and Cameras", "ILight", "SpotLight")] SpotLight,


        [Feature("Sheet Metal", "IBaseFlangeFeatureData", "SMBaseFlange")] SmBaseFlange,
        [Feature("Sheet Metal", "IBreakCornerFeatureData", "BreakCorner")] BreakCorner,
        [Feature("Sheet Metal", "IBreakCornerFeatureData", "CornerTrim")] CornerTrim,
        [Feature("Sheet Metal", "ICrossBreakFeatureData", "CrossBreak")] CrossBreak,
        [Feature("Sheet Metal", "IEdgeFlangeFeatureData", "EdgeFlange")] EdgeFlange,
        [Feature("Sheet Metal", "IFlatPatternFeatureData", "FlatPattern")] FlatPattern,
        [Feature("Sheet Metal", "IBendsFeatureData", "FlattenBends")] FlattenBends,
        [Feature("Sheet Metal", "IFoldsFeatureData", "Fold")] Fold,
        [Feature("Sheet Metal", "None (FormTool feature)", "FormToolInstance")] FormToolInstance,
        [Feature("Sheet Metal", "IHemFeatureData", "Hem")] Hem,
        [Feature("Sheet Metal", "IJogFeatureData", "Jog")] Jog,
        [Feature("Sheet Metal", "ILoftedBendsFeatureData", "LoftedBend")] LoftedBend,
        [Feature("Sheet Metal", "IOneBendFeatureData", "OneBend")] OneBend,
        [Feature("Sheet Metal", "IBendsFeatureData", "ProcessBends")] ProcessBends,
        [Feature("Sheet Metal", "ISheetMetalFeatureData", "SheetMetal")] SheetMetal,
        [Feature("Sheet Metal", "IOneBendFeatureData", "SketchBend")] SketchBend,
        [Feature("Sheet Metal", "ISketchedBendFeatureData", "SM3dBend")] Sm3dBend,
        [Feature("Sheet Metal", "ISMGussetFeatureData", "SMGusset")] SmGusset,
        [Feature("Sheet Metal", "IMiterFlangeFeatureData", "SMMiteredFlange")] SmMiteredFlange,
        [Feature("Sheet Metal", "ISheetMetalFolder", "TemplateSheetMetal")] TemplateSheetMetal,
        [Feature("Sheet Metal", "IOneBendFeatureData", "ToroidalBend")] ToroidalBend,
        [Feature("Sheet Metal", "IFoldsFeatureData", "UnFold")] UnFold,


        [Feature("Sketch", "ISketch", "3DProfileFeature")] ProfileFeature3D,
        [Feature("Sketch", "IReferenceCurve or IReferencePointCurveFeatureData", "3DSplineCurve")] SplineCurve3D,
        [Feature("Sketch", "IReferenceCurve or ICompositeCurveFeatureData", "CompositeCurve")] CompositeCurve,
        [Feature("Sketch", "IReferenceCurve or IImportedCurveFeatureData", "ImportedCurve")] ImportedCurve,
        [Feature("Sketch", "ISplitLineFeatureData", "PLine")] PLine,
        [Feature("Sketch", "ISketch", "ProfileFeature")] ProfileFeature,
        [Feature("Sketch", "IReferenceCurve or IProjectionCurveFeatureData", "RefCurve")] RefCurve,
        [Feature("Sketch", "IRefPoint or IRefPointFeatureData", "RefPoint")] RefPoint,
        [Feature("Sketch", "ISketchBlockDefinition", "SketchBlockDef")] SketchBlockDef,
        [Feature("Sketch", "ISketchBlockInstance", "SketchBlockInst")] SketchBlockInst,
        [Feature("Sketch", "ISimpleHoleFeatureData2", "SketchHole")] SketchHole,
        [Feature("Sketch", "ISketchPatternFeatureData", "SketchPattern")] SketchPattern,
        [Feature("Sketch", "ISketchPicture", "SketchBitmap")] SketchBitmap,


        [Feature("Surface", "None (Surface-Loft feature)", "BlendRefSurface")] BlendRefSurface,
        [Feature("Surface", "ISurfaceExtendFeatureData", "ExtendRefSurface")] ExtendRefSurface,
        [Feature("Surface", "ISurfExtrudeFeatureData", "ExtruRefSurface")] ExtruRefSurface,
        [Feature("Surface", "IFillSurfaceFeatureData", "FillRefSurface")] FillRefSurface,
        [Feature("Surface", "ISurfaceFlattenFeatureData", "FlattenSurface")] FlattenSurface,
        [Feature("Surface", "IMidSurface3", "MidRefSurface")] MidRefSurface,
        [Feature("Surface", "ISurfaceOffsetFeatureData", "OffsetRefSuface")] OffsetRefSuface,
        [Feature("Surface", "ISurfacePlanarFeatureData", "PlanarSurface")] PlanarSurface,
        [Feature("Surface", "ISurfaceRadiateFeatureData", "RadiateRefSurface")] RadiateRefSurface,
        [Feature("Surface", "None (Surface-Imported feature)", "RefSurface")] RefSurface,
        [Feature("Surface", "ISurfRevolveFeatureData", "RevolvRefSurf")] RevolvRefSurf,
        [Feature("Surface", "IRuledSurfaceFeatureData", "RuledSrfFromEdge")] RuledSrfFromEdge,
        [Feature("Surface", "ISurfaceKnitFeatureData", "SewRefSurface")] SewRefSurface,
        [Feature("Surface", "ISurfaceCutFeatureData", "SurfCut")] SurfCut,
        [Feature("Surface", "ISweepFeatureData", "SweepRefSurface")] SweepRefSurface,
        [Feature("Surface", "ISurfaceTrimFeatureData", "TrimRefSurface")] TrimRefSurface,
        [Feature("Surface", "None (Surface-Untrim feature)", "UnTrimRefSurf")] UnTrimRefSurf,


        [Feature("Weldment", "ICosmeticWeldBeadFeatureData", "CosmeticWeldBead")] CosmeticWeldBead,
        [Feature("Weldment", "IEndCapFeatureData", "EndCap")] EndCap,
        [Feature("Weldment", "IGussetFeatureData", "Gusset")] Gusset,
        [Feature("Weldment", "IWeldmentBeadFeatureData", "WeldBeadFeat")] WeldBeadFeat,
        [Feature("Weldment", "IWeldmentTrimExtendFeatureData", "WeldCornerFeat")] WeldCornerFeat,
        [Feature("Weldment", "IStructuralMemberFeatureData", "WeldMemberFeat")] WeldMemberFeat,
        [Feature("Weldment", "IStructuralMemberFeatureData", "WeldmentFeature")] WeldmentFeature,
        [Feature("Weldment", "IWeldmentCutListFeature", "WeldmentTableFeat")] WeldmentTableFeat,

        
    }

    /// <summary>
    /// The attributes for the FeatureName
    /// </summary>
    public class FeatureAttribute : Attribute
    {

        #region Properties

        /// <summary>
        /// Holds the string value for a value in an enum.
        /// </summary>
        public new string ToString { get; protected set; }

        /// <summary>
        /// Holds the string value for a value in an enum.
        /// </summary>
        public string AsString => ToString;

        /// <summary>
        /// Holds the Category for a value in an enum.
        /// </summary>
        public string Category { get; protected set; }

        /// <summary>
        /// Holds the Interface type you need to implement
        /// </summary>
        public string Interface { get; protected set; }


        #endregion

        #region Constructor

        /// <summary>
        /// Constructor used to init a FeatureAttribute Attribute
        /// </summary>
        /// <param name="category"></param>
        /// <param name="interfaceType"></param>
        /// <param name="stringName"></param>
        public FeatureAttribute(string category, string interfaceType, string stringName)
        {
            ToString = stringName;
            Category = category;
            Interface = interfaceType;
        }

        #endregion

    }



    public static class FeatureNameHelpers
    {
        private static Dictionary<string, FeatureName> _allEnums;
        private static Dictionary<string, FeatureName> AllEnums
        {
            get {
                if (_allEnums != null) return _allEnums;
                _allEnums = new Dictionary<string, FeatureName>();

                var values = Enum.GetValues(typeof(FeatureName));
                foreach (FeatureName val in values)
                {
                    
                    _allEnums.Add(val.ConvertEnumToString(), val);
                }

                return _allEnums;
            }
        }

        //public static string ConvertEnumToString(FeatureName value)

        //{
        //    return GetAttributeOfType<FeatureAttribute>(value).AsString;
        //}

        public static string ConvertEnumToString(this FeatureName value)

        {
            return GetAttributeOfType<FeatureAttribute>(value).AsString;
        }

        public static FeatureName ConvertStringToEnum(string featName)
        {
            if (AllEnums.ContainsKey(featName))
                return AllEnums[featName];
            return FeatureName.None;
        }

        /// <summary>
        /// Gets an attribute on an enum field value
        /// </summary>
        /// <typeparam name="T">The type of the attribute you want to retrieve</typeparam>
        /// <param name="enumVal">The enum value</param>
        /// <returns>The attribute of type T that exists on the enum value</returns>
        /// <example>string desc = myEnumVariable.GetAttributeOfType<DescriptionAttribute>().Description;</example>
        public static T GetAttributeOfType<T>(this Enum enumVal) where T : System.Attribute
        {
            var type = enumVal.GetType();
            var memInfo = type.GetMember(enumVal.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(T), false);
            return (attributes.Length > 0) ? (T)attributes[0] : null;
        }
    }


    

    [Obsolete("Use the FeatureName enum")]
    public class FeaturesName
    {
        //TODO implement this for the below classes

        public abstract class FeatureNameEnum
        {
            public abstract FeatureNameType Category { get; }
        }





        public class AssemblyFeaturesEnum : FeatureNameEnum
        {
            public override FeatureNameType Category => FeatureNameType.Assembly;

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

        public class BodyFeatureEnum : FeatureNameEnum
        {
            public override FeatureNameType Category => FeatureNameType.Body;
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

        public class DrawingFeatureEnum : FeatureNameEnum
        {
            public override FeatureNameType Category => FeatureNameType.Drawing;
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

        public class FolderFeaturesEnum : FeatureNameEnum
        {
            public override FeatureNameType Category => FeatureNameType.Folder;
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

        public class MiscFeatureEnum : FeatureNameEnum
        {
            public override FeatureNameType Category => FeatureNameType.Misc;
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

        public class MoldFeatureEnum : FeatureNameEnum
        {
            public override FeatureNameType Category => FeatureNameType.Mold;
            // Mold Features
            public const string TnMoldCoreCavitySolids = "MoldCoreCavitySolids";

            public const string TnMoldPartingGeom = "MoldPartingGeom";

            public const string TnMoldPartingLine = "MoldPartingLine";

            public const string TnMoldShutOffSrf = "MoldShutOffSrf";
        }

        public class Motion_SimFeaturesEnum : FeatureNameEnum
        {
            public override FeatureNameType Category => FeatureNameType.MotionSimulation;
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

        public class RefGeometryFeaturesEnum : FeatureNameEnum
        {
            public override FeatureNameType Category => FeatureNameType.RefGeometry;
            // Reference Geometry Features
            public const string TnOrigin = "OriginProfileFeature";

            public const string TnCoordinateSystem = "CoordSys";

            public const string TnCoordSys = "CoordSys";

            public const string TnRefAxis = "RefAxis";

            public const string TnReferenceCurve = "ReferenceCurve";

            public const string TnRefPlane = "RefPlane";
        }

        public class SceneLightsCamerasEnum : FeatureNameEnum
        {
            public override FeatureNameType Category => FeatureNameType.SceneLightCamer;
            // Scene, Lights, and Cameras
            public const string TnAmbientLight = "AmbientLight";

            public const string TnCameraFeature = "CameraFeature";

            public const string TnDirectionLight = "DirectionLight";

            public const string TnPointLight = "PointLight";

            public const string TnSpotLight = "SpotLight";
        }

        public class SheetMetalFeaturesEnum : FeatureNameEnum
        {
            public override FeatureNameType Category => FeatureNameType.SheetMetal;
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

        public class SketchFeaturesEnum : FeatureNameEnum
        {
            public override FeatureNameType Category => FeatureNameType.Sketch;
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

        public class SurfaceFeatures : FeatureNameEnum
        {
            public override FeatureNameType Category => FeatureNameType.Surface;
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

        public class WeldmentFeatureEnum : FeatureNameEnum
        {
            public override FeatureNameType Category => FeatureNameType.Weldment;
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
