# Global-Bank-App
GlobalBank – A modern, responsive banking services web application built with Vue 3 and Tailwind CSS, allowing users to browse banking services, book appointments for loans, investments, or account assistance, and view confirmation details. Designed for simplicity, usability, and a professional look suitable for a real-world banking portal.

GlobalBank

A modern banking services web application built with Vue 3, providing customers the ability to browse services, book appointments, and view confirmations.

Table of Contents

Features

Technologies

Project Structure

Installation

Usage

Screenshots

Contributing

License

Features

Browse various banking services (loans, investments, account opening, mortgage consultation).

Book appointments for selected services.

View appointment confirmation details.

Responsive design for desktop and mobile.

User-friendly interface with Vue components and reusable ServiceCards.

Technologies

Frontend: Vue 3, TypeScript, Vue Router, Pinia (state management)

Styling: Tailwind CSS

Backend (example): Node.js / Express (for API, optional)

Package Manager: npm

Project Structure
src/
 ├─ assets/          # Images and static assets
 ├─ components/      # Reusable Vue components (ServiceCard, Navbar, Footer)
 ├─ pages/           # Main pages (Home, Services, Contact, Booking, Confirmation)
 ├─ store/           # Pinia store for booking state
 ├─ App.vue          # Root component
 └─ main.ts          # Vue app entry point

Installation

Clone the repository:

git clone https://github.com/your-username/global-bank-app.git
cd global-bank-app


Install dependencies:

npm install


Run the development server:

npm run dev


Open http://localhost:5173 in your browser (Vite default).

Usage

Navigate to Home to see an overview of banking services.

Click on a service card to book an appointment.

Fill out the booking form with date, time, and personal information.

View the confirmation page after submission.

Screenshots

(Add screenshots of your app here for Home page, Booking page, and Confirmation page)

Contributing

Fork the repository.

Create a new branch: git checkout -b feature-name

Make your changes and commit: git commit -m "Add new feature"

Push to your branch: git push origin feature-name

Create a Pull Request on GitHub.

License

This project is licensed under the MIT License – see the LICENSE file for details.
