import { ActionTree } from 'vuex'
import axios from 'axios'
import { RootState } from '@/store/types'
import { WorkHistoryApiResponseInterface, WorkHistoryInterface, WorkHistoryStoreInterface } from '@/store/modules/workHistories/types'
import { WorkHistoryMutations } from '@/store/modules/workHistories/mutations'
import { isEmpty } from 'lodash'

export class WorkHistoryActions {
  /** Gets work history from the api. */
  public static GetWorkHistory = 'work-history/getWorkHistory'
}

export const actions: ActionTree<WorkHistoryStoreInterface, RootState> = {
    getWorkHistory({ commit }) {
    axios
      .get<Array<WorkHistoryApiResponseInterface>>('http://localhost:41368/api/work_history')
      .then<Array<WorkHistoryInterface>>((response) => {
        if (isEmpty(response?.data)) throw new Error('response is empty')
        const histories = response.data
          .map(h => {
            return {
              companyName: h.companyName,
              duties: h.duties,
              endDate: h.endDate,
              jobId: h.jobId,
              startDate: h.startDate,
              title: h.title,
              workedRemote: h.workedRemote
            } as WorkHistoryInterface
          })

        commit(WorkHistoryMutations.SET_WORK_HISTORY, { histories: histories })
        return histories
      })
      .catch(e => console.error('work-history/getWorkHistory :: failed', e))
  }
}

export default actions