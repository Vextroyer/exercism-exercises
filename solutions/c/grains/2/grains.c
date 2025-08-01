#include "grains.h"

uint64_t square(uint64_t index){
    if(index < 1 || index > 64)return 0;
    //Careful on the way of doing the shift to avoid overflows or underflows
    uint64_t grains = 1;
    grains <<= index - 1;
    return grains;
}
uint64_t total(void){
    //What if we use an underflow
    //Think of it like this, when all bits are turned we have 2^63 + 2^62 + ..., which is what we want
    //If we add 1 to that it will become 0 because it is the remainder when divided by 2^64
    //So if we substract 1 from 0 we get the value we want.
    //I recomend reading this article for further comprehension.
    //https://www.learncpp.com/cpp-tutorial/unsigned-integers-and-why-to-avoid-them/
    uint64_t value = 0;
    --value;
    return value;
}