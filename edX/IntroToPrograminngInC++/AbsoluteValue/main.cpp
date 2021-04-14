#include <iostream>
using namespace std;

int main(){
  int userInput, absValue;
/*
  cout<<"Please enter an integer:"<<endl;
  cin>>userInput;
  absValue = userInput;
  if(userInput < 0)
    absValue = userInput * (-1);
  cout<<"|"<< userInput <<"| = "<< absValue <<endl;
*/
  
  cout<<"Please enter a positive integer:"<<endl;
  cin>>userInput;
  if (userInput % 2 == 0){
    cout<<userInput<<" is even"<<endl;
  }
  else {
    cout<<userInput<<" is odd"<<endl;
  }
  return 0;
}