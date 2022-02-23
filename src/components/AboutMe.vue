<template>
  <v-container>
    <v-row class="text-center">
      <v-card
        :loading="loading"
        class="my-4"
        max-width="400"
      >
        <template slot="progress">
          <v-progress-linear
            color="secondary"
            height="10"
            indeterminate
          ></v-progress-linear>
        </template>

        <v-img
          height="250"
          src="../assets/profile_pic.png"
        ></v-img>

        <v-card-title>Elle Ryba</v-card-title>

        <v-card-text>
          <v-row
            align="center"
            class="mx-0"
          >
            <div class="text-subtitle-1">
              Front-end only resume
            </div>
          </v-row>
          <v-row>
            <div class="text-subtitle-3">This will be a work in progress for a while. I will start by building a full front-end
              project, then I will create a database, and then I will write the back-end using the .NET
              framework.
            </div>
          </v-row>
        </v-card-text>

        <v-divider class="mx-4"></v-divider>

        <v-card-title>Technical Skills:</v-card-title>

        <v-card-text>
          <v-chip-group
            v-model="selection"
            active-class="deep-purple accent-4 white--text"
            column
          >
            <v-chip @click="testFunc()">front-end</v-chip>

            <v-chip>back-end</v-chip>

            <v-chip>SQL</v-chip>

            <v-chip>NoSql</v-chip>
          </v-chip-group>
        </v-card-text>

        <v-card-actions>
          <v-btn
            color="accent"
            text
          >
            Reserve
          </v-btn>
        </v-card-actions>
      </v-card>
    </v-row>
  </v-container>
</template>

<script>
export default {
  name: 'AboutMe',

  data: () => ({
    loading: false,
    selection: undefined,
    ecosystem: [
      {
        text: 'vuetify-loader',
        href: 'https://github.com/vuetifyjs/vuetify-loader',
      },
      {
        text: 'github',
        href: 'https://github.com/vuetifyjs/vuetify',
      },
      {
        text: 'awesome-vuetify',
        href: 'https://github.com/vuetifyjs/awesome-vuetify',
      },
    ]
  }),
  methods:{
    testFunc(){
      this.loading = true
      setTimeout(() => (this.loading = false), 1500)
      console.info('test')
    }
  }
}
</script>
