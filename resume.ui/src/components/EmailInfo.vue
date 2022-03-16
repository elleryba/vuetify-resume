<template>
  <v-btn text color="background" @click="sendEmail()">
    <v-icon size="27">mdi-email-fast</v-icon>
  </v-btn>
</template>

<script lang="ts">
import Vue from 'vue'

export default Vue.extend({
  name: 'EmailInfo',
  data() {
    return {}
  },
  methods: {
    // would like to change this to emit to parent
    sendEmail() {
      window.location.href = 'mailto:elleryba@icloud.com'
    },
  },
})
</script>
