<template>
  <v-row>
    <v-col>
      <v-card class="my-4 mx-4" max-width="500" elevation="5">
        <v-card-title>Technical Experience</v-card-title>
        <v-card-text>
          <v-row align="center" class="mx-0 my-0">
            <div class="text-subtitle-1">On the Job...</div>
          </v-row>
          <v-row class="my-2 mx-0">
            <div align="left" class="text-subtitle-3">
              <p v-for="d in experienceData" :key="d">{{d}}</p>
            </div>
          </v-row>
        </v-card-text>
      </v-card>
    </v-col>
  </v-row>
</template>

<script lang="ts">
import { computed, defineComponent } from '@vue/composition-api'
import store from '@/store'
import { TechnicalExperienceActions } from '@/store/modules/technical-experience/actions'
import { TechnicalExperienceGetters } from '@/store/modules/technical-experience/getters'
import { TechnicalExperienceInterface } from '@/store/modules/technical-experience/types'

export default defineComponent({
  name: 'TechnicalExperience',
  setup() {
    const experienceData = computed<Array<TechnicalExperienceInterface>>(() => store.getters[TechnicalExperienceGetters.All])

    store.dispatch(TechnicalExperienceActions.GetTechnicalExperience)

    return{
      experienceData
    }
  }
})
</script>
