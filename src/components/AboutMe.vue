<template>
      <v-card
        :loading="loading"
        class="my-4 mx-auto"
        max-width="400"
      >
        <v-img
          max-height="250"
          src="../assets/profile_pic.png"
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
            class="transition-fast-in-fast-out v-card--reveal"
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
      </v-card>
</template>

<script>
export default {
  name: 'AboutMe',
  data: () => ({
    loading: false,
    resetChip: false,
    selection: undefined,
    showTechStack: false,
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
