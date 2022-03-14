import Vue from 'vue'
import Vuex from 'vuex'
import { RootState } from '../../src/store/types'
import technicalSkills from './modules/technicalSkills'

Vue.use(Vuex)

export default new Vuex.Store<RootState>({
  modules: {
    technicalSkills
  },
})