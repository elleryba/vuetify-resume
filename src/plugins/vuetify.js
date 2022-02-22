import Vue from 'vue';
import Vuetify from 'vuetify/lib';

Vue.use(Vuetify);

export default new Vuetify({
    theme: {
    themes: {
      light: {
        primary: '#3f51b5',
        secondary: '#b0bec5',
        accent: '#8c9eff',
        error: '#b71c1c',
      },
      dark: {
        primary: '#607d8b',
        secondary: '#673ab7',
        accent: '#ff5722',
        error: '#ff9800',
        warning: '#ffc107',
        info: '#2196f3',
        success: '#03a9f4'
      }
    },
  },
});
