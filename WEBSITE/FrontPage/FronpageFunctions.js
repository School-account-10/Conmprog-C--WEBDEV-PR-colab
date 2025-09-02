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
    var young_age_group = {
        from: 1,
        to: 17
    };

    var young_adult_group = {
        from: 18,
        to: 29
    };

    var middle_adult = {
        from: 30,
        to: 49
    };

    var adult_na_talaga = { // early stage ng sakt sa likod at atritis
        from: 50, 
        to: 59
    };

    var elderly = {
        from: 56,
        to: 100
    };


 }
 
    
    
