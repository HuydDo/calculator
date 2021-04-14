#include <iostream>
using namespace std;

int main(){
  int oddCount = 0;
  int evenCount = 0;
  int num1, num2, num3, num4;
  cout << "Please enter four numbers seperated by space:\n";
	cin >> num1>>num2>>num3>>num4; 
  if(num1 % 2 == 0)
    evenCount++;
  else if (num1 % 2 != 0)
    oddCount++;
   if(num2 % 2 == 0)
    evenCount++;
  else if (num2 % 2 != 0)
    oddCount++;
     if(num3 % 2 == 0)
    evenCount++;
  else if (num3 % 2 != 0)
    oddCount++;
     if(num4 % 2 == 0)
    evenCount++;
  else if (num4 % 2 != 0)
    oddCount++;
  
  cout<< "oddCount: " << oddCount << endl;
  cout<< "evenCount: " << evenCount << endl;
 
  if (evenCount > oddCount){
    cout <<"more evens";
  }
  else if (evenCount < oddCount){
    cout <<"more odds";
  } 
  else
    cout<<"same number of evens and odds"; 
  return 0;
}
