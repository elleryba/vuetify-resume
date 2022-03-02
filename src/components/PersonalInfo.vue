<template>
  <v-row>
    <v-col>
      <v-card
        class="my-4 mx-4"
        max-width="500"
        elevation="5"
      >
        <v-card-title>Personal</v-card-title>
        <v-card-text>
          <v-row
            align="center"
            class="mx-0 my-0"
          >
            <div class="text-subtitle-1">
              Outside of Work
            </div>
          </v-row>
          <v-row class="my-2 mx-0">
            <div align="left" class="text-subtitle-3">
              In my personal time I am playing through the
              <a
                href="https://www.ea.com/games/mass-effect/mass-effect-legendary-edition"
                target="_blank"
              >
                Mass Effect
              </a>
              trilogy via
              <a
                href="https://www.xbox.com/en-US/games/store/xbox-game-pass-ultimate/cfq7ttc0khs0"
                target="_blank"
              >Xbox Game Pass</a>.
            </div>
          </v-row>
        </v-card-text>
      </v-card>
    </v-col>
  </v-row>
</template>

<script>
import { defineComponent } from '@vue/composition-api'

export default defineComponent({
  setup() {
  }
})
</script>