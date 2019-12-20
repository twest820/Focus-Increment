using System.Xml;

namespace FocusIncrement.Zerene
{
    internal class Preferences : ZereneXmlElement
    {
        public double AcquisitionSequencerBacklashMillimeters { get; set; }
        public bool AcquisitionSequencerCommandLogging { get; set; }
        public double AcquisitionSequencerDistancePerStepperRotation { get; set; }
        public int AcquisitionSequencerEndPosition { get; set; }
        public double AcquisitionSequencerMaximumMmPerSecond { get; set; }
        public int AcquisitionSequencerMicrostepsPerRotation { get; set; }
        public double AcquisitionSequencerMovementRampTime { get; set; }
        public int AcquisitionSequencerNumberOfSteps { get; set; }
        public double AcquisitionSequencerPrecisionThreshold { get; set; }
        public double AcquisitionSequencerPrerunMillimeters { get; set; }
        public double AcquisitionSequencerRppIndicatorLeft { get; set; }
        public double AcquisitionSequencerRppIndicatorRight { get; set; }
        public double AcquisitionSequencerSettlingTime { get; set; }
        public int AcquisitionSequencerShutterActivationsPerStep { get; set; }
        public double AcquisitionSequencerShutterAfterTime { get; set; }
        public double AcquisitionSequencerShutterBetweenTime { get; set; }
        public double AcquisitionSequencerShutterPulseTime { get; set; }
        public int AcquisitionSequencerStartPosition { get; set; }
        public double AcquisitionSequencerStepSize { get; set; }
        public double AcquisitionSequencerStepSizeAdjustmentFactor { get; set; }
        public string AcquisitionSequencerStepSizesFile { get; set; }
        public bool AlignmentControlAddNewFilesAsAlreadyAligned { get; set; }
        public bool AlignmentControlAlignmentSettingsChanged { get; set; }
        public bool AlignmentControlAllowRotation { get; set; }
        public bool AlignmentControlAllowScale { get; set; }
        public bool AlignmentControlAllowShiftX { get; set; }
        public bool AlignmentControlAllowShiftY { get; set; }
        public bool AlignmentControlAutoTsvFile { get; set; }
        public bool AlignmentControlBrightnessSettingsChanged { get; set; }
        public bool AlignmentControlCorrectBrightness { get; set; }
        public bool AlignmentControlForceAllAlignAgainstFirst { get; set; }
        public double AlignmentControlMaxRelDegRotation { get; set; }
        public double AlignmentControlMaxRelPctScale { get; set; }
        public double AlignmentControlMaxRelPctShiftX { get; set; }
        public double AlignmentControlMaxRelPctShiftY { get; set; }
        public bool AlignmentControlOrderAutomatic { get; set; }
        public bool AlignmentControlOrderNarrowFirst { get; set; }
        public bool AlignmentControlUseMaximumPrecisionRules { get; set; }
        public bool AllowReportingUsageStatistics { get; set; }
        public string BatchFileChooserLastDirectory { get; set; }
        public string BrightnessCorrectionParameters { get; set; }
        public bool ColorManagementCopyIccProfileExternally { get; set; }
        public bool ColorManagementDebugPrintProfile { get; set; }
        public string ColorManagementInputOption { get; set; }
        public string ColorManagementInputOptionAssumedProfile { get; set; }
        public bool ColorManagementManageZSDisplays { get; set; }
        public bool ColorManagementManageZSDisplaysHasChanged { get; set; }
        public string ColorManagementOutputOption { get; set; }
        public int DepthMapControlAlgorithmIdentifier { get; set; }
        public double DepthMapControlContrastThresholdLevel { get; set; }
        public double DepthMapControlContrastThresholdPercentile { get; set; }
        public int DepthMapControlEstimationRadius { get; set; }
        public byte[] DepthMapControlExternalMaskColorRgba { get; set; }
        public string DepthMapControlExternalMaskFile { get; set; }
        public bool DepthMapControlSaveDepthMapImage { get; set; }
        public string DepthMapControlSaveDepthMapImageDirectory { get; set; }
        public bool DepthMapControlSaveUsedPixelImages { get; set; }
        public int DepthMapControlSmoothingRadius { get; set; }
        public byte[] DepthMapControlThresholdMaskColorRgba { get; set; }
        public bool DepthMapControlUseFixedContrastThresholdLevel { get; set; }
        public bool DepthMapControlUseFixedContrastThresholdPercentile { get; set; }
        public double DepthMapControlUsedPixelFractionThreshold { get; set; }
        public bool FileIOIgnoreExifOrientation { get; set; }
        public bool FileIOUseExternalTiffReader { get; set; }
        public string InterpolatorRenderingSelection { get; set; }
        public bool InterpolatorShowAdvanced { get; set; }
        public string OriginalSourceFilesFolderPath { get; set; }
        public string OutputImageNamingTemplate { get; set; }
        public string PrecropLimitsString { get; set; }
        public bool PrecropSelected { get; set; }
        public int PrerotationDegrees { get; set; }
        public bool PrerotationExifTagIgnore { get; set; }
        public bool PrerotationSelected { get; set; }
        public double PresizeUserSettingScale { get; set; }
        public bool PresizeUserSettingSelected { get; set; }
        public double PresizeWorkingScale { get; set; }
        public int PyramidControlGritSuppressionMethod { get; set; }
        public bool PyramidControlRetainOnlyUdrImage { get; set; }
        public bool PyramidControlRetainUdrImage { get; set; }
        public bool PyramidControlUseAllChannels { get; set; }
        public double RetouchingBrushHardness { get; set; }
        public bool RetouchingBrushShowBrushes { get; set; }
        public string RetouchingBrushType { get; set; }
        public double RetouchingBrushWidth { get; set; }
        public int SaveImageBitsPerColor { get; set; }
        public double SaveImageCompressionQuality { get; set; }
        public string SaveImageCompressionType { get; set; }
        public string SaveImageDefaultFolderStrategy { get; set; }
        public string SaveImageFileType { get; set; }
        public string SaveImageFolderPathLastUsed { get; set; }
        public bool SaveImagePropagateExif { get; set; }
        public bool SaveImageRescaleImageToAvoidOverflow { get; set; }
        public int SkewSequenceNumberOfOutputImages { get; set; }
        public bool SkewSequenceSelected { get; set; }
        public double SkewSequenceShiftXPctLimit1 { get; set; }
        public double SkewSequenceShiftXPctLimit2 { get; set; }
        public double SkewSequenceShiftYPctLimit1 { get; set; }
        public double SkewSequenceShiftYPctLimit2 { get; set; }
        public bool SkewSequenceUseConicalPath { get; set; }
        public int StackingControlFrameSkipFactor { get; set; }
        public bool StackingControlFrameSkipSelected { get; set; }
        public int StereoOrderingLeftRightIndexSeparation { get; set; }
        public bool WatchDirectoryOptionsAcceptViaDelay { get; set; }
        public double WatchDirectoryOptionsAcceptViaDelaySeconds { get; set; }

        public Preferences()
        {
            this.AcquisitionSequencerBacklashMillimeters = 0.22;
            this.AcquisitionSequencerCommandLogging = false;
            this.AcquisitionSequencerDistancePerStepperRotation = 1.5875;
            this.AcquisitionSequencerEndPosition = 0;
            this.AcquisitionSequencerMaximumMmPerSecond = 2.0;
            this.AcquisitionSequencerMicrostepsPerRotation = 3200;
            this.AcquisitionSequencerMovementRampTime = 2.0;
            this.AcquisitionSequencerNumberOfSteps = 5;
            this.AcquisitionSequencerPrecisionThreshold = 0.05;
            this.AcquisitionSequencerPrerunMillimeters = 0.0;
            this.AcquisitionSequencerRppIndicatorLeft = -100.0;
            this.AcquisitionSequencerRppIndicatorRight = 100.0;
            this.AcquisitionSequencerSettlingTime = 3.0;
            this.AcquisitionSequencerShutterActivationsPerStep = 1;
            this.AcquisitionSequencerShutterAfterTime = 2.0;
            this.AcquisitionSequencerShutterBetweenTime = 1.0;
            this.AcquisitionSequencerShutterPulseTime = 0.3;
            this.AcquisitionSequencerStartPosition = 0;
            this.AcquisitionSequencerStepSize = 0.1;
            this.AcquisitionSequencerStepSizeAdjustmentFactor = 1.0;
            this.AcquisitionSequencerStepSizesFile = "";
            this.AlignmentControlAddNewFilesAsAlreadyAligned = false;
            this.AlignmentControlAlignmentSettingsChanged = false;
            this.AlignmentControlAllowRotation = true;
            this.AlignmentControlAllowScale = true;
            this.AlignmentControlAllowShiftX = true;
            this.AlignmentControlAllowShiftY = true;
            this.AlignmentControlAutoTsvFile = false;
            this.AlignmentControlBrightnessSettingsChanged = false;
            this.AlignmentControlCorrectBrightness = true;
            this.AlignmentControlForceAllAlignAgainstFirst = false;
            this.AlignmentControlMaxRelDegRotation = 20;
            this.AlignmentControlMaxRelPctScale = 20;
            this.AlignmentControlMaxRelPctShiftX = 20;
            this.AlignmentControlMaxRelPctShiftY = 20;
            this.AlignmentControlOrderAutomatic = true;
            this.AlignmentControlOrderNarrowFirst = true;
            this.AlignmentControlUseMaximumPrecisionRules = false;
            this.AllowReportingUsageStatistics = false;
            this.BatchFileChooserLastDirectory = null;
            this.ColorManagementCopyIccProfileExternally = false;
            this.ColorManagementDebugPrintProfile = false;
            this.ColorManagementInputOption = "Use_EXIF_and_DCF_rules";
            this.ColorManagementInputOptionAssumedProfile = "sRGB IEC61966-2.1";
            this.ColorManagementManageZSDisplays = false;
            this.ColorManagementManageZSDisplaysHasChanged = false;
            this.ColorManagementOutputOption = "CopyInput";
            this.DepthMapControlAlgorithmIdentifier = 1;
            this.DepthMapControlContrastThresholdLevel = 2.2606417E-5;
            this.DepthMapControlContrastThresholdPercentile = 52.6;
            this.DepthMapControlEstimationRadius = 10;
            this.DepthMapControlExternalMaskColorRgba = new byte[] { 80, 0, 0, 128 };
            this.DepthMapControlExternalMaskFile = "";
            this.DepthMapControlSaveDepthMapImage = false;
            this.DepthMapControlSaveDepthMapImageDirectory = "{project}\\DepthMaps";
            this.DepthMapControlSaveUsedPixelImages = false;
            this.DepthMapControlSmoothingRadius = 5;
            this.DepthMapControlThresholdMaskColorRgba = new byte[] { 0, 0, 0, 255 };
            this.DepthMapControlUseFixedContrastThresholdLevel = false;
            this.DepthMapControlUseFixedContrastThresholdPercentile = false;
            this.DepthMapControlUsedPixelFractionThreshold = 0.5;
            this.FileIOIgnoreExifOrientation = false;
            this.FileIOUseExternalTiffReader = false;
            this.InterpolatorRenderingSelection = "Interpolator.Spline4x4";
            this.InterpolatorShowAdvanced = false;
            this.OriginalSourceFilesFolderPath = null;
            this.OutputImageNamingTemplate = "{datetime} ZS {method}";
            this.PrecropLimitsString = null;
            this.PrecropSelected = false;
            this.PrerotationDegrees = 0;
            this.PrerotationExifTagIgnore = false;
            this.PrerotationSelected = false;
            this.PresizeUserSettingScale = 1.0;
            this.PresizeUserSettingSelected = false;
            this.PresizeWorkingScale = 1.0;
            this.PyramidControlGritSuppressionMethod = 1;
            this.PyramidControlRetainOnlyUdrImage = false;
            this.PyramidControlRetainUdrImage = false;
            this.PyramidControlUseAllChannels = false;
            this.RetouchingBrushHardness = 0.5;
            this.RetouchingBrushShowBrushes = true;
            this.RetouchingBrushType = "Details";
            this.RetouchingBrushWidth = 30.073105;
            this.SaveImageBitsPerColor = 8;
            this.SaveImageCompressionQuality = 0.9166667;
            this.SaveImageCompressionType = "none";
            this.SaveImageDefaultFolderStrategy = "WithSource";
            this.SaveImageFileType = "jpg";
            this.SaveImageFolderPathLastUsed = null;
            this.SaveImagePropagateExif = false;
            this.SaveImageRescaleImageToAvoidOverflow = false;
            this.SkewSequenceNumberOfOutputImages = 3;
            this.SkewSequenceSelected = false;
            this.SkewSequenceShiftXPctLimit1 = -3.0;
            this.SkewSequenceShiftXPctLimit2 = 3.0;
            this.SkewSequenceShiftYPctLimit1 = 0.0;
            this.SkewSequenceShiftYPctLimit2 = 0.0;
            this.SkewSequenceUseConicalPath = false;
            this.StackingControlFrameSkipFactor = 1;
            this.StackingControlFrameSkipSelected = false;
            this.StereoOrderingLeftRightIndexSeparation = 1;
            this.WatchDirectoryOptionsAcceptViaDelay = false;
            this.WatchDirectoryOptionsAcceptViaDelaySeconds = 2.0;
        }

        public void Write(XmlWriter writer)
        {
            writer.WriteStartElement(Constant.Zerene.Element.Preferences);

            this.WriteElementValue(writer, Constant.Zerene.Element.AcquisitionSequencerBacklashMillimeters, this.AcquisitionSequencerBacklashMillimeters);
            this.WriteElementValue(writer, Constant.Zerene.Element.AcquisitionSequencerCommandLogging, this.AcquisitionSequencerCommandLogging);
            this.WriteElementValue(writer, Constant.Zerene.Element.AcquisitionSequencerDistancePerStepperRotation, this.AcquisitionSequencerDistancePerStepperRotation);
            this.WriteElementValue(writer, Constant.Zerene.Element.AcquisitionSequencerEndPosition, this.AcquisitionSequencerEndPosition);
            this.WriteElementValue(writer, Constant.Zerene.Element.AcquisitionSequencerMaximumMmPerSecond, this.AcquisitionSequencerMaximumMmPerSecond);
            this.WriteElementValue(writer, Constant.Zerene.Element.AcquisitionSequencerMicrostepsPerRotation, this.AcquisitionSequencerMicrostepsPerRotation);
            this.WriteElementValue(writer, Constant.Zerene.Element.AcquisitionSequencerMovementRampTime, this.AcquisitionSequencerMovementRampTime);
            this.WriteElementValue(writer, Constant.Zerene.Element.AcquisitionSequencerNumberOfSteps, this.AcquisitionSequencerNumberOfSteps);
            this.WriteElementValue(writer, Constant.Zerene.Element.AcquisitionSequencerPrecisionThreshold, this.AcquisitionSequencerPrecisionThreshold);
            this.WriteElementValue(writer, Constant.Zerene.Element.AcquisitionSequencerPrerunMillimeters, this.AcquisitionSequencerPrerunMillimeters);
            this.WriteElementValue(writer, Constant.Zerene.Element.AcquisitionSequencerRppIndicatorLeft, this.AcquisitionSequencerRppIndicatorLeft);
            this.WriteElementValue(writer, Constant.Zerene.Element.AcquisitionSequencerRppIndicatorRight, this.AcquisitionSequencerRppIndicatorRight);
            this.WriteElementValue(writer, Constant.Zerene.Element.AcquisitionSequencerSettlingTime, this.AcquisitionSequencerSettlingTime);
            this.WriteElementValue(writer, Constant.Zerene.Element.AcquisitionSequencerShutterActivationsPerStep, this.AcquisitionSequencerShutterActivationsPerStep);
            this.WriteElementValue(writer, Constant.Zerene.Element.AcquisitionSequencerShutterAfterTime, this.AcquisitionSequencerShutterAfterTime);
            this.WriteElementValue(writer, Constant.Zerene.Element.AcquisitionSequencerShutterBetweenTime, this.AcquisitionSequencerShutterBetweenTime);
            this.WriteElementValue(writer, Constant.Zerene.Element.AcquisitionSequencerShutterPulseTime, this.AcquisitionSequencerShutterPulseTime);
            this.WriteElementValue(writer, Constant.Zerene.Element.AcquisitionSequencerStartPosition, this.AcquisitionSequencerStartPosition);
            this.WriteElementValue(writer, Constant.Zerene.Element.AcquisitionSequencerStepSize, this.AcquisitionSequencerStepSize);
            this.WriteElementValue(writer, Constant.Zerene.Element.AcquisitionSequencerStepSizeAdjustmentFactor, this.AcquisitionSequencerStepSizeAdjustmentFactor);
            this.WriteElementValue(writer, Constant.Zerene.Element.AcquisitionSequencerStepSizesFile, this.AcquisitionSequencerStepSizesFile);
            this.WriteElementValue(writer, Constant.Zerene.Element.AlignmentControlAddNewFilesAsAlreadyAligned, this.AlignmentControlAddNewFilesAsAlreadyAligned);
            this.WriteElementValue(writer, Constant.Zerene.Element.AlignmentControlAlignmentSettingsChanged, this.AlignmentControlAlignmentSettingsChanged);
            this.WriteElementValue(writer, Constant.Zerene.Element.AlignmentControlAllowRotation, this.AlignmentControlAllowRotation);
            this.WriteElementValue(writer, Constant.Zerene.Element.AlignmentControlAllowScale, this.AlignmentControlAllowScale);
            this.WriteElementValue(writer, Constant.Zerene.Element.AlignmentControlAllowShiftX, this.AlignmentControlAllowShiftX);
            this.WriteElementValue(writer, Constant.Zerene.Element.AlignmentControlAllowShiftY, this.AlignmentControlAllowShiftY);
            this.WriteElementValue(writer, Constant.Zerene.Element.AlignmentControlAutoTsvFile, this.AlignmentControlAutoTsvFile);
            this.WriteElementValue(writer, Constant.Zerene.Element.AlignmentControlBrightnessSettingsChanged, this.AlignmentControlBrightnessSettingsChanged);
            this.WriteElementValue(writer, Constant.Zerene.Element.AlignmentControlCorrectBrightness, this.AlignmentControlCorrectBrightness);
            this.WriteElementValue(writer, Constant.Zerene.Element.AlignmentControlForceAllAlignAgainstFirst, this.AlignmentControlForceAllAlignAgainstFirst);
            this.WriteElementValue(writer, Constant.Zerene.Element.AlignmentControlMaxRelDegRotation, this.AlignmentControlMaxRelDegRotation);
            this.WriteElementValue(writer, Constant.Zerene.Element.AlignmentControlMaxRelPctScale, this.AlignmentControlMaxRelPctScale);
            this.WriteElementValue(writer, Constant.Zerene.Element.AlignmentControlMaxRelPctShiftX, this.AlignmentControlMaxRelPctShiftX);
            this.WriteElementValue(writer, Constant.Zerene.Element.AlignmentControlMaxRelPctShiftY, this.AlignmentControlMaxRelPctShiftY);
            this.WriteElementValue(writer, Constant.Zerene.Element.AlignmentControlOrderAutomatic, this.AlignmentControlOrderAutomatic);
            this.WriteElementValue(writer, Constant.Zerene.Element.AlignmentControlOrderNarrowFirst, this.AlignmentControlOrderNarrowFirst);
            this.WriteElementValue(writer, Constant.Zerene.Element.AlignmentControlUseMaximumPrecisionRules, this.AlignmentControlUseMaximumPrecisionRules);
            this.WriteElementValue(writer, Constant.Zerene.Element.AllowReportingUsageStatistics, this.AllowReportingUsageStatistics);
            this.WriteElementValue(writer, Constant.Zerene.Element.BatchFileChooserLastDirectory, this.BatchFileChooserLastDirectory);
            this.WriteElementValue(writer, Constant.Zerene.Element.ColorManagementCopyIccProfileExternally, this.ColorManagementCopyIccProfileExternally);
            this.WriteElementValue(writer, Constant.Zerene.Element.ColorManagementDebugPrintProfile, this.ColorManagementDebugPrintProfile);
            this.WriteElementValue(writer, Constant.Zerene.Element.ColorManagementInputOption, this.ColorManagementInputOption);
            this.WriteElementValue(writer, Constant.Zerene.Element.ColorManagementInputOptionAssumedProfile, this.ColorManagementInputOptionAssumedProfile);
            this.WriteElementValue(writer, Constant.Zerene.Element.ColorManagementManageZSDisplays, this.ColorManagementManageZSDisplays);
            this.WriteElementValue(writer, Constant.Zerene.Element.ColorManagementManageZSDisplaysHasChanged, this.ColorManagementManageZSDisplaysHasChanged);
            this.WriteElementValue(writer, Constant.Zerene.Element.ColorManagementOutputOption, this.ColorManagementOutputOption);
            this.WriteElementValue(writer, Constant.Zerene.Element.DepthMapControlAlgorithmIdentifier, this.DepthMapControlAlgorithmIdentifier);
            this.WriteElementValue(writer, Constant.Zerene.Element.DepthMapControlContrastThresholdLevel, this.DepthMapControlContrastThresholdLevel);
            this.WriteElementValue(writer, Constant.Zerene.Element.DepthMapControlContrastThresholdPercentile, this.DepthMapControlContrastThresholdPercentile);
            this.WriteElementValue(writer, Constant.Zerene.Element.DepthMapControlEstimationRadius, this.DepthMapControlEstimationRadius);
            this.WriteElementValue(writer, Constant.Zerene.Element.DepthMapControlExternalMaskColorRgba, this.DepthMapControlExternalMaskColorRgba);
            this.WriteElementValue(writer, Constant.Zerene.Element.DepthMapControlExternalMaskFile, this.DepthMapControlExternalMaskFile);
            this.WriteElementValue(writer, Constant.Zerene.Element.DepthMapControlSaveDepthMapImage, this.DepthMapControlSaveDepthMapImage);
            this.WriteElementValue(writer, Constant.Zerene.Element.DepthMapControlSaveDepthMapImageDirectory, this.DepthMapControlSaveDepthMapImageDirectory);
            this.WriteElementValue(writer, Constant.Zerene.Element.DepthMapControlSaveUsedPixelImages, this.DepthMapControlSaveUsedPixelImages);
            this.WriteElementValue(writer, Constant.Zerene.Element.DepthMapControlSmoothingRadius, this.DepthMapControlSmoothingRadius);
            this.WriteElementValue(writer, Constant.Zerene.Element.DepthMapControlThresholdMaskColorRgba, this.DepthMapControlThresholdMaskColorRgba);
            this.WriteElementValue(writer, Constant.Zerene.Element.DepthMapControlUseFixedContrastThresholdLevel, this.DepthMapControlUseFixedContrastThresholdLevel);
            this.WriteElementValue(writer, Constant.Zerene.Element.DepthMapControlUseFixedContrastThresholdPercentile, this.DepthMapControlUseFixedContrastThresholdPercentile);
            this.WriteElementValue(writer, Constant.Zerene.Element.DepthMapControlUsedPixelFractionThreshold, this.DepthMapControlUsedPixelFractionThreshold);
            this.WriteElementValue(writer, Constant.Zerene.Element.FileIOIgnoreExifOrientation, this.FileIOIgnoreExifOrientation);
            this.WriteElementValue(writer, Constant.Zerene.Element.FileIOUseExternalTiffReader, this.FileIOUseExternalTiffReader);
            this.WriteElementValue(writer, Constant.Zerene.Element.InterpolatorRenderingSelection, this.InterpolatorRenderingSelection);
            this.WriteElementValue(writer, Constant.Zerene.Element.InterpolatorShowAdvanced, this.InterpolatorShowAdvanced);
            this.WriteElementValue(writer, Constant.Zerene.Element.OriginalSourceFilesFolderPath, this.OriginalSourceFilesFolderPath);
            this.WriteElementValue(writer, Constant.Zerene.Element.OutputImageNamingTemplate, this.OutputImageNamingTemplate);
            this.WriteElementValue(writer, Constant.Zerene.Element.PrecropLimitsString, this.PrecropLimitsString);
            this.WriteElementValue(writer, Constant.Zerene.Element.PrecropSelected, this.PrecropSelected);
            this.WriteElementValue(writer, Constant.Zerene.Element.PrerotationDegrees, this.PrerotationDegrees);
            this.WriteElementValue(writer, Constant.Zerene.Element.PrerotationExifTagIgnore, this.PrerotationExifTagIgnore);
            this.WriteElementValue(writer, Constant.Zerene.Element.PrerotationSelected, this.PrerotationSelected);
            this.WriteElementValue(writer, Constant.Zerene.Element.PresizeUserSettingScale, this.PresizeUserSettingScale);
            this.WriteElementValue(writer, Constant.Zerene.Element.PresizeUserSettingSelected, this.PresizeUserSettingSelected);
            this.WriteElementValue(writer, Constant.Zerene.Element.PresizeWorkingScale, this.PresizeWorkingScale);
            this.WriteElementValue(writer, Constant.Zerene.Element.PyramidControlGritSuppressionMethod, this.PyramidControlGritSuppressionMethod);
            this.WriteElementValue(writer, Constant.Zerene.Element.PyramidControlRetainOnlyUdrImage, this.PyramidControlRetainOnlyUdrImage);
            this.WriteElementValue(writer, Constant.Zerene.Element.PyramidControlRetainUdrImage, this.PyramidControlRetainUdrImage);
            this.WriteElementValue(writer, Constant.Zerene.Element.PyramidControlUseAllChannels, this.PyramidControlUseAllChannels);
            this.WriteElementValue(writer, Constant.Zerene.Element.RetouchingBrushHardness, this.RetouchingBrushHardness);
            this.WriteElementValue(writer, Constant.Zerene.Element.RetouchingBrushShowBrushes, this.RetouchingBrushShowBrushes);
            this.WriteElementValue(writer, Constant.Zerene.Element.RetouchingBrushType, this.RetouchingBrushType);
            this.WriteElementValue(writer, Constant.Zerene.Element.RetouchingBrushWidth, this.RetouchingBrushWidth);
            this.WriteElementValue(writer, Constant.Zerene.Element.SaveImageBitsPerColor, this.SaveImageBitsPerColor);
            this.WriteElementValue(writer, Constant.Zerene.Element.SaveImageCompressionQuality, this.SaveImageCompressionQuality);
            this.WriteElementValue(writer, Constant.Zerene.Element.SaveImageCompressionType, this.SaveImageCompressionType);
            this.WriteElementValue(writer, Constant.Zerene.Element.SaveImageFileType, this.SaveImageFileType);
            this.WriteElementValue(writer, Constant.Zerene.Element.SaveImageFolderPathLastUsed, this.SaveImageFolderPathLastUsed);
            this.WriteElementValue(writer, Constant.Zerene.Element.SaveImagePropagateExif, this.SaveImagePropagateExif);
            this.WriteElementValue(writer, Constant.Zerene.Element.SaveImageRescaleImageToAvoidOverflow, this.SaveImageRescaleImageToAvoidOverflow);
            this.WriteElementValue(writer, Constant.Zerene.Element.SkewSequenceNumberOfOutputImages, this.SkewSequenceNumberOfOutputImages);
            this.WriteElementValue(writer, Constant.Zerene.Element.SkewSequenceSelected, this.SkewSequenceSelected);
            this.WriteElementValue(writer, Constant.Zerene.Element.SkewSequenceShiftXPctLimit1, this.SkewSequenceShiftXPctLimit1);
            this.WriteElementValue(writer, Constant.Zerene.Element.SkewSequenceShiftXPctLimit2, this.SkewSequenceShiftXPctLimit2);
            this.WriteElementValue(writer, Constant.Zerene.Element.SkewSequenceShiftYPctLimit1, this.SkewSequenceShiftYPctLimit1);
            this.WriteElementValue(writer, Constant.Zerene.Element.SkewSequenceShiftYPctLimit2, this.SkewSequenceShiftYPctLimit2);
            this.WriteElementValue(writer, Constant.Zerene.Element.SkewSequenceUseConicalPath, this.SkewSequenceUseConicalPath);
            this.WriteElementValue(writer, Constant.Zerene.Element.StackingControlFrameSkipFactor, this.StackingControlFrameSkipFactor);
            this.WriteElementValue(writer, Constant.Zerene.Element.StackingControlFrameSkipSelected, this.StackingControlFrameSkipSelected);
            this.WriteElementValue(writer, Constant.Zerene.Element.StereoOrderingLeftRightIndexSeparation, this.StereoOrderingLeftRightIndexSeparation);
            this.WriteElementValue(writer, Constant.Zerene.Element.WatchDirectoryOptionsAcceptViaDelay, this.WatchDirectoryOptionsAcceptViaDelay);
            this.WriteElementValue(writer, Constant.Zerene.Element.WatchDirectoryOptionsAcceptViaDelaySeconds, this.WatchDirectoryOptionsAcceptViaDelaySeconds);
            writer.WriteEndElement(); // preferences
        }
    }
}
