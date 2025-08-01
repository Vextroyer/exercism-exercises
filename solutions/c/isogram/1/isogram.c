#include "isogram.h"

const char hyphen = '-';
const char space = ' ';

int GuessSize(const char* string);

int GuessSize(const char* string){
    int size = 0;
    while(string[size] != '\0')++size;
    return size;
}

bool is_isogram(const char phrase[]){
    //In case is NULL
    if(phrase == NULL)return false;

    //Guess the size of phrase
    int size = GuessSize(phrase);
    
    bool isIsogram = true;//Flag

    //Double for approach, the current char must be different of every other char to be an isogram
    //else , it isnt an isogram
    for(int i=0;i < size;++i){  
        //We ignore spaces and hyphens
        if( phrase[i] == space || phrase[i] == hyphen )continue;
        
        for(int j = i + 1;j < size;++j){
            //If some character is repeated its not an isogram
            //Use tolower because of mixed case
            if( tolower(phrase[j]) == tolower(phrase[i]) ){
                isIsogram = false;
                break;
            }
        }
        if(!isIsogram)break;
    }
    return isIsogram;
}