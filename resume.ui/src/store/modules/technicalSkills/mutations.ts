import { MutationTree } from 'vuex'
import { TechnicalSkillInterface, TechnicalSkillStoreInterface } from './types'

export class TechnicalSkillMutations {
  public static SET_SKILLS = 'SET_SKILLS'
}

export const mutations: MutationTree<TechnicalSkillStoreInterface> = {
  SET_SKILLS(state: TechnicalSkillStoreInterface, payload: { skills: Array<TechnicalSkillInterface> }) {
    state.skills = payload.skills
  }
}

export default mutations