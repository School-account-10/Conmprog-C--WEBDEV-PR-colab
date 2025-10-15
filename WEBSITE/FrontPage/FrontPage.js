function Pageloader(page){ // god help my ass

const loaderdiv = document.getElementById("Loader")

fetch(page)
    .then(response => {
      if (!response.ok) {
        throw new Error(`Fetch failed: ${response.status}`);
      }
      return response.text();
    })
    .then(data => {
      loaderdiv.innerHTML = data;
      console.log("pressed"); 
    })
    .catch(error => {
      console.error("Error loading page:", error);
    });
} 
function MainPageBack(){
  console.log("hello")
  window.location.replace(~FrontPage/EasyMed.html);
}