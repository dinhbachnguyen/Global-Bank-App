<!-- <template>
  <div class="p-6 max-w-5xl mx-auto">
    <h1 class="text-3xl font-bold mb-6 text-center">Banking Services</h1>

    <div class="grid grid-cols-1 md:grid-cols-3 gap-6">
      <ServiceCard
        v-for="service in services"
        :key="service.id"
        :service="service"
        @book="selectService(service)"
      />
    </div>
  </div>
</template> -->


<template>
  <div class="p-6 max-w-5xl mx-auto">
    <h1 class="text-3xl font-bold mb-6 text-center">Banking Services</h1>

    <div class="grid grid-cols-1 md:grid-cols-3 gap-6">
      <template v-for="service in services" :key="service.id">
        <ServiceCard 
          :service="service" 
          @book="selectService(service)" 
        />

        <div class="service-image-wrapper">
          <img :src="getImage(service.id)"
               alt="Bank Service Image" 
               class="service-image rounded-lg shadow-md" />
        </div>
      </template>
    </div>
  </div>
</template>


<script setup lang="ts">
import { useRouter } from 'vue-router'
import ServiceCard from '../components/ServiceCard.vue'
import { ref, onMounted } from 'vue'

const router = useRouter()

// Example banking services (can also be fetched from backend)
const services = ref([
  { id: 1, name: 'Personal Loan Consultation', price: 50, duration: '30 min', description: 'Discuss loan eligibility, terms, and repayment plans with an advisor.'},
  { id: 2, name: 'Investment Advisory', price: 120, duration: '45 min', description: 'Meet with an investment advisor to review portfolio strategies.' },
  { id: 3, name: 'Account Opening Assistance', price: 30, duration: '20 min', description: 'Guided support for opening checking, savings, or business accounts.' },
  { id: 4, name: 'Mortgage Consultation', price: 150, duration: '60 min', description: 'Understand mortgage options, interest rates, and approval processes.' }
])

const getImage = (id: number) => {
  switch(id) {
    case 1: return new URL('@/assets/bank1.jpg', import.meta.url).href
    case 2: return new URL('@/assets/bank2.jpg', import.meta.url).href
    case 3: return new URL('@/assets/bank3.jpg', import.meta.url).href
    case 4: return new URL('@/assets/bank4.jpg', import.meta.url).href
    default: return new URL('@/assets/a.png', import.meta.url).href
  }
}

// onMounted(async () => {
//   try {
//     const res = await fetch('http://localhost:5000/api/services')
//     services.value = await res.json()
//   } catch (err) {
//     console.error('Failed to fetch banking services', err)
//   }
// })

// Called when user clicks "Book Appointment"
function selectService(service: any) {
  router.push({ name: 'BookingPage', query: { serviceId: service.id } })
}
</script>

<!-- 
<style scoped>

.service-image-wrapper {
  margin-top: 1rem;
  display: flex;
  justify-content: center; /* centers the image under the card */
}

.service-image {
  width: 100%;        /* takes full width of wrapper */
  max-width: 250px;   /* reduce size of image */
  height: auto;       /* maintain aspect ratio */
  object-fit: cover;  /* crops nicely if needed */
  border-radius: 1rem;
  box-shadow: 0 6px 18px rgba(0, 0, 0, 0.08);
  transition: transform 0.2s ease, box-shadow 0.2s ease;
}

.service-image:hover {
  transform: translateY(-2px);
  box-shadow: 0 10px 20px rgba(0, 0, 0, 0.12);
}

/* Page container */
div {
  font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
  background-color: #f9fafb;
  min-height: 1vh;
  padding: 3rem 1.5rem;
  color: #1f2937; /* dark gray */
}

/* Main heading */
h1 {
  text-align: center;
  font-size: 2rem;
  font-weight: 700;
  color: #1e3a8a; /* deep blue */
  margin-bottom: 2rem;
}

/* Services grid */
.grid {
  display: grid;
  grid-template-columns: 1fr;
  gap: 1.5rem;
}

@media (min-width: 768px) {
  .grid {
    grid-template-columns: repeat(3, 1fr);
  }
}

/* ServiceCard styling for consistency */
.ServiceCard {
  background: #ffffff;
  border-radius: 1rem;
  padding: 1.5rem;
  box-shadow: 0 6px 18px rgba(0, 0, 0, 0.08);
  transition: transform 0.2s ease, box-shadow 0.2s ease;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
}

.ServiceCard:hover {
  transform: translateY(-4px);
  box-shadow: 0 12px 24px rgba(0, 0, 0, 0.12);
}

/* ServiceCard content */
.ServiceCard h2 {
  font-size: 1.25rem;
  font-weight: 600;
  color: #1e3a8a;
  margin-bottom: 0.5rem;
}

.ServiceCard p {
  font-size: 0.9rem;
  color: #4b5563;
  margin-bottom: 0.5rem;
}

.ServiceCard .price-duration {
  font-weight: 500;
  color: #2563eb;
  margin-bottom: 1rem;
}

/* Book button */
.ServiceCard button {
  background-color: #3b82f6;
  color: #ffffff;
  padding: 0.6rem 1.2rem;
  border-radius: 0.75rem;
  font-weight: 600;
  cursor: pointer;
  transition: background-color 0.3s ease, transform 0.2s ease;
}

.ServiceCard button:hover {
  background-color: #2563eb;
  transform: translateY(-2px);
}

/* Responsive spacing tweaks */
@media (max-width: 768px) {
  .ServiceCard {
    padding: 1rem;
  }
}
</style> -->






<style scoped>

.service-image-wrapper {
  margin-top: 1rem;
  display: flex;
  justify-content: center; /* centers the image under the card */
}

.service-image {
  width: 100%;        /* takes full width of wrapper */
  max-width: 250px;   /* reduce size of image */
  height: auto;       /* maintain aspect ratio */
  object-fit: cover;  /* crops nicely if needed */
  border-radius: 1rem;
  box-shadow: 0 6px 18px rgba(0, 0, 0, 0.08);
  transition: transform 0.2s ease, box-shadow 0.2s ease;
}

.service-image:hover {
  transform: translateY(-2px);
  box-shadow: 0 10px 20px rgba(0, 0, 0, 0.12);
}

/* Page container */
div[p-6] {
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

/* Grid layout for services */
.grid {
  display: grid;
  grid-template-columns: 1fr;
  gap: 1.5rem;
}

@media (min-width: 768px) {
  .grid {
    grid-template-columns: repeat(3, 1fr);
  }
}

/* Service image wrapper */
.service-image-wrapper {
  grid-column: span 1; /* full width on mobile */
  margin: 1rem 0;
  display: flex;
  justify-content: center;
}

@media (min-width: 768px) {
  .service-image-wrapper {
    grid-column: span 3; /* full width between cards */
  }
}

/* Service images */
.service-image {
  width: 100%;
  max-width: 400px;
  height: auto;
  object-fit: cover;
  border-radius: 1rem;
  box-shadow: 0 6px 18px rgba(0, 0, 0, 0.08);
  transition: transform 0.2s ease, box-shadow 0.2s ease;
}

.service-image:hover {
  transform: translateY(-3px);
  box-shadow: 0 12px 24px rgba(0, 0, 0, 0.12);
}

/* ServiceCard styling (if needed) */
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

/* Card content */
.ServiceCard h2 {
  font-size: 1.25rem;
  font-weight: 600;
  color: #1e3a8a;
  margin-bottom: 0.5rem;
}

.ServiceCard p {
  font-size: 0.9rem;
  color: #4b5563;
  margin-bottom: 0.5rem;
}

.ServiceCard .price-duration {
  font-weight: 500;
  color: #2563eb;
  margin-bottom: 1rem;
}

.ServiceCard button {
  background-color: #3b82f6;
  color: #ffffff;
  padding: 0.6rem 1.2rem;
  border-radius: 0.75rem;
  font-weight: 600;
  cursor: pointer;
  transition: background-color 0.3s ease, transform 0.2s ease;
}

.ServiceCard button:hover {
  background-color: #2563eb;
  transform: translateY(-2px);
}

/* Responsive tweaks */
@media (max-width: 768px) {
  .ServiceCard {
    padding: 1rem;
  }

  .service-image {
    max-width: 100%;
  }
}
</style>
