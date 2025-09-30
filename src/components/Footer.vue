<template>
  <footer class="bg-white shadow-inner mt-12">
    <div class="max-w-6xl mx-auto py-8 px-6 md:flex md:justify-between md:items-center">

      <!-- Bank Info -->
      <div class="mb-6 md:mb-0">
        <h2 class="text-xl font-bold text-blue-600 mb-2">Global Bank</h2>
        <p class="text-gray-600">100 Finance Avenue, Capital City</p>
        <p class="text-gray-600">Phone: (800) 123-4567</p>
        <p class="text-gray-600">Email: support@globaltrustbank.com</p>
      </div>

      <!-- Social Media Icons -->
      <div class="flex space-x-4">
        <!-- LinkedIn -->
        <!-- <a href="#" class="text-gray-600 hover:text-blue-600 transition-colors">
          <svg xmlns="http://www.w3.org/2000/svg" class="h-6 w-6" fill="currentColor" viewBox="0 0 24 24">
            <path d="M19 0h-14c-2.77 0-5 2.23-5 5v14c0 2.77 2.23 5 5 5h14c2.77 0 5-2.23 5-5v-14c0-2.77-2.23-5-5-5zm-11 19h-3v-9h3v9zm-1.5-10.29c-.96 0-1.75-.79-1.75-1.75s.79-1.75 1.75-1.75 1.75.79 1.75 1.75-.79 1.75-1.75 1.75zm13.5 10.29h-3v-4.8c0-1.15-.02-2.62-1.59-2.62-1.59 0-1.84 1.24-1.84 2.54v4.88h-3v-9h2.88v1.23h.04c.4-.75 1.38-1.54 2.85-1.54 3.05 0 3.62 2.01 3.62 4.62v4.69z"/>
          </svg>
        </a> -->

        <!-- Twitter -->
        <!-- <a href="#" class="text-gray-600 hover:text-blue-600 transition-colors">
          <svg xmlns="http://www.w3.org/2000/svg" class="h-6 w-6" fill="currentColor" viewBox="0 0 24 24">
            <path d="M22.46 6c-.77.35-1.6.58-2.46.69a4.3 4.3 0 0 0 1.88-2.37c-.84.5-1.77.87-2.76 1.07a4.28 4.28 0 0 0-7.3 3.9c-3.56-.18-6.72-1.88-8.84-4.47-.37.64-.58 1.38-.58 2.18 0 1.5.76 2.83 1.92 3.61-.7-.02-1.37-.21-1.95-.53v.05c0 2.1 1.49 3.84 3.46 4.23-.36.1-.73.15-1.12.15-.27 0-.53-.03-.78-.08.53 1.65 2.07 2.85 3.9 2.88a8.61 8.61 0 0 1-5.33 1.84c-.35 0-.7-.02-1.04-.06A12.13 12.13 0 0 0 6.29 20c7.55 0 11.68-6.25 11.68-11.67 0-.18-.01-.36-.02-.54.8-.57 1.5-1.27 2.06-2.07z"/>
          </svg>
        </a> -->

        <!-- Facebook -->
        <!-- <a href="#" class="text-gray-600 hover:text-blue-600 transition-colors">
          <svg xmlns="http://www.w3.org/2000/svg" class="h-6 w-6" fill="currentColor" viewBox="0 0 24 24">
            <path d="M22 12c0-5.52-4.48-10-10-10S2 6.48 2 12c0 5 3.66 9.14 8.44 9.88v-6.99H7.9v-2.89h2.54V9.84c0-2.51 1.49-3.89 3.77-3.89 1.09 0 2.24.2 2.24.2v2.46h-1.26c-1.24 0-1.63.77-1.63 1.56v1.88h2.77l-.44 2.89h-2.33v6.99C18.34 21.14 22 17 22 12z"/>
          </svg>
        </a> -->
      </div>
    </div>

    <!-- Copyright -->
    <div class="text-center text-gray-400 text-sm py-4 border-t border-gray-200">
      &copy; 2025 GlobalTrust Bank. All rights reserved.
    </div>
  </footer>
</template>

<script setup lang="ts">
// No logic needed for static footer
</script>

<style scoped>
footer {
  font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
  background-color: #ffffff;
  box-shadow: inset 0 2px 4px rgba(0, 0, 0, 0.05);
  color: #374151; /* dark gray text */
  padding-top: 2rem;
  padding-bottom: 1rem;
}

/* Container */
footer > div:first-child {
  max-width: 72rem; /* 6xl */
  margin: 0 auto;
  padding: 0 1.5rem;
  display: flex;
  flex-direction: column;
  gap: 1.5rem;
}

@media (min-width: 768px) {
  footer > div:first-child {
    flex-direction: row;
    justify-content: space-between;
    align-items: center;
  }
}

/* Bank Info */
footer h2 {
  font-size: 1.25rem;
  font-weight: 700;
  color: #1e3a8a; /* deep blue */
  margin-bottom: 0.5rem;
}

footer p {
  font-size: 0.875rem;
  color: #6b7280; /* gray */
  margin: 0.125rem 0;
}

/* Social Media Icons */
footer .social-icons {
  display: flex;
  gap: 1rem;
}

footer .social-icons a {
  display: inline-flex;
  align-items: center;
  justify-content: center;
  background: #f3f4f6;
  color: #1e3a8a;
  width: 2.5rem;
  height: 2.5rem;
  border-radius: 9999px;
  transition: background 0.3s ease, transform 0.2s ease;
  text-decoration: none;
}

footer .social-icons a:hover {
  background: #3b82f6;
  color: #ffffff;
  transform: translateY(-2px);
}

/* Copyright */
footer .copyright {
  text-align: center;
  font-size: 0.75rem;
  color: #9ca3af; /* light gray */
  padding-top: 1rem;
  border-top: 1px solid #e5e7eb;
}
</style>
