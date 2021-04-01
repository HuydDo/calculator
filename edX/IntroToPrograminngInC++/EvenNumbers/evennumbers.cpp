#include <iostream>
using namespace std;

int main(){
  int num;
  int count;
  cout<<"Please enter a positive integer: ";
  cin >> num;
  for(count = 1; count <= num; count++){
    cout << count * 2 << endl;
  }
  return 0;
}
