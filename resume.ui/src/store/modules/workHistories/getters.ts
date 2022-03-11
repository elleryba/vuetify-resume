import { GetterTree } from 'vuex'
import { RootState } from '@/store/types'
import { WorkHistoryStoreInterface } from './types'

export class WorkHistoryGetters {
  public static All = 'work-history/getAllWorkHistory'
}

export const getters: GetterTree<WorkHistoryStoreInterface, RootState> = {
  getAllWorkHistory: (state: WorkHistoryStoreInterface) => {
    return state.items
  }
}

export default getters