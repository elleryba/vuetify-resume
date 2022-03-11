import Vue from 'vue'
import Vuex from 'vuex'
import { RootState } from '@/store/types'
import workHistory from '@/store/modules/workHistories'

Vue.use(Vuex)

export default new Vuex.Store<RootState>({
  modules: {
    workHistory
  },
})