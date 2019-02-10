using System;
using SolidWorks.Interop.sldworks;
using System.Collections.Generic;
using SolidWorks.Interop.swconst;

namespace SingularityBase
{

    /// <summary>
    /// Is a wrapper for IFeatureManager 
    /// </summary>
    public interface ISingleFeatureManagers : ISingleBaseObject<IFeatureManager>
    {
        
        ISingleModelDoc Document { get; }

        ISingleFeature GetFirstFeature { get; }
        IEnumerable<ISingleFeature> GetFeatures(bool topLevelOnly);
        int FeatureCount { get; }


        /// <summary>
        /// Will disable feature tree, with a disposable object to restore on dispose
        /// </summary>
        /// <returns></returns>
        IDisposable DisableFeatureTree();
        /// <summary>
        /// Will disable feature tree, with a disposable object to restore on dispose
        /// </summary>
        /// <returns></returns>
        IDisposable DisableFeatureTreeWindow();

        /// <summary>
        /// The Flat pattern feature folder
        /// </summary>
        ISingleFlatPatternFolder GetFlatPatternFolder { get; }

        /// <summary>
        /// Gets the interface to the sheet metal folder feature in the FeatureManager design tree. 
        /// </summary>
        ISingleBaseObject<ISheetMetalFolder> GetSheetMetalFolder { get; }



        ISingleFeature InsertMacroFeature(string baseName,
            string ProgId,
            object MacroMethods,
            object ParamNames,
            object ParamTypes,
            object ParamValues,
            object DimTypes,
            object DimValues,
            object EditBodies,
            object IconFiles,
            swMacroFeatureOptions_e Options
        );


    #region MyRegion

                bool ShowFeatureName { get; set; }
        bool ShowFeatureDescription { get; set; }
        bool ShowComponentNames { get; set; }

        bool ShowComponentDescriptions { get; set; }
        bool ShowComponentConfigurationNames { get; set; }
        bool ShowComponentConfigurationDescriptions { get; set; }
        /// <summary>
        /// True to enable Instant3D, false to not
        /// </summary>
        bool MoveSizeFeatures { get; set; }
        FeatureStatistics FeatureStatistics { get; }


        bool ViewDependencies { get; set; }
        /// <summary>
        /// Gets or sets whether to view the FeatureManager design tree by its features.  
        /// </summary>
        bool ViewFeatures { get; set; }
        bool ShowHierarchyOnly { get; set; }
        bool ShowFeatureDetails { get; set; }
        bool ShowDisplayStateNames { get; set; }

        /// <summary>
        /// Gets or sets whether a surface trim feature is a solid body or a surface body.  
        /// </summary>
        bool SolidForTrim { get; set; }
        bool GroupComponentInstances { get; set; }
        #endregion
    }

    internal interface Iaa
    {
        CustomBendAllowance CreateCustomBendAllowance();

        Feature InsertSheetMetalBaseFlange(double Thickness, bool ThickenDir, double Radius, double ExtrudeDist1,
            double ExtrudeDist2, bool FlipExtruDir, int EndCondition1, int EndCondition2, int DirToUse,
            CustomBendAllowance PCBA, bool UseDefaultRelief, int ReliefType, double ReliefWidth, double ReliefDepth,
            double ReliefRatio, bool UseReliefRatio);

        Feature InsertDeleteBody();

        Feature FeatureExtrusion(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2,
            bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2,
            bool TranslateSurface1, bool TranslateSurface2, bool Merge, bool UseFeatScope, bool UseAutoSelect);

        Feature FeatureExtrusionThin(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2,
            bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2,
            bool TranslateSurface1, bool TranslateSurface2, bool Merge, double Thk1, double Thk2, double EndThk, int RevThinDir,
            int CapEnds, bool AddBends, double BendRad, bool UseFeatScope, bool UseAutoSelect);

        Feature FeatureCut(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2,
            bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2,
            bool TranslateSurface1, bool TranslateSurface2, bool NormalCut, bool UseFeatScope, bool UseAutoSelect);

        Feature FeatureCutThin(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2,
            bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2,
            bool TranslateSurface1, bool TranslateSurface2, double Thk1, double Thk2, double EndThk, int RevThinDir,
            int CapEnds, bool AddBends, double BendRad, bool UseFeatScope, bool UseAutoSelect);

        Feature FeatureRevolve(double Angle, bool ReverseDir, double Angle2, int RevType, int Options, bool Merge,
            bool UseFeatScope, bool UseAutoSel);

        Feature FeatureRevolveCut(double Angle, bool ReverseDir, double Angle2, int RevType, int Options, bool UseFeatScope,
            bool UseAutoSelect);

        Feature FeatureRevolveThin(double Angle, bool ReverseDir, double Angle2, int RevType, double Thickness1,
            double Thickness2, int ReverseThinDir, bool Merge, bool UseFeatScope, bool UseAutoSelect);

        Feature FeatureRevolveThinCut(double Angle, bool ReverseDir, double Angle2, int RevType, double Thickness1,
            double Thickness2, int ReverseThinDir, bool UseFeatScope, bool UseAutoSelect);

        Feature FeatureBossThicken(double Thickness, int Direction, int FaceIndex, bool FillVolume, bool Merge,
            bool UseFeatScope, bool UseAutoSelect);

        Feature FeatureCutThicken(double Thickness, int Direction, int FaceIndex, bool FillVolume, bool UseFeatScope,
            bool UseAutoSelect);

        Feature InsertProtrusionSwept(bool Propagate, bool Alignment, short TwistCtrlOption, bool KeepTangency,
            bool ForceNonRational, short StartMatchingType, short EndMatchingType, bool IsThinBody, double Thickness1,
            double Thickness2, short ThinType, bool Merge, bool UseFeatScope, bool UseAutoSelect);

        Feature InsertCutSwept(bool Propagate, bool Alignment, short TwistCtrlOption, bool KeepTangency, bool ForceNonRational,
            short StartMatchingType, short EndMatchingType, bool IsThinBody, double Thickness1, double Thickness2,
            short ThinType, bool UseFeatScope, bool UseAutoSelect);

        Feature InsertProtrusionBlend(bool Closed, bool KeepTangency, bool ForceNonRational, double TessToleranceFactor,
            short StartMatchingType, short EndMatchingType, double StartTangentLength, double EndTangentLength,
            bool StartTangentDir, bool EndTangentDir, bool IsThinBody, double Thickness1, double Thickness2, short ThinType,
            bool Merge, bool UseFeatScope, bool UseAutoSelect);

        Feature InsertCutBlend(bool Closed, bool KeepTangency, bool ForceNonRational, double TessToleranceFactor,
            short StartMatchingType, short EndMatchingType, bool IsThinBody, double Thickness1, double Thickness2,
            short ThinType, bool UseFeatScope, bool UseAutoSelect);

        Feature HoleWizard(int GenericHoleType, int StandardIndex, int FastenerTypeIndex, string SSize, short EndType,
            double Diameter, double Depth, double Value1, double Value2, double Value3, double Value4, double Value5,
            double Value6, double Value7, double Value8, double Value9, double Value10, double Value11, double Value12);

        Feature InsertMacroFeature(string BaseName, string ProgId, object MacroMethods, object ParamNames, object ParamTypes,
            object ParamValues, Body2 EditBody, int Options);

        Feature IInsertMacroFeature(string BaseName, string ProgId, ref string MacroMethods, int ParamCount,
            ref string ParamNames, ref int ParamTypes, ref string ParamValues, Body2 EditBody, int Options);

        void UpdateFeatureTree();
        bool InsertFeatureTreeFolder();

        Feature InsertSheetMetalCornerTrim(int InternalCornerFlag, int BreakType, double BreakDist, int ReliefType,
            double Param);

        Feature InsertFillSurface(int Resolution);
        bool EditRollback(int Location, string Feature);
        Feature InsertSheetMetalLoftedBend(int ThickDirType, double Thickness);
        void MakeStyledCurves(double Tol, int Mode);
        void HideBodies();
        void ShowBodies();
        Feature InsertMirrorFeature(bool BMirrorBody, bool BGeometryPattern, bool BMerge, bool BKnit);

        Feature InsertMoveCopyBody(double TransX, double TransY, double TransZ, double TransDist, double RotPointX,
            double RotPointY, double RotPointZ, double RotAngleX, double RotAngleY, double RotAngleZ, bool BCopy,
            int NumCopies);

        Feature InsertCombineFeature(int OperationType, Body2 MainBody, object ToolVar);
        Feature IInsertCombineFeature(int OperationType, Body2 MainBody, int ToolsCount, ref Body2 ToolsArr);
        Feature InsertDwgOrDxfFile(string FileName);

        Feature FeatureLinearPattern(int Num1, double Spacing1, int Num2, double Spacing2, bool FlipDir1, bool FlipDir2,
            string DName1, string DName2);

        Feature FeatureCircularPattern(int Num, double Spacing, bool FlipDir, string DName);
        Feature InsertTableDrivenPattern(string FileName, object PointVar, bool UseCentrod, bool GeomPatt);
        Feature IInsertTableDrivenPattern(string FileName, int Count, ref double PointArr, bool UseCentrod, bool GeomPatt);
        string InsertCosmeticThread(short Type, double Depth, double Length, string Note);
        Feature InsertScale(short Type, bool Uniform, double Xscale, double YScale, double ZScale);
        Feature InsertFeatureTreeFolder2(int Type);

        Feature InsertMoveCopyBody2(double TransX, double TransY, double TransZ, double TransDist, double RotPointX,
            double RotPointY, double RotPointZ, double RotAngleX, double RotAngleY, double RotAngleZ, bool BCopy,
            int NumCopies);

        Feature FeatureSketchDrivenPattern(bool UseCentroid, bool BGeomPatt);
        Feature InsertDerivedPattern();

        Feature InsertGussetFeature(double Depth, short DirType, short LocType, bool BIsProfile, double ProfileD1,
            double ProfileD2, double ProfileD3, double ProfileAngle, double ProfileD4, bool BOffset, double DProfileOffset,
            int CrvIndex, bool BReverseDir, bool BReverseFace, bool BUseLenDim);

        Feature InsertSubWeldFolder();
        Feature InsertMoldPartingLine(bool BFlipDir);
        Feature InsertMoldShutOffSurface();
        Feature InsertWeldmentFeature();

        Feature InsertMultiFaceDraft(double Angle, bool FlipDir, bool EdgeDraft, int PropType, bool IsStepDraft,
            bool IsBodyDraft);

        Feature InsertRuledSurfaceFromEdge(int Type, double Length, bool FlipPullDir, bool FlipDir, bool TrimAndSew,
            double Angle, bool CoordInput, double X, double Y, double Z);

        bool MakeStyledCurves2(double Tolerance, int Mode);
        bool InsertSaveOutBodies();
        Feature InsertMoldCoreCavitySolids(double Dist1, double Dist2, bool Setback, double Angle);

        Feature InsertMacroFeature2(string BaseName, string ProgId, object MacroMethods, object ParamNames, object ParamTypes,
            object ParamValues, object DimTypes, object DimValues, Body2 EditBody, object IconFiles, int Options);

        Feature IInsertMacroFeature2(string BaseName, string ProgId, ref string MacroMethods, int ParamCount,
            ref string ParamNames, ref int ParamTypes, ref string ParamValues, int DimCount, ref int DimTypes,
            ref double DimCountValues, Body2 EditBody, int IconCount, ref string IconFiles, int Options);

        void MoldUndercutDetect(int ColUndercut, int ColBase, bool BCoordInput, double Dx, double Dy, double Dz);
        bool PreTrimSurface(bool BMutualTrimIn, bool BSplitSystemIn, bool BSplitLinearIn, bool BRemovePickedIn);
        Feature PostTrimSurface(bool BSewSurfaceIn);
        Feature InsertStructuralWeldment(string Path, int EndCond, double Angle);
        Feature InsertWeldmentTrimFeature(int EndCond);
        Feature InsertWrapFeature(int Type, double Thickness, bool ReverseDir);

        Feature InsertFilletBeadFeature(short Type1, double Size1, double Length1, double Pitch, short Type2, double Size2,
            double Length2, int Flag, int EdgeNum1, object DeSelEdge1, int EdgeNum2, object DeSelEdge2);

        Feature InsertEndCapFeature(double Depth, bool BIsGivenOffset, bool BIsChamfer, double OffsetValue,
            double WallThicknessRatio, double ChamferValue);

        object InsertReferencePoint(int NRefPointType, int NRefPointAlongCurveType, double DDistance_or_Percent,
            int NumberOfRefPoints);

        Feature IInsertReferencePoint(int NRefPointType, int NRefPointAlongCurveType, double DDistance_or_Percent,
            int NumberOfRefPoints);

        Feature InsertProtrusionSwept2(bool Propagate, bool Alignment, short TwistCtrlOption, bool KeepTangency,
            bool ForceNonRational, short StartMatchingType, short EndMatchingType, bool IsThinBody, double Thickness1,
            double Thickness2, short ThinType, short PathAlign, bool Merge, bool UseFeatScope, bool UseAutoSelect);

        Feature InsertCutSwept2(bool Propagate, bool Alignment, short TwistCtrlOption, bool KeepTangency, bool ForceNonRational,
            short StartMatchingType, short EndMatchingType, bool IsThinBody, double Thickness1, double Thickness2,
            short ThinType, short PathAlign, bool UseFeatScope, bool UseAutoSelect);

        Feature InsertSweepSurface(bool Propagate, short TwistCtrlOption, bool KeepTangency, bool ForceNonRational,
            short StartMatchingType, short EndMatchingType, short PathAlign);

        Feature SimpleHole(double Dia, bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1,
            bool Dchk2, bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2,
            bool TranslateSurface1, bool TranslateSurface2, bool UseFeatScope, bool UseAutoSelect);

        Feature InsertMoldPartingSurface(int Radiate, bool ReverseAlignment, bool ReverseOffset, double OffsetDistance,
            double Angle, int Smooth, double SmoothDistance, bool Knit);

        Feature InsertRuledSurfaceFromEdge2(int Type, double Length, bool FlipPullDir, bool FlipDir, bool TrimAndSew,
            double Angle, bool CoordInput, double X, double Y, double Z, bool BConnectSurface);

        Feature InsertWeldmentCutList();
        Feature InsertUntrimSurface(int FaceUntrimType, int EdgeUntrimType, double Distance, bool BMerge);
        Feature InsertCosmeticThread2(short Type, double Depth, double Length, string Note);
        Feature InsertStructuralWeldment2(string Path, int EndCond, double Angle, bool Merge);

        Feature InsertSheetMetalMiterFlange(bool UseDefaultRadius, double GlobalRadius, double RipGap, bool UseDefaultRelief,
            bool UseReliefRatio, double ReliefRatio, double ReliefWidth, double ReliefDepth, int ReliefType, bool TrimSideBends,
            int FlangePos, double OffsetDist1, double OffsetDist2, CustomBendAllowance PCBA);

        Feature InsertSubFolder();

        Feature InsertFeatureChamfer(int Options, int ChamferType, double Width, double Angle, double OtherDist,
            double VertexChamDist1, double VertexChamDist2, double VertexChamDist3);

        bool MoveToFolder(string MoveToFeat, string MoveFromFeat, bool IsFolder);

        Feature InsertMateReference(string BstrMateReferenceName, Entity PrimaryReferenceEntity, int PrimaryReferenceType,
            int PrimaryReferenceAlignment, Entity SecondaryReferenceEntity, int SecondaryReferenceType,
            int SecondaryReferenceAlignment, Entity TertiaryReferenceEntity, int TertiaryReferenceType,
            int TertiaryReferenceAlignment);

        object FeatureFillet(int Options, double R1, int Ftyp, int OverflowType, object Radii, object SetBackDistances,
            object PointRadiusArray);

        Feature IFeatureFillet(int Options, double R1, int Ftyp, int OverflowType, int NRadii, ref double Radii,
            int SetbackDistCount, ref double SetBackDistances, int PointCount, ref double PointRadiusArray);

        Feature InsertProtrusionSwept3(bool Propagate, bool Alignment, short TwistCtrlOption, bool KeepTangency,
            bool BAdvancedSmoothing, short StartMatchingType, short EndMatchingType, bool IsThinBody, double Thickness1,
            double Thickness2, short ThinType, short PathAlign, bool Merge, bool UseFeatScope, bool UseAutoSelect,
            double TwistAngle, bool BMergeSmoothFaces);

        Feature InsertCutSwept3(bool Propagate, bool Alignment, short TwistCtrlOption, bool KeepTangency,
            bool BAdvancedSmoothing, short StartMatchingType, short EndMatchingType, bool IsThinBody, double Thickness1,
            double Thickness2, short ThinType, short PathAlign, bool UseFeatScope, bool UseAutoSelect, double TwistAngle,
            bool BMergeSmoothFaces);

        Feature InsertSweepSurface2(bool Propagate, short TwistCtrlOption, bool KeepTangency, bool BAdvancedSmoothing,
            short StartMatchingType, short EndMatchingType, short PathAlign, bool UseFeatScope, bool UseAutoSelect,
            double TwistAngle, bool BMergeSmoothFaces);

        Feature InsertSheetMetalHem(int Type, int Position, bool Reverse, double DLength, double DGap, double DAngle,
            double DRad, double DMiterGap, CustomBendAllowance PCBA);

        Feature InsertSheetMetalEdgeFlange(Edge FlangeEdge, Feature SketchFeat, int BooleanOptions, double DAngle,
            double DRadius, int BendPosition, double DOffsetDist, int ReliefType, double DReliefRatio, double DReliefWidth,
            double DReliefDepth, int FlangeSharpType, CustomBendAllowance PCBA);

        Feature InsertSheetMetal3dBend(double Angle, bool BUseDefaultRadius, double Radius, bool FlipDir, short BendPos,
            CustomBendAllowance PCBA);

        Feature InsertEdgeMerge(double Angular_tolerance, double Edge_length_tolerance);

        void MoldUndercutDetect2(int ColUndercut1, int ColUndercut2, int ColOccluded, int ColStraddle, int ColBase,
            bool BCoordInput, double Dx, double Dy, double Dz);

        Feature InsertIndent(double Thickness, double Clearance, bool Exclude, bool ClrDir, bool Cut, bool CutDir);

        Feature FeatureLinearPattern2(int Num1, double Spacing1, int Num2, double Spacing2, bool FlipDir1, bool FlipDir2,
            string DName1, string DName2, bool GeometryPattern);

        Feature FeatureCircularPattern2(int Num, double Spacing, bool FlipDir, string DName, bool GeometryPattern);
        Feature InsertSplitLineIntersect(int CompleteOption);

        Feature InsertFlexFeature(double RotX, double RotY, double RotZ, double TanX, double TanY, double TanZ, double RadX,
            double RadY, double RadZ, double Angle, double PivotX, double PivotY, double PivotZ, int Type, double LeftTrim,
            double RightTrim, bool HardEdges);

        Feature FeatureExtrusion2(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2,
            bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2,
            bool TranslateSurface1, bool TranslateSurface2, bool Merge, bool UseFeatScope, bool UseAutoSelect, int T0,
            double StartOffset, bool FlipStartOffset);

        Feature InsertMoveFace(int MoveType, bool ReverseDir, double Angle, double Distance);
        bool IsNameUsed(int Type, string Name);

        Feature HoleWizard2(int GenericHoleType, int StandardIndex, int FastenerTypeIndex, string SSize, short EndType,
            double Diameter, double Depth, double Value1, double Value2, double Value3, double Value4, double Value5,
            double Value6, double Value7, double Value8, double Value9, double Value10, double Value11, double Value12,
            string ThreadClass, bool RevDir, bool UseFeatScope, bool UseAutoSelect, bool AssemblyFeatureScope,
            bool AutoSelectComponents);

        object CreateDefinition(int Type);
        Feature CreateFeature(object FeatureData);
        Feature CreateFormTool();
        bool InsertVariablePitchHelix(bool Reversed, bool Clockwise, int Helixdef, double Startangle);
        bool AddVariablePitchHelixSegment(double Height, double Diameter, double Pitch);
        Feature EndVariablePitchHelix();
        int GetFeatureCount(bool ToplevelOnly);
        object GetFeatures(bool ToplevelOnly);
        Feature IGetFeatures(bool ToplevelOnly, int Count);

        Feature FeatureExtrusionThin2(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1,
            bool Dchk2, bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2,
            bool TranslateSurface1, bool TranslateSurface2, bool Merge, double Thk1, double Thk2, double EndThk, int RevThinDir,
            int CapEnds, bool AddBends, double BendRad, bool UseFeatScope, bool UseAutoSelect, int T0, double StartOffset,
            bool FlipStartOffset);

        Note InsertSecurityNote(string Text, Feature FeatureOwner);
        object PreSplitBody();
        Feature PostSplitBody(object BodiesToMark, bool ConsumeCut, object Origins, object SavePaths);

        Feature InsertMacroFeature3(string BaseName, string ProgId, object MacroMethods, object ParamNames, object ParamTypes,
            object ParamValues, object DimTypes, object DimValues, object EditBodies, object IconFiles, int Options);

        Feature IInsertMacroFeature3(string BaseName, string ProgId, ref string MacroMethods, int ParamCount,
            ref string ParamNames, ref int ParamTypes, ref string ParamValues, int DimCount, ref int DimTypes,
            ref double DimCountValues, int BodyCount, ref Body2 EditBodies, int IconCount, ref string IconFiles, int Options);

        Feature InsertNetBlend(short Type, short NCurvesDir1, short NCurvesDir2, bool HasCenterline, double TessTolFactor,
            bool WantsSolid, bool MergeBody, bool FeatureScope, bool AutoSelect, bool Thin, double Thickness1,
            double Thickness2, bool ReverseThickness, short ThinSolidType, bool UseSharedThickness, bool CapEnds,
            double EndThickness, bool AutoFillet, double FilletRadius, bool ForceNonRational);

        Feature SetNetBlendCurveData(short Direction, short CurveIndex, short TangentType, double SignedDraftAngle,
            double SignedTangentLength, bool TangentLengthApplyAll);

        Feature SetNetBlendDirectionData(short Direction, short InfluenceType, short TrimCurves, bool BlendClosed,
            bool SplitSurfaces);

        Feature SetNetBlendCenterlineData(bool CombineWithDir2, short TwistType, short PathAlignmentType, short TwistAngleType,
            double TwistAngle);

        Feature ConvertLoftOrSweepToNetBlend();

        Feature InsertSheetMetalEdgeFlange2(object FlangeEdges, object SketchFeats, int BooleanOptions, double FlangeAngle,
            double FlangeRadius, int BendPosition, double FlangeOffsetDist, int ReliefType, double FlangeReliefRatio,
            double FlangeReliefWidth, double FlangeReliefDepth, int FlangeSharpType, CustomBendAllowance CustomBendAllowance);

        Feature IInsertSheetMetalEdgeFlange2(int EdgeCount, ref Edge FlangeEdges, int SketchFeatCount, ref Feature SketchFeat,
            int BooleanOptions, double FlangeAngle, double FlangeRadius, int BendPosition, double FlangeOffsetDist,
            int ReliefType, double FlangeReliefRatio, double FlangeReliefWidth, double FlangeReliefDepth, int FlangeSharpType,
            CustomBendAllowance CustomBendAllowance);

        Feature InsertFillSurface2(int Resolutions, int Options, object VPatchBoundaries, object VCurvatureControlType,
            object VFaces, object VConstraintCurves);

        Feature InsertFreeform(short Continuity0, short Continuity1, short Continuity2, short Continuity3, bool Symmetric0,
            bool Symmetric1);

        void SetFreeformCurveData(short Direction, double CurveParameter, double Tangent0X, double Tangent0Y, double Tangent0Z,
            double Tangent1X, double Tangent1Y, double Tangent1Z);

        void SetFreeformPointData(short Direction, double CurveParameter, double ParameterOnCurve, double XOffset,
            double YOffset, double ZOffset);

        Feature DraftXpertChange(double Angle, bool FlipDir, bool EdgeDraft, int PropType, bool IsStepDraft, bool IsBodyDraft);
        Feature DraftXpertRemove();
        Feature FilletXpertChange(int Options, double R1, int Ftyp, int OverflowType);
        Feature FilletXpertRemove();
        Feature InsertRevolvedRefSurface(double Angle, bool ReverseDir, double Angle2, int RevType);
        object GetPreTrimmedBodies(Body2 TargetSurface);
        Feature FilletXpertMakeCorner(int CornerType);
        Feature InsertMirrorFeature2(bool BMirrorBody, bool BGeometryPattern, bool BMerge, bool BKnit, int ScopeOptions);

        Feature InsertFilletBeadFeature2(short Type1, double Size1, double Length1, short PenetrationType1,
            double PenetrationValue1, double Pitch, short Type2, double Size2, double Length2, short PenetrationType2,
            double PenetrationValue2, int Flag, int EdgeNum1, object DeSelEdge1, int EdgeNum2, object DeSelEdge2);

        TreeControlItem GetFeatureTreeRootItem();
        Feature SimpleFeatureBossExtrude(string SketchName, double Depth, bool Direction);
        object InsertMidSurface(Body2 PBodyIn, ModelDoc2 PPartDocIn, double Placement, bool KnitFlag);

        object CreateSaveBodyFeature(object Bodies, object FilePaths, string AssemName, bool ConsumeBody,
            bool CopyCustomProperty);

        Feature HoleWizard3(int GenericHoleType, int StandardIndex, int FastenerTypeIndex, string SSize, short EndType,
            double Diameter, double Depth, double Value1, double Value2, double Value3, double Value4, double Value5,
            double Value6, double Value7, double Value8, double Value9, double Value10, double Value11, double Value12,
            string ThreadClass, bool RevDir, bool UseFeatScope, bool UseAutoSelect, bool AssemblyFeatureScope,
            bool AutoSelectComponents, bool PropagateFeatureToParts);

        Feature SimpleHole2(double Dia, bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1,
            bool Dchk2, bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2,
            bool TranslateSurface1, bool TranslateSurface2, bool UseFeatScope, bool UseAutoSelect, bool AssemblyFeatureScope,
            bool AutoSelectComponents, bool PropagateFeatureToParts);

        Feature FeatureCut2(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2,
            bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2,
            bool TranslateSurface1, bool TranslateSurface2, bool NormalCut, bool UseFeatScope, bool UseAutoSelect,
            bool AssemblyFeatureScope, bool AutoSelectComponents, bool PropagateFeatureToParts);

        Feature FeatureRevolveCut2(double Angle, bool ReverseDir, double Angle2, int RevType, int Options, bool UseFeatScope,
            bool UseAutoSelect, bool AssemblyFeatureScope, bool AutoSelectComponents, bool PropagateFeatureToParts);

        Feature InsertFreeform2(bool Nsided, bool Symmetric0, bool Symmetric1, double Angle);
        void SetFreeformBoundaryContinuity(short BoundaryIndex, short Continuity);

        bool EditReferencePoint(int NRefPointType, int NRefPointAlongCurveType, double DDistance_or_Percent,
            int NumberOfRefPoints);

        bool EditDeleteFace(int Refill);
        Feature InsertLiveSectionPlane(short Type);

        bool MoveRotateLiveSectionPlane(string Feat, short Type, double XorDeltaX, double YorDeltaY, double ZorDeltaZ,
            double Axisx, double Axisy, double Axisz, double Angle);

        Feature InsertCrossBreak(double Angle, double Radius);

        void InsertRib(bool Is2Sided, bool ReverseThicknessDir, double Thickness, int ReferenceEdgeIndex,
            bool ReverseMaterialDir, bool IsDrafted, bool DraftOutward, double DraftAngle, bool IsNormToSketch,
            bool IsDraftedFromWall);

        short GetPlasticsShellType();
        Feature InsertCoordinateSystem(bool XFlippedIn, bool YFlippedIn, bool ZFlippedIn);

        Feature CreateCoordinateSystem(object OriginPointEntity, object XAxisEntities, object YAxisEntities,
            object ZAxisEntities);

        bool InsertConvertToSheetMetal(double Thickness, bool ReverseThickDir, bool FindBends, double Radius, double Gap,
            int ReliefType, double ReliefRatio);

        bool InsertConnectionPoint(int Type, int SubType, bool ReverseDirection, double Diameter, double StubLength,
            double MinimumStraight, double EndLengthAdjustment, double ConductorSplitLength, string SchematicPinID,
            double CableWidth, double CableThickness, bool SwitchPin1Position, string SpecificationFieldName,
            string SpecificationValue);

        Feature FeatureCut3(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2,
            bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2,
            bool TranslateSurface1, bool TranslateSurface2, bool NormalCut, bool UseFeatScope, bool UseAutoSelect,
            bool AssemblyFeatureScope, bool AutoSelectComponents, bool PropagateFeatureToParts, int T0, double StartOffset,
            bool FlipStartOffset);

        Feature FeatureCutThin2(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2,
            bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2,
            bool TranslateSurface1, bool TranslateSurface2, double Thk1, double Thk2, double EndThk, int RevThinDir,
            int CapEnds, bool AddBends, double BendRad, bool UseFeatScope, bool UseAutoSelect, int T0, double StartOffset,
            bool FlipStartOffset);

        Feature InsertStructuralWeldment3(string Path, int EndCond, double Angle, bool Merge, object Groups);
        StructuralMemberGroup CreateStructuralMemberGroup();

        Feature InsertMateReference2(string BstrMateReferenceName, Entity PrimaryReferenceEntity, int PrimaryReferenceType,
            int PrimaryReferenceAlignment, bool PrimaryReferenceAlignAxes, Entity SecondaryReferenceEntity,
            int SecondaryReferenceType, int SecondaryReferenceAlignment, bool SecondaryReferenceAlignAxes,
            Entity TertiaryReferenceEntity, int TertiaryReferenceType, int TertiaryReferenceAlignment);

        Feature InsertWeldmentCutList2(object Bodies);

        Feature InsertGussetFeature2(double Depth, short DirType, short LocType, bool BIsProfile, double ProfileD1,
            double ProfileD2, double ProfileD3, double ProfileAngle, double ProfileD4, bool BOffset, double DProfileOffset,
            int CrvIndex, bool BReverseDir, bool BReverseFace, bool BUseLenDim, object Faces);

        Feature InsertEndCapFeature2(double Depth, bool BIsGivenOffset, bool BIsChamfer, double OffsetValue,
            double WallThicknessRatio, double ChamferValue, object Faces);

        Feature InsertWeldmentTrimFeature2(int EndCond, int Options, double GapValue, object BodiesToTrim,
            object BodiesOrFaces);

        Feature InsertFilletBeadFeature3(short Type1, double Size1, double Length1, short PenetrationType1,
            double PenetrationValue1, double Pitch, short Type2, double Size2, double Length2, short PenetrationType2,
            double PenetrationValue2, int Flag, int EdgeNum1, object DeSelEdge1, int EdgeNum2, object DeSelEdge2,
            object FaceSet1, object FaceSet2);

        Feature InsertSubWeldFolder2(object BodyArray);

        Feature InsertSewRefSurface(bool UseGapFilters, bool TryToFormSolid, bool MergeEntities, double KnitTolerance,
            double MaxValueForGapRange);

        Feature InsertSheetMetalBaseFlange2(double Thickness, bool ThickenDir, double Radius, double ExtrudeDist1,
            double ExtrudeDist2, bool FlipExtruDir, int EndCondition1, int EndCondition2, int DirToUse,
            CustomBendAllowance PCBA, bool UseDefaultRelief, int ReliefType, double ReliefWidth, double ReliefDepth,
            double ReliefRatio, bool UseReliefRatio, bool Merge, bool UseFeatScope, bool UseAutoSelect);

        object InsertRefPlane(int FirstConstraint, double FirstConstraintAngleOrDistance, int SecondConstraint,
            double SecondConstraintAngleOrDistance, int ThirdConstraint, double ThirdConstraintAngleOrDistance);

        Feature HoleWizard4(int GenericHoleType, int StandardIndex, int FastenerTypeIndex, string SSize, short EndType,
            double Diameter, double Depth, double Value1, double Value2, double Value3, double Value4, double Value5,
            double Value6, double Value7, double Value8, double Value9, double Value10, double Value11, double Value12,
            string ThreadClass, bool RevDir, bool UseFeatScope, bool UseAutoSelect, bool AssemblyFeatureScope,
            bool AutoSelectComponents, bool PropagateFeatureToParts);

        Feature InsertMoveFace2(int MoveType, bool ReverseDir, double Angle, double Distance, object TranslationParams,
            object RotationParams);

        Feature IInsertMoveFace2(int MoveType, bool ReverseDir, double Angle, double Distance, ref double TranslationParams,
            ref double RotationParams);

        Feature InsertProtrusionBlend2(bool Closed, bool KeepTangency, bool ForceNonRational, double TessToleranceFactor,
            short StartMatchingType, short EndMatchingType, double StartTangentLength, double EndTangentLength,
            bool StartTangentDir, bool EndTangentDir, bool IsThinBody, double Thickness1, double Thickness2, short ThinType,
            bool Merge, bool UseFeatScope, bool UseAutoSelect, int GuideCurveInfluence);

        bool InsertConvertToSheetMetal2(double Thickness, bool ReverseThickDir, bool FindBends, double Radius, double Gap,
            int ReliefType, double ReliefRatio, int OverlapType, double OverlapRatio, bool KeepBody);

        Feature InsertCutSwept4(bool Propagate, bool Alignment, short TwistCtrlOption, bool KeepTangency,
            bool BAdvancedSmoothing, short StartMatchingType, short EndMatchingType, bool IsThinBody, double Thickness1,
            double Thickness2, short ThinType, short PathAlign, bool UseFeatScope, bool UseAutoSelect, double TwistAngle,
            bool BMergeSmoothFaces, bool AssemblyFeatureScope, bool AutoSelectComponents, bool PropagateFeatureToParts);

        Feature InsertStructuralWeldment4(string Path, int ConnectedSegmentsOption, bool AllowProtrusion, object Groups);
        Feature InsertFeatureLock();
        Feature InsertGridFeature(object HeightDoubles);

        void FeatureExtruRefSurface(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2,
            bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2,
            bool TranslateSurface1, bool TranslateSurface2, bool CapEnd1, bool CapEnd2, bool DeleteOriginalFace,
            bool KnitResult);

        bool AddVariablePitchHelixFirstPitchAndDiameter(double FirstPitch, double FirstDiameter);

        Feature FeatureRevolve2(bool SingleDir, bool IsSolid, bool IsThin, bool IsCut, bool ReverseDir,
            bool BothDirectionUpToSameEntity, int Dir1Type, int Dir2Type, double Dir1Angle, double Dir2Angle,
            bool OffsetReverse1, bool OffsetReverse2, double OffsetDistance1, double OffsetDistance2, int ThinType,
            double ThinThickness1, double ThinThickness2, bool Merge, bool UseFeatScope, bool UseAutoSelect);

        Feature InsertDwgOrDxfFile2(string FileName, object DxfDwgImportData);

        Feature FeatureCircularPattern3(int Number, double Spacing, bool FlipDirection, string DName, bool GeometryPattern,
            bool EqualSpacing);

        Feature InsertSheetMetalHem2(int Type, int Position, bool Reverse, double DLength, double DGap, double DAngle,
            double DRad, double DMiterGap, CustomBendAllowance PCBA, bool UseDefaultRelief, int ReliefType, int ReliefTearTypes,
            bool UseReliefRatio, double ReliefRatio, double ReliefWidth, double ReliefDepth);

        Feature InsertFormToolFeature(string Path, bool Flip, double RotAngle, string Config, bool OverrideDoc, bool ShowPunch,
            bool ShowProfile, bool ShowCenter, bool LinkToPart);

        Feature GetFreezeLocation();
        int EditFreeze(int Location, string FeatureName, bool UpdateAllConfigs);

        void FeatureExtruRefSurface2(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2,
            bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2,
            bool TranslateSurface1, bool TranslateSurface2, bool CapEnd1, bool CapEnd2, bool DeleteOriginalFace,
            bool KnitResult);

        TreeControlItem GetFeatureTreeRootItem2(int WhichPane);
        Feature InsertCosmeticWeldBead(double WeldSize);
        Feature CreateFormTool2(double OriginX, double OriginY);

        Feature FeatureLinearPattern3(int Num1, double Spacing1, int Num2, double Spacing2, bool FlipDir1, bool FlipDir2,
            string DName1, string DName2, bool GeometryPattern, bool VaryInstance);

        Feature FeatureCircularPattern4(int Number, double Spacing, bool FlipDirection, string DName, bool GeometryPattern,
            bool EqualSpacing, bool VaryInstance);

        bool InsertVaryInstanceIncrement(string DName, int PatternType, int IncrementType, int Direction,
            double IncrementValue);

        bool InsertVaryInstanceOverride(string DName, int PatternType, int OverrideType, int Direction, int InstanceRowIndex,
            int InstanceColumnIndex, double OverrideValue);

        Feature InsertCenterOfMass();
        Feature InsertCenterOfMassReferencePoint();

        Feature InsertCutSurface(bool Flip, int KeepPieceIndex, bool UseFeatScope, bool UseAutoSelect, object Bodies,
            out int Error);

        object GetSheetMetalFolder();
        object GetFlatPatternFolder();

        Feature FeatureFillPattern(int PatternLayoutType, int LayoutSpacingType, double InstanceSpacing, double StaggerAngle,
            double Margins, double LoopSpacing, int NoOfInstances, int PatternLayoutPolygonSides, int FeaturesToPatternType,
            int CreateSeedCutType, double Diameter, double Dimension, double Rotation, double Diagonal,
            int CreateSeedCutPolygonSides, double OuterRadius, double InnerRadius, bool FlipShapeDirection,
            bool GeometryPattern);

        Feature FeatureDimensionPattern(int Num1, double Spacing1, int Num2, double Spacing2, bool DiagonalOnly, string DName1,
            string DName2, bool VaryInstance);

        Feature InsertSheetMetalLoftedBend2(int ThickDirType, double Thickness, bool BFormed, double DRadius,
            bool BReferToEndPoint, int EFacetOption, double DChordTol, int INumBends, double DSegLength, double DSegAngle);

        Feature HoleWizard5(int GenericHoleType, int StandardIndex, int FastenerTypeIndex, string SSize, short EndType,
            double Diameter, double Depth, double Length, double Value1, double Value2, double Value3, double Value4,
            double Value5, double Value6, double Value7, double Value8, double Value9, double Value10, double Value11,
            double Value12, string ThreadClass, bool RevDir, bool FeatureScope, bool AutoSelect, bool AssemblyFeatureScope,
            bool AutoSelectComponents, bool PropagateFeatureToParts);

        Feature InsertSheetMetalGussetFeature(bool BOffset, double DOffset, bool BFlipOffsetSide, int ProfDimType,
            double DIndentDepth, double DLength, bool BUseAngle, double DHeight, double DAngle, bool BFlipSides, double DWidth,
            double DThickness, bool BDraft, double DDraftAngle, bool BInnerCornerFillet, double DInnerCornerFilletRadius,
            bool BOuterCornerFillet, double DOuterCornerFilletRadius, int GussetType, bool BEdgeFillet,
            double DEdgeFilletRadius);

        Feature InsertSheetMetalGussetFeature2(bool BOffset, double DOffset, bool BFlipOffsetSide, int ProfDimType,
            double DIndentDepth, double DLength, bool BUseAngle, double DHeight, double DAngle, bool BFlipSides, double DWidth,
            double DThickness, bool BDraft, double DDraftAngle, bool BInnerCornerFillet, double DInnerCornerFilletRadius,
            bool BOuterCornerFillet, double DOuterCornerFilletRadius, int GussetType, bool BEdgeFillet,
            double DEdgeFilletRadius, object ArrayOfFaces, object ArrayRefLines, object ArrayRefPoints);

        Feature FeatureExtrusion3(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2,
            bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2,
            bool TranslateSurface1, bool TranslateSurface2, bool Merge, bool UseFeatScope, bool UseAutoSelect, int T0,
            double StartOffset, bool FlipStartOffset);

        object FeatureFillet2(int Options, double R1, double Rho, int Ftyp, int OverflowType, int ConicRhoType, object Radii,
            object RhoArr, object SetBackDistances, object PointRadiusArray, object PointRhoArray);

        Feature IFeatureFillet2(int Options, double R1, double Rho, int Ftyp, int OverflowType, int ConicRhoType, int NRadii,
            ref double Radii, ref double RhoArr, int SetbackDistCount, ref double SetBackDistances, int PointCount,
            ref double PointRadiusArray, ref double PointRhoArray);

        bool AddCornerReliefType(int CornerIndex, int ReliefType, double Length1, double Length2, double Length3,
            bool CenterOnBendLines, bool RatioToThickness, bool TangentToBend, bool AddFilletedCorners, bool NarrowCorner);

        int AddCornerReliefCorner();
        Feature FinishCornerRelief();

        Feature InsertCosmeticThread3(int Standard, string StandardType, string Size, double Diameter, int EndType,
            double Depth, string Note);

        object PreIntersect(bool CapPlanar);
        Feature PostIntersect(object IntersectionsToExclude, bool Merge, bool Consume);

        object FeatureFillet3(int Options, double R1, double R2, double Rho, int Ftyp, int OverflowType, int ConicRhoType,
            object Radii, object Dist2Arr, object RhoArr, object SetBackDistances, object PointRadiusArray,
            object PointDist2Array, object PointRhoArray);

        Feature FeatureFolderLocation(Feature Feature);
        int EditFreeze2(int Location, string FeatureName, bool UpdateAllConfigs, bool UnlockConfigs);

        Feature FeatureLocalCurveDrivenPattern(bool FlipDir1, int Num1, bool EqualSpacing1, double Spacing1, int ReferencePoint,
            int CurveMethod, int AlignMethod, bool Direction2, bool FlipDir2, int Num2, bool EqualSpacing2, double Spacing2,
            bool PatternSeedOnly);

        Feature FeatureLocalSketchDrivenPattern(int ReferencePoint);
        object PreSplitBody2();

        Feature InsertEndCapFeature3(double Depth, bool BIsGivenOffset, bool BIsChamfer, double OffsetValue,
            double WallThicknessRatio, double ChamferValue, bool BIsCornerTreatment, double DepthOffset, bool BIsReverse,
            int BIsEndCapInward);

        Feature InsertGussetFeature3(double Depth, short DirType, short LocType, bool BIsProfile, double ProfileD1,
            double ProfileD2, double ProfileD3, double ProfileAngle, double ProfileD4, bool BOffset, double DProfileOffset,
            int CrvIndex, bool BReverseDir, bool BReverseFace, bool BUseLenDim, double ProfileD5, double ProfileD6,
            double ProfileChamferAngle, bool BUseLenDimForChamfer, bool BNeedChamferInGusset);

        Feature InsertDeleteBody2(bool KeepBodies);

        Feature FeatureLinearPattern4(int Num1, double Spacing1, int Num2, double Spacing2, bool FlipDir1, bool FlipDir2,
            string DName1, string DName2, bool GeometryPattern, bool VaryInstance, bool HasOffset1, bool HasOffset2,
            bool CtrlByNum1, bool CtrlByNum2, bool FromCentroid1, bool FromCentroid2, bool RevOffset1, bool RevOffset2,
            double Offset1, double Offset2);

        Feature FeatureAdvancedTableDrivenPattern();

        Feature InsertSheetMetalGussetFeature3(bool BOffset, double DOffset, bool BFlipOffsetSide, int ProfDimType,
            double DIndentDepth, double DLength, bool BUseAngle, double DHeight, double DAngle, bool BFlipSides, double DWidth,
            double DThickness, bool BDraft, double DDraftAngle, bool BInnerCornerFillet, double DInnerCornerFilletRadius,
            bool BOuterCornerFillet, double DOuterCornerFilletRadius, int GussetType, bool BEdgeFillet,
            double DEdgeFilletRadius, bool BOverrideDoc, bool BShowProfile, bool BShowCenter);

        Feature InsertFlattenSurface(int AccuracyFactor);

        Feature InsertMoveFace3(int MoveType, bool ReverseDir, double Angle, double Distance, object TranslationParams,
            object RotationParams, int EndConditionType, double OffsetDistance);

        object InsertCosmeticWeldBead2(int WeldMode, object WeldFromFaceOrEdgeSet, object WeldToFaceOrEdgeSet, double WeldSize);

        Feature InsertStructuralWeldment5(string Path, int ConnectedSegmentsOption, bool AllowProtrusion, object Groups,
            string ConfigurationName);

        Feature FeatureChainPattern(int PitchMethod, bool FlipDirection, bool FillPath, int Number, double Spacing,
            bool GroupOneFlipPlane, bool GroupTwoChain, bool GroupTwoFlipPlane, int AlignMethod, int Options);

        Feature InsertNetBlend2(short Type, short NCurvesDir1, short NCurvesDir2, bool HasCenterline, double TessTolFactor,
            bool WantsSolid, bool MergeBody, bool FeatureScope, bool AutoSelect, bool Thin, double Thickness1,
            double Thickness2, bool ReverseThickness, short ThinSolidType, bool UseSharedThickness, bool CapEnds,
            double EndThickness, bool AutoFillet, double FilletRadius, bool ForceNonRational, bool CreateSolid);

        Feature InsertFlattenSurface2(int AccuracyFactor, bool ShouldUseTears);
        object PreIntersect2(bool CapPlanar, int RegionType);

        Feature InsertProtrusionSwept4(bool Propagate, bool Alignment, int TwistCtrlOption, bool KeepTangency,
            bool BAdvancedSmoothing, int StartMatchingType, int EndMatchingType, bool IsThinBody, double Thickness1,
            double Thickness2, int ThinType, int PathAlign, bool Merge, bool UseFeatScope, bool UseAutoSelect,
            double TwistAngle, bool BMergeSmoothFaces, bool CircularProfile, double CircularProfileDiameter, int Direction);

        Feature InsertCutSwept5(bool Propagate, bool Alignment, int TwistCtrlOption, bool KeepTangency, bool BAdvancedSmoothing,
            int StartMatchingType, int EndMatchingType, bool IsThinBody, double Thickness1, double Thickness2, int ThinType,
            int PathAlign, bool UseFeatScope, bool UseAutoSelect, double TwistAngle, bool BMergeSmoothFaces,
            bool AssemblyFeatureScope, bool AutoSelectComponents, bool PropagateFeatureToParts, bool CircularProfile,
            double CircularProfileDiameter, int Direction);

        Feature InsertSweepSurface3(bool Propagate, int TwistCtrlOption, bool KeepTangency, bool BAdvancedSmoothing,
            int StartMatchingType, int EndMatchingType, int PathAlign, bool UseFeatScope, bool UseAutoSelect, double TwistAngle,
            bool BMergeSmoothFaces, bool CircularProfile, double CircularProfileDiameter, int Direction);

        bool ExpandFeature(object Component, string FeatureName, int WhichPane);

        Feature FeatureLinearPattern5(int Num1, double Spacing1, int Num2, double Spacing2, bool FlipDir1, bool FlipDir2,
            string DName1, string DName2, bool GeometryPattern, bool VaryInstance, bool HasOffset1, bool HasOffset2,
            bool CtrlByNum1, bool CtrlByNum2, bool FromCentroid1, bool FromCentroid2, bool RevOffset1, bool RevOffset2,
            double Offset1, double Offset2, bool D2PatternSeedOnly, bool SyncSubAssemblies);

        Feature FeatureCircularPattern5(int Number, double Spacing, bool FlipDirection, string DName, bool GeometryPattern,
            bool EqualSpacing, bool VaryInstance, bool SyncSubAssemblies, bool BDir2, bool BSymmetric, int Number2,
            double Spacing2, string DName2, bool EqualSpacing2);

        Feature InsertTableDrivenPattern2(string FileName, object PointVar, bool UseCentroid, bool GeomPattern,
            bool PropVisProps);

        void FeatureExtruRefSurface3(bool Sd, bool Dir, int StartCond, double OffsetVal, int T1, int T2, double D1, double D2,
            bool Dchk1, bool Dchk2, bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1,
            bool OffsetReverse2, bool TranslateSurface1, bool TranslateSurface2, bool CapEnd1, bool CapEnd2,
            bool DeleteOriginalFace, bool KnitResult);

        object GetSelectionSetFolder();
        Feature InsertDerivedPattern2();

        Feature FeatureCut4(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2,
            bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2,
            bool TranslateSurface1, bool TranslateSurface2, bool NormalCut, bool UseFeatScope, bool UseAutoSelect,
            bool AssemblyFeatureScope, bool AutoSelectComponents, bool PropagateFeatureToParts, int T0, double StartOffset,
            bool FlipStartOffset, bool OptimizeGeometry);

        Feature InsertWrapFeature2(int Type, double Thickness, bool ReverseDir, int Method, int MeshFactor);

        string get_FeatureName(int NameID);
    }

}
