<template>
  <div>
    <AboutMe />
  </div>
</template>

<script lang="ts">
import { defineComponent } from '@vue/composition-api'
import AboutMe from '@/components/AboutMe.vue'

export default defineComponent({
  name: 'Home',
  components: {
    AboutMe
  },
})
</script>
