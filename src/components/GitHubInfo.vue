<template>
  <v-btn
    :href="route"
    target="_blank"
    text
    color="background"
  >
    <v-icon size="26">mdi-github</v-icon>
  </v-btn>
</template>

<script>
export default {
  name: 'GitHubInfo',
  data() {
    return {
      route: 'https://github.com/elleryba'
    }
  },
  methods: {
  },
}
</script>