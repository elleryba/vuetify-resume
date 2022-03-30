<template>
  <v-row class="pa-2">
      <SkeletonLoader v-if="isLoading"/>
      <v-card
        v-else
        class="my-auto mx-auto"
        max-width="500"
        elevation="5"
      >
        <v-card-title>Technical Experience</v-card-title>
        <v-card-text>
          <v-row align="center" class="mx-0">
            <div class="text-subtitle-1">On the Job...</div>
          </v-row>
          <v-row class="my-4 mx-0">
            <div align="left" class="text-subtitle-3">
              <p v-for="d in experienceData" :key="d">{{d}}</p>
            </div>
          </v-row>
        </v-card-text>
        <v-divider class="mx-4"></v-divider>
        <TechnicalSkills />
      </v-card>
  </v-row>
</template>

<script lang="ts">
import { isEmpty } from 'lodash'
import { computed, defineComponent, ref } from '@vue/composition-api'

import SkeletonLoader from '@/components/SkeletonLoader.vue'
import TechnicalSkills from '@/components/TechnicalSkills.vue'
import store from '@/store'
import { ResumeGetters } from '@/store/modules/resume/getters'
import { JobItemInterface } from '@/store/modules/resume/types'
import { TechnicalExperienceActions } from '@/store/modules/technical-experience/actions'
import { TechnicalExperienceGetters } from '@/store/modules/technical-experience/getters'
import { TechnicalExperienceInterface } from '@/store/modules/technical-experience/types'
import { TechnicalSkillGetters } from '@/store/modules/technical-skills/getters'
import { TechnicalSkillInterface } from '@/store/modules/technical-skills/types'

export default defineComponent({
  name: 'TechnicalExperience',
  components: {
    SkeletonLoader,
    TechnicalSkills
  },
  setup() {
    const isLoading = ref<boolean>(true)

    const experienceData = computed<Array<TechnicalExperienceInterface>>(() => store.getters[TechnicalExperienceGetters.All])
    const resumeData = computed<Array<JobItemInterface>>(() => store.getters[ResumeGetters.All])
    const skills = computed<Array<TechnicalSkillInterface>>(() => store.getters[TechnicalSkillGetters.All])

    store.dispatch(TechnicalExperienceActions.SetTechnicalExperience)

    async function loadingCheck() {
      while(isEmpty(resumeData) || isEmpty(experienceData) || isEmpty(skills))
        isLoading.value = true
      
      // let the people see the pretty lil skeleton loader
      setTimeout(() =>
        isLoading.value = false, 2000)
    }

    loadingCheck()

    return{
      experienceData,
      isLoading
    }
  }
})
</script>
