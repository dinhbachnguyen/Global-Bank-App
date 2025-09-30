import { defineStore } from 'pinia'

export const useBookingStore = defineStore('booking', {
  state: () => ({
    service: null as null | { id: number, name: string, price: number, duration: string },
    date: '',
    time: '',
    customer: {
      name: '',
      phone: ''
    }
  }),
  actions: {
     setService(service: { id: number, name: string, description: string, price: number, duration: string }) {
      this.service = service
    },
    setDate(date: string) { this.date = date },
    setTime(time: string) { this.time = time },
    setCustomer(name: string, phone: string) {
      this.customer.name = name
      this.customer.phone = phone
    }
  }
})
