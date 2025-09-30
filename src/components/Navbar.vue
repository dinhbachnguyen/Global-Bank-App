<template>
  <nav class="bg-white shadow-md py-4 px-6 flex justify-between items-center">
    <!-- Logo -->
    <RouterLink to="/" class="text-2xl font-bold text-blue-600">
      Global Bank
    </RouterLink>

    <!-- Links -->
    <ul class="flex flex-row space-x-6">
      <li>
        <RouterLink to="/" class="hover:text-blue-600 transition-colors">Home</RouterLink>
      </li>
      <li>
        <RouterLink to="/services" class="hover:text-blue-600 transition-colors">Services</RouterLink>
      </li>
      <!-- <li>
        <RouterLink to="/appointments" class="hover:text-blue-600 transition-colors">Appointments</RouterLink>
      </li> -->
      <li>
        <RouterLink to="/contact" class="hover:text-blue-600 transition-colors">Contact</RouterLink>
      </li>
    </ul>
  </nav>
</template>

<script setup lang="ts">
// Static navbar, no logic needed
</script>


<style scoped>
nav {
  font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
  background-color: #ffffff;
  box-shadow: 0 4px 12px rgba(0, 0, 0, 0.08);
  padding: 1rem 1.5rem;
  display: flex;
  justify-content: space-between;
  align-items: center;
  position: sticky;
  top: 0;
  z-index: 50;
  transition: background-color 0.3s ease, box-shadow 0.3s ease;
}

nav:hover {
  box-shadow: 0 6px 18px rgba(0, 0, 0, 0.1);
}

nav a {
  font-weight: 500;
  color: #1e3a8a; /* deep blue */
  text-decoration: none;
  transition: color 0.2s ease, transform 0.2s ease;
}

nav a:hover {
  color: #3b82f6; /* lighter blue hover */
  transform: translateY(-2px);
}

nav .logo {
  font-size: 1.75rem;
  font-weight: 700;
}

ul {
  display: flex;
  flex-direction: row;
  gap: 1.5rem;
  list-style: none;
  margin: 0;
  padding: 0;
}

ul li {
  position: relative;
}

ul li::after {
  content: "";
  position: absolute;
  width: 0%;
  height: 2px;
  bottom: -4px;
  left: 0;
  background-color: #3b82f6;
  transition: width 0.3s ease;
}

ul li:hover::after {
  width: 100%;
}

/* Responsive tweaks */
@media (max-width: 768px) {
  nav {
    flex-direction: column;
    align-items: flex-start;
    padding: 1rem;
  }

  ul {
    flex-direction: column;
    gap: 0.75rem;
    width: 100%;
    margin-top: 0.5rem;
  }

  ul li::after {
    bottom: 0;
  }
}
</style>
