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

                <v-card-title>Front-End</v-card-title>

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
                        <div class="text-subtitle-3"></div>
                    </v-row>
                </v-card-text>

                <v-divider class="mx-4"></v-divider>

                <v-card-title>Technical Skills:</v-card-title>

                <v-card-actions>
                    <v-btn
                        color="accent"
                        text
                    >
                        close
                    </v-btn>
                </v-card-actions>
            </v-card>
        </v-row>
    </v-container>
</template>

<script>
export default {
    name: 'TechSkills',

    data: () => ({
        loading: false,
        selection: undefined,
        skillset: [
            {
            text: 'JavaScript'
            },
            {
            text: 'Vue'
            },
            {
            text: 'TypeScript'
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
