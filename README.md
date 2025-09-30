
# GlobalBank

A modern **banking services web application** built with **Vue 3**, providing customers the ability to browse services, book appointments, and view confirmations.

---

## Table of Contents

- [Features](#features)  
- [Technologies](#technologies)  
- [Project Structure](#project-structure)  
- [Installation](#installation)  
- [Usage](#usage)  


---

## Features

- Browse various banking services (loans, investments, account opening, mortgage consultation).  
- Book appointments for selected services.  
- View appointment confirmation details.  
- Responsive design for desktop and mobile.  
- User-friendly interface with Vue components and reusable ServiceCards.  

---

## Technologies

- **Frontend:** Vue 3, TypeScript, Vue Router, Pinia (state management)  
- **Styling:** Tailwind CSS  
- **Backend:** C# .NET (API and business logic)  
- **Package Manager / Build Tool:** npm

---

## Project Structure

```

src/
├─ assets/          # Images and static assets
├─ components/      # Reusable Vue components (ServiceCard, Navbar, Footer)
├─ pages/           # Main pages (Home, Services, Contact, Booking, Confirmation)
├─ stores/           # Pinia store for booking state
├─ App.vue          # Root component
└─ main.ts          # Vue app entry point

````

---

## Installation

1. **Clone the repository:**

```bash
git clone https://github.com/your-username/global-bank-app.git
cd global-bank-app
````

2. **Install dependencies:**

```bash
npm install
```

3. **Run the development server:**

```bash
npm run dev
```

4. Open `http://localhost:5173` in your browser (Vite default).

---

## Backend

The backend of this project is built with **C# .NET** and is located in the `bank.api` folder.  
It handles the API, business logic, and data management for the banking services and appointments.

### Running the Backend

1. Navigate to the backend folder:

```bash
cd bank.api
````

2. Restore dependencies, build, and run the project using the .NET CLI:

```bash
dotnet build
dotnet watch run
```

3. By default, the backend API should run on `http://localhost:5000` (or the port configured in the project).

You can now connect the frontend application to this backend API to fetch services and submit bookings.

---

## Usage

* Navigate to **Home** to see an overview of banking services.
* Click on a service card to **book an appointment**.
* Fill out the **booking form** with date, time, and personal information.
* View the **confirmation page** after submission.

---
