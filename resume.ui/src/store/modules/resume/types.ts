/** The job item interface. */
export interface JobItemInterface {
    companyName: string;
    id: number;
    endDate: Date | undefined;
    jobDuties: Array<string>;
    startDate: Date;
    title: string;
    wasRemotePosition: boolean;
  }

export interface ResumeInterface {
  resume: Array<JobItemInterface>
}
  
  /** The resume store interface. */
  export interface ResumeStoreInterface {
    resume: ResumeInterface;
  }
  
  /** The resume api response interface. */
  export interface ResumeApiResponseInterface {
    resume: ResumeInterface
  }