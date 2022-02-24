<template>
      <v-card
        :loading="loading"
        class="my-4 mx-auto"
        max-width="400"
      >
        <v-img
          max-height="250"
          :src="profilePic"
        ></v-img>

        <v-card-title>Elle Ryba</v-card-title>

        <v-card-text>
          <v-row
            align="center"
            class="mx-0 my-0"
          >
            <div class="text-subtitle-1">
              Front-end only resume
            </div>
          </v-row>
          <v-row class="my-2 mx-0">
            <div align="left" class="text-subtitle-3">
              At this time, this entire project is comprised of only a front-end code base.
            </div>
          </v-row>
        </v-card-text>

        <v-divider class="mx-4"></v-divider>

        <TechSkills />

      </v-card>
</template>

<script>
import TechSkills from './TechSkills.vue'

export default {
  name: 'AboutMe',
  components: {
    TechSkills
  },
  data: () => ({
    loading: false,
    // would like to store and retrieve via api
    profilePic: require('../assets/profile_pic.png'),
    resetChip: false,
    selection: undefined,
    showTechStack: false,
    // this will eventually be moved to a db and pulled via api call
    techSkills: [
      'CSS',
      'HTML',
      'C#',
      '.NET',
      'JavaScript',
      'SQL',
      'NoSQL',
      'Vue.js',
      'Sql Server Management Studio',
      'MongoDB',
      'Azure DevOps'
    ]
  }),
  methods:{}
}
</script>

<style scoped>
.v-card--reveal {
  bottom: 0;
  opacity: 1 !important;
  position: absolute;
  width: 100%;
}
</style>
