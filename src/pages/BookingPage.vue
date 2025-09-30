<template>
  <div class="max-w-xl mx-auto p-6">
    <h1 class="text-3xl font-bold mb-6 text-center">Book Your Bank Appointment</h1>

    <!-- Selected Service -->
    <!-- <div class="mb-4 p-4 bg-white rounded-lg shadow">
      <h2 class="text-xl font-semibold mb-2">Selected Service:</h2>
      <p class="text-gray-700">{{ selectedService?.name || 'Please select a banking service' }}</p>
      <p class="text-gray-500">{{ selectedService?.description }}</p>
    </div> -->


<!-- Selected Service -->
<div class="mb-4 p-4 bg-white rounded-lg shadow">
  <h2 class="text-xl font-semibold mb-2">Select a Service:</h2>

  <!-- Dropdown -->
  <select v-model="selectedService" class="w-full border p-2 rounded">
    <option disabled value="">-- Choose a banking service --</option>
    <option v-for="s in services" :key="s.id" :value="s">
      {{ s.name }}
    </option>
  </select>

  <!-- Service Details -->
  <div v-if="selectedService" class="mt-4">
    <p class="text-gray-700 font-medium">{{ selectedService.name }}</p>
    <p class="text-gray-500">{{ selectedService.description }}</p>
    <div class="flex justify-between text-gray-700 font-medium">
      <span>Price: ${{ selectedService.price }}, Duration: {{ selectedService.duration }}</span>
    </div>
  </div>
</div>



    <!-- Booking Form -->
    <form @submit.prevent="submitBooking" class="space-y-4">
      <!-- Date -->
      <div>
        <label class="block font-medium mb-1">Select Date:</label>
        <input type="date" v-model="date" class="w-full border p-2 rounded"/>
      </div>

      <!-- Time Slot -->
      <div>
        <label class="block font-medium mb-1">Select Time:</label>
        <select v-model="time" class="w-full border p-2 rounded">
          <option v-for="t in availableTimes" :key="t" :value="t">{{ t }}</option>
        </select>
      </div>

      <!-- Customer Info -->
      <div>
        <label class="block font-medium mb-1">Full Name:</label>
        <input v-model="name" type="text" class="w-full border p-2 rounded" required/>
      </div>

      <div>
        <label class="block font-medium mb-1">Phone Number:</label>
        <input v-model="phone" type="text" class="w-full border p-2 rounded" required/>
      </div>

      <button type="submit" class="w-full bg-blue-600 text-white py-2 rounded hover:bg-blue-700">
        Confirm Appointment
      </button>
    </form>
  </div>
</template>

<script setup lang="ts">
import { ref, onMounted } from 'vue'
import { useRouter, useRoute } from 'vue-router'
import { useBookingStore } from '../stores/booking'

interface Service {
  id: number
  name: string
  description: string
  price: number
  duration: string
}

const bookingStore = useBookingStore()
const router = useRouter()
const route = useRoute()

// Form fields
const selectedService = ref<Service | null>(null)
const date = ref('')
const time = ref('')
const name = ref('')
const phone = ref('')

// Example available time slots (could be fetched from backend)
const availableTimes = ['09:00', '10:00', '11:00', '14:00', '15:00', '16:00', '17:00']

const services = ref<Service[]>([
  { id: 1, name: 'Personal Loan Consultation', price: 50, duration: '30 min', description: 'Discuss loan eligibility, terms, and repayment plans with an advisor.' },
  { id: 2, name: 'Investment Advisory', price: 120, duration: '45 min', description: 'Meet with an investment advisor to review portfolio strategies.' },
  { id: 3, name: 'Account Opening Assistance', price: 30, duration: '20 min', description: 'Guided support for opening checking, savings, or business accounts.' },
  { id: 4, name: 'Mortgage Consultation', price: 150, duration: '60 min', description: 'Understand mortgage options, interest rates, and approval processes.' }
])

// Load service if passed in query
onMounted(() => {
  const serviceId = Number(route.query.serviceId)
  if (serviceId) {
    // Example bank services
    
    selectedService.value = services.value.find(s => s.id === serviceId) || null
  }
})

// Submit appointment
async function submitBooking() {
  if (!selectedService.value) {
    alert('Please select a banking service first.')
    return
  }

  const booking = {
    serviceId: selectedService.value.id,
    bookingDate: date.value,
    bookingTime: `0001-01-01T${time.value}`,
    customerName: name.value,
    customerPhone: phone.value
  }
  
  try {
    const response = await fetch('http://localhost:5000/api/bookings', {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(booking)
    })

    const result = await response.json()

    if (!response.ok) {
      alert(result.error)
      console.error("Request failed:", result.error)
    } else {
      // Save to Pinia
      bookingStore.setService(selectedService.value)
      bookingStore.setDate(date.value)
      bookingStore.setTime(time.value)
      bookingStore.setCustomer(name.value, phone.value)

      // Redirect to confirmation page
      router.push('/confirmation')
      console.log("Success:", result)
    }


  } catch (error) {
    console.error(error)
    alert('Could not confirm appointment.')
  }
}
</script>


<style scoped>
/* Page container */
div[max-w-xl] {
  font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
  background-color: #f9fafb;
  min-height: 100vh;
  padding: 3rem 1.5rem;
  color: #1f2937; /* dark gray */
}

/* Main heading */
h1 {
  text-align: center;
  font-size: 2.25rem;
  font-weight: 700;
  color: #1e3a8a; /* deep blue */
  margin-bottom: 2rem;
}

/* Selected Service Section */
.mb-4 {
  background-color: #ffffff;
  padding: 1.5rem;
  border-radius: 1rem;
  box-shadow: 0 6px 18px rgba(0, 0, 0, 0.08);
}

.mb-4 h2 {
  font-size: 1.25rem;
  font-weight: 600;
  color: #1e3a8a;
  margin-bottom: 0.5rem;
}

.mb-4 p {
  color: #4b5563; /* medium gray */
  margin-bottom: 0.5rem;
}

.mb-4 .flex span {
  color: #2563eb; /* blue accent */
}

/* Dropdown styling */
select {
  width: 100%;
  padding: 0.5rem 0.75rem;
  border: 1px solid #d1d5db;
  border-radius: 0.5rem;
  font-size: 1rem;
  transition: border-color 0.2s ease, box-shadow 0.2s ease;
}

select:focus {
  border-color: #3b82f6;
  box-shadow: 0 0 0 3px rgba(59, 130, 246, 0.2);
  outline: none;
}

/* Inputs styling */
input[type="text"],
input[type="date"] {
  width: 100%;
  padding: 0.5rem 0.75rem;
  border: 1px solid #d1d5db;
  border-radius: 0.5rem;
  font-size: 1rem;
  transition: border-color 0.2s ease, box-shadow 0.2s ease;
}

input:focus {
  border-color: #3b82f6;
  box-shadow: 0 0 0 3px rgba(59, 130, 246, 0.2);
  outline: none;
}

/* Booking Form */
form {
  margin-top: 1.5rem;
  display: flex;
  flex-direction: column;
  gap: 1rem;
}

/* Labels */
label {
  font-weight: 600;
  margin-bottom: 0.25rem;
  display: block;
  color: #374151;
}

/* Submit button */
button {
  background-color: #3b82f6;
  color: #ffffff;
  padding: 0.75rem;
  border-radius: 0.75rem;
  font-weight: 600;
  cursor: pointer;
  transition: background-color 0.3s ease, transform 0.2s ease, box-shadow 0.2s ease;
  border: none;
}

button:hover {
  background-color: #2563eb;
  transform: translateY(-2px);
  box-shadow: 0 6px 18px rgba(0, 0, 0, 0.12);
}

/* Service Details */
.mt-4 p {
  margin-bottom: 0.25rem;
}

.mt-4 .flex {
  justify-content: space-between;
  font-weight: 500;
  color: #2563eb;
}

/* Responsive tweaks */
@media (max-width: 640px) {
  .mb-4 {
    padding: 1rem;
  }

  button {
    padding: 0.65rem;
  }
}
</style>
../stores/booking