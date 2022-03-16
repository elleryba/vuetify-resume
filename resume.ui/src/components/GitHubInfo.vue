<template>
  <v-btn :href="route" target="_blank" text color="background">
    <v-icon size="26">mdi-github</v-icon>
  </v-btn>
</template>

<script lang="ts">
import Vue from 'vue'

export default Vue.extend({
  name: 'GitHubInfo',
  data() {
    return {
      route: 'https://github.com/elleryba',
    }
  },
  methods: {},
})
</script>
