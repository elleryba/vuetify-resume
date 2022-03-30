<template>
  <v-btn :href="route" target="_blank" text color="background">
    <v-icon size="26">mdi-linkedin</v-icon>
  </v-btn>
</template>

<script lang="ts">
import Vue from 'vue'

// lets use composition api here to defineComponent
export default Vue.extend({
  name: 'LinkedInInfo',
  data() {
    return {
      route: 'https://www.linkedin.com/in/elle-ryba/'
    }
  }
})
</script>
