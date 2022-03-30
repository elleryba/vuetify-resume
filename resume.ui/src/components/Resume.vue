<template>
  <div>
    <v-card-actions>
      <v-btn
        text
        color="warning"
        @click="flipResumeDisplay"
      >
        Resume
      </v-btn>
    </v-card-actions>

    <v-expand-transition>
      <v-card
        v-if="isResumeShowing"
        class="transition-fast-in-fast-out v-card--reveal scroll"
        style="height: 100%;"
        color="primary"
        elevation="5"
      >
        <v-card
          class="my-4 mx-4"
          elevation="5"
          v-for="item in resumeData" :key="item.id"
        >
          <v-card-title>{{ item.companyName }}</v-card-title>
          <v-card-text>
            <v-row align="center" class="mx-0 my-0">
              <div class="text-subtitle-1">
                Title: {{ item.title }}<br/>
                Start Date: {{ useJsDateFormatter(item.startDate) }}<br/>
                End Date: {{ useJsDateFormatter(item.endDate) }}<br/>
                Worked Remote: {{ item.wasRemotePosition ? 'Yes' : 'No' }}
              </div>
            </v-row>
            <v-row align="center" class="mx-0 my-0">
              <div>
                  <ul>
                    <li v-for="duty in item.jobDuties" :key="duty">{{ duty }}</li>
                  </ul>
              </div>
            </v-row>
          </v-card-text>
        </v-card>
        <v-card-actions class="pt-0">
      <v-btn
        text
        color="warning"
        @click="flipResumeDisplay"
      >
        Close
      </v-btn>
    </v-card-actions>
      </v-card>
    </v-expand-transition>
  </div>
</template>

<script lang="ts">
import { computed, defineComponent, ref } from '@vue/composition-api'

import { useJsDateFormatter } from '@/composables/dates'
import store from '@/store'
import { ResumeActions } from '@/store/modules/resume/actions'
import { ResumeGetters } from '@/store/modules/resume/getters'
import { JobItemInterface } from '@/store/modules/resume/types'

export default defineComponent({
    name: 'Resume',
    setup() {
        const isResumeShowing = ref<boolean>(false)

        const resumeData = computed<Array<JobItemInterface>>(() => store.getters[ResumeGetters.All])

        store.dispatch(ResumeActions.SetResume)

        function flipResumeDisplay() {
            isResumeShowing.value = !isResumeShowing.value
        }

        return {
            flipResumeDisplay,
            isResumeShowing,
            resumeData,
            useJsDateFormatter
        }
    }
})
</script>

<style scoped>
.v-card--reveal {
  bottom: 0;
  position: absolute;
  width: 100%;
}
.scroll {
  overflow-y: scroll;
}
</style>