function weight(){
    const weightLbs = document.getElementById('weight_lbs');
    const weightKg = document.getElementById('weight_kg');

    const inputValue = document.getElementById('Weight_slider').value;;
    weightLbs.textContent = inputValue + ' lbs';
    weightKg.textContent = (inputValue * 0.453592).toFixed(2) + ' kg';
}

document.getElementById('Weight_slider').addEventListener('input', weight);



function weight_lim(){

    let weightSlider = document.getElementById('Weight_slider');
    let weight_age_limit = document.getElementById('Age_picker').value // so i can get data from the age
   const young_age_group = { from: 1, to: 17 };
    const young_adult_group = { from: 18, to: 29 };
    const middle_adult = { from: 30, to: 49 };
    const adult_na_talaga = { from: 50, to: 59 };
    const elderly = { from: 60, to: 100 };

if (weight_age_limit >= young_age_group.from && weight_age_limit <= young_age_group.to) {
        console.log("first");
        weightSlider.min = 20; 
		weightSlider.value = 50;
    } else if (weight_age_limit >= young_adult_group.from && weight_age_limit <= young_adult_group.to) {
        console.log("sec");
        weightSlider.min = 80; 
		weightSlider.value = 120;
    } else if (weight_age_limit >= middle_adult.from && weight_age_limit <= middle_adult.to) {
        console.log("third");
        weightSlider.min = 100; 
		weightSlider.value = 150;
    } else if (weight_age_limit >= adult_na_talaga.from && weight_age_limit <= adult_na_talaga.to) {
        console.log("forth");
        weightSlider.min = 100; 
		weightSlider.value = 140;
    } else if (weight_age_limit >= elderly.from && weight_age_limit <= elderly.to) {
        console.log("5th");
        weightSlider.min = 80; 
		weightSlider.value = 130;
    } else {
        console.log("not in the list");
        console.log("guy is prob dead");
         console.log("go default params")
         weightSlider.min = 1; 
		weightSlider.value = 1;

    }
    let lbs = parseInt(weightSlider.value);
	let kg = (lbs * 0.453592).toFixed(2);
	document.getElementById('weight_lbs').textContent = `${lbs} lbs`;
	document.getElementById('weight_kg').textContent = `${kg} kg`;
}
document.getElementById('Age_picker').addEventListener('input', weight_lim);




 
    
    
