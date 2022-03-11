<template>
  <v-col cols="12" md="6" >
    <v-item>
      <v-dialog v-model="isDialogOpen" width="500">
        <v-card v-if="!isEmpty(selectedItem)">
          <v-card-title>{{ selectedItem.companyName }}</v-card-title>
          <v-card-subtitle>
            <v-img
              :src="require(`@/assets/${selectedItem.companyName}.jpg`)"
              :alt="selectedItem.companyName"
              contain
              height="300"
              max-width="500"
              @click="openDescription"
            />
          </v-card-subtitle>
          <v-card-text>{{ selectedItem.duties }}</v-card-text>
        </v-card>
        <template v-slot:activator="{ }">
          <v-btn class="ma-2" width="150" height="150">
            <v-img
              :src="require(`@/assets/${selectedItem.companyName}.jpg`)"
              :alt="selectedItem.companyName"
              height="150"
              width="150"
              @click="openDescription"
            />
          </v-btn>
        </template>
      </v-dialog>
    </v-item>
  </v-col>
</template>

<script lang="ts">
import { WorkHistoryInterface } from '@/store/modules/workHistories/types'
import { defineComponent, PropType, ref } from '@vue/composition-api'
import { isEmpty } from 'lodash'
export default defineComponent({
  name: 'WorkHistoryItem',
  props: {
    history: {
      required: true,
      type: Object as PropType<WorkHistoryInterface>
    }
  },
  setup(props) {
    const selectedItem = ref<WorkHistoryInterface>()
    const isDialogOpen = ref<boolean>(false)
    function openDescription() {
      selectedItem.value = props.history
      isDialogOpen.value = !isEmpty(selectedItem.value)
    }
    return {
      isDialogOpen,
      isEmpty,
      openDescription,
      selectedItem
    }
  },
})
</script>