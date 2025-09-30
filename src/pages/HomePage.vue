<template>
  <div class="text-center p-6">
    <h1 class="text-4xl font-bold mb-4">Welcome to Global Bank</h1>
    <p class="mb-6">Easily book your appointment for loans, investments, or account services.</p>
    <RouterLink 
      to="/booking" 
      class="bg-blue-600 text-white px-6 py-3 rounded hover:bg-blue-700"
    >
      Book Appointment
    </RouterLink>
    
    <h2 class="text-2xl font-semibold mt-12 mb-4">Our Services</h2>
    <div class="grid grid-cols-1 md:grid-cols-3 gap-6">
      <ServiceCard v-for="s in services" :key="s.id" :service="s" :hideButton="true"/>
    </div>
  </div>
</template>

<script setup lang="ts">
import ServiceCard from '../components/ServiceCard.vue'

const services = [
  { id: 1, name: 'Personal Loan Consultation', price: 50, duration: '30 min' },
  { id: 2, name: 'Investment Advisory', price: 120, duration: '45 min' },
  { id: 3, name: 'Account Opening Assistance', price: 30, duration: '20 min' },
  { id: 4, name: 'Mortgage Consultation', price: 150, duration: '60 min' }
]
</script>

<style scoped>
/* General page styling */
div.text-center {
  font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
  background-color: #f9fafb;
  min-height: 100vh;
  padding: 3rem 1.5rem;
  color: #1f2937; /* dark gray text */
}

/* Main heading */
h1 {
  font-size: 2.5rem;
  font-weight: 700;
  color: #1e3a8a; /* deep blue */
  margin-bottom: 1rem;
}

p {
  font-size: 1.125rem;
  margin-bottom: 1.5rem;
  color: #4b5563; /* medium gray */
}

/* Call-to-action button */
a.router-link-exact-active,
a.router-link-active,
a {
  display: inline-block;
  font-weight: 600;
  background-color: #3b82f6;
  color: #ffffff;
  padding: 0.75rem 1.5rem;
  border-radius: 0.75rem;
  transition: background-color 0.3s ease, transform 0.2s ease, box-shadow 0.2s ease;
  text-decoration: none;
}

a:hover {
  background-color: #2563eb;
  transform: translateY(-2px);
  box-shadow: 0 4px 12px rgba(0, 0, 0, 0.12);
}

/* Section heading */
h2 {
  font-size: 1.75rem;
  font-weight: 600;
  color: #1e3a8a;
  margin-top: 3rem;
  margin-bottom: 1rem;
}

/* Services grid */
.grid {
  display: grid;
  grid-template-columns: 1fr;
  gap: 1.5rem;
  margin-top: 1.5rem;
}

@media (min-width: 768px) {
  .grid {
    grid-template-columns: repeat(3, 1fr);
  }
}

/* Optional: subtle animation for cards */
.ServiceCard {
  background: #ffffff;
  border-radius: 1rem;
  padding: 1.5rem;
  box-shadow: 0 6px 18px rgba(0, 0, 0, 0.08);
  transition: transform 0.2s ease, box-shadow 0.2s ease;
}

.ServiceCard:hover {
  transform: translateY(-4px);
  box-shadow: 0 12px 24px rgba(0, 0, 0, 0.12);
}
</style>
