import Vue from 'vue'
import Vuetify from 'vuetify/lib/framework'

Vue.use(Vuetify)

export default new Vuetify({
  theme: {
    options: {
      customProperties: true,
    },
    themes: {
      light: {
        background: '#E1E1E1',
        primary: '#048FA3',
        secondary: '#81989C',
        accent: '#8c9eff',
        error: '#b71c1c',
        warning: '#F3B650',
      },
      dark: {
        background: '#414242',
        primary: '#878E8F',
        secondary: '#3f51b5',
        accent: '#C6D8DB',
        error: '#ff5722',
        warning: '#85C3F7',
        info: '#673ab7',
        success: '#009688',
      },
    },
  },
})
