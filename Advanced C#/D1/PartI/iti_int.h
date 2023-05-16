

class iti_int {
    public:
        int value;
        iti_int * next;
        iti_int(int _value){
            value = _value;
            next = NULL;
        }
};
