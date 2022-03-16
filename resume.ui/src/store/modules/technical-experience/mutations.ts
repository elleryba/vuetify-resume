import { MutationTree } from 'vuex'
import { TechnicalExperienceStoreInterface } from './types'

export class TechnicalExperienceMutations {
  public static SET_SKILLS = 'SET_EXPERIENCE'
}

export const mutations: MutationTree<TechnicalExperienceStoreInterface> = {
  SET_EXPERIENCE(state: TechnicalExperienceStoreInterface, payload: { items: Array<string> }) {
    state.items = payload.items
  }
}

export default mutations