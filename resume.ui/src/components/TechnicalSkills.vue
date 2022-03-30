<template>
  <div>
    <v-card-actions>
      <v-btn
        text
        color="warning"
        @click="flipTechStackDisplay"
      >
        Tech Skills
      </v-btn>
    </v-card-actions>

    <v-expand-transition>
      <v-card
        v-if="isTechStackDisplayed"
        class="transition-fast-in-fast-out v-card--reveal scroll"
        style="height: 100%;"
        color="primary"
      >
        <v-card-text class="pb-0">
          <p v-for="s in skills" :key="s">{{s}}</p>
        </v-card-text>
        <v-card-actions class="pt-0">
          <v-btn
            text
            color="warning"
            @click="flipTechStackDisplay"
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

import store from '@/store'
import { TechnicalSkillActions } from '@/store/modules/technical-skills/actions'
import { TechnicalSkillGetters } from '@/store/modules/technical-skills/getters'
import { TechnicalSkillInterface } from '@/store/modules/technical-skills/types'

export default defineComponent({
  name: 'TechSkills',
  setup() {
    const isTechStackDisplayed = ref<boolean>(false)

    const skills = computed<Array<TechnicalSkillInterface>>(() => store.getters[TechnicalSkillGetters.All])

    store.dispatch(TechnicalSkillActions.SetTechnicalSkills)

    function flipTechStackDisplay(){
      isTechStackDisplayed.value = !isTechStackDisplayed.value
    }

    return {
      isTechStackDisplayed,
      flipTechStackDisplay,
      skills
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
