import { Module } from 'vuex'
import { RootState } from '@/store/types'
import actions from '@/store/modules/workHistories/actions'
import getters from '@/store/modules/workHistories/getters'
import mutations from '@/store/modules/workHistories/mutations'
import state from '@/store/modules/workHistories/state'
import { WorkHistoryStoreInterface } from '@/store/modules/workHistories/types'

export const workHistory: Module<WorkHistoryStoreInterface, RootState> = {
  namespaced: true,
  state,
  actions,
  mutations,
  getters
}

export default workHistory