/** The work history object interface. */
export interface WorkHistoryInterface {
    companyName: string;
    duties: Array<string>;
    endDate: Date | undefined;
    jobId: number;
    startDate: Date;
    title: string;
    workedRemote: boolean;
  }
  
  /** The work history interface. */
  export interface WorkHistoryStoreInterface {
    items: Array<WorkHistoryInterface>
  }
  
  export interface WorkHistoryApiResponseInterface {
    companyName: string;
    duties: Array<string>;
    endDate: Date | undefined;
    jobId: number;
    startDate: Date;
    title: string;
    workedRemote: boolean;
  }