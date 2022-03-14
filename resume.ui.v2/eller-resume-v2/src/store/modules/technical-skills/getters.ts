import { GetterTree } from 'vuex'
import { RootState } from '@/store/types'
import { TechnicalSkillStoreInterface } from './types'

export class TechnicalSkillGetters {
  public static All = 'technicalSkills/getAllSkills'
}

export const getters: GetterTree<TechnicalSkillStoreInterface, RootState> = {
    getAllSkills: (state: TechnicalSkillStoreInterface) => {
    return state.skills
  }
}

export default getters