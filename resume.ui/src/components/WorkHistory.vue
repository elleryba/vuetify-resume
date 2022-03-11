<template>
  <v-card class="d-flex align-center justify-space-around mt-4 pa-4 text-center">
    <v-item-group v-model="model">
      <v-row v-if="!isEmpty(histories)">
        <HistoryItem v-for="item in histories" :key="item.jobId" :history="item" />
      </v-row>
    </v-item-group>
  </v-card>
</template>

<script lang="ts">
import { defineComponent, computed, ref } from '@vue/composition-api'
import { isEmpty } from 'lodash'
import WorkHistoryItem from '@/components/WorkHistoryItem.vue'
import store from '@/store'
import { WorkHistoryActions } from '@/store/modules/workHistories/actions'
import { WorkHistoryGetters } from '@/store/modules/workHistories/getters'
import { WorkHistoryInterface } from '@/store/modules/workHistories/types'
export default defineComponent({
  name: 'WorkHistory',
  components: {
    WorkHistoryItem
  },
  setup() {
    const model = ref<number>(0)
    const histories = computed<Array<WorkHistoryInterface>>(() => store.getters[WorkHistoryGetters.All])
    store.dispatch(WorkHistoryActions.GetWorkHistory)
    return {
      isEmpty,
      model,
      histories,
    }
  },
})
</script>