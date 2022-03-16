import Vue from 'vue'
import Vuex from 'vuex'
import { RootState } from '@/store/types'
import technicalSkills from '@/store/modules/technical-skills'

Vue.use(Vuex)

export default new Vuex.Store<RootState>({
  modules: {
    technicalSkills
  },
})