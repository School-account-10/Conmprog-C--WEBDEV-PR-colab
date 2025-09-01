function weight(){
    const weightLbs = document.getElementById('weight_lbs');
    const weightKg = document.getElementById('weight_kg');

    const inputValue = document.getElementById('Weight_slider').value;;
    weightLbs.textContent = inputValue + ' lbs';
    weightKg.textContent = (inputValue * 0.453592).toFixed(2) + ' kg';
}

document.getElementById('Weight_slider').addEventListener('input', weight);

updateWeight.call(document.getElementById('Weight_slider'));

function weight_lim(){
    const weight_age_limit = document.getElementById('Age_picker').value // so i can get data from the age
    
    
}