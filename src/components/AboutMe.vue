<template>
  <div>
    <v-row
        :align="align"
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
                At this time, this entire project is comprised of only a front-end code base.
              </div>
            </v-row>
          </v-card-text>

          <v-divider class="mx-4"></v-divider>

          <TechSkills />

        </v-card>

        <v-card
          color="primary"
          class="my-4 mx-4"
          max-width="500"
          elevation="5"
        >
          <TechExperience />
          <PersonalInfo />
        </v-card>
        
      </v-row>
  </div>
</template>

<script>
import PersonalInfo from './PersonalInfo.vue'
import TechExperience from './TechExperience.vue'
import TechSkills from './TechSkills.vue'

export default {
  name: 'AboutMe',
  components: {
    PersonalInfo,
    TechExperience,
    TechSkills
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
}
</script>
