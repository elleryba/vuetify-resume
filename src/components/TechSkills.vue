<template>
  <div>
    <v-card-actions>
      <v-btn
        text
        color="warning"
        @click="showTechStack = true"
      >
        Tech Skills
      </v-btn>
    </v-card-actions>

    <v-expand-transition>
      <v-card
        v-if="showTechStack"
        class="transition-fast-in-fast-out v-card--reveal scroll"
        style="height: 100%;"
      >
        <v-card-text class="pb-0">
          <p v-for="t in techSkills" :key="t">{{t}}</p>
        </v-card-text>
        <v-card-actions class="pt-0">
          <v-btn
            text
            color="warning"
            @click="showTechStack = false"
          >
            Close
          </v-btn>
        </v-card-actions>
      </v-card>
    </v-expand-transition>
  </div>
</template>

<script>
export default {
  name: 'TechSkills',
  data: () => ({
    showTechStack: false,
    // this will eventually be moved to a db and pulled via api call
    techSkills: [
      'CSS',
      'HTML',
      'JavaScript',
      'TypeScript',
      'Vue.js (Vue 2 | vuetify | composition api)',
      'C#',
      '.NET',
      'SQL',
      'NoSQL',
      'Sql Server Management Studio',
      'MongoDB',
      'Azure DevOps',
      'Visual Studio | Visual Studio Code',
      'Postman'
    ]
  }),
  methods:{}
}
</script>

<style scoped>
.v-card--reveal {
  bottom: 0;
  position: absolute;
  width: 100%;
}
.scroll {
  overflow-y: scroll
}
</style>