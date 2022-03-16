<template>
  <div>
    <v-row
        no-gutters
        style="height: 150px;"
      >
        <v-card
          :loading="loading"
          class="my-4 mx-4"
          max-width="500"
          elevation="5"
        >
          <v-img
            max-height="350"
            :src="profilePic"
          ></v-img>

          <v-card-title>Elle Ryba</v-card-title>

          <v-card-text>
            <v-row
              align="center"
              class="mx-0 my-0"
            >
              <div class="text-subtitle-1">
                Front-end only resume
              </div>
            </v-row>
            <v-row class="my-2 mx-0">
              <div align="left" class="text-subtitle-3">
                <span style='text-decoration:line-through'>
                  At this time, this entire project is comprised of only a front-end code base.
                  Why? Because I feel like front-end work has been my weak point. This is how I make
                  it a strength
                </span>.
                This project started as front-end only. I have now begun integrating my back-end code base.
                The back-end is comprised of an api that retrieves data from a SQL database via EF Core and
                the .NET framework.
              </div>
            </v-row>
          </v-card-text>

          <v-divider class="mx-4"></v-divider>

          <TechnicalSkills />

        </v-card>
        <v-row
          no-gutters
          style="height: 150px;"
        >
          <v-card
            color="primary"
            class="my-4 mx-4"
            max-width="500"
            elevation="5"
          >
            <TechnicalExperience />
            <PersonalInfo />
          </v-card>
        </v-row>
      </v-row>
  </div>
</template>

<script lang="ts">
import { defineComponent } from '@vue/composition-api'
import PersonalInfo from './PersonalInfo.vue'
import TechnicalExperience from './TechnicalExperience.vue'
import TechnicalSkills from './TechnicalSkills.vue'

export default defineComponent({
  name: 'AboutMe',
  components: {
    PersonalInfo,
    TechnicalExperience,
    TechnicalSkills
  },
  data: () => ({
    loading: false,
    // would like to store and retrieve via api
    profilePic: require('../assets/profile_pic.png'),
    alignments: [
        'start',
        'center',
        'end',
      ]
  }),
  methods:{}
})
</script>