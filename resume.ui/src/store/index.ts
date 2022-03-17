import Vue from 'vue'
import Vuex from 'vuex'
import { RootState } from '@/store/types'
import resume from './modules/resume'
import technicalExperience from './modules/technical-experience'
import technicalSkills from './modules/technical-skills'

Vue.use(Vuex)

export default new Vuex.Store<RootState>({
  modules: {
    resume,
    technicalExperience,
    technicalSkills
  },
})