<template>
  <v-menu
    v-model="menu"
    :close-on-content-click="false"
    :nudge-width="200"
    offset-y
  >
    <template v-slot:activator="{ on }">
      <v-btn large icon v-on="on">
        <v-icon size="30" color="accent">mdi-brightness-6</v-icon>
      </v-btn>
    </template>
    <v-card>
      <v-list-item>
        <v-list-item-content>
          <v-list-item-title class="font-weight-bold">{{
            isDark ? 'Light Mode' : 'Dark Mode'
          }}</v-list-item-title>
        </v-list-item-content>
        <v-list-item-action>
          <v-switch v-model="$vuetify.theme.dark" @click="setSwitchText()" />
        </v-list-item-action>
      </v-list-item>
      <v-divider />
    </v-card>
  </v-menu>
</template>

<script>
export default {
  name: 'ThemeChanger',
  data() {
    return {
      isDark: false,
      menu: false,
    }
  },
  methods: {
    setSwitchText() {
      this.isDark = !this.isDark
    },
  },
}
</script>
