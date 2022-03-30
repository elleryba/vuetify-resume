import { isEmpty } from 'lodash'

/** This is gross. Take in a Date YYYY-MM-DDT00:00:00
 *  and return in a prettier form MM-DD-YYYY.
 */
export function useDateFormatter(date: Date): string {
    if (isEmpty(date)) return ''

    const dateText = date.toString()
    const dateTimeComponents = dateText.split('T')
    const dateComponents = dateTimeComponents[0].split('-')
    const formattedDate = `${dateComponents[1]}-${dateComponents[2]}-${dateComponents[0]}`

    return formattedDate
}

/** Also gross. This is to format the date string when
 * the resume is built client-side.
 */
export function useJsDateFormatter(date: Date | undefined): string {
    if (date == undefined) return ''

    const dateText = date.toString()
    const dateComponents = dateText.split(' ')
    const formattedDate = `${dateComponents[1]} ${dateComponents[2]} ${dateComponents[3]}`

    return formattedDate
}