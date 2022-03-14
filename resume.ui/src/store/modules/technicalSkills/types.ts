/** The technical skill interface. */
export interface TechnicalSkillInterface {
    skill: string;
  }
  
  /** The technical skill interface. */
  export interface TechnicalSkillStoreInterface {
    skills: Array<TechnicalSkillInterface>;
  }
  
  export interface TechnicalSkillApiResponseInterface {
    skills: Array<string>;
  }