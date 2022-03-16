import { Module } from 'vuex'
import { RootState } from '../../types'
import actions from './actions'
import getters from './getters'
import mutations from './mutations'
import state from './state'
import { TechnicalExperienceStoreInterface } from './types'

export const technicalExperience: Module<TechnicalExperienceStoreInterface, RootState> = {
  namespaced: true,
  state,
  actions,
  mutations,
  getters
}

export default technicalExperience