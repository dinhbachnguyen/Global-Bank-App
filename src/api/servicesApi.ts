// src/api/api.ts
const API_BASE = 'https://localhost:5001/api'

// --- Fetch services ---
export async function getServices() {
  const res = await fetch(`${API_BASE}/services`)
  if (!res.ok) throw new Error('Failed to fetch services')
  return res.json()
}

// --- Check availability ---
export async function getAvailability(serviceId: number, date: string) {
  const res = await fetch(`${API_BASE}/availability?serviceId=${serviceId}&date=${date}`)
  if (!res.ok) throw new Error('Failed to fetch availability')
  return res.json()
}

// --- Create booking ---
export async function createBooking(payload: any) {
  const res = await fetch(`${API_BASE}/bookings`, {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(payload),
  })

  if (res.status === 201) {
    return res.json()
  } else {
    const err = await res.json()
    throw err
  }
}
