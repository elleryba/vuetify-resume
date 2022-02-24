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

      <v-btn
        text
        color="accent"
        @click="sendEmail()"
      >
        <v-icon>mdi-email-fast</v-icon>
      </v-btn>

      <v-btn
        href="https://www.linkedin.com/in/elle-ryba/"
        target="_blank"
        text
        color="accent"
      >
        <v-icon>mdi-linkedin</v-icon>
      </v-btn>

      <v-toolbar-items>
        <ThemeChanger />
      </v-toolbar-items>
    </v-app-bar>

    <v-main>
      <AboutMe/>
    </v-main>

  </v-app>
</template>

<script>
import AboutMe from './components/AboutMe'
import PhoneInfo from './components/PhoneInfo.vue';
import ThemeChanger from './components/ThemeChanger'

export default {
  name: 'App',

  components: {
    AboutMe,
    ThemeChanger,
    PhoneInfo
  },

  data: () => ({
    //
  }),
  methods: {
    sendEmail(){
      window.location = "mailto:elleryba@icloud.com";
    }
  }
};
</script>
