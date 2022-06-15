$(document).ready(function(){
    initializeDays();
    initializeMonths();
    initializeYears();
    
    $('#birthdate-month').change(handleChangeMonth);
    $('#birthdate-day').change(calculateAge);
    $('#birthdate-month').change(calculateAge);
    $('#birthdate-year').change(calculateAge);
    
    $('#register').bind('reset', handleResetForm);
    $('#register').submit(handleSubmitForm);
});

function initializeDays(days = 31){
    $('#birthdate-day').empty().append($('<option />').val(null).text('Day'));
    for(var i=1; i <= days; i++){
        $('#birthdate-day').append($('<option />').val(i).text(i))
    }
}

function initializeMonths(){
    var months = ['Jan','Feb','Mar','Apr','May','Jun','Jul','Aug','Sept','Oct','Nov','Dec'];
    for(var i=1; i <= 12; i++){
        $('#birthdate-month').append($('<option />').val(i-1).text(months[i-1]))
    }
}

function initializeYears(){
    for(var i=1950; i <= 2021; i++){
         $('#birthdate-year').append($('<option />').val(i).text(i))
    }
}

function handleChangeMonth(){
    if([0, 2, 4, 6, 7, 9, 11].includes(parseInt($(this).val()))){
        initializeDays(31);
    }else if([3, 5, 8, 10].includes(parseInt($(this).val()))){
        initializeDays(30);
    } else {
        initializeDays(28);
    }
}

function calculateAge(){
    if($('#birthdate-day').val() && $('#birthdate-month').val() && $('#birthdate-year').val()){
        var currentDate = Date.now();
        var day = $('#birthdate-day').val() < 10 ? '0' + $('#birthdate-day').val() : $('#birthdate-day').val();
        var month = $('#birthdate-month').val() < 10 ? '0' + $('#birthdate-month').val() : $('#birthdate-month').val();
        var year = $('#birthdate-year').val();
        var birthdate = Date.parse(`${month}/${day}/${year}`);
        var ageDateTime = new Date(currentDate - birthdate);
        var age = ageDateTime.getUTCFullYear();
        $('#age').val(Math.abs(age - 1970));
        $('#age').addClass('valid');
    }
}

function handleResetForm(){
    $('#age').removeClass('valid');
}
