// === Toggle dark/light theme ===
document.addEventListener("DOMContentLoaded", () => {
    const toggleBtn = document.getElementById("toggle-theme");
    toggleBtn.addEventListener("click", () => {
        const currentTheme = document.documentElement.getAttribute("data-theme");
        if (currentTheme === "dark") {
            document.documentElement.removeAttribute("data-theme");
        } else {
            document.documentElement.setAttribute("data-theme", "dark");
        }
    });
});

// === Form validation with basic checks ===
const form = document.getElementById("contact-form");

form.addEventListener("submit", (e) => {
    e.preventDefault();

    const name = form.name.value.trim();
    const email = form.email.value.trim();
    const message = form.message.value.trim();
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

    // Check if all fields are filled
    if (!name || !email || !message) {
        alert("Please fill out all fields.");
        return;
    }

    // Check for valid email format
    if (!emailRegex.test(email)) {
        alert("Please enter a valid email address.");
        return;
    }

    // Simulated success
    alert("✅ Thank you! Your message has been sent.");
    form.reset();
});

// === Show scroll-to-top button when scrolled down ===
const topBtn = document.getElementById("back-to-top");

window.addEventListener("scroll", () => {
    topBtn.style.display = window.scrollY > 300 ? "block" : "none";
});

// === Smooth scroll to top ===
topBtn.addEventListener("click", () => {
    window.scrollTo({ top: 0, behavior: "smooth" });
});
=======
﻿// === Toggle dark/light theme ===
document.addEventListener("DOMContentLoaded", () => {
    const toggleBtn = document.getElementById("toggle-theme");
    toggleBtn.addEventListener("click", () => {
        const currentTheme = document.documentElement.getAttribute("data-theme");
        if (currentTheme === "dark") {
            document.documentElement.removeAttribute("data-theme");
        } else {
            document.documentElement.setAttribute("data-theme", "dark");
        }
    });
});

// === Form validation with basic checks ===
const form = document.getElementById("contact-form");

form.addEventListener("submit", (e) => {
    e.preventDefault();

    const name = form.name.value.trim();
    const email = form.email.value.trim();
    const message = form.message.value.trim();
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

    // Check if all fields are filled
    if (!name || !email || !message) {
        alert("Please fill out all fields.");
        return;
    }

    // Check for valid email format
    if (!emailRegex.test(email)) {
        alert("Please enter a valid email address.");
        return;
    }

    // Simulated success
    alert("✅ Thank you! Your message has been sent.");
    form.reset();
});

// === Show scroll-to-top button when scrolled down ===
const topBtn = document.getElementById("back-to-top");

window.addEventListener("scroll", () => {
    topBtn.style.display = window.scrollY > 300 ? "block" : "none";
});

// === Smooth scroll to top ===
topBtn.addEventListener("click", () => {
    window.scrollTo({ top: 0, behavior: "smooth" });
});

