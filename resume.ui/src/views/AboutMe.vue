<template>
  <div class="home">
    <AboutMe />
  </div>
</template>

<script lang="ts">
import Vue from 'vue'
import AboutMe from '@/components/AboutMe.vue'

export default Vue.extend({
  name: 'Home',
  components: {
    AboutMe
  },
})
</script>
