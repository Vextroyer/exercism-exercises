#include "raindrops.h"
#include<string>
namespace raindrops {

// TODO: add your solution here
std::string convert(int number){
    std::string ans = "";
    bool notDivisibleBy357 = true;
    if (number % 3 == 0){
        ans += "Pling";
        notDivisibleBy357 = false;
    }
    if (number % 5 == 0){
        ans += "Plang";
        notDivisibleBy357 = false;
    }
    if (number % 7 == 0){
        ans += "Plong";
        notDivisibleBy357 = false;
    }
    if(notDivisibleBy357) ans += std::to_string(number);
    return ans;
}
}  // namespace raindrops
