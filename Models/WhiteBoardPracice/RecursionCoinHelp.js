function change(amount, array)
    if (amount === 0) {
        return array
    }
    //ex. 4.99 * 100 = 499 -> 499 % 100 = 99
    
    amount = amount * 100;
    amount = amount % 100;
    
    if(amount % 25 > 0){
        array[0] = amount/25;
        amount = amount - array[0]*25
        return change(amount, array);
    }
    
    else if(amount % 10 > 0){
        array[1] = amount/10;
        amount = amount - array[1]*10
        return change(amount, array);
    }
    
    else if(amount % 5 > 0){
        array[2] = amount/5;
        amount = amount - array[2]*5
        return change(amount, array);
    }

    else{
        array[3] = amount;
        amount = amount - array[4]*1
        change(amount, array);

        return array
    }


