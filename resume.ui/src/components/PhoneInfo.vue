<template>
  <v-menu v-model="menu" :close-on-content-click="true" offset-y>
    <template v-slot:activator="{ on }">
      <v-btn large icon v-on="on">
        <v-icon size="26" color="background">mdi-cellphone</v-icon>
      </v-btn>
    </template>
    <v-card>
      <v-list-item>
        <v-list-item-content>
          <v-list-item-title class="font-weight-bold">
            {{ phoneNumber }}
          </v-list-item-title>
        </v-list-item-content>
        <v-list-item-action>
          <v-btn v-model="phoneNumber" @click="copyPhoneNumber()">
            <v-icon size="20" color="accent">mdi-content-copy</v-icon>
          </v-btn>
        </v-list-item-action>
      </v-list-item>
      <v-divider />
    </v-card>
  </v-menu>
</template>

<script lang="ts">

// lets use composition api here to defineComponent
export default {
  name: 'PhoneInfo',
  data(): { menu: boolean; phoneNumber: string } {
    return {
      menu: false,
      phoneNumber: 'XXX-XXX-XXXX',
    }
  },
  methods: {
    // add notification to user that action was completed
    copyPhoneNumber(): void {
      navigator.clipboard.writeText('216-379-9501')
    }
  }
}
</script>
