import { Module } from 'vuex'
import { RootState } from '../../types'
import actions from './actions'
import getters from './getters'
import mutations from './mutations'
import state from './state'
import { ResumeStoreInterface } from './types'

export const resume: Module<ResumeStoreInterface, RootState> = {
  namespaced: true,
  state,
  actions,
  mutations,
  getters
}

export default resume