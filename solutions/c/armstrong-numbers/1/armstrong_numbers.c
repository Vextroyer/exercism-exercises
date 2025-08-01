#include "armstrong_numbers.h"

//Suppose all numbers are non-negative

//Return the amount of digits
int AmountOfDigits(int num){
    if(num == 0)return 1;//Corner case
    int cntDigits = 0;
    while(num > 0){
        //Integer Division discards decimal part
        num /= 10;
        ++cntDigits;
    }
    return cntDigits;
}

//Compute a^b, recursively
int Raise(int num,int power){
    if(power == 0)return 1;
    return num * Raise(num,power - 1);
}

//Computes the sum of the digits of number raised to the given power
int SumOfRaisedDigits(int num,int power){
    int sumOfRaisedDigits = 0;
    do{
        int lastDigit = num % 10;//Retrieve last digit
        num /= 10;
        sumOfRaisedDigits += Raise(lastDigit,power);
    }while(num > 0);
    return sumOfRaisedDigits;
}

bool is_armstrong_number(int num){
    int cntDigits = AmountOfDigits(num);
    int sumOfRaisedDigits = SumOfRaisedDigits(num,cntDigits);
    return num == sumOfRaisedDigits;
}
