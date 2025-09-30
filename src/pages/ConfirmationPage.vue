<template>
  <div class="max-w-xl mx-auto p-6">
    <h1 class="text-3xl font-bold mb-6 text-center text-blue-600">Appointment Confirmed!</h1>

    <div class="bg-white shadow-lg rounded-xl p-6 space-y-4">
      <h2 class="text-2xl font-semibold mb-2">Your Appointment Details</h2>

      <div class="flex justify-between">
        <span class="font-medium">Service:</span>
        <span>{{ booking.service?.name }}</span>
      </div>

      <div class="flex justify-between">
        <span class="font-medium">Date:</span>
        <span>{{ booking.date }}</span>
      </div>

      <div class="flex justify-between">
        <span class="font-medium">Time:</span>
        <span>{{ booking.time }}</span>
      </div>

      <div class="flex justify-between">
        <span class="font-medium">Customer Name:</span>
        <span>{{ booking.customer.name }}</span>
      </div>

      <div class="flex justify-between">
        <span class="font-medium">Phone:</span>
        <span>{{ booking.customer.phone }}</span>
      </div>

    </div>

    <div class="text-center mt-6">
      <RouterLink 
        to="/" 
        class="bg-blue-600 text-white px-6 py-3 rounded hover:bg-blue-700"
      >
        Back to Home
      </RouterLink>
    </div>
  </div>
</template>

<script setup lang="ts">
import { useBookingStore } from '../stores/booking'

const booking = useBookingStore()
</script>


<style scoped>
/* Page container */
.max-w-xl {
  font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
  background-color: #f9fafb;
  min-height: 100vh;
  padding: 2rem 1.5rem;
  color: #1f2937; /* dark gray */
}

/* Main heading */
h1 {
  font-size: 2rem;
  font-weight: 700;
  text-align: center;
  color: #1e40af; /* blue */
  margin-bottom: 2rem;
}

/* Appointment card */
.bg-white {
  background-color: #ffffff;
  border-radius: 1rem;
  padding: 1.5rem;
  box-shadow: 0 8px 20px rgba(0,0,0,0.1);
}

.bg-white h2 {
  font-size: 1.5rem;
  font-weight: 600;
  color: #1e3a8a;
  margin-bottom: 1rem;
}

/* Flex rows for details */
.flex {
  display: flex;
  justify-content: space-between;
  margin-bottom: 0.5rem;
}

.font-medium {
  font-weight: 500;
  color: #374151;
}

.flex span:last-child {
  font-weight: 400;
  color: #1f2937;
}

/* Back to home button */
.text-center {
  margin-top: 1.5rem;
  display: flex;
  justify-content: center;
}

.text-center a {
  background-color: #2563eb;
  color: #ffffff;
  padding: 0.75rem 1.5rem;
  border-radius: 0.75rem;
  font-weight: 600;
  text-decoration: none;
  transition: background-color 0.3s ease, transform 0.2s ease;
}

.text-center a:hover {
  background-color: #1d4ed8;
  transform: translateY(-2px);
}

/* Responsive tweaks */
@media (max-width: 640px) {
  .bg-white {
    padding: 1rem;
  }
  h1 {
    font-size: 1.75rem;
  }
  h2 {
    font-size: 1.25rem;
  }
}
</style>
../stores/booking