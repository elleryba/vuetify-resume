import { GetterTree } from 'vuex'
import { RootState } from '@/store/types'
import { ResumeStoreInterface } from './types'

export class ResumeGetters {
  public static All = 'resume/getResume'
}

export const getters: GetterTree<ResumeStoreInterface, RootState> = {
    getResume: (state: ResumeStoreInterface) => {
    return state.resume
  }
}

export default getters