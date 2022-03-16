import { ActionTree } from 'vuex'
import axios from 'axios'
import { RootState } from '../../types'
import { TechnicalSkillApiResponseInterface, TechnicalSkillInterface, TechnicalSkillStoreInterface } from './types'
import { TechnicalSkillMutations } from './mutations'
import { isEmpty } from 'lodash'

export class TechnicalSkillActions {
  /** Loads all technical skills from the api. */
  public static GetTechnicalSkills = 'technicalSkills/getTechnicalSkills'
}

export const actions: ActionTree<TechnicalSkillStoreInterface, RootState> = {
    getTechnicalSkills({ commit }) {
    axios
      .get<TechnicalSkillApiResponseInterface>('http://localhost:41368/api/technical_skills')
      .then<TechnicalSkillInterface>((response) => {
        if (isEmpty(response?.data)) throw new Error('response is empty')
        
        const skills = response.data as TechnicalSkillInterface

        commit(TechnicalSkillMutations.SET_SKILLS, { skills: skills })
        return skills
      })
      .catch(e => console.error('technicalSkills/getTechnicalSkills :: failed', e))
  }
}

export default actions