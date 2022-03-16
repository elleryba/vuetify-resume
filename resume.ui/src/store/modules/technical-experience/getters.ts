import { GetterTree } from 'vuex'
import { RootState } from '@/store/types'
import { TechnicalExperienceStoreInterface } from './types'

export class TechnicalExperienceGetters {
  public static All = 'technicalExperience/getTechnicalExperience'
}

export const getters: GetterTree<TechnicalExperienceStoreInterface, RootState> = {
    getTechnicalExperience: (state: TechnicalExperienceStoreInterface) => {
    return state.items
  }
}

export default getters