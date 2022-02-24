<template>
  <v-btn
    text
    color="warning"
    @click="sendEmail()"
  >
    <v-icon>mdi-email-fast</v-icon>
  </v-btn>
</template>

<script>
export default {
  name: 'EmailInfo',
  data() {
    return {
    }
  },
  methods: {
    // would like to change this to emit to parent
    sendEmail(){
      window.location = "mailto:elleryba@icloud.com";
    }
  },
}
</script>