import { MutationTree } from 'vuex'
import { ResumeInterface, ResumeStoreInterface } from './types'

export class ResumeMutations {
  public static SET_RESUME = 'SET_RESUME'
}

export const mutations: MutationTree<ResumeStoreInterface> = {
  SET_RESUME(state: ResumeStoreInterface, payload: { resume: ResumeInterface }) {
    state.resume = payload.resume
  }
}

export default mutations