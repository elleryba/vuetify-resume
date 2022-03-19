import { isEmpty } from 'lodash'

export function useDateFormatter(date: Date): string {
    if (isEmpty(date)) return ''

    const dateText = date.toString()
    const components = dateText.split('T')
    return components[0]
}