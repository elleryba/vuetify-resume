<template>
  <v-app :style="{background: $vuetify.theme.themes[theme].background}">
    <v-app-bar
      app
      color="primary"
      dark
      elevation="5"
    >
      <div class="d-flex align-center">
        <v-icon size="28" color="background">mdi-newspaper-variant-outline</v-icon>
        <span class="name" :style="{color: $vuetify.theme.themes[theme].background}">ELLE RYBA</span>
      </div>

      <!-- The v-spacer separates the div above from the toolbar items below. -->
      <v-spacer></v-spacer>

      <v-toolbar-items>
        <PhoneInfo />
      </v-toolbar-items>

      <v-toolbar-items>
        <EmailInfo />
      </v-toolbar-items>

      <v-toolbar-items>
        <LinkedInInfo />
      </v-toolbar-items>

      <v-toolbar-items>
        <GitHubInfo />
      </v-toolbar-items>

      <v-toolbar-items>
        <ThemeChanger />
      </v-toolbar-items>
    </v-app-bar>

    <v-main>
      <v-container class="d-flex justify-center">
        <AboutMe />
      </v-container>
    </v-main>

  </v-app>
</template>

<script lang="ts">
import AboutMe from './components/AboutMe.vue'
import EmailInfo from './components/EmailInfo.vue'
import GitHubInfo from './components/GitHubInfo.vue'
import LinkedInInfo from './components/LinkedInInfo.vue'
import PhoneInfo from './components/PhoneInfo.vue';
import ThemeChanger from './components/ThemeChanger.vue'
import { defineComponent } from '@vue/composition-api'

export default defineComponent({
  name: 'App',
  components: {
    AboutMe,
    EmailInfo,
    GitHubInfo,
    LinkedInInfo,
    ThemeChanger,
    PhoneInfo
  },
  setup(){
    function theme(){
      return (this.$vuetify.theme.dark) ? 'dark' : 'light'
    }
    return theme
  }
});
</script>

<style scoped>
.name{
  font-size: 150%;
  font-weight: 400;
}
</style>