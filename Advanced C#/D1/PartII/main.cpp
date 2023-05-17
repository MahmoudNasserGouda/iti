#include <iostream>

using namespace std;

int * GetNumbers(){
    cout << "Count Of Numbers : ";
    int Count;
    cin  >> Count;
    int * arr = new int  [Count]; // 400 Bytes
    for(int i =0; i< Count; i++){
        cin  >> arr[i];
    }
    return arr;
}

int main()
{
    int * arr = GetNumbers();

    return 0;
}
