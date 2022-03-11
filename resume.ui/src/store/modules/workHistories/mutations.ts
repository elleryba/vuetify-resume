import { MutationTree } from 'vuex'
import { WorkHistoryInterface, WorkHistoryStoreInterface } from '@/store/modules/workHistories/types'

export class WorkHistoryMutations {
  public static SET_WORK_HISTORY = 'SET_WORK_HISTORY'
}

export const mutations: MutationTree<WorkHistoryStoreInterface> = {
    SET_WORK_HISTORY(state: WorkHistoryStoreInterface, payload: { histories: Array<WorkHistoryInterface> }) {
    state.items = payload.histories
  }
}

export default mutations