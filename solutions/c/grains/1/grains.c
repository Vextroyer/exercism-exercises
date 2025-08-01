#include "grains.h"

uint64_t square(uint64_t index){
    if(index < 1 || index > 64)return 0;
    //Careful on the way of doing the shift to avoid overflows or underflows
    uint64_t grains = 1;
    grains <<= index - 1;
    return grains;
}
uint64_t total(void){
    uint64_t value = 0;
    //Turn on bits one at a time
    for(uint64_t mask = 0;mask < 64;++mask){
        value |= (1<<mask);
    }
    return value;
}