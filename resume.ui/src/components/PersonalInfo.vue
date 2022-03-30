<template>
  <v-row class="pa-2">
      <SkeletonLoader v-if="isLoading"/>
      <v-card
        v-else
        class="my-auto mx-auto"
        max-width="500"
        elevation="5"
      >
        <v-card-title>Personal</v-card-title>
        <v-card-text>
          <v-row align="center" class="mx-0">
            <div class="text-subtitle-1">A Day in the Life...</div>
          </v-row>
          <v-row class="my-2 mx-0">
            <div align="left" class="text-subtitle-3 my-2">
              <p>In my personal time I am playing through the
              <a
                href="https://www.ea.com/games/mass-effect/mass-effect-legendary-edition"
                target="_blank"
              >
                Mass Effect</a> trilogy via
              <a
                href="https://www.xbox.com/en-US/games/store/xbox-game-pass-ultimate/cfq7ttc0khs0"
                target="_blank"
              >
                Xbox Game Pass</a>. Happy to report I have finished the first two games, 
                and I am working through the third.</p>
                <p>I am also playing the latest
                <a
                  href="https://www.nintendo.com/store/products/kirby-and-the-forgotten-land-switch/"
                  target="_blank"
                >
                Kirby</a> game on the Nintendo Switch.</p>
            </div>
          </v-row>
        </v-card-text>
      </v-card>
  </v-row>
</template>

<script lang="ts">
import { isEmpty } from 'lodash'
import { computed, defineComponent, ref } from '@vue/composition-api'

import SkeletonLoader from '@/components/SkeletonLoader.vue'
import store from '@/store'
import { ResumeGetters } from '@/store/modules/resume/getters'
import { JobItemInterface } from '@/store/modules/resume/types'
import { TechnicalExperienceGetters } from '@/store/modules/technical-experience/getters'
import { TechnicalExperienceInterface } from '@/store/modules/technical-experience/types'
import { TechnicalSkillGetters } from '@/store/modules/technical-skills/getters'
import { TechnicalSkillInterface } from '@/store/modules/technical-skills/types'

export default defineComponent({
  name: 'PersonalInfo',
  components: {
    SkeletonLoader
  },
  setup() {
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
      isLoading
    }
  }
})
</script>
