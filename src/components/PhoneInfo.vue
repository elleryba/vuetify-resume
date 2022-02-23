<template>
  <v-menu
    v-model="menu"
    :close-on-content-click="false"
    offset-y
  >
    <template v-slot:activator="{ on }">
      <v-btn large icon v-on="on">
        <v-icon size="28" color="accent">mdi-cellphone</v-icon>
      </v-btn>
    </template>
    <v-card>
      <v-list-item>
        <v-list-item-content>
          <v-list-item-title class="font-weight-bold">216-379-9501</v-list-item-title>
        </v-list-item-content>
      </v-list-item>
      <v-divider />
    </v-card>
  </v-menu>
</template>

<script>
export default {
  name: 'PhoneInfo',
  data() {
    return {
      menu: false
    }
  },
  methods: {
  },
}
</script>
