function weight() {
    const weightLbs = document.getElementById('weight_lbs');
    const weightKg = document.getElementById('weight_kg');
    const inputValue = document.getElementById('Weight_slider').value;
    weightLbs.textContent = `${inputValue} lbs`;
    weightKg.textContent = `${(inputValue * 0.453592).toFixed(2)} kg`;
}

function weight_lim() {
    const weightSlider = document.getElementById('Weight_slider');
    const weight_age_limit = parseInt(document.getElementById('Age_picker').value) || 0;
    const young_age_group = { from: 1, to: 17 }; 
    const young_adult_group = { from: 18, to: 29 }; 
    const middle_adult = { from: 30, to: 49 }; 
    const adult_na_talaga = { from: 50, to: 59 };
    const elderly = { from: 60, to: 100 }; 
    
    if (weight_age_limit >= young_age_group.from && weight_age_limit <= young_age_group.to) {
        console.log("Child or Teen");
        weightSlider.min = 20;
        weightSlider.value = 50;
    } else if (weight_age_limit >= young_adult_group.from && weight_age_limit <= young_adult_group.to) {
        console.log("Young Adult");
        weightSlider.min = 80;
        weightSlider.value = 120;
    } else if (weight_age_limit >= middle_adult.from && weight_age_limit <= middle_adult.to) {
        console.log("Middle Adult");
        weightSlider.min = 100;
        weightSlider.value = 150;
    } else if (weight_age_limit >= adult_na_talaga.from && weight_age_limit <= adult_na_talaga.to) {
        console.log("Older Adult");
        weightSlider.min = 100;
        weightSlider.value = 140;
    } else if (weight_age_limit >= elderly.from && weight_age_limit <= elderly.to) {
        console.log("Elderly");
        weightSlider.min = 80;
        weightSlider.value = 130;
    } else {
        console.log("probably dead asf so will default");
        weightSlider.min = 1;
        weightSlider.value = 1;
    }

    weight(); 
}


function validateForm(e) {
    e.preventDefault();
    let isValid = true;
    const genderSelect = document.getElementById('Gender_Options');
    const ageInput = document.getElementById('Age_picker');
    const genderError = document.getElementById('genderError');
    const ageError = document.getElementById('ageError');

   
    if (!genderSelect.value) {
        genderError.textContent = 'Please select a gender';
        isValid = false;
    } else {
        genderError.textContent = '';
    }

    
    if (!ageInput.value || ageInput.value < 0 || ageInput.value > 120) {
        ageError.textContent = 'Please enter a valid age (0-120)';
        isValid = false;
    } else {
        ageError.textContent = '';
    }

    if (isValid) {

        
        alert('Form submitted successfully!');
        alert('Proceding to next form ');
        
    }
}
weight();


function gender_ops_data(){
    const genderSelect = document.getElementById('Gender_Options');
    const ageInput = document.getElementById('Age_picker');
}


document.getElementById('Weight_slider').addEventListener('input', weight);
document.getElementById('Age_picker').addEventListener('input', weight_lim);
document.getElementById('symptomForm').addEventListener('submit', validateForm);
document.getElementById("Gender_Options").addEventListener('input',gender_ops_data );

