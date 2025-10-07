function Pageloader(event, pagePath) {
  event.preventDefault(); // Prevent page reload

  const mainContainer = document.querySelector("main"); // Finds <main>

  if (!mainContainer) {
    console.error("Main container not found!");
    return;
  }

  fetch(pagePath)
    .then(response => response.text())
    .then(html => {
      mainContainer.innerHTML = html; // Replaces <main> content
      window.history.pushState({}, "", pagePath);
    })
    .catch(error => {
      console.error("Error loading page:", error);
      mainContainer.innerHTML = "<p>Failed to load page.</p>";
    });
}