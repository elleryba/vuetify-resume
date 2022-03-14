<template>
  <div>
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
        class="transition-fast-in-fast-out v-card--reveal scroll"
        style="height: 100%;"
      >
        <v-card-text class="pb-0">
          <p v-for="s in skills" :key="s">{{s}}</p>
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
    const showTechStack = ref<boolean>()
    const skills = computed<Array<TechnicalSkillInterface>>(() => store.getters[TechnicalSkillGetters.All])

    store.dispatch(TechnicalSkillActions.GetTechnicalSkills)

    return {
      showTechStack,
      skills
    }
  },
  // data: () => ({
  //   showTechStack: false,
  //   // this will eventually be moved to a db and pulled via api call
  //   techSkills: [
  //     'CSS',
  //     'HTML',
  //     'JavaScript',
  //     'TypeScript',
  //     'Vue.js (Vue 2 | vuetify | composition api)',
  //     'C#',
  //     '.NET',
  //     'SQL',
  //     'NoSQL',
  //     'Sql Server Management Studio',
  //     'MongoDB',
  //     'Azure DevOps',
  //     'Visual Studio | Visual Studio Code',
  //     'Postman'
  //   ]
  // }),
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
