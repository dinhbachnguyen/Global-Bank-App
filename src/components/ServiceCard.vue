<template>
  <div class="bg-white shadow-lg rounded-xl p-4 flex flex-col justify-between hover:shadow-2xl transition-shadow duration-300">
    <!-- Service Info -->
    <div>
      <h2 class="text-xl font-semibold mb-2">{{ service.name }}</h2>
      <p class="text-gray-500 mb-2">{{ service.description }}</p>
      <div class="flex justify-between text-gray-700 font-medium">
        <span>Price: ${{ service.price }}, Duration: {{ service.duration }}</span>
      </div>
    </div>

    <!-- Book Button -->
    <button v-if="!hideButton"
      @click="$emit('book')"
      class="mt-4 bg-pink-500 text-white py-2 rounded hover:bg-pink-600 transition-colors duration-200"
    >
      Book This
    </button>
  </div>
</template>

<script setup lang="ts">

defineProps<{
  service: {
    id: number | string,
    name: string,
    price: number,
    duration?: string,
    description?: string
  }
  hideButton?: boolean;
}>()
</script>
