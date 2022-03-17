import { JobItemInterface, ResumeStoreInterface } from './types'

export const state: ResumeStoreInterface = {
  resume: [] as Array<JobItemInterface>
}

export default state