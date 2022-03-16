import { MutationTree } from 'vuex'
import { TechnicalSkillStoreInterface } from './types'

export class TechnicalSkillMutations {
  public static SET_SKILLS = 'SET_SKILLS'
}

export const mutations: MutationTree<TechnicalSkillStoreInterface> = {
  SET_SKILLS(state: TechnicalSkillStoreInterface, payload: { skills: Array<string> }) {
    state.skills = payload.skills
  }
}

export default mutations