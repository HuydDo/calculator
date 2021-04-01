#include <iostream>
using namespace std;

int main(int argc, char** argv){

  int year;
  
  cout << "You have entered " << argc << " arguments:" << "\n"; 
  
  for (int i = 0; i < argc; ++i) {
      cout << argv[i] << "\n"; 
      if (i == 1)
        year = stoi(argv[i]);
  }

  if(((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
    cout<<year<< " was a leap year";
  else 
    cout<<year<< " was not a leap year";

  return 0;


}