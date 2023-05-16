
#include "iti_int.h"
#include  <conio.h>
class Calc {
    private:
        iti_int * getNumbers(){
            iti_int * numbers = NULL;
            cout << "Enter  Numbers :" << endl;
            while(cin.get() != '\n'){
                int value;
                cin.unget();
                cin >> value;
                if(cin){
                  iti_int * N =   new iti_int(value);
                 if(numbers==NULL){
                     numbers= N;
                 }else{
                     iti_int * current  = numbers;
                     iti_int * before;
                     while(current!=NULL){
                        before = current;
                        current = current->next;
                     }
                     before->next = N;
                 }
                }
            }
            return numbers;
        }
    public:
        void showMenu(){
            cout << "Choose :" << endl;
            cout << "1- Add " << endl;
            cout << "2- Subtract" << endl;
            cout << "3- Exit" << endl;
        }
        int getUserOption(){
            cout << "Choice : ";
            int option;
            cin >> option;
            return option;
        }
        void processUserOption(int _option){
            switch(_option){
            case 1:
                {
                    getchar();
                    int sum  =0 ;
                    iti_int * values= getNumbers();
                    iti_int * position = values;
                    iti_int * garb;
                    while(position !=NULL){
                        garb  = position;
                        sum  += position->value;
                        position = position->next;
                        delete garb;
                    }

                    cout << "Sum = " << sum << endl;
                }break;
            case 2:
                {
                }break;
            case 3:
                {

                }break;
            }
        }
};
