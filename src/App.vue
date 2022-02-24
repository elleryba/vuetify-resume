<template>
  <v-app>
    <v-app-bar
      app
      color="primary"
      dark
    >
      <div class="d-flex align-center">
        <v-icon size="28" color="warning">mdi-newspaper-variant-outline</v-icon>
        <span style="font-size:150%">ELLE RYBA</span>
      </div>

      <!-- The v-spacer separates the div above from the tookbar items below. -->
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
        <ThemeChanger />
      </v-toolbar-items>
    </v-app-bar>

    <v-main>
      <AboutMe />
    </v-main>

  </v-app>
</template>

<script>
import AboutMe from './components/AboutMe'
import EmailInfo from './components/EmailInfo.vue'
import LinkedInInfo from './components/LinkedInInfo.vue'
import PhoneInfo from './components/PhoneInfo.vue';
import ThemeChanger from './components/ThemeChanger'

export default {
  name: 'App',

  components: {
    AboutMe,
    EmailInfo,
    LinkedInInfo,
    ThemeChanger,
    PhoneInfo
  },

  data: () => ({
    //
  }),
  methods: {
  }
};
</script>
