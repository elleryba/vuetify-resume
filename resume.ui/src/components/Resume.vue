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
    <v-flex d-flex>
      <v-layout wrap>
        <v-flex md4 v-for="item in resume" :key="item.id">
          <v-card
            v-if="isTechStackDisplayed"
            class="transition-fast-in-fast-out v-card--reveal scroll"
            style="height: 100%;"
          >
            <v-card-title>{{ item.companyName }}</v-card-title>
              <v-card-text>
                <v-row align="center" class="mx-0 my-0">
                  <div class="text-subtitle-1">Title: {{ item.title }}</div>
                  <div class="text-subtitle-1">Start Date: {{ item.startDate }}</div>
                  <div class="text-subtitle-1">End Date: {{ item.endDate }}</div>
                  <div class="text-subtitle-1">Worked Remote: {{ item.wasRemotePosition }}</div>
                </v-row>
                <v-row align="center" class="mx-0 my-0">
                  <div>
                      <ul><li v-for="duty in item.jobDuties" :key="duty">{{ duty }}</li></ul>
                  </div>
                </v-row>
              </v-card-text>
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
        </v-flex>
      </v-layout>
    </v-flex>
    </v-expand-transition>
  </div>
</template>

<script lang="ts">
import { computed, defineComponent, ref } from '@vue/composition-api'
import store from '@/store'
import { ResumeActions } from '@/store/modules/resume/actions'
import { ResumeGetters } from '@/store/modules/resume/getters'
import { JobItemInterface } from '@/store/modules/resume/types'

export default defineComponent({
    name: 'Resume',
    setup() {
        const isResumeShowing = ref<boolean>(false)

        const resume = computed<Array<JobItemInterface>>(() => store.getters[ResumeGetters.All])

        store.dispatch(ResumeActions.GetResume)

        function flipResumeDisplay() {
            isResumeShowing.value = !isResumeShowing.value
        }

        return {
            flipResumeDisplay,
            isResumeShowing,
            resume
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