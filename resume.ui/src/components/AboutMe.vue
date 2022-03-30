<template>
  <v-row class="pa-2">
    <SkeletonLoader v-if="isLoading"/>
    <v-card
      v-else
      class="my-auto mx-auto"
      max-width="500"
      elevation="5"
    >
      <v-img
        v-if="this.$vuetify.breakpoint.mdAndUp"
        class="primary"
        contain
        max-height="350"
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
            I have created this front-end only version of my resume app to deploy via Github Pages.
            This app was built using Vue 2 and Vuetify. A full-stack version with data being served up to the client from Sql Server via RESTful
            api can be found <a target="blank" href="https://github.com/elleryba/vuetify-resume">here</a>.
          </div>
        </v-row>
      </v-card-text>

      <v-divider class="mx-4"></v-divider>
      <Resume />
    </v-card>
  </v-row>
</template>

<script lang="ts">
import { isEmpty } from 'lodash'
import { computed, defineComponent, ref } from '@vue/composition-api'

import Resume from '@/components/Resume.vue'
import SkeletonLoader from '@/components/SkeletonLoader.vue'
import store from '@/store'
import { ResumeGetters } from '@/store/modules/resume/getters'
import { JobItemInterface } from '@/store/modules/resume/types'
import { TechnicalExperienceGetters } from '@/store/modules/technical-experience/getters'
import { TechnicalExperienceInterface } from '@/store/modules/technical-experience/types'
import { TechnicalSkillGetters } from '@/store/modules/technical-skills/getters'
import { TechnicalSkillInterface } from '@/store/modules/technical-skills/types'

export default defineComponent({
  name: 'AboutMe',
  components: {
    Resume,
    SkeletonLoader
  },
  setup() {
    const alignments = [ 'start', 'center', 'end' ]
    const isLoading = ref<boolean>(true)
    const resumeData = computed<Array<JobItemInterface>>(() => store.getters[ResumeGetters.All])
    const experienceData = computed<Array<TechnicalExperienceInterface>>(() => store.getters[TechnicalExperienceGetters.All])
    const skills = computed<Array<TechnicalSkillInterface>>(() => store.getters[TechnicalSkillGetters.All])

    async function loadingCheck() {
      while(isEmpty(resumeData) || isEmpty(experienceData) || isEmpty(skills))
        isLoading.value = true
      
      // let the people see the pretty lil skeleton loader
      setTimeout(() =>
        isLoading.value = false, 2000)
    }

    loadingCheck()

    return {
      alignments,
      isLoading
    }
  },
  data: () => ({
    profilePic: require('@/assets/pfp.png')
  })
})
</script>