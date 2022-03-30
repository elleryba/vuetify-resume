import { ActionTree } from 'vuex'
import axios from 'axios'
import { RootState } from '@/store/types'
import { ResumeApiResponseInterface, ResumeStoreInterface, ResumeInterface } from './types'
import { ResumeMutations } from './mutations'
import { isEmpty } from 'lodash'

export class ResumeActions {
  /** Loads the resume from the api. */
  public static GetResume = 'resume/getResume'

  /** For use in front-end only version of app. */
  public static SetResume = 'resume/setResume'
}

export const actions: ActionTree<ResumeStoreInterface, RootState> = {
    getResume({ commit }) {
    axios
      .get<ResumeApiResponseInterface>('http://localhost:41368/api/resume')
      .then<ResumeInterface>((response) => {
        if (isEmpty(response?.data)) throw new Error('response is empty')

        const resume = response.data.resume as ResumeInterface

        commit(ResumeMutations.SET_RESUME, { resume: resume })

        return resume
      })
      .catch(e => console.error('resume/getResume :: failed', e))
  },
  setResume({ commit }) {
    const data = {
      resume: [
          {
              'companyName': 'AmpliFund',
              'endDate': undefined,
              'id': 4,
              'jobDuties': [],
              'startDate': new Date('2022-02-15T00:00:00'),
              'title': 'Developer II',
              'wasRemotePosition': true
          },
          {
              'companyName': 'National General Insurance Company',
              'endDate': new Date('2022-02-08T00:00:00'),
              'id': 1,
              'jobDuties': [
                  'Agile team with project-focused delivery',
                  'Full stack project creating a new website for internal and external agents to write quotes and bind policies',
                  'MVC pattern',
                  'Domain driven design',
                  'Microservice architecture',
                  'SOLID principles',
                  'Create RESTful Api services using C# and .NET 3.1',
                  'Interact with SQL storage via EF Core and SQL Server Management Studio',
                  'Interact with NoSQL storage via MongoDB Driver NuGet',
                  'Code defensively via early returns based on null/conditional checks prior to accessing or modifying data',
                  'Test locally by consuming endpoints via Postman',
                  'Write unit tests using AAA pattern',
                  'Use HTML, CSS, JavaScript, and TypeScript to build out Vue components',
                  'Interact with the back-end services by consuming endpoints via Axios library',
                  'Create composables for code reusability without violating DRY principles',
                  'Ensure a positive, consistent user experience throughout each page',
                  'Locally test all code changes',
                  'Debug via Console, Network, and Vue.js devtools',
                  'Complete integration testing across domain apis, and full-stack testing from the front-end to back-end',
                  'Make revisions to eliminate errors prior to QA review',
                  'Work with the business to obtain approval for changes made to the project',
                  'Submit and review pull requests via Azure DevOps',
                  'Track sprint work and open bugs via Azure DevOps',
                  'Score effort for tasks using Fibonacci scale'
              ],
              'startDate': new Date('2020-09-01T00:00:00'),
              'title': 'Enterprise Software Developer Senior Consultant I',
              'wasRemotePosition': true
          },
          {
              'companyName': 'Homesite Insurance',
              'endDate': new Date('2020-05-01T00:00:00'),
              'id': 2,
              'jobDuties': [
                  'During first contact with a customer, assessed needs and formulated a plan for resolution in real-time',
                  'Negotiate settlements that were favorable for both the customer and the company',
                  'Recognized and escalated potential fraud and recovery opportunities to prevent monetary and reputational loss',
                  'Utilized time management skills to lower overall cycle time and pending claims volume below expected standard'
              ],
              'startDate': new Date('2019-08-01T00:00:00'),
              'title': 'Claims Adjuster',
              'wasRemotePosition': true
          },
          {
              'companyName': 'Safeguard Properties',
              'endDate': new Date('2019-08-01'),
              'id': 3,
              'jobDuties': [
                  'Directly responsible for managing assignments, tracking quality & production, and providing regular performance feedback and coaching to a staff of 14',
                  'Implemented production tracking to streamline processing and lessen time needed to track daily data',
                  'Created Excel pivot with processor reported indirect time and average production per month. This helped to identify trends and areas of opportunity at processor level',
                  'Developed new workflow distribution to increase proficiency for processors by 29.31% in three months',
                  'Created weekly reconciliation reporting and analyzed trends to isolate opportunities to mitigate revenue loss'
              ],
              'startDate': new Date('2012-10-01'),
              'title': 'Order Entry Team Lead',
              'wasRemotePosition': false
          }
      ]
    } as ResumeInterface

    commit(ResumeMutations.SET_RESUME, { resume: data.resume })
  }
}

export default actions