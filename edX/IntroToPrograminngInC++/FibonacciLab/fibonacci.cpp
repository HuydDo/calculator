#include <iostream>
using namespace std;

int main(){
  int count, num, num1, num2;
  cout <<"Please enter a positive integer greater than 1:";
  cin >> num;
  int sum = 0;
  num1 = 0;
  num2 =0;
  for(count = 1; count <= num ; count++){
    
    if (count == 1 || count ==2)
    {
     num1 = 1;
     num2 = 1;
     sum = num1 + num2;
     cout << 1 << endl;
    }
    else 
    {
    cout << "num1: "<< num1 << " num2: "<< num2<<endl;
     sum = num1 + num2;
     cout << sum << endl;
     num1 = num2;
     num2 = sum;
    }
       
  }
  return 0;
}