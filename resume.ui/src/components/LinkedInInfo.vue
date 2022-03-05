<template>
  <v-btn
    :href="route"
    target="_blank"
    text
    color="background"
  >
    <v-icon size="26">mdi-linkedin</v-icon>
  </v-btn>
</template>

<script>
export default {
  name: 'LinkedInInfo',
  data() {
    return {
      route: 'https://www.linkedin.com/in/elle-ryba/'
    }
  },
  methods: {
  },
}
</script>