import Vue from 'vue';
import Vuetify from 'vuetify/lib';

Vue.use(Vuetify);

export default new Vuetify({
  theme: {
    options: {
      customProperties: true
    },
    themes: {
      light: {
        primary: '#3f51b5',
        secondary: '#b0bec5',
        accent: '#8c9eff',
        error: '#b71c1c',
        warning: '#F3B650'
      },
      dark: {
        primary: '#878E8F',
        secondary: '#3f51b5',
        accent: '#C6D8DB',
        error: '#ff5722',
        warning: '#85C3F7',
        info: '#673ab7',
        success: '#009688'
      }
    },
  },
});
