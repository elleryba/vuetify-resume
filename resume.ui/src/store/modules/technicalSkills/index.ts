import { Module } from 'vuex'
import { RootState } from '../../types'
import actions from './actions'
import getters from './getters'
import mutations from './mutations'
import state from './state'
import { TechnicalSkillStoreInterface } from './types'

export const technicalSkills: Module<TechnicalSkillStoreInterface, RootState> = {
  namespaced: true,
  state,
  actions,
  mutations,
  getters
}

export default technicalSkills