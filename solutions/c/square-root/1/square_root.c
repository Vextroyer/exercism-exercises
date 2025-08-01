#include "square_root.h"

int square_root(int number){
    int rootUpperBound = 0;
    while(rootUpperBound * rootUpperBound < number){
        ++rootUpperBound;
    }
    if(rootUpperBound * rootUpperBound == number)return rootUpperBound;
    else return 0;
    //Some code to handle the operaions
}
