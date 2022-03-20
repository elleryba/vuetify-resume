<template>
  <v-skeleton-loader
    class="my-4 mx-4"
    width="500"
    height="350"
    elevation="5"
    type="card-heading, list-item-three-line, list-item-two-line, list-item-two-line"
  ></v-skeleton-loader>
</template>

<script>
import { defineComponent } from '@vue/composition-api'

  export default defineComponent({
    name: 'SkeletonLoader'
  })
</script>