#include <iostream>
using namespace std;

class MyClass {
private:
    int* nums;
    int size;
public:
    MyClass(int s) {
        size = s;
        nums = new int[size]; // allocate memory on the heap
        for (int i = 0; i < size; i++) {
            nums[i] = i; // initialize the array
        }
    }
    ~MyClass() {
        delete[] nums; // free the allocated memory
    }
    void print() {
        for (int i = 0; i < size; i++) {
            cout << nums[i] << " ";
        }
        cout << endl;
    }
};

int main() {
    MyClass* obj = new MyClass(10); // allocate MyClass object on the heap
    obj->print(); // call the print method
    delete obj; // free the allocated MyClass object
    return 0;
}
