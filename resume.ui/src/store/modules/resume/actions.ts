import { ActionTree } from 'vuex'
import axios from 'axios'
import { RootState } from '../../types'
import { ResumeApiResponseInterface, ResumeStoreInterface, ResumeInterface } from './types'
import { ResumeMutations } from './mutations'
import { isEmpty } from 'lodash'

export class ResumeActions {
  /** Loads the resume from the api. */
  public static GetResume = 'resume/getResume'
}

export const actions: ActionTree<ResumeStoreInterface, RootState> = {
    getResume({ commit }) {
    axios
      .get<ResumeApiResponseInterface>('http://localhost:41368/api/resume')
      .then<ResumeInterface>((response) => {
        if (isEmpty(response?.data)) throw new Error('response is empty')

        const resume = response.data.resume as ResumeInterface
        console.info('*****resume: ', resume)
        commit(ResumeMutations.SET_RESUME, { resume: resume })

        return resume
      })
      .catch(e => console.error('resume/getResume :: failed', e))
  }
}

export default actions