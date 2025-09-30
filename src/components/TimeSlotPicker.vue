<template>
  <div class="grid grid-cols-3 gap-3">
    <button
      v-for="slot in availableTimes"
      :key="slot"
      @click="$emit('update:time', slot)"
      :class="[
        'py-2 rounded shadow transition-colors duration-200',
        slot === modelValue ? 'bg-pink-500 text-white' : 'bg-white text-gray-700 hover:bg-pink-100'
      ]"
    >
      {{ slot }}
    </button>
  </div>
</template>

<script setup lang="ts">
defineProps<{
  availableTimes: string[]
  modelValue: string
}>()

defineEmits<{
  (e: 'update:time', value: string): void
}>()
</script>
