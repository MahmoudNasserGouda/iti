#include <iostream>
using namespace std;

#include "Calc.h"

int main()
{

    Calc c  = Calc();
    c.showMenu();
    int option =  c.getUserOption();
    c.processUserOption(option);

    /*
        12 Bytes
        Leak
    */

    int x = 10 ;

    return 0;
}
