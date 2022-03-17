import { MutationTree } from 'vuex'
import { ResumeInterface, ResumeStoreInterface } from './types'

export class ResumeMutations {
  public static SET_RESUME = 'SET_RESUME'
}

export const mutations: MutationTree<ResumeStoreInterface> = {
  SET_RESUME(state: ResumeStoreInterface, payload: { resume: ResumeInterface }) {
    console.info('****payload: ', payload)
    state.resume = payload.resume.items
  }
}

export default mutations