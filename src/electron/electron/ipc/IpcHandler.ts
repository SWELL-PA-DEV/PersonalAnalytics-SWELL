import { ExperienceSamplingService } from '../main/services/ExperienceSamplingService';
import { app, ipcMain, IpcMainInvokeEvent, shell, systemPreferences } from 'electron';
import { WindowService } from '../main/services/WindowService';
import { getLogger } from '../shared/Logger';
import { TypedIpcMain } from '../../src/utils/TypedIpcMain';
import Commands from '../../src/utils/Commands';
import Events from '../../src/utils/Events';
import StudyInfoDto from '../../shared/dto/StudyInfoDto';
import { Settings } from '../main/entities/Settings';
import studyConfig from '../../shared/study.config';
import { TrackerService } from '../main/services/trackers/TrackerService';
import { WindowActivityTrackerService } from '../main/services/trackers/WindowActivityTrackerService';
import { WindowActivityEntity } from '../main/entities/WindowActivityEntity';
import { UserInputEntity } from '../main/entities/UserInputEntity';
import { UserInputTrackerService } from '../main/services/trackers/UserInputTrackerService';
import { DataExportType } from '../../shared/DataExportType.enum';
import { DataExportService } from '../main/services/DataExportService';

const LOG = getLogger('IpcHandler');

export class IpcHandler {
  private readonly actions: any;
  private readonly windowService: WindowService;
  private readonly trackerService: TrackerService;

  private readonly experienceSamplingService: ExperienceSamplingService;
  private readonly windowActivityService: WindowActivityTrackerService;
  private readonly userInputService: UserInputTrackerService;
  private readonly dataExportService: DataExportService;
  private typedIpcMain: TypedIpcMain<Events, Commands> = ipcMain as TypedIpcMain<Events, Commands>;

  constructor(
    windowService: WindowService,
    trackerService: TrackerService,
    experienceSamplingService: ExperienceSamplingService
  ) {
    this.windowService = windowService;
    this.trackerService = trackerService;
    this.experienceSamplingService = experienceSamplingService;
    this.windowActivityService = new WindowActivityTrackerService();
    this.userInputService = new UserInputTrackerService();
    this.dataExportService = new DataExportService();
    this.actions = {
      createExperienceSample: this.createExperienceSample,
      closeExperienceSamplingWindow: this.closeExperienceSamplingWindow,
      closeOnboardingWindow: this.closeOnboardingWindow,
      getStudyInfo: this.getStudyInfo,
      getMostRecentWindowActivities: this.getMostRecentWindowActivities,
      getMostRecentUserInputs: this.getMostRecentUserInputs,
      obfuscateWindowActivitiesById: this.obfuscateWindowActivitiesById,
      startDataExport: this.startDataExport,
      openExportFolder: this.openExportFolder,
      startAllTrackers: this.startAllTrackers,
      triggerPermissionCheckAccessibility: this.triggerPermissionCheckAccessibility,
      triggerPermissionCheckScreenRecording: this.triggerPermissionCheckScreenRecording
    };
    LOG.debug('IpcHandler constructor called');
  }

  public init(): void {
    Object.keys(this.actions).forEach((action: string): void => {
      LOG.info(`ipcMain.handle setup: ${action}`);
      ipcMain.handle(action, async (_event: IpcMainInvokeEvent, ...args): Promise<any> => {
        try {
          return await this.actions[action].apply(this, args);
        } catch (error) {
          LOG.error(error);
          return error;
        }
      });
    });
  }

  private async createExperienceSample(
    promptedAt: Date,
    question: string,
    responseOptions: string,
    scale: number,
    response: number,
    skipped: boolean = false
  ) {
    await this.experienceSamplingService.createExperienceSample(
      promptedAt,
      question,
      responseOptions,
      scale,
      response,
      skipped
    );
  }

  private closeExperienceSamplingWindow(): void {
    this.windowService.closeExperienceSamplingWindow();
  }

  private closeOnboardingWindow(): void {
    this.windowService.closeOnboardingWindow();
  }

  private async getStudyInfo(): Promise<StudyInfoDto> {
    const settings: Settings = await Settings.findOne({ where: { onlyOneEntityShouldExist: 1 } });
    return {
      studyName: settings.studyName,
      subjectId: settings.subjectId,
      shortDescription: studyConfig.shortDescription,
      infoUrl: studyConfig.infoUrl,
      privacyPolicyUrl: studyConfig.privacyPolicyUrl,
      contactName: studyConfig.contactName,
      contactEmail: studyConfig.contactEmail,
      appVersion: app.getVersion(),
      currentlyActiveTrackers: this.trackerService.getRunningTrackerNames()
    };
  }

  private async getMostRecentWindowActivities(itemCount: number): Promise<WindowActivityEntity[]> {
    return await this.windowActivityService.getMostRecentWindowActivities(itemCount);
  }

  private async obfuscateWindowActivitiesById(ids: string[]): Promise<WindowActivityEntity[]> {
    return await this.windowActivityService.obfuscateWindowActivitiesById(ids);
  }

  private async getMostRecentUserInputs(itemCount: number): Promise<UserInputEntity[]> {
    return await this.userInputService.getMostRecentUserInputs(itemCount);
  }

  private async startDataExport(
    windowActivityExportType: DataExportType,
    userInputExportType: DataExportType
  ): Promise<void> {
    await this.dataExportService.startDataExport(windowActivityExportType, userInputExportType);
  }

  private async openExportFolder(): Promise<void> {
    await shell.openPath(`${app.getPath('desktop')}`);
  }

  private triggerPermissionCheckAccessibility(prompt: boolean): boolean {
    return systemPreferences.isTrustedAccessibilityClient(prompt);
  }

  private triggerPermissionCheckScreenRecording(): boolean {
    const status = systemPreferences.getMediaAccessStatus('screen');
    return status === 'granted';
  }

  private async startAllTrackers(): Promise<void> {
    try {
      await this.trackerService.startAllTrackers();
    } catch (e) {
      LOG.error('Error starting trackers', e);
    }
  }
}
