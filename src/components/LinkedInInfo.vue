<template>
  <v-btn
    :href="route"
    target="_blank"
    text
    color="warning"
  >
    <v-icon>mdi-linkedin</v-icon>
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