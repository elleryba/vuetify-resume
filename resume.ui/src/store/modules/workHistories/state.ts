import { WorkHistoryInterface, WorkHistoryStoreInterface } from '@/store/modules/workHistories/types'

export const state: WorkHistoryStoreInterface = {
  items: [] as Array<WorkHistoryInterface>,
}

export default state