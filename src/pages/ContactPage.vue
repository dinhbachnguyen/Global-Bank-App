<template>
  <div class="contact-page max-w-3xl mx-auto p-8">
    <h1 class="text-3xl font-bold mb-6">📞 Contact GlobalBank</h1>

    <form @submit.prevent="submitForm" class="space-y-4 bg-white shadow-md rounded-lg p-6">
      <div>
        <label class="block text-sm font-medium mb-1">Name</label>
        <input v-model="form.name" type="text" required
               class="w-full border rounded-lg p-2 focus:ring focus:ring-blue-300" />
      </div>

      <div>
        <label class="block text-sm font-medium mb-1">Email</label>
        <input v-model="form.email" type="email" required
               class="w-full border rounded-lg p-2 focus:ring focus:ring-blue-300" />
      </div>

      <div>
        <label class="block text-sm font-medium mb-1">Message</label>
        <textarea v-model="form.message" rows="4" required
                  class="w-full border rounded-lg p-2 focus:ring focus:ring-blue-300"></textarea>
      </div>

      <button type="submit"
              class="w-full bg-blue-600 text-white py-2 px-4 rounded-lg hover:bg-blue-700 transition">
        Send Message
      </button>
    </form>

    <p v-if="submitted" class="mt-4 text-green-600 font-semibold">
      ✅ Your message has been sent successfully!
    </p>
  </div>
</template>

<script setup lang="ts">
import { ref } from 'vue'



const form = ref({
  name: "",
  email: "",
  message: ""
});

const submitted = ref(false);

const submitForm = () => {
  console.log("Form submitted:", form.value);
  submitted.value = true;

  // reset form
  form.value = { name: "", email: "", message: "" };
};
</script>

<!-- <style scoped>
.contact-page {
  font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
}
</style> -->


<style scoped>
.contact-page {
  font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
  background: #f9fafb; /* soft page background */
  min-height: 100vh;
  padding-top: 4rem;
  padding-bottom: 4rem;
}

.contact-page h1 {
  text-align: center;
  color: #1e3a8a; /* deep blue */
}

form {
  background: #ffffff;
  border-radius: 1rem;
  padding: 2rem;
  box-shadow: 0 10px 25px rgba(0, 0, 0, 0.08);
  transition: transform 0.2s ease, box-shadow 0.2s ease;
}

form:hover {
  transform: translateY(-2px);
  box-shadow: 0 15px 30px rgba(0, 0, 0, 0.12);
}

label {
  font-weight: 600;
  color: #374151; /* dark gray */
}

input,
textarea {
  width: 100%;
  padding: 0.6rem 0.75rem;
  border: 1px solid #d1d5db; /* light gray */
  border-radius: 0.5rem;
  font-size: 1rem;
  transition: border-color 0.2s ease, box-shadow 0.2s ease;
}

input:focus,
textarea:focus {
  border-color: #3b82f6; /* blue accent */
  box-shadow: 0 0 0 3px rgba(59, 130, 246, 0.2);
  outline: none;
}

button {
  background: #3b82f6; /* blue */
  color: #ffffff;
  padding: 0.75rem;
  border-radius: 0.75rem;
  font-weight: 600;
  cursor: pointer;
  transition: background 0.2s ease, transform 0.2s ease;
}

button:hover {
  background: #2563eb; /* darker blue on hover */
  transform: translateY(-1px);
}

button:active {
  transform: translateY(0);
}

.submitted-message {
  text-align: center;
  font-weight: 600;
  color: #16a34a; /* green success */
  margin-top: 1rem;
  animation: fadeIn 0.5s ease-in-out;
}

/* subtle fade-in animation for success message */
@keyframes fadeIn {
  from {
    opacity: 0;
    transform: translateY(-5px);
  }
  to {
    opacity: 1;
    transform: translateY(0);
  }
}
</style>
